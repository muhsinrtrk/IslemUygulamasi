namespace IslemUygulamasi
{
    partial class frmIslemuygulaması
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIslemuygulaması));
            this.grpbIslembilgileri = new System.Windows.Forms.GroupBox();
            this.mtxtBitis = new System.Windows.Forms.MaskedTextBox();
            this.mtxtBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblBitis = new System.Windows.Forms.Label();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.tbcIslemler = new System.Windows.Forms.TabControl();
            this.tbpTeksayilar = new System.Windows.Forms.TabPage();
            this.lstvTeksayilar = new System.Windows.Forms.ListView();
            this.tbpCiftsayilar = new System.Windows.Forms.TabPage();
            this.lstvCiftsayilar = new System.Windows.Forms.ListView();
            this.tbpAsalsayilar = new System.Windows.Forms.TabPage();
            this.lstvAsalsayilar = new System.Windows.Forms.ListView();
            this.tbpArmstrongsayilar = new System.Windows.Forms.TabPage();
            this.lstvArmstrongsayilar = new System.Windows.Forms.ListView();
            this.nfyiResim = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxtmsBilgi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpbIslembilgileri.SuspendLayout();
            this.tbcIslemler.SuspendLayout();
            this.tbpTeksayilar.SuspendLayout();
            this.tbpCiftsayilar.SuspendLayout();
            this.tbpAsalsayilar.SuspendLayout();
            this.tbpArmstrongsayilar.SuspendLayout();
            this.ctxtmsBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbIslembilgileri
            // 
            this.grpbIslembilgileri.Controls.Add(this.mtxtBitis);
            this.grpbIslembilgileri.Controls.Add(this.mtxtBaslangic);
            this.grpbIslembilgileri.Controls.Add(this.btnIleri);
            this.grpbIslembilgileri.Controls.Add(this.btnGeri);
            this.grpbIslembilgileri.Controls.Add(this.btnHesapla);
            this.grpbIslembilgileri.Controls.Add(this.lblBitis);
            this.grpbIslembilgileri.Controls.Add(this.lblBaslangic);
            this.grpbIslembilgileri.Location = new System.Drawing.Point(13, 13);
            this.grpbIslembilgileri.Name = "grpbIslembilgileri";
            this.grpbIslembilgileri.Size = new System.Drawing.Size(775, 118);
            this.grpbIslembilgileri.TabIndex = 0;
            this.grpbIslembilgileri.TabStop = false;
            this.grpbIslembilgileri.Text = "İşlem Bilgileri";
            // 
            // mtxtBitis
            // 
            this.mtxtBitis.Location = new System.Drawing.Point(273, 54);
            this.mtxtBitis.Mask = "00000";
            this.mtxtBitis.Name = "mtxtBitis";
            this.mtxtBitis.Size = new System.Drawing.Size(100, 22);
            this.mtxtBitis.TabIndex = 8;
            this.mtxtBitis.ValidatingType = typeof(int);
            // 
            // mtxtBaslangic
            // 
            this.mtxtBaslangic.Location = new System.Drawing.Point(106, 54);
            this.mtxtBaslangic.Mask = "00000";
            this.mtxtBaslangic.Name = "mtxtBaslangic";
            this.mtxtBaslangic.Size = new System.Drawing.Size(100, 22);
            this.mtxtBaslangic.TabIndex = 7;
            this.mtxtBaslangic.ValidatingType = typeof(int);
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(645, 50);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(75, 23);
            this.btnIleri.TabIndex = 6;
            this.btnIleri.Text = "İleri";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(564, 49);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(379, 49);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(233, 54);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(34, 17);
            this.lblBitis.TabIndex = 2;
            this.lblBitis.Text = "Bitiş";
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Location = new System.Drawing.Point(27, 53);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(73, 17);
            this.lblBaslangic.TabIndex = 0;
            this.lblBaslangic.Text = " Başlangıç";
            // 
            // tbcIslemler
            // 
            this.tbcIslemler.Controls.Add(this.tbpTeksayilar);
            this.tbcIslemler.Controls.Add(this.tbpCiftsayilar);
            this.tbcIslemler.Controls.Add(this.tbpAsalsayilar);
            this.tbcIslemler.Controls.Add(this.tbpArmstrongsayilar);
            this.tbcIslemler.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbcIslemler.Location = new System.Drawing.Point(13, 138);
            this.tbcIslemler.Name = "tbcIslemler";
            this.tbcIslemler.SelectedIndex = 0;
            this.tbcIslemler.Size = new System.Drawing.Size(775, 606);
            this.tbcIslemler.TabIndex = 1;
            // 
            // tbpTeksayilar
            // 
            this.tbpTeksayilar.Controls.Add(this.lstvTeksayilar);
            this.tbpTeksayilar.Location = new System.Drawing.Point(4, 25);
            this.tbpTeksayilar.Name = "tbpTeksayilar";
            this.tbpTeksayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTeksayilar.Size = new System.Drawing.Size(767, 577);
            this.tbpTeksayilar.TabIndex = 0;
            this.tbpTeksayilar.Text = "Tek Sayılar";
            this.tbpTeksayilar.UseVisualStyleBackColor = true;
            // 
            // lstvTeksayilar
            // 
            this.lstvTeksayilar.HideSelection = false;
            this.lstvTeksayilar.Location = new System.Drawing.Point(7, 7);
            this.lstvTeksayilar.Name = "lstvTeksayilar";
            this.lstvTeksayilar.Size = new System.Drawing.Size(754, 564);
            this.lstvTeksayilar.TabIndex = 0;
            this.lstvTeksayilar.UseCompatibleStateImageBehavior = false;
            this.lstvTeksayilar.View = System.Windows.Forms.View.Tile;
            // 
            // tbpCiftsayilar
            // 
            this.tbpCiftsayilar.Controls.Add(this.lstvCiftsayilar);
            this.tbpCiftsayilar.Location = new System.Drawing.Point(4, 25);
            this.tbpCiftsayilar.Name = "tbpCiftsayilar";
            this.tbpCiftsayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCiftsayilar.Size = new System.Drawing.Size(767, 577);
            this.tbpCiftsayilar.TabIndex = 1;
            this.tbpCiftsayilar.Text = "Çift Sayılar";
            this.tbpCiftsayilar.UseVisualStyleBackColor = true;
            // 
            // lstvCiftsayilar
            // 
            this.lstvCiftsayilar.HideSelection = false;
            this.lstvCiftsayilar.Location = new System.Drawing.Point(6, 6);
            this.lstvCiftsayilar.Name = "lstvCiftsayilar";
            this.lstvCiftsayilar.Size = new System.Drawing.Size(754, 565);
            this.lstvCiftsayilar.TabIndex = 1;
            this.lstvCiftsayilar.UseCompatibleStateImageBehavior = false;
            this.lstvCiftsayilar.View = System.Windows.Forms.View.Tile;
            // 
            // tbpAsalsayilar
            // 
            this.tbpAsalsayilar.Controls.Add(this.lstvAsalsayilar);
            this.tbpAsalsayilar.Location = new System.Drawing.Point(4, 25);
            this.tbpAsalsayilar.Name = "tbpAsalsayilar";
            this.tbpAsalsayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAsalsayilar.Size = new System.Drawing.Size(767, 577);
            this.tbpAsalsayilar.TabIndex = 2;
            this.tbpAsalsayilar.Text = "Asal Sayılar";
            this.tbpAsalsayilar.UseVisualStyleBackColor = true;
            // 
            // lstvAsalsayilar
            // 
            this.lstvAsalsayilar.HideSelection = false;
            this.lstvAsalsayilar.Location = new System.Drawing.Point(6, 6);
            this.lstvAsalsayilar.Name = "lstvAsalsayilar";
            this.lstvAsalsayilar.Size = new System.Drawing.Size(754, 565);
            this.lstvAsalsayilar.TabIndex = 1;
            this.lstvAsalsayilar.UseCompatibleStateImageBehavior = false;
            this.lstvAsalsayilar.View = System.Windows.Forms.View.Tile;
            // 
            // tbpArmstrongsayilar
            // 
            this.tbpArmstrongsayilar.Controls.Add(this.lstvArmstrongsayilar);
            this.tbpArmstrongsayilar.Location = new System.Drawing.Point(4, 25);
            this.tbpArmstrongsayilar.Name = "tbpArmstrongsayilar";
            this.tbpArmstrongsayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpArmstrongsayilar.Size = new System.Drawing.Size(767, 577);
            this.tbpArmstrongsayilar.TabIndex = 3;
            this.tbpArmstrongsayilar.Text = "Armstrong Sayılar";
            this.tbpArmstrongsayilar.UseVisualStyleBackColor = true;
            // 
            // lstvArmstrongsayilar
            // 
            this.lstvArmstrongsayilar.HideSelection = false;
            this.lstvArmstrongsayilar.Location = new System.Drawing.Point(6, 6);
            this.lstvArmstrongsayilar.Name = "lstvArmstrongsayilar";
            this.lstvArmstrongsayilar.Size = new System.Drawing.Size(754, 565);
            this.lstvArmstrongsayilar.TabIndex = 1;
            this.lstvArmstrongsayilar.UseCompatibleStateImageBehavior = false;
            this.lstvArmstrongsayilar.View = System.Windows.Forms.View.Tile;
            // 
            // nfyiResim
            // 
            this.nfyiResim.ContextMenuStrip = this.ctxtmsBilgi;
            this.nfyiResim.Icon = ((System.Drawing.Icon)(resources.GetObject("nfyiResim.Icon")));
            this.nfyiResim.Text = "İşlem Uygulaması";
            this.nfyiResim.Visible = true;
            // 
            // ctxtmsBilgi
            // 
            this.ctxtmsBilgi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxtmsBilgi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.ctxtmsBilgi.Name = "ctxtmsBilgi";
            this.ctxtmsBilgi.Size = new System.Drawing.Size(103, 28);
            this.ctxtmsBilgi.Text = "Bilgilendirme";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmIslemuygulaması
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 756);
            this.Controls.Add(this.tbcIslemler);
            this.Controls.Add(this.grpbIslembilgileri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIslemuygulaması";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlem Uygulaması";
            this.Shown += new System.EventHandler(this.frmIslemuygulaması_Shown);
            this.grpbIslembilgileri.ResumeLayout(false);
            this.grpbIslembilgileri.PerformLayout();
            this.tbcIslemler.ResumeLayout(false);
            this.tbpTeksayilar.ResumeLayout(false);
            this.tbpCiftsayilar.ResumeLayout(false);
            this.tbpAsalsayilar.ResumeLayout(false);
            this.tbpArmstrongsayilar.ResumeLayout(false);
            this.ctxtmsBilgi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbIslembilgileri;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.TabControl tbcIslemler;
        private System.Windows.Forms.TabPage tbpTeksayilar;
        private System.Windows.Forms.TabPage tbpCiftsayilar;
        private System.Windows.Forms.TabPage tbpAsalsayilar;
        private System.Windows.Forms.TabPage tbpArmstrongsayilar;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.ListView lstvTeksayilar;
        private System.Windows.Forms.ListView lstvCiftsayilar;
        private System.Windows.Forms.ListView lstvAsalsayilar;
        private System.Windows.Forms.ListView lstvArmstrongsayilar;
        private System.Windows.Forms.MaskedTextBox mtxtBitis;
        private System.Windows.Forms.MaskedTextBox mtxtBaslangic;
        private System.Windows.Forms.NotifyIcon nfyiResim;
        private System.Windows.Forms.ContextMenuStrip ctxtmsBilgi;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

