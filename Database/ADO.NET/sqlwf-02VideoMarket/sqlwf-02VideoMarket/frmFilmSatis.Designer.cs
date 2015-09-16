namespace sqlwf_02VideoMarket
{
    partial class frmFilmSatis
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMusteriBul = new System.Windows.Forms.Button();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilmNo = new System.Windows.Forms.TextBox();
            this.btnFilmBul = new System.Windows.Forms.Button();
            this.txtFilm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lvSatislar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSatisNo = new System.Windows.Forms.TextBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.txtToplamAdet = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih :";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(81, 13);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(104, 20);
            this.txtTarih.TabIndex = 1;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(189, 13);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(18, 20);
            this.dtpTarih.TabIndex = 2;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(81, 39);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.ReadOnly = true;
            this.txtMusteri.Size = new System.Drawing.Size(104, 20);
            this.txtMusteri.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Müşteri Bul :";
            // 
            // btnMusteriBul
            // 
            this.btnMusteriBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriBul.Location = new System.Drawing.Point(189, 39);
            this.btnMusteriBul.Name = "btnMusteriBul";
            this.btnMusteriBul.Size = new System.Drawing.Size(27, 20);
            this.btnMusteriBul.TabIndex = 5;
            this.btnMusteriBul.Text = "...";
            this.btnMusteriBul.UseVisualStyleBackColor = true;
            this.btnMusteriBul.Click += new System.EventHandler(this.btnMusteriBul_Click);
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Location = new System.Drawing.Point(292, 39);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.ReadOnly = true;
            this.txtMusteriNo.Size = new System.Drawing.Size(26, 20);
            this.txtMusteriNo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Müşteri No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Film No :";
            // 
            // txtFilmNo
            // 
            this.txtFilmNo.Location = new System.Drawing.Point(573, 38);
            this.txtFilmNo.Name = "txtFilmNo";
            this.txtFilmNo.ReadOnly = true;
            this.txtFilmNo.Size = new System.Drawing.Size(26, 20);
            this.txtFilmNo.TabIndex = 11;
            // 
            // btnFilmBul
            // 
            this.btnFilmBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmBul.Location = new System.Drawing.Point(485, 39);
            this.btnFilmBul.Name = "btnFilmBul";
            this.btnFilmBul.Size = new System.Drawing.Size(27, 20);
            this.btnFilmBul.TabIndex = 10;
            this.btnFilmBul.Text = "...";
            this.btnFilmBul.UseVisualStyleBackColor = true;
            this.btnFilmBul.Click += new System.EventHandler(this.btnFilmBul_Click);
            // 
            // txtFilm
            // 
            this.txtFilm.Location = new System.Drawing.Point(377, 39);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.ReadOnly = true;
            this.txtFilm.Size = new System.Drawing.Size(104, 20);
            this.txtFilm.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Film Bul :";
            // 
            // lvSatislar
            // 
            this.lvSatislar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvSatislar.FullRowSelect = true;
            this.lvSatislar.Location = new System.Drawing.Point(16, 120);
            this.lvSatislar.Name = "lvSatislar";
            this.lvSatislar.Size = new System.Drawing.Size(582, 337);
            this.lvSatislar.TabIndex = 46;
            this.lvSatislar.UseCompatibleStateImageBehavior = false;
            this.lvSatislar.View = System.Windows.Forms.View.Details;
            this.lvSatislar.DoubleClick += new System.EventHandler(this.lvSatislar_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Satış Tarihi";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "FilmNo";
            this.columnHeader3.Width = 1;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Film Adı";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Miktar";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "MusteriNo";
            this.columnHeader6.Width = 1;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Müşteri";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Fiyat";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Adet";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tutar";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(513, 91);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 23);
            this.btnSil.TabIndex = 50;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Location = new System.Drawing.Point(422, 91);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(85, 23);
            this.btnDegistir.TabIndex = 49;
            this.btnDegistir.Text = "Değistir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(331, 91);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 23);
            this.btnKaydet.TabIndex = 48;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(16, 91);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(85, 23);
            this.btnYeni.TabIndex = 47;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(107, 93);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(53, 20);
            this.txtAdet.TabIndex = 51;
            this.txtAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdet.TextChanged += new System.EventHandler(this.txtAdet_TextChanged);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(225, 93);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.ReadOnly = true;
            this.txtTutar.Size = new System.Drawing.Size(53, 20);
            this.txtTutar.TabIndex = 52;
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(166, 93);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(53, 20);
            this.txtFiyat.TabIndex = 53;
            this.txtFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiyat.TextChanged += new System.EventHandler(this.txtFiyat_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Adet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Fiyat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Tutar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(518, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "Satis No :";
            // 
            // txtSatisNo
            // 
            this.txtSatisNo.Location = new System.Drawing.Point(573, 10);
            this.txtSatisNo.Name = "txtSatisNo";
            this.txtSatisNo.ReadOnly = true;
            this.txtSatisNo.Size = new System.Drawing.Size(26, 20);
            this.txtSatisNo.TabIndex = 57;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(546, 466);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(53, 20);
            this.txtToplamTutar.TabIndex = 61;
            this.txtToplamTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtToplamAdet
            // 
            this.txtToplamAdet.Location = new System.Drawing.Point(487, 466);
            this.txtToplamAdet.Name = "txtToplamAdet";
            this.txtToplamAdet.Size = new System.Drawing.Size(53, 20);
            this.txtToplamAdet.TabIndex = 60;
            this.txtToplamAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 469);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "Toplam :";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(573, 65);
            this.txtStok.Name = "txtStok";
            this.txtStok.ReadOnly = true;
            this.txtStok.Size = new System.Drawing.Size(26, 20);
            this.txtStok.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(518, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 64;
            this.label11.Text = "Stok :";
            // 
            // frmFilmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 499);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtToplamAdet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSatisNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.lvSatislar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFilmNo);
            this.Controls.Add(this.btnFilmBul);
            this.Controls.Add(this.txtFilm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMusteriNo);
            this.Controls.Add(this.btnMusteriBul);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFilmSatis";
            this.Text = "frmFilmSatis";
            this.Load += new System.EventHandler(this.frmFilmSatis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMusteriBul;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilmNo;
        private System.Windows.Forms.Button btnFilmBul;
        private System.Windows.Forms.TextBox txtFilm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvSatislar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSatisNo;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.TextBox txtToplamAdet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label11;
    }
}