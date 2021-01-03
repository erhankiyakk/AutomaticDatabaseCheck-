using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FlapErhanUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlCommand cmd;
        SqlDependency dependency;
        SqlDataAdapter da;
        SqlConnection denemecon = new SqlConnection("Data Source=.;Initial Catalog=master; Integrated Security=True");
        string connectionString;
        bool kapatilsinMi = false;
        string ServerAdi = "", DatabaseAdi = "", DatabaseKullaniciAdi = "", DatabaseSifre = "";
        private void Dependency()
        {
            dependency = new SqlDependency(cmd);
            SqlDependency.Start(baglanti.ConnectionString);
            dependency.OnChange += Dependency_OnChange;
        }
        private void FaturaBilgileriGetir()
        {
           cmd = new SqlCommand("Select FaturaID,SubeID,FaturaTuru,FaturaTipi,FaturaNo,FaturaTarihi,FaturaSaati," +
                "VadeGunu, VadeTarihi, AK, GrupKodu1ID, Muhasebelestirilmis, FaturasiKesilmis," +
                "FaturasiIptal,CariHareketineIslensin, StokHareketineIslensin, IskontoTutari," +
                "IskontoOrani, Dovizli, DovizVarsayilanID, DovizVarsayilanKur, Toplam, AraToplam," +
                "SatirIskontosu, HesaplananKdv, AltIskonto, TevkifatTutari, ToplamIskonto, OdenecekKdv," +
                "GenelToplam, PlasiyerID, CariID, CariIsim, CariAdres, CariVergiDairesi, CariVergiNumarasi," +
                "CariTelefon, CariCepTelefonu, CariIlce, CariIl, CariUlke, TeslimCariID, TeslimCariIsim," +
                "TeslimCariAdres, TeslimCariIlce, TeslimCariIl, TeslimCariUlke, TeslimCariTelefon," +
                "TeslimCariCepTelefonu, Aciklama1, Aciklama2, Aciklama3, Aciklama4, Aciklama5, Aciklama6," +
                "KayitTarihi, KayitYapanKullanici, DuzenlemeTarihi, DuzenlemeYapanKullanici, Silindi, SilinenTarih," +
                "SilenKullanici, GelenIrsaliye, Gecici, GeciciID, dtKalemler, dtFaturaKapali, CariDovizHareketineIsle," +
                "GrupKodu2ID, BaglantiBelgeNo, EkKesintiler, OtvTutari, Yuvarlama, G_BirimFiyat, G_FiyatAktar, G_FiyatOran," +
                "G_FiyatOranArttir, G_IskontoOrani1, G_IskontoOrani2, G_IskontoOrani3, G_IskontoOrani4, G_IskontoOrani5," +
                "G_IskontoOrani6, G_IskontoTutari1, G_IskontoTutari2, G_IskontoTutari3, G_IskontoTutari4, G_IskontoTutari5," +
                "G_IskontoTutari6, G_OzelIskonto, G_OzelIskontoTutar, SiparisDurumu, ETTN, GibBelgeTipi, GibBelgeTuru, GibBelgeNo," +
                "GibPostaKutusu, GibGonderimTipi, GibBelge, UlkeKod, GibGonderimDurumu, GibFaturaDurumu, IstisnaKodu, IstisnaAciklama, GibRedDurumu" +
                " from dbo.Fatura", baglanti);

            SqlConnection sqlDeneme = new SqlConnection(connectionString);
            if (sqlDeneme.State == ConnectionState.Closed)
            {
                sqlDeneme.Open();
                Control.CheckForIllegalCrossThreadCalls = false;
                Dependency();
                DataTable Faturalar = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(Faturalar);
                dgvPersoneller.DataSource = Faturalar;
                sqlDeneme.Close();
                cmd.Dispose();
            }
        }
        private void XmlOkuma()
        {
            if (!File.Exists($@"{Application.StartupPath}\DatabaseBilgilerim.xml"))
            {
                TabControl.SelectedTab = tabPageAyarlar;
                MessageBox.Show("Lütfen database bilgilerini kaydedin");
            }
            else
            {
                XmlTextReader xmlTextReader = new XmlTextReader($@"{Application.StartupPath}\DatabaseBilgilerim.xml");
                while (xmlTextReader.Read())
                {
                    if (xmlTextReader.Name == "ServerAdi")
                    {
                        ServerAdi = xmlTextReader.ReadString();
                    }
                    else if (xmlTextReader.Name == "DatabaseAdi")
                    {
                        DatabaseAdi = xmlTextReader.ReadString();
                    }
                    else if (xmlTextReader.Name == "DatabaseKullaniciAdi")
                    {
                        DatabaseKullaniciAdi = xmlTextReader.ReadString();
                    }
                    else if (xmlTextReader.Name == "DatabaseSifre")
                    {
                        DatabaseSifre = xmlTextReader.ReadString();
                    }
                }
                xmlTextReader.Close();
                PCyeDatabaseBaglantıAdresKaydı();
                connectionString = Registry.CurrentUser.OpenSubKey("Software\\FlapYazilimDatabaseBilgileri").GetValue("Connect").ToString();
                baglanti = new SqlConnection(connectionString);
                FaturaBilgileriGetir();
            }
            
        }
        private void BilgisayarAcilincaCalismasi()
        {
            const string HKCU = "HKEY_CURRENT_USER";
            const string RUN_KEY = @"Software\\Microsoft\Windows\CurrentVersion\Run";
            string exePath = Application.ExecutablePath;
            Registry.SetValue(HKCU + "\\" + RUN_KEY, "FlapYazılımUygulaması", exePath);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ServerIsimleriGetir();
            XmlOkuma();
            BilgisayarAcilincaCalismasi();
        }
        private void ServerIsimleriGetir()
        {
            var instances = SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (DataRow instance in instances.AsEnumerable())
            {
                cmbServerAdi.Items.Add(instance["ServerName"]);
            }
        }
        private void Dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            MessageBox.Show("Veritabanı güncellenmiştir. " + e.Info.ToString());
            dependency.OnChange -= Dependency_OnChange;
            FaturaBilgileriGetir();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (kapatilsinMi)
            {
                Application.Exit();
            }
            else
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                e.Cancel = true;
            }
        }
        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
        }
        private void XmlOlustur(string ServerAdi,string DatabaseAdi, string DatabaseKullaniciAdi, string DatabaseSifre)
        {
            using (var dosya = new XmlTextWriter($@"{Application.StartupPath}\DatabaseBilgilerim.xml", Encoding.UTF8))
            {
                dosya.WriteStartDocument();
                dosya.WriteStartElement("DatabaseBilgileri");
                dosya.WriteElementString("ServerAdi", ServerAdi);
                dosya.WriteElementString("DatabaseAdi", DatabaseAdi);
                dosya.WriteElementString("DatabaseKullaniciAdi", DatabaseKullaniciAdi);
                dosya.WriteElementString("DatabaseSifre", DatabaseSifre);
                dosya.WriteEndElement();
                dosya.Close();
            }
            TabControl.SelectedTab = tabPageAnasayfa;
            XmlOkuma();
        }
        private void btnDatabaseKaydet_Click(object sender, EventArgs e)
        {
            if (!File.Exists($@"{Application.StartupPath}\DatabaseBilgilerim.xml"))
            {
                XmlOlustur(cmbServerAdi.Text, txtDatabaseAdi.Text, txtDatabaseKullaniciAdi.Text, txtDatabaseSifre.Text);
            }

            else if (MessageBox.Show($@"DatabaseBilgilerim.xml dosyası daha önce oluşturulmuş. Yeniden oluşturulsun mu?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                XmlOlustur(cmbServerAdi.Text, txtDatabaseAdi.Text, txtDatabaseKullaniciAdi.Text, txtDatabaseSifre.Text);
            }

            if (MessageBox.Show($@"Xml oluşturma işlemi başarılı bir şekilde tamamlandı. Xml '{Application.StartupPath}' konumunda oluşturuldu. Konumu açmak istiyor musununz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.Yes) return;
            Process.Start(Application.StartupPath);
        }
        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kapatilsinMi = true;
            this.Close();
        }
        private void PCyeDatabaseBaglantıAdresKaydı()
        {
            RegistryKey registryKey = Registry.CurrentUser;
            registryKey = registryKey.CreateSubKey("Software\\FlapYazilimDatabaseBilgileri");
            registryKey.SetValue("Connect", $@"Persist Security Info=True;User Id={DatabaseKullaniciAdi};Password={DatabaseSifre};Initial Catalog={DatabaseAdi};Data Source={ServerAdi}");
            registryKey.Flush();
        }
    }
}
