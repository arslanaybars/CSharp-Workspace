namespace wf_09ListBox
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
            this.lbListe = new System.Windows.Forms.ListBox();
            this.txtGirilen = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSilme = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnArayaEkle = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.btnForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbListe
            // 
            this.lbListe.FormattingEnabled = true;
            this.lbListe.Items.AddRange(new object[] {
            "hasan",
            "vedat",
            "necati"});
            this.lbListe.Location = new System.Drawing.Point(80, 13);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(141, 238);
            this.lbListe.TabIndex = 0;
            // 
            // txtGirilen
            // 
            this.txtGirilen.Location = new System.Drawing.Point(80, 258);
            this.txtGirilen.Name = "txtGirilen";
            this.txtGirilen.Size = new System.Drawing.Size(141, 20);
            this.txtGirilen.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(80, 284);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(141, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSilme
            // 
            this.btnSilme.Location = new System.Drawing.Point(80, 313);
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(141, 23);
            this.btnSilme.TabIndex = 3;
            this.btnSilme.Text = "Sil";
            this.btnSilme.UseVisualStyleBackColor = true;
            this.btnSilme.Click += new System.EventHandler(this.btnSilme_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(80, 343);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(141, 23);
            this.btnBul.TabIndex = 4;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnArayaEkle
            // 
            this.btnArayaEkle.Location = new System.Drawing.Point(80, 372);
            this.btnArayaEkle.Name = "btnArayaEkle";
            this.btnArayaEkle.Size = new System.Drawing.Size(141, 23);
            this.btnArayaEkle.TabIndex = 5;
            this.btnArayaEkle.Text = "Araya Ekle";
            this.btnArayaEkle.UseVisualStyleBackColor = true;
            this.btnArayaEkle.Click += new System.EventHandler(this.btnArayaEkle_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(80, 401);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(141, 23);
            this.btnForm2.TabIndex = 6;
            this.btnForm2.Text = "Form2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // btnForm3
            // 
            this.btnForm3.Location = new System.Drawing.Point(80, 430);
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(141, 23);
            this.btnForm3.TabIndex = 7;
            this.btnForm3.Text = "Form3";
            this.btnForm3.UseVisualStyleBackColor = true;
            this.btnForm3.Click += new System.EventHandler(this.btnForm3_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 531);
            this.Controls.Add(this.btnForm3);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.btnArayaEkle);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnSilme);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtGirilen);
            this.Controls.Add(this.lbListe);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ListBox Örnek";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbListe;
        private System.Windows.Forms.TextBox txtGirilen;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSilme;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnArayaEkle;
        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.Button btnForm3;
    }
}

