namespace wf_23Kutuphane
{
    partial class frmRaporlama
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
            this.cbYayinEvleri = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbYazarlar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKitapTurleri = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSorgulama = new System.Windows.Forms.Button();
            this.lvDetaylar = new System.Windows.Forms.ListView();
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnYaziciyaGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbYayinEvleri
            // 
            this.cbYayinEvleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYayinEvleri.FormattingEnabled = true;
            this.cbYayinEvleri.Location = new System.Drawing.Point(424, 40);
            this.cbYayinEvleri.Name = "cbYayinEvleri";
            this.cbYayinEvleri.Size = new System.Drawing.Size(180, 21);
            this.cbYayinEvleri.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Yayınevleri : ";
            // 
            // cbYazarlar
            // 
            this.cbYazarlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYazarlar.FormattingEnabled = true;
            this.cbYazarlar.Location = new System.Drawing.Point(222, 40);
            this.cbYazarlar.Name = "cbYazarlar";
            this.cbYazarlar.Size = new System.Drawing.Size(180, 21);
            this.cbYazarlar.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Kitap Yazarı :";
            // 
            // cbKitapTurleri
            // 
            this.cbKitapTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKitapTurleri.FormattingEnabled = true;
            this.cbKitapTurleri.Location = new System.Drawing.Point(12, 40);
            this.cbKitapTurleri.Name = "cbKitapTurleri";
            this.cbKitapTurleri.Size = new System.Drawing.Size(180, 21);
            this.cbKitapTurleri.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Kitap Türü :";
            // 
            // btnSorgulama
            // 
            this.btnSorgulama.Location = new System.Drawing.Point(222, 77);
            this.btnSorgulama.Name = "btnSorgulama";
            this.btnSorgulama.Size = new System.Drawing.Size(180, 23);
            this.btnSorgulama.TabIndex = 25;
            this.btnSorgulama.Text = "Detaylı Sorgulama";
            this.btnSorgulama.UseVisualStyleBackColor = true;
            // 
            // lvDetaylar
            // 
            this.lvDetaylar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvDetaylar.Location = new System.Drawing.Point(12, 127);
            this.lvDetaylar.Name = "lvDetaylar";
            this.lvDetaylar.Size = new System.Drawing.Size(592, 298);
            this.lvDetaylar.TabIndex = 26;
            this.lvDetaylar.UseCompatibleStateImageBehavior = false;
            this.lvDetaylar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kitap Adı";
            this.columnHeader2.Width = 113;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kitap Türü";
            this.columnHeader3.Width = 103;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yazar";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Yayın Evi";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Basım Tarihi";
            this.columnHeader6.Width = 100;
            // 
            // btnYaziciyaGonder
            // 
            this.btnYaziciyaGonder.Location = new System.Drawing.Point(222, 443);
            this.btnYaziciyaGonder.Name = "btnYaziciyaGonder";
            this.btnYaziciyaGonder.Size = new System.Drawing.Size(180, 23);
            this.btnYaziciyaGonder.TabIndex = 27;
            this.btnYaziciyaGonder.Text = "Yazıcıya Gönder";
            this.btnYaziciyaGonder.UseVisualStyleBackColor = true;
            // 
            // frmRaporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 478);
            this.Controls.Add(this.btnYaziciyaGonder);
            this.Controls.Add(this.lvDetaylar);
            this.Controls.Add(this.btnSorgulama);
            this.Controls.Add(this.cbYayinEvleri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbYazarlar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbKitapTurleri);
            this.Controls.Add(this.label3);
            this.Name = "frmRaporlama";
            this.Text = "frmRaporlama";
            this.Load += new System.EventHandler(this.frmRaporlama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbYayinEvleri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbYazarlar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKitapTurleri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSorgulama;
        private System.Windows.Forms.ListView lvDetaylar;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnYaziciyaGonder;
    }
}