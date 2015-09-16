namespace sqlwf_02VideoMarket
{
    partial class frmAnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuAnaSayfa = new System.Windows.Forms.MenuStrip();
            this.filmBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemFilmTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemFilmTuruTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemFilmSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemMusteriGirisi = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemMusteriSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.satışİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemFilmSatis = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemSatisSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemSatisRaporu = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnaSayfa.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAnaSayfa
            // 
            this.mnuAnaSayfa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmBilgileriToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.satışİşlemleriToolStripMenuItem,
            this.raporlamaToolStripMenuItem,
            this.mItemCikis});
            this.mnuAnaSayfa.Location = new System.Drawing.Point(0, 0);
            this.mnuAnaSayfa.Name = "mnuAnaSayfa";
            this.mnuAnaSayfa.Size = new System.Drawing.Size(592, 24);
            this.mnuAnaSayfa.TabIndex = 1;
            this.mnuAnaSayfa.Text = "menuStrip1";
            // 
            // filmBilgileriToolStripMenuItem
            // 
            this.filmBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemFilmTanimlama,
            this.mItemFilmTuruTanimlama,
            this.mItemFilmSorgulama});
            this.filmBilgileriToolStripMenuItem.Name = "filmBilgileriToolStripMenuItem";
            this.filmBilgileriToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.filmBilgileriToolStripMenuItem.Text = "&Film Bilgileri";
            // 
            // mItemFilmTanimlama
            // 
            this.mItemFilmTanimlama.Name = "mItemFilmTanimlama";
            this.mItemFilmTanimlama.Size = new System.Drawing.Size(188, 22);
            this.mItemFilmTanimlama.Text = "Film Tanımlama";
            this.mItemFilmTanimlama.Click += new System.EventHandler(this.mItemFilmTanimlama_Click);
            // 
            // mItemFilmTuruTanimlama
            // 
            this.mItemFilmTuruTanimlama.Name = "mItemFilmTuruTanimlama";
            this.mItemFilmTuruTanimlama.Size = new System.Drawing.Size(188, 22);
            this.mItemFilmTuruTanimlama.Text = "Film Türü Tanımlama";
            this.mItemFilmTuruTanimlama.Click += new System.EventHandler(this.mItemFilmTuruTanimlama_Click);
            // 
            // mItemFilmSorgulama
            // 
            this.mItemFilmSorgulama.Name = "mItemFilmSorgulama";
            this.mItemFilmSorgulama.Size = new System.Drawing.Size(188, 22);
            this.mItemFilmSorgulama.Text = "Film Sorgulama";
            this.mItemFilmSorgulama.Click += new System.EventHandler(this.mItemFilmSorgulama_Click);
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemMusteriGirisi,
            this.mItemMusteriSorgulama});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.müşterilerToolStripMenuItem.Text = "&Müşteriler";
            // 
            // mItemMusteriGirisi
            // 
            this.mItemMusteriGirisi.Name = "mItemMusteriGirisi";
            this.mItemMusteriGirisi.Size = new System.Drawing.Size(174, 22);
            this.mItemMusteriGirisi.Text = "Müşteri Girişi";
            this.mItemMusteriGirisi.Click += new System.EventHandler(this.mItemMusteriGirisi_Click);
            // 
            // mItemMusteriSorgulama
            // 
            this.mItemMusteriSorgulama.Name = "mItemMusteriSorgulama";
            this.mItemMusteriSorgulama.Size = new System.Drawing.Size(174, 22);
            this.mItemMusteriSorgulama.Text = "Müşteri Sorgulama";
            this.mItemMusteriSorgulama.Click += new System.EventHandler(this.mItemMusteriSorgulama_Click);
            // 
            // satışİşlemleriToolStripMenuItem
            // 
            this.satışİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemFilmSatis,
            this.mItemSatisSorgulama});
            this.satışİşlemleriToolStripMenuItem.Name = "satışİşlemleriToolStripMenuItem";
            this.satışİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.satışİşlemleriToolStripMenuItem.Text = "&Satış İşlemleri";
            // 
            // mItemFilmSatis
            // 
            this.mItemFilmSatis.Name = "mItemFilmSatis";
            this.mItemFilmSatis.Size = new System.Drawing.Size(158, 22);
            this.mItemFilmSatis.Text = "Film Satış";
            this.mItemFilmSatis.Click += new System.EventHandler(this.mItemFilmSatis_Click);
            // 
            // mItemSatisSorgulama
            // 
            this.mItemSatisSorgulama.Name = "mItemSatisSorgulama";
            this.mItemSatisSorgulama.Size = new System.Drawing.Size(158, 22);
            this.mItemSatisSorgulama.Text = "Satış Sorgulama";
            this.mItemSatisSorgulama.Click += new System.EventHandler(this.mItemSatisSorgulama_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemSatisRaporu});
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.raporlamaToolStripMenuItem.Text = "&Raporlama";
            // 
            // mItemSatisRaporu
            // 
            this.mItemSatisRaporu.Name = "mItemSatisRaporu";
            this.mItemSatisRaporu.Size = new System.Drawing.Size(178, 22);
            this.mItemSatisRaporu.Text = "Detaylı Satış Raporu";
            // 
            // mItemCikis
            // 
            this.mItemCikis.Name = "mItemCikis";
            this.mItemCikis.Size = new System.Drawing.Size(44, 20);
            this.mItemCikis.Text = "&Çıkış";
            this.mItemCikis.Click += new System.EventHandler(this.mItemCikis_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 465);
            this.Controls.Add(this.mnuAnaSayfa);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuAnaSayfa;
            this.Name = "frmAnaSayfa";
            this.Text = "Video Market AnaSayfa İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuAnaSayfa.ResumeLayout(false);
            this.mnuAnaSayfa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAnaSayfa;
        private System.Windows.Forms.ToolStripMenuItem filmBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mItemFilmTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mItemFilmTuruTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mItemFilmSorgulama;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mItemMusteriGirisi;
        private System.Windows.Forms.ToolStripMenuItem mItemMusteriSorgulama;
        private System.Windows.Forms.ToolStripMenuItem satışİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mItemFilmSatis;
        private System.Windows.Forms.ToolStripMenuItem mItemSatisSorgulama;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mItemSatisRaporu;
        private System.Windows.Forms.ToolStripMenuItem mItemCikis;
    }
}

