namespace wf_03PiSayisi
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
            this.txtR = new System.Windows.Forms.TextBox();
            this.lblR = new System.Windows.Forms.Label();
            this.btnCevre = new System.Windows.Forms.Button();
            this.btnAlan = new System.Windows.Forms.Button();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.rbCevre = new System.Windows.Forms.RadioButton();
            this.rbAlan = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(31, 36);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(220, 20);
            this.txtR.TabIndex = 0;
            this.txtR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(28, 20);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(52, 13);
            this.lblR.TabIndex = 1;
            this.lblR.Text = "Yarıçap : ";
            // 
            // btnCevre
            // 
            this.btnCevre.Location = new System.Drawing.Point(31, 147);
            this.btnCevre.Name = "btnCevre";
            this.btnCevre.Size = new System.Drawing.Size(102, 23);
            this.btnCevre.TabIndex = 2;
            this.btnCevre.Text = "Cevre";
            this.btnCevre.UseVisualStyleBackColor = true;
            this.btnCevre.Visible = false;
            this.btnCevre.Click += new System.EventHandler(this.btnCevre_Click);
            // 
            // btnAlan
            // 
            this.btnAlan.Location = new System.Drawing.Point(139, 147);
            this.btnAlan.Name = "btnAlan";
            this.btnAlan.Size = new System.Drawing.Size(112, 23);
            this.btnAlan.TabIndex = 3;
            this.btnAlan.Text = "Alan";
            this.btnAlan.UseVisualStyleBackColor = true;
            this.btnAlan.Visible = false;
            this.btnAlan.Click += new System.EventHandler(this.btnAlan_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(31, 121);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.ReadOnly = true;
            this.txtSonuc.Size = new System.Drawing.Size(220, 20);
            this.txtSonuc.TabIndex = 4;
            this.txtSonuc.Text = "Sonuc";
            this.txtSonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(31, 62);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(220, 23);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // rbCevre
            // 
            this.rbCevre.AutoSize = true;
            this.rbCevre.Checked = true;
            this.rbCevre.Location = new System.Drawing.Point(31, 98);
            this.rbCevre.Name = "rbCevre";
            this.rbCevre.Size = new System.Drawing.Size(102, 17);
            this.rbCevre.TabIndex = 6;
            this.rbCevre.TabStop = true;
            this.rbCevre.Text = "Dairenin Çevresi";
            this.rbCevre.UseVisualStyleBackColor = true;
            // 
            // rbAlan
            // 
            this.rbAlan.AutoSize = true;
            this.rbAlan.Location = new System.Drawing.Point(161, 98);
            this.rbAlan.Name = "rbAlan";
            this.rbAlan.Size = new System.Drawing.Size(90, 17);
            this.rbAlan.TabIndex = 7;
            this.rbAlan.TabStop = true;
            this.rbAlan.Text = "Dairenin Alanı";
            this.rbAlan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(280, 195);
            this.Controls.Add(this.rbAlan);
            this.Controls.Add(this.rbCevre);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.btnAlan);
            this.Controls.Add(this.btnCevre);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.txtR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Button btnCevre;
        private System.Windows.Forms.Button btnAlan;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.RadioButton rbCevre;
        private System.Windows.Forms.RadioButton rbAlan;
    }
}

