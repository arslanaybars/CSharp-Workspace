namespace wf_08PersonelAlimi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblIsBasvuru = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblDTarih = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.gbYabanciDil = new System.Windows.Forms.GroupBox();
            this.cbxRus = new System.Windows.Forms.CheckBox();
            this.cbxArap = new System.Windows.Forms.CheckBox();
            this.cbxFra = new System.Windows.Forms.CheckBox();
            this.cbxAlm = new System.Windows.Forms.CheckBox();
            this.cbxIng = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbBilgisayar = new System.Windows.Forms.GroupBox();
            this.cbxWeb = new System.Windows.Forms.CheckBox();
            this.cbxVeri = new System.Windows.Forms.CheckBox();
            this.cbxSis = new System.Windows.Forms.CheckBox();
            this.cbxMSO = new System.Windows.Forms.CheckBox();
            this.cbxYaz = new System.Windows.Forms.CheckBox();
            this.gbCinsiyet = new System.Windows.Forms.GroupBox();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.gbAskerlik = new System.Windows.Forms.GroupBox();
            this.rbYapilmadi = new System.Windows.Forms.RadioButton();
            this.rbTecilli = new System.Windows.Forms.RadioButton();
            this.rbYapildi = new System.Windows.Forms.RadioButton();
            this.btnBasvur = new System.Windows.Forms.Button();
            this.dtpDTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbEgitim = new System.Windows.Forms.ComboBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtTCKno = new System.Windows.Forms.MaskedTextBox();
            this.gbYabanciDil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbBilgisayar.SuspendLayout();
            this.gbCinsiyet.SuspendLayout();
            this.gbAskerlik.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIsBasvuru
            // 
            this.lblIsBasvuru.AutoSize = true;
            this.lblIsBasvuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsBasvuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblIsBasvuru.Location = new System.Drawing.Point(202, 9);
            this.lblIsBasvuru.Name = "lblIsBasvuru";
            this.lblIsBasvuru.Size = new System.Drawing.Size(150, 20);
            this.lblIsBasvuru.TabIndex = 0;
            this.lblIsBasvuru.Text = "İş Başvuru Formu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı                  :";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(4, 197);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(128, 17);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyisim            :";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.Location = new System.Drawing.Point(7, 223);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(125, 17);
            this.lblTc.TabIndex = 3;
            this.lblTc.Text = "TC Kimlik No    :";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(7, 280);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(125, 17);
            this.lblAdres.TabIndex = 5;
            this.lblAdres.Text = "Adres              :";
            // 
            // lblDTarih
            // 
            this.lblDTarih.AutoSize = true;
            this.lblDTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDTarih.Location = new System.Drawing.Point(7, 359);
            this.lblDTarih.Name = "lblDTarih";
            this.lblDTarih.Size = new System.Drawing.Size(125, 17);
            this.lblDTarih.TabIndex = 6;
            this.lblDTarih.Text = "Doğum Tarihi   :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(10, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Eğitim             :";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(149, 171);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(123, 20);
            this.txtAdi.TabIndex = 8;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(149, 198);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(123, 20);
            this.txtSoyadi.TabIndex = 9;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(149, 279);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(123, 72);
            this.txtAdres.TabIndex = 12;
            // 
            // gbYabanciDil
            // 
            this.gbYabanciDil.Controls.Add(this.cbxRus);
            this.gbYabanciDil.Controls.Add(this.cbxArap);
            this.gbYabanciDil.Controls.Add(this.cbxFra);
            this.gbYabanciDil.Controls.Add(this.cbxAlm);
            this.gbYabanciDil.Controls.Add(this.cbxIng);
            this.gbYabanciDil.Location = new System.Drawing.Point(287, 55);
            this.gbYabanciDil.Name = "gbYabanciDil";
            this.gbYabanciDil.Size = new System.Drawing.Size(261, 100);
            this.gbYabanciDil.TabIndex = 15;
            this.gbYabanciDil.TabStop = false;
            this.gbYabanciDil.Text = "Yabancı Dil";
            // 
            // cbxRus
            // 
            this.cbxRus.AutoSize = true;
            this.cbxRus.Location = new System.Drawing.Point(138, 60);
            this.cbxRus.Name = "cbxRus";
            this.cbxRus.Size = new System.Drawing.Size(57, 17);
            this.cbxRus.TabIndex = 4;
            this.cbxRus.Text = "Rusça";
            this.cbxRus.UseVisualStyleBackColor = true;
            // 
            // cbxArap
            // 
            this.cbxArap.AutoSize = true;
            this.cbxArap.Location = new System.Drawing.Point(37, 60);
            this.cbxArap.Name = "cbxArap";
            this.cbxArap.Size = new System.Drawing.Size(60, 17);
            this.cbxArap.TabIndex = 3;
            this.cbxArap.Text = "Arapça";
            this.cbxArap.UseVisualStyleBackColor = true;
            // 
            // cbxFra
            // 
            this.cbxFra.AutoSize = true;
            this.cbxFra.Location = new System.Drawing.Point(179, 20);
            this.cbxFra.Name = "cbxFra";
            this.cbxFra.Size = new System.Drawing.Size(71, 17);
            this.cbxFra.TabIndex = 2;
            this.cbxFra.Text = "Fransızca";
            this.cbxFra.UseVisualStyleBackColor = true;
            // 
            // cbxAlm
            // 
            this.cbxAlm.AutoSize = true;
            this.cbxAlm.Location = new System.Drawing.Point(93, 20);
            this.cbxAlm.Name = "cbxAlm";
            this.cbxAlm.Size = new System.Drawing.Size(67, 17);
            this.cbxAlm.TabIndex = 1;
            this.cbxAlm.Text = "Almanca";
            this.cbxAlm.UseVisualStyleBackColor = true;
            // 
            // cbxIng
            // 
            this.cbxIng.AutoSize = true;
            this.cbxIng.Location = new System.Drawing.Point(7, 20);
            this.cbxIng.Name = "cbxIng";
            this.cbxIng.Size = new System.Drawing.Size(64, 17);
            this.cbxIng.TabIndex = 0;
            this.cbxIng.Text = "İngilizce";
            this.cbxIng.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // gbBilgisayar
            // 
            this.gbBilgisayar.Controls.Add(this.cbxWeb);
            this.gbBilgisayar.Controls.Add(this.cbxVeri);
            this.gbBilgisayar.Controls.Add(this.cbxSis);
            this.gbBilgisayar.Controls.Add(this.cbxMSO);
            this.gbBilgisayar.Controls.Add(this.cbxYaz);
            this.gbBilgisayar.Location = new System.Drawing.Point(287, 171);
            this.gbBilgisayar.Name = "gbBilgisayar";
            this.gbBilgisayar.Size = new System.Drawing.Size(261, 100);
            this.gbBilgisayar.TabIndex = 16;
            this.gbBilgisayar.TabStop = false;
            this.gbBilgisayar.Text = "Bilgisayar Bilgisi";
            // 
            // cbxWeb
            // 
            this.cbxWeb.AutoSize = true;
            this.cbxWeb.Location = new System.Drawing.Point(138, 52);
            this.cbxWeb.Name = "cbxWeb";
            this.cbxWeb.Size = new System.Drawing.Size(89, 17);
            this.cbxWeb.TabIndex = 4;
            this.cbxWeb.Text = "Web Tasarim";
            this.cbxWeb.UseVisualStyleBackColor = true;
            // 
            // cbxVeri
            // 
            this.cbxVeri.AutoSize = true;
            this.cbxVeri.Location = new System.Drawing.Point(37, 55);
            this.cbxVeri.Name = "cbxVeri";
            this.cbxVeri.Size = new System.Drawing.Size(73, 17);
            this.cbxVeri.TabIndex = 3;
            this.cbxVeri.Text = "Veritabani";
            this.cbxVeri.UseVisualStyleBackColor = true;
            // 
            // cbxSis
            // 
            this.cbxSis.AutoSize = true;
            this.cbxSis.Location = new System.Drawing.Point(179, 20);
            this.cbxSis.Name = "cbxSis";
            this.cbxSis.Size = new System.Drawing.Size(57, 17);
            this.cbxSis.TabIndex = 2;
            this.cbxSis.Text = "Sistem";
            this.cbxSis.UseVisualStyleBackColor = true;
            // 
            // cbxMSO
            // 
            this.cbxMSO.AutoSize = true;
            this.cbxMSO.Location = new System.Drawing.Point(93, 20);
            this.cbxMSO.Name = "cbxMSO";
            this.cbxMSO.Size = new System.Drawing.Size(73, 17);
            this.cbxMSO.TabIndex = 1;
            this.cbxMSO.Text = "MS Office";
            this.cbxMSO.UseVisualStyleBackColor = true;
            // 
            // cbxYaz
            // 
            this.cbxYaz.AutoSize = true;
            this.cbxYaz.Location = new System.Drawing.Point(7, 20);
            this.cbxYaz.Name = "cbxYaz";
            this.cbxYaz.Size = new System.Drawing.Size(58, 17);
            this.cbxYaz.TabIndex = 0;
            this.cbxYaz.Text = "Yazılım";
            this.cbxYaz.UseVisualStyleBackColor = true;
            // 
            // gbCinsiyet
            // 
            this.gbCinsiyet.Controls.Add(this.rbErkek);
            this.gbCinsiyet.Controls.Add(this.rbKadin);
            this.gbCinsiyet.Location = new System.Drawing.Point(287, 280);
            this.gbCinsiyet.Name = "gbCinsiyet";
            this.gbCinsiyet.Size = new System.Drawing.Size(120, 128);
            this.gbCinsiyet.TabIndex = 17;
            this.gbCinsiyet.TabStop = false;
            this.gbCinsiyet.Text = "Cinsiyet";
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Checked = true;
            this.rbErkek.Location = new System.Drawing.Point(6, 67);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 17);
            this.rbErkek.TabIndex = 1;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            this.rbErkek.CheckedChanged += new System.EventHandler(this.rbErkek_CheckedChanged);
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(6, 44);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(52, 17);
            this.rbKadin.TabIndex = 0;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            this.rbKadin.CheckedChanged += new System.EventHandler(this.rbKadin_CheckedChanged);
            // 
            // gbAskerlik
            // 
            this.gbAskerlik.Controls.Add(this.rbYapilmadi);
            this.gbAskerlik.Controls.Add(this.rbTecilli);
            this.gbAskerlik.Controls.Add(this.rbYapildi);
            this.gbAskerlik.Location = new System.Drawing.Point(425, 280);
            this.gbAskerlik.Name = "gbAskerlik";
            this.gbAskerlik.Size = new System.Drawing.Size(120, 128);
            this.gbAskerlik.TabIndex = 18;
            this.gbAskerlik.TabStop = false;
            this.gbAskerlik.Text = "Askerlik";
            // 
            // rbYapilmadi
            // 
            this.rbYapilmadi.AutoSize = true;
            this.rbYapilmadi.Checked = true;
            this.rbYapilmadi.Location = new System.Drawing.Point(6, 77);
            this.rbYapilmadi.Name = "rbYapilmadi";
            this.rbYapilmadi.Size = new System.Drawing.Size(70, 17);
            this.rbYapilmadi.TabIndex = 2;
            this.rbYapilmadi.TabStop = true;
            this.rbYapilmadi.Text = "Yapılmadı";
            this.rbYapilmadi.UseVisualStyleBackColor = true;
            // 
            // rbTecilli
            // 
            this.rbTecilli.AutoSize = true;
            this.rbTecilli.Location = new System.Drawing.Point(6, 54);
            this.rbTecilli.Name = "rbTecilli";
            this.rbTecilli.Size = new System.Drawing.Size(52, 17);
            this.rbTecilli.TabIndex = 1;
            this.rbTecilli.Text = "Tecilli";
            this.rbTecilli.UseVisualStyleBackColor = true;
            // 
            // rbYapildi
            // 
            this.rbYapildi.AutoSize = true;
            this.rbYapildi.Location = new System.Drawing.Point(6, 31);
            this.rbYapildi.Name = "rbYapildi";
            this.rbYapildi.Size = new System.Drawing.Size(56, 17);
            this.rbYapildi.TabIndex = 0;
            this.rbYapildi.Text = "Yapıldı";
            this.rbYapildi.UseVisualStyleBackColor = true;
            // 
            // btnBasvur
            // 
            this.btnBasvur.Location = new System.Drawing.Point(244, 525);
            this.btnBasvur.Name = "btnBasvur";
            this.btnBasvur.Size = new System.Drawing.Size(75, 23);
            this.btnBasvur.TabIndex = 20;
            this.btnBasvur.Text = "İşe Başvur";
            this.btnBasvur.UseVisualStyleBackColor = true;
            this.btnBasvur.Click += new System.EventHandler(this.btnBasvur_Click);
            // 
            // dtpDTarihi
            // 
            this.dtpDTarihi.Location = new System.Drawing.Point(149, 358);
            this.dtpDTarihi.Name = "dtpDTarihi";
            this.dtpDTarihi.Size = new System.Drawing.Size(121, 20);
            this.dtpDTarihi.TabIndex = 13;
            this.dtpDTarihi.ValueChanged += new System.EventHandler(this.dtpDTarihi_ValueChanged);
            // 
            // cbEgitim
            // 
            this.cbEgitim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEgitim.FormattingEnabled = true;
            this.cbEgitim.Items.AddRange(new object[] {
            "Lise",
            "Ön Lisans",
            "Lisans",
            "Y. Lisans",
            "Doktora"});
            this.cbEgitim.Location = new System.Drawing.Point(149, 385);
            this.cbEgitim.Name = "cbEgitim";
            this.cbEgitim.Size = new System.Drawing.Size(121, 21);
            this.cbEgitim.TabIndex = 14;
            this.cbEgitim.SelectedIndexChanged += new System.EventHandler(this.cbEgitim_SelectedIndexChanged);
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(9, 249);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(123, 17);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "Telefon No      :";
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(13, 419);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(532, 100);
            this.txtNot.TabIndex = 19;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(149, 252);
            this.txtTelefon.Mask = "(999) 000-00-00";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(121, 20);
            this.txtTelefon.TabIndex = 11;
            // 
            // txtTCKno
            // 
            this.txtTCKno.Location = new System.Drawing.Point(149, 225);
            this.txtTCKno.Mask = "00000000000";
            this.txtTCKno.Name = "txtTCKno";
            this.txtTCKno.Size = new System.Drawing.Size(121, 20);
            this.txtTCKno.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 558);
            this.Controls.Add(this.txtTCKno);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.cbEgitim);
            this.Controls.Add(this.dtpDTarihi);
            this.Controls.Add(this.btnBasvur);
            this.Controls.Add(this.gbAskerlik);
            this.Controls.Add(this.gbCinsiyet);
            this.Controls.Add(this.gbBilgisayar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbYabanciDil);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDTarih);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIsBasvuru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "İş Başvuru Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbYabanciDil.ResumeLayout(false);
            this.gbYabanciDil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbBilgisayar.ResumeLayout(false);
            this.gbBilgisayar.PerformLayout();
            this.gbCinsiyet.ResumeLayout(false);
            this.gbCinsiyet.PerformLayout();
            this.gbAskerlik.ResumeLayout(false);
            this.gbAskerlik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIsBasvuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblDTarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.GroupBox gbYabanciDil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbxRus;
        private System.Windows.Forms.CheckBox cbxArap;
        private System.Windows.Forms.CheckBox cbxFra;
        private System.Windows.Forms.CheckBox cbxAlm;
        private System.Windows.Forms.CheckBox cbxIng;
        private System.Windows.Forms.GroupBox gbBilgisayar;
        private System.Windows.Forms.CheckBox cbxWeb;
        private System.Windows.Forms.CheckBox cbxVeri;
        private System.Windows.Forms.CheckBox cbxSis;
        private System.Windows.Forms.CheckBox cbxMSO;
        private System.Windows.Forms.CheckBox cbxYaz;
        private System.Windows.Forms.GroupBox gbCinsiyet;
        private System.Windows.Forms.GroupBox gbAskerlik;
        private System.Windows.Forms.Button btnBasvur;
        private System.Windows.Forms.DateTimePicker dtpDTarihi;
        private System.Windows.Forms.ComboBox cbEgitim;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.RadioButton rbYapilmadi;
        private System.Windows.Forms.RadioButton rbTecilli;
        private System.Windows.Forms.RadioButton rbYapildi;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.MaskedTextBox txtTCKno;
    }
}

