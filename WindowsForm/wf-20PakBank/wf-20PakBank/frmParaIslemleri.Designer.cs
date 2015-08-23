namespace wf_20PakBank
{
    partial class frmParaIslemleri
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
            this.txtIslemTarihi = new System.Windows.Forms.TextBox();
            this.lblIslemTarihi = new System.Windows.Forms.Label();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.txtHesapID = new System.Windows.Forms.TextBox();
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.lblHesapID = new System.Windows.Forms.Label();
            this.cbIslemTurleri = new System.Windows.Forms.ComboBox();
            this.lblİslemTuru = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lbTutar = new System.Windows.Forms.Label();
            this.btnTamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIslemTarihi
            // 
            this.txtIslemTarihi.Location = new System.Drawing.Point(100, 76);
            this.txtIslemTarihi.Name = "txtIslemTarihi";
            this.txtIslemTarihi.ReadOnly = true;
            this.txtIslemTarihi.Size = new System.Drawing.Size(152, 20);
            this.txtIslemTarihi.TabIndex = 15;
            // 
            // lblIslemTarihi
            // 
            this.lblIslemTarihi.AutoSize = true;
            this.lblIslemTarihi.Location = new System.Drawing.Point(24, 79);
            this.lblIslemTarihi.Name = "lblIslemTarihi";
            this.lblIslemTarihi.Size = new System.Drawing.Size(66, 13);
            this.lblIslemTarihi.TabIndex = 14;
            this.lblIslemTarihi.Text = "Açılış Tarihi :";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(100, 44);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.ReadOnly = true;
            this.txtHesapNo.Size = new System.Drawing.Size(152, 20);
            this.txtHesapNo.TabIndex = 13;
            // 
            // txtHesapID
            // 
            this.txtHesapID.Location = new System.Drawing.Point(100, 12);
            this.txtHesapID.Name = "txtHesapID";
            this.txtHesapID.ReadOnly = true;
            this.txtHesapID.Size = new System.Drawing.Size(152, 20);
            this.txtHesapID.TabIndex = 12;
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.Location = new System.Drawing.Point(24, 47);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(61, 13);
            this.lblHesapNo.TabIndex = 11;
            this.lblHesapNo.Text = "Hesap No :";
            // 
            // lblHesapID
            // 
            this.lblHesapID.AutoSize = true;
            this.lblHesapID.Location = new System.Drawing.Point(24, 15);
            this.lblHesapID.Name = "lblHesapID";
            this.lblHesapID.Size = new System.Drawing.Size(58, 13);
            this.lblHesapID.TabIndex = 10;
            this.lblHesapID.Text = "Hesap ID :";
            // 
            // cbIslemTurleri
            // 
            this.cbIslemTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIslemTurleri.FormattingEnabled = true;
            this.cbIslemTurleri.Items.AddRange(new object[] {
            "yatan",
            "cekilen"});
            this.cbIslemTurleri.Location = new System.Drawing.Point(100, 148);
            this.cbIslemTurleri.Name = "cbIslemTurleri";
            this.cbIslemTurleri.Size = new System.Drawing.Size(152, 21);
            this.cbIslemTurleri.TabIndex = 17;
            // 
            // lblİslemTuru
            // 
            this.lblİslemTuru.AutoSize = true;
            this.lblİslemTuru.Location = new System.Drawing.Point(24, 151);
            this.lblİslemTuru.Name = "lblİslemTuru";
            this.lblİslemTuru.Size = new System.Drawing.Size(62, 13);
            this.lblİslemTuru.TabIndex = 16;
            this.lblİslemTuru.Text = "İşlem Türü :";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(100, 111);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(152, 20);
            this.txtTutar.TabIndex = 19;
            // 
            // lbTutar
            // 
            this.lbTutar.AutoSize = true;
            this.lbTutar.Location = new System.Drawing.Point(24, 114);
            this.lbTutar.Name = "lbTutar";
            this.lbTutar.Size = new System.Drawing.Size(41, 13);
            this.lbTutar.TabIndex = 18;
            this.lbTutar.Text = "Tutar : ";
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(100, 186);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(152, 23);
            this.btnTamam.TabIndex = 20;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // frmParaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(284, 230);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.lbTutar);
            this.Controls.Add(this.cbIslemTurleri);
            this.Controls.Add(this.lblİslemTuru);
            this.Controls.Add(this.txtIslemTarihi);
            this.Controls.Add(this.lblIslemTarihi);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.txtHesapID);
            this.Controls.Add(this.lblHesapNo);
            this.Controls.Add(this.lblHesapID);
            this.Name = "frmParaIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para İşlemleri";
            this.Load += new System.EventHandler(this.frmParaIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIslemTarihi;
        private System.Windows.Forms.Label lblIslemTarihi;
        private System.Windows.Forms.Label lblHesapNo;
        private System.Windows.Forms.Label lblHesapID;
        private System.Windows.Forms.ComboBox cbIslemTurleri;
        private System.Windows.Forms.Label lblİslemTuru;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label lbTutar;
        private System.Windows.Forms.Button btnTamam;
        public System.Windows.Forms.TextBox txtHesapNo;
        public System.Windows.Forms.TextBox txtHesapID;
    }
}