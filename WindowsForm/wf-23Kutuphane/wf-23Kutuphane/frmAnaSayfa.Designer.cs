namespace wf_23Kutuphane
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
            this.kitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItmKitapTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mItmKitapTuru = new System.Windows.Forms.ToolStripMenuItem();
            this.mItmKitapSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItmYazarTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mItmYazarSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.yayınevleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItmYayineviTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mItmYayıneviSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.mItmDetayliKitapSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.detaylıKitapSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItmCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnaSayfa.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAnaSayfa
            // 
            this.mnuAnaSayfa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitaplarToolStripMenuItem,
            this.yazarlarToolStripMenuItem,
            this.yayınevleriToolStripMenuItem,
            this.mItmDetayliKitapSorgulama,
            this.mItmCikis});
            this.mnuAnaSayfa.Location = new System.Drawing.Point(0, 0);
            this.mnuAnaSayfa.Name = "mnuAnaSayfa";
            this.mnuAnaSayfa.Size = new System.Drawing.Size(618, 24);
            this.mnuAnaSayfa.TabIndex = 1;
            this.mnuAnaSayfa.Text = "menuStrip1";
            // 
            // kitaplarToolStripMenuItem
            // 
            this.kitaplarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItmKitapTanimlama,
            this.mItmKitapTuru,
            this.mItmKitapSorgulama});
            this.kitaplarToolStripMenuItem.Name = "kitaplarToolStripMenuItem";
            this.kitaplarToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.kitaplarToolStripMenuItem.Text = "&Kitaplar";
            // 
            // mItmKitapTanimlama
            // 
            this.mItmKitapTanimlama.Name = "mItmKitapTanimlama";
            this.mItmKitapTanimlama.Size = new System.Drawing.Size(192, 22);
            this.mItmKitapTanimlama.Text = "Kitap Tanımlama";
            this.mItmKitapTanimlama.Click += new System.EventHandler(this.mItmKitapTanimlama_Click);
            // 
            // mItmKitapTuru
            // 
            this.mItmKitapTuru.Name = "mItmKitapTuru";
            this.mItmKitapTuru.Size = new System.Drawing.Size(192, 22);
            this.mItmKitapTuru.Text = "Kitap Türü Tanımlama";
            this.mItmKitapTuru.Click += new System.EventHandler(this.mItmKitapTuru_Click);
            // 
            // mItmKitapSorgulama
            // 
            this.mItmKitapSorgulama.Name = "mItmKitapSorgulama";
            this.mItmKitapSorgulama.Size = new System.Drawing.Size(192, 22);
            this.mItmKitapSorgulama.Text = "Kitap Sorgulama";
            this.mItmKitapSorgulama.Click += new System.EventHandler(this.mItmKitapSorgulama_Click);
            // 
            // yazarlarToolStripMenuItem
            // 
            this.yazarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItmYazarTanimlama,
            this.mItmYazarSorgulama});
            this.yazarlarToolStripMenuItem.Name = "yazarlarToolStripMenuItem";
            this.yazarlarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.yazarlarToolStripMenuItem.Text = "&Yazarlar";
            // 
            // mItmYazarTanimlama
            // 
            this.mItmYazarTanimlama.Name = "mItmYazarTanimlama";
            this.mItmYazarTanimlama.Size = new System.Drawing.Size(165, 22);
            this.mItmYazarTanimlama.Text = "Yazar Tanımlama";
            this.mItmYazarTanimlama.Click += new System.EventHandler(this.mItmYazarTanimlama_Click);
            // 
            // mItmYazarSorgulama
            // 
            this.mItmYazarSorgulama.Name = "mItmYazarSorgulama";
            this.mItmYazarSorgulama.Size = new System.Drawing.Size(165, 22);
            this.mItmYazarSorgulama.Text = "Yazar Sorgulama";
            this.mItmYazarSorgulama.Click += new System.EventHandler(this.mItmYazarSorgulama_Click);
            // 
            // yayınevleriToolStripMenuItem
            // 
            this.yayınevleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItmYayineviTanimlama,
            this.mItmYayıneviSorgulama});
            this.yayınevleriToolStripMenuItem.Name = "yayınevleriToolStripMenuItem";
            this.yayınevleriToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.yayınevleriToolStripMenuItem.Text = "Yayın&evleri";
            // 
            // mItmYayineviTanimlama
            // 
            this.mItmYayineviTanimlama.Name = "mItmYayineviTanimlama";
            this.mItmYayineviTanimlama.Size = new System.Drawing.Size(181, 22);
            this.mItmYayineviTanimlama.Text = "Yayınevi Tanımlama";
            this.mItmYayineviTanimlama.Click += new System.EventHandler(this.mItmYayineviTanimlama_Click);
            // 
            // mItmYayıneviSorgulama
            // 
            this.mItmYayıneviSorgulama.Name = "mItmYayıneviSorgulama";
            this.mItmYayıneviSorgulama.Size = new System.Drawing.Size(181, 22);
            this.mItmYayıneviSorgulama.Text = "Yayınevi Sorgulama";
            this.mItmYayıneviSorgulama.Click += new System.EventHandler(this.mItmYayıneviSorgulama_Click);
            // 
            // mItmDetayliKitapSorgulama
            // 
            this.mItmDetayliKitapSorgulama.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detaylıKitapSorgulamaToolStripMenuItem});
            this.mItmDetayliKitapSorgulama.Name = "mItmDetayliKitapSorgulama";
            this.mItmDetayliKitapSorgulama.Size = new System.Drawing.Size(76, 20);
            this.mItmDetayliKitapSorgulama.Text = "&Raporlama";
            // 
            // detaylıKitapSorgulamaToolStripMenuItem
            // 
            this.detaylıKitapSorgulamaToolStripMenuItem.Name = "detaylıKitapSorgulamaToolStripMenuItem";
            this.detaylıKitapSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.detaylıKitapSorgulamaToolStripMenuItem.Text = "Detaylı Kitap Sorgulama";
            // 
            // mItmCikis
            // 
            this.mItmCikis.Name = "mItmCikis";
            this.mItmCikis.Size = new System.Drawing.Size(44, 20);
            this.mItmCikis.Text = "&Çıkış";
            this.mItmCikis.Click += new System.EventHandler(this.mItmCikis_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 480);
            this.Controls.Add(this.mnuAnaSayfa);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuAnaSayfa;
            this.Name = "frmAnaSayfa";
            this.Text = "BP-9 Kütüphanesi AnaSayfa İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuAnaSayfa.ResumeLayout(false);
            this.mnuAnaSayfa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAnaSayfa;
        private System.Windows.Forms.ToolStripMenuItem kitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mItmKitapTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mItmKitapTuru;
        private System.Windows.Forms.ToolStripMenuItem mItmKitapSorgulama;
        private System.Windows.Forms.ToolStripMenuItem yazarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mItmYazarTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mItmYazarSorgulama;
        private System.Windows.Forms.ToolStripMenuItem yayınevleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mItmYayineviTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mItmYayıneviSorgulama;
        private System.Windows.Forms.ToolStripMenuItem mItmDetayliKitapSorgulama;
        private System.Windows.Forms.ToolStripMenuItem detaylıKitapSorgulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mItmCikis;
    }
}