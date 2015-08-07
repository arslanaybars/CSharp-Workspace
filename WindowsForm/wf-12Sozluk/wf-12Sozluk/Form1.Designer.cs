namespace wf_12Sozluk
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
            this.txtTurkce = new System.Windows.Forms.TextBox();
            this.lblTurkce = new System.Windows.Forms.Label();
            this.lblIngilizce = new System.Windows.Forms.Label();
            this.txtIngilizce = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.rbTurIng = new System.Windows.Forms.RadioButton();
            this.rbIngTur = new System.Windows.Forms.RadioButton();
            this.lbKelimeler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTurkce
            // 
            this.txtTurkce.Location = new System.Drawing.Point(67, 44);
            this.txtTurkce.Name = "txtTurkce";
            this.txtTurkce.Size = new System.Drawing.Size(100, 20);
            this.txtTurkce.TabIndex = 0;
            // 
            // lblTurkce
            // 
            this.lblTurkce.AutoSize = true;
            this.lblTurkce.Location = new System.Drawing.Point(9, 47);
            this.lblTurkce.Name = "lblTurkce";
            this.lblTurkce.Size = new System.Drawing.Size(41, 13);
            this.lblTurkce.TabIndex = 1;
            this.lblTurkce.Text = "Türkçe";
            // 
            // lblIngilizce
            // 
            this.lblIngilizce.AutoSize = true;
            this.lblIngilizce.Location = new System.Drawing.Point(9, 73);
            this.lblIngilizce.Name = "lblIngilizce";
            this.lblIngilizce.Size = new System.Drawing.Size(45, 13);
            this.lblIngilizce.TabIndex = 3;
            this.lblIngilizce.Text = "İngilizce";
            // 
            // txtIngilizce
            // 
            this.txtIngilizce.Location = new System.Drawing.Point(67, 70);
            this.txtIngilizce.Name = "txtIngilizce";
            this.txtIngilizce.ReadOnly = true;
            this.txtIngilizce.Size = new System.Drawing.Size(100, 20);
            this.txtIngilizce.TabIndex = 2;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(186, 44);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 46);
            this.btnBul.TabIndex = 4;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // rbTurIng
            // 
            this.rbTurIng.AutoSize = true;
            this.rbTurIng.Checked = true;
            this.rbTurIng.Location = new System.Drawing.Point(12, 12);
            this.rbTurIng.Name = "rbTurIng";
            this.rbTurIng.Size = new System.Drawing.Size(106, 17);
            this.rbTurIng.TabIndex = 5;
            this.rbTurIng.TabStop = true;
            this.rbTurIng.Text = "Türkçe - İngilizce";
            this.rbTurIng.UseVisualStyleBackColor = true;
            this.rbTurIng.CheckedChanged += new System.EventHandler(this.rbTurIng_CheckedChanged);
            // 
            // rbIngTur
            // 
            this.rbIngTur.AutoSize = true;
            this.rbIngTur.Location = new System.Drawing.Point(149, 12);
            this.rbIngTur.Name = "rbIngTur";
            this.rbIngTur.Size = new System.Drawing.Size(106, 17);
            this.rbIngTur.TabIndex = 6;
            this.rbIngTur.Text = "İngilizce - Türkçe";
            this.rbIngTur.UseVisualStyleBackColor = true;
            this.rbIngTur.CheckedChanged += new System.EventHandler(this.rbIngTur_CheckedChanged);
            // 
            // lbKelimeler
            // 
            this.lbKelimeler.FormattingEnabled = true;
            this.lbKelimeler.Location = new System.Drawing.Point(67, 96);
            this.lbKelimeler.Name = "lbKelimeler";
            this.lbKelimeler.Size = new System.Drawing.Size(100, 173);
            this.lbKelimeler.TabIndex = 7;
            this.lbKelimeler.DoubleClick += new System.EventHandler(this.lbKelimeler_DoubleClick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBul;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(267, 278);
            this.Controls.Add(this.lbKelimeler);
            this.Controls.Add(this.rbIngTur);
            this.Controls.Add(this.rbTurIng);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.lblIngilizce);
            this.Controls.Add(this.txtIngilizce);
            this.Controls.Add(this.lblTurkce);
            this.Controls.Add(this.txtTurkce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Türkçe - İngilzce Sözlük";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTurkce;
        private System.Windows.Forms.Label lblTurkce;
        private System.Windows.Forms.Label lblIngilizce;
        private System.Windows.Forms.TextBox txtIngilizce;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.RadioButton rbTurIng;
        private System.Windows.Forms.RadioButton rbIngTur;
        private System.Windows.Forms.ListBox lbKelimeler;
    }
}

