namespace sqlwf_09LinqToSqlVideo
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
            this.dgvFilmler = new System.Windows.Forms.DataGridView();
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilmNo = new System.Windows.Forms.TextBox();
            this.txtFilmTurNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilmTuru = new System.Windows.Forms.TextBox();
            this.cbFilmTurleri = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYonetmen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOyuncular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOzet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxVarmi = new System.Windows.Forms.CheckBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFilmler
            // 
            this.dgvFilmler.AllowUserToAddRows = false;
            this.dgvFilmler.AllowUserToDeleteRows = false;
            this.dgvFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmler.Location = new System.Drawing.Point(261, 12);
            this.dgvFilmler.Name = "dgvFilmler";
            this.dgvFilmler.ReadOnly = true;
            this.dgvFilmler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmler.Size = new System.Drawing.Size(752, 489);
            this.dgvFilmler.TabIndex = 0;
            this.dgvFilmler.DoubleClick += new System.EventHandler(this.dgvFilmler_DoubleClick);
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Location = new System.Drawing.Point(69, 12);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(138, 20);
            this.txtFilmAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Film Adi";
            // 
            // txtFilmNo
            // 
            this.txtFilmNo.Location = new System.Drawing.Point(213, 12);
            this.txtFilmNo.Name = "txtFilmNo";
            this.txtFilmNo.ReadOnly = true;
            this.txtFilmNo.Size = new System.Drawing.Size(21, 20);
            this.txtFilmNo.TabIndex = 3;
            // 
            // txtFilmTurNo
            // 
            this.txtFilmTurNo.Location = new System.Drawing.Point(213, 38);
            this.txtFilmTurNo.Name = "txtFilmTurNo";
            this.txtFilmTurNo.ReadOnly = true;
            this.txtFilmTurNo.Size = new System.Drawing.Size(21, 20);
            this.txtFilmTurNo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Film Turu";
            // 
            // txtFilmTuru
            // 
            this.txtFilmTuru.Location = new System.Drawing.Point(69, 38);
            this.txtFilmTuru.Name = "txtFilmTuru";
            this.txtFilmTuru.ReadOnly = true;
            this.txtFilmTuru.Size = new System.Drawing.Size(123, 20);
            this.txtFilmTuru.TabIndex = 4;
            // 
            // cbFilmTurleri
            // 
            this.cbFilmTurleri.DropDownHeight = 100;
            this.cbFilmTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilmTurleri.DropDownWidth = 100;
            this.cbFilmTurleri.FormattingEnabled = true;
            this.cbFilmTurleri.IntegralHeight = false;
            this.cbFilmTurleri.Location = new System.Drawing.Point(190, 37);
            this.cbFilmTurleri.Name = "cbFilmTurleri";
            this.cbFilmTurleri.Size = new System.Drawing.Size(19, 21);
            this.cbFilmTurleri.TabIndex = 7;
            this.cbFilmTurleri.SelectedIndexChanged += new System.EventHandler(this.cbFilmTurleri_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yönetmen";
            // 
            // txtYonetmen
            // 
            this.txtYonetmen.Location = new System.Drawing.Point(69, 64);
            this.txtYonetmen.Name = "txtYonetmen";
            this.txtYonetmen.Size = new System.Drawing.Size(138, 20);
            this.txtYonetmen.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Oyuncular";
            // 
            // txtOyuncular
            // 
            this.txtOyuncular.Location = new System.Drawing.Point(69, 90);
            this.txtOyuncular.Multiline = true;
            this.txtOyuncular.Name = "txtOyuncular";
            this.txtOyuncular.Size = new System.Drawing.Size(138, 48);
            this.txtOyuncular.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Özet";
            // 
            // txtOzet
            // 
            this.txtOzet.Location = new System.Drawing.Point(69, 144);
            this.txtOzet.Multiline = true;
            this.txtOzet.Name = "txtOzet";
            this.txtOzet.Size = new System.Drawing.Size(138, 48);
            this.txtOzet.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Miktar";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(69, 198);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.ReadOnly = true;
            this.txtMiktar.Size = new System.Drawing.Size(138, 20);
            this.txtMiktar.TabIndex = 14;
            this.txtMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Varmı";
            // 
            // cbxVarmi
            // 
            this.cbxVarmi.AutoSize = true;
            this.cbxVarmi.Location = new System.Drawing.Point(69, 230);
            this.cbxVarmi.Name = "cbxVarmi";
            this.cbxVarmi.Size = new System.Drawing.Size(15, 14);
            this.cbxVarmi.TabIndex = 17;
            this.cbxVarmi.UseVisualStyleBackColor = true;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(15, 268);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(51, 23);
            this.btnYeni.TabIndex = 18;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(72, 268);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(51, 23);
            this.btnKaydet.TabIndex = 19;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Location = new System.Drawing.Point(129, 268);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(51, 23);
            this.btnDegistir.TabIndex = 20;
            this.btnDegistir.Text = "Degistir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(190, 268);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(51, 23);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1029, 511);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.cbxVarmi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOzet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOyuncular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYonetmen);
            this.Controls.Add(this.cbFilmTurleri);
            this.Controls.Add(this.txtFilmTurNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilmTuru);
            this.Controls.Add(this.txtFilmNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilmAdi);
            this.Controls.Add(this.dgvFilmler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFilmler;
        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilmNo;
        private System.Windows.Forms.TextBox txtFilmTurNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilmTuru;
        private System.Windows.Forms.ComboBox cbFilmTurleri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYonetmen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOyuncular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOzet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbxVarmi;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnSil;
    }
}

