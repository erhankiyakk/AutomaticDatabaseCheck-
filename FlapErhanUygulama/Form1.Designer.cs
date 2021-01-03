namespace FlapErhanUygulama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPageAnasayfa = new System.Windows.Forms.TabPage();
            this.tabPageAyarlar = new System.Windows.Forms.TabPage();
            this.lblFatura = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDatabaseKaydet = new System.Windows.Forms.Button();
            this.lblDatabaseAdi = new System.Windows.Forms.Label();
            this.txtDatabaseKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblServerAdi = new System.Windows.Forms.Label();
            this.txtDatabaseAdi = new System.Windows.Forms.TextBox();
            this.txtDatabaseSifre = new System.Windows.Forms.TextBox();
            this.lblPortNo = new System.Windows.Forms.Label();
            this.cmbServerAdi = new System.Windows.Forms.ComboBox();
            this.lblDatabaseSifre = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPersoneller = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPageAnasayfa.SuspendLayout();
            this.tabPageAyarlar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Flap Erhan Uygulama";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 52);
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.gösterToolStripMenuItem.Text = "Göster";
            this.gösterToolStripMenuItem.Click += new System.EventHandler(this.gösterToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.tabPageAnasayfa);
            this.TabControl.Controls.Add(this.tabPageAyarlar);
            this.TabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TabControl.Location = new System.Drawing.Point(2, 2);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(994, 461);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 3;
            // 
            // tabPageAnasayfa
            // 
            this.tabPageAnasayfa.Controls.Add(this.panel1);
            this.tabPageAnasayfa.Controls.Add(this.lblFatura);
            this.tabPageAnasayfa.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPageAnasayfa.Location = new System.Drawing.Point(4, 25);
            this.tabPageAnasayfa.Name = "tabPageAnasayfa";
            this.tabPageAnasayfa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAnasayfa.Size = new System.Drawing.Size(986, 432);
            this.tabPageAnasayfa.TabIndex = 0;
            this.tabPageAnasayfa.Text = "Anasayfa";
            this.tabPageAnasayfa.UseVisualStyleBackColor = true;
            // 
            // tabPageAyarlar
            // 
            this.tabPageAyarlar.Controls.Add(this.groupBox1);
            this.tabPageAyarlar.Location = new System.Drawing.Point(4, 25);
            this.tabPageAyarlar.Name = "tabPageAyarlar";
            this.tabPageAyarlar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAyarlar.Size = new System.Drawing.Size(986, 432);
            this.tabPageAyarlar.TabIndex = 1;
            this.tabPageAyarlar.Text = "Ayarlar";
            this.tabPageAyarlar.UseVisualStyleBackColor = true;
            // 
            // lblFatura
            // 
            this.lblFatura.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblFatura.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFatura.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatura.Location = new System.Drawing.Point(3, 3);
            this.lblFatura.Name = "lblFatura";
            this.lblFatura.Size = new System.Drawing.Size(980, 50);
            this.lblFatura.TabIndex = 2;
            this.lblFatura.Text = "Faturalar";
            this.lblFatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFatura.UseCompatibleTextRendering = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bağlantı Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.btnDatabaseKaydet);
            this.groupBox2.Controls.Add(this.lblDatabaseAdi);
            this.groupBox2.Controls.Add(this.txtDatabaseKullaniciAdi);
            this.groupBox2.Controls.Add(this.lblServerAdi);
            this.groupBox2.Controls.Add(this.txtDatabaseAdi);
            this.groupBox2.Controls.Add(this.txtDatabaseSifre);
            this.groupBox2.Controls.Add(this.lblPortNo);
            this.groupBox2.Controls.Add(this.cmbServerAdi);
            this.groupBox2.Controls.Add(this.lblDatabaseSifre);
            this.groupBox2.Location = new System.Drawing.Point(235, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 368);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnDatabaseKaydet
            // 
            this.btnDatabaseKaydet.Location = new System.Drawing.Point(195, 246);
            this.btnDatabaseKaydet.Name = "btnDatabaseKaydet";
            this.btnDatabaseKaydet.Size = new System.Drawing.Size(223, 54);
            this.btnDatabaseKaydet.TabIndex = 17;
            this.btnDatabaseKaydet.Text = "Database Kaydet";
            this.btnDatabaseKaydet.UseVisualStyleBackColor = true;
            this.btnDatabaseKaydet.Click += new System.EventHandler(this.btnDatabaseKaydet_Click);
            // 
            // lblDatabaseAdi
            // 
            this.lblDatabaseAdi.AutoSize = true;
            this.lblDatabaseAdi.Location = new System.Drawing.Point(85, 102);
            this.lblDatabaseAdi.Name = "lblDatabaseAdi";
            this.lblDatabaseAdi.Size = new System.Drawing.Size(97, 17);
            this.lblDatabaseAdi.TabIndex = 15;
            this.lblDatabaseAdi.Text = "Database Adı:";
            // 
            // txtDatabaseKullaniciAdi
            // 
            this.txtDatabaseKullaniciAdi.Location = new System.Drawing.Point(195, 153);
            this.txtDatabaseKullaniciAdi.Name = "txtDatabaseKullaniciAdi";
            this.txtDatabaseKullaniciAdi.Size = new System.Drawing.Size(223, 22);
            this.txtDatabaseKullaniciAdi.TabIndex = 11;
            // 
            // lblServerAdi
            // 
            this.lblServerAdi.AutoSize = true;
            this.lblServerAdi.Location = new System.Drawing.Point(104, 48);
            this.lblServerAdi.Name = "lblServerAdi";
            this.lblServerAdi.Size = new System.Drawing.Size(78, 17);
            this.lblServerAdi.TabIndex = 13;
            this.lblServerAdi.Text = "Server Adı:";
            // 
            // txtDatabaseAdi
            // 
            this.txtDatabaseAdi.Location = new System.Drawing.Point(195, 99);
            this.txtDatabaseAdi.Name = "txtDatabaseAdi";
            this.txtDatabaseAdi.Size = new System.Drawing.Size(223, 22);
            this.txtDatabaseAdi.TabIndex = 10;
            // 
            // txtDatabaseSifre
            // 
            this.txtDatabaseSifre.Location = new System.Drawing.Point(195, 198);
            this.txtDatabaseSifre.Name = "txtDatabaseSifre";
            this.txtDatabaseSifre.Size = new System.Drawing.Size(223, 22);
            this.txtDatabaseSifre.TabIndex = 12;
            // 
            // lblPortNo
            // 
            this.lblPortNo.AutoSize = true;
            this.lblPortNo.Location = new System.Drawing.Point(29, 153);
            this.lblPortNo.Name = "lblPortNo";
            this.lblPortNo.Size = new System.Drawing.Size(153, 17);
            this.lblPortNo.TabIndex = 14;
            this.lblPortNo.Text = "Database Kullanıcı Adı:";
            // 
            // cmbServerAdi
            // 
            this.cmbServerAdi.FormattingEnabled = true;
            this.cmbServerAdi.Items.AddRange(new object[] {
            "DESKTOP-4S51J92\\SQLEXPRESS"});
            this.cmbServerAdi.Location = new System.Drawing.Point(195, 48);
            this.cmbServerAdi.Name = "cmbServerAdi";
            this.cmbServerAdi.Size = new System.Drawing.Size(223, 24);
            this.cmbServerAdi.TabIndex = 18;
            // 
            // lblDatabaseSifre
            // 
            this.lblDatabaseSifre.AutoSize = true;
            this.lblDatabaseSifre.Location = new System.Drawing.Point(76, 201);
            this.lblDatabaseSifre.Name = "lblDatabaseSifre";
            this.lblDatabaseSifre.Size = new System.Drawing.Size(106, 17);
            this.lblDatabaseSifre.TabIndex = 16;
            this.lblDatabaseSifre.Text = "Database Şifre:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPersoneller);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 376);
            this.panel1.TabIndex = 3;
            // 
            // dgvPersoneller
            // 
            this.dgvPersoneller.AllowUserToAddRows = false;
            this.dgvPersoneller.AllowUserToDeleteRows = false;
            this.dgvPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersoneller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersoneller.Location = new System.Drawing.Point(0, 0);
            this.dgvPersoneller.Name = "dgvPersoneller";
            this.dgvPersoneller.ReadOnly = true;
            this.dgvPersoneller.RowTemplate.Height = 24;
            this.dgvPersoneller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersoneller.Size = new System.Drawing.Size(980, 376);
            this.dgvPersoneller.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 461);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.tabPageAnasayfa.ResumeLayout(false);
            this.tabPageAyarlar.ResumeLayout(false);
            this.tabPageAyarlar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPageAnasayfa;
        private System.Windows.Forms.TabPage tabPageAyarlar;
        private System.Windows.Forms.Label lblFatura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDatabaseKaydet;
        private System.Windows.Forms.Label lblDatabaseAdi;
        private System.Windows.Forms.TextBox txtDatabaseKullaniciAdi;
        private System.Windows.Forms.Label lblServerAdi;
        private System.Windows.Forms.TextBox txtDatabaseAdi;
        private System.Windows.Forms.TextBox txtDatabaseSifre;
        private System.Windows.Forms.Label lblPortNo;
        private System.Windows.Forms.ComboBox cmbServerAdi;
        private System.Windows.Forms.Label lblDatabaseSifre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPersoneller;
    }
}

