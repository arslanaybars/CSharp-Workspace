namespace wf_19TextYazmaOkuma
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtYeniSatir = new System.Windows.Forms.TextBox();
            this.btnYaz = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnOku = new System.Windows.Forms.Button();
            this.btnHepsiniOku = new System.Windows.Forms.Button();
            this.lblMetin = new System.Windows.Forms.Label();
            this.txtMetin = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yeni Satır : ";
            // 
            // txtYeniSatir
            // 
            this.txtYeniSatir.Location = new System.Drawing.Point(81, 13);
            this.txtYeniSatir.Name = "txtYeniSatir";
            this.txtYeniSatir.Size = new System.Drawing.Size(249, 20);
            this.txtYeniSatir.TabIndex = 1;
            // 
            // btnYaz
            // 
            this.btnYaz.Location = new System.Drawing.Point(12, 51);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(75, 23);
            this.btnYaz.TabIndex = 2;
            this.btnYaz.Text = "Yaz";
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(93, 51);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnOku
            // 
            this.btnOku.Location = new System.Drawing.Point(174, 51);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(75, 23);
            this.btnOku.TabIndex = 4;
            this.btnOku.Text = "Oku";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // btnHepsiniOku
            // 
            this.btnHepsiniOku.Location = new System.Drawing.Point(255, 51);
            this.btnHepsiniOku.Name = "btnHepsiniOku";
            this.btnHepsiniOku.Size = new System.Drawing.Size(75, 23);
            this.btnHepsiniOku.TabIndex = 5;
            this.btnHepsiniOku.Text = "Hepsini Oku";
            this.btnHepsiniOku.UseVisualStyleBackColor = true;
            this.btnHepsiniOku.Click += new System.EventHandler(this.btnHepsiniOku_Click);
            // 
            // lblMetin
            // 
            this.lblMetin.AutoSize = true;
            this.lblMetin.Location = new System.Drawing.Point(13, 96);
            this.lblMetin.Name = "lblMetin";
            this.lblMetin.Size = new System.Drawing.Size(42, 13);
            this.lblMetin.TabIndex = 6;
            this.lblMetin.Text = "Metin : ";
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(81, 96);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(246, 205);
            this.txtMetin.TabIndex = 7;
            this.txtMetin.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 316);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.lblMetin);
            this.Controls.Add(this.btnHepsiniOku);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnYaz);
            this.Controls.Add(this.txtYeniSatir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Text Dosyalarına Yazma ve Okuma İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYeniSatir;
        private System.Windows.Forms.Button btnYaz;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnOku;
        private System.Windows.Forms.Button btnHepsiniOku;
        private System.Windows.Forms.Label lblMetin;
        private System.Windows.Forms.RichTextBox txtMetin;

    }
}

