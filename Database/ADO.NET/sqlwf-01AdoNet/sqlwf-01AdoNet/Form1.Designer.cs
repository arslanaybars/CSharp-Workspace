namespace sqlwf_01AdoNet
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
            this.lblFilmNo = new System.Windows.Forms.Label();
            this.txtFilmNo = new System.Windows.Forms.TextBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.btnFilmNoGetir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFilmNo
            // 
            this.lblFilmNo.AutoSize = true;
            this.lblFilmNo.Location = new System.Drawing.Point(13, 13);
            this.lblFilmNo.Name = "lblFilmNo";
            this.lblFilmNo.Size = new System.Drawing.Size(42, 13);
            this.lblFilmNo.TabIndex = 0;
            this.lblFilmNo.Text = "Film No";
            // 
            // txtFilmNo
            // 
            this.txtFilmNo.Location = new System.Drawing.Point(13, 30);
            this.txtFilmNo.Name = "txtFilmNo";
            this.txtFilmNo.Size = new System.Drawing.Size(100, 20);
            this.txtFilmNo.TabIndex = 1;
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(13, 57);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(206, 23);
            this.btnGetir.TabIndex = 2;
            this.btnGetir.Text = "Film Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Location = new System.Drawing.Point(119, 30);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(100, 20);
            this.txtFilmAdi.TabIndex = 4;
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.AutoSize = true;
            this.lblFilmAdi.Location = new System.Drawing.Point(119, 13);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(43, 13);
            this.lblFilmAdi.TabIndex = 3;
            this.lblFilmAdi.Text = "Film Adı";
            // 
            // btnFilmNoGetir
            // 
            this.btnFilmNoGetir.Location = new System.Drawing.Point(13, 86);
            this.btnFilmNoGetir.Name = "btnFilmNoGetir";
            this.btnFilmNoGetir.Size = new System.Drawing.Size(206, 23);
            this.btnFilmNoGetir.TabIndex = 5;
            this.btnFilmNoGetir.Text = "Film No Getir";
            this.btnFilmNoGetir.UseVisualStyleBackColor = true;
            this.btnFilmNoGetir.Click += new System.EventHandler(this.btnFilmNoGetir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 261);
            this.Controls.Add(this.btnFilmNoGetir);
            this.Controls.Add(this.txtFilmAdi);
            this.Controls.Add(this.lblFilmAdi);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.txtFilmNo);
            this.Controls.Add(this.lblFilmNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilmNo;
        private System.Windows.Forms.TextBox txtFilmNo;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.Label lblFilmAdi;
        private System.Windows.Forms.Button btnFilmNoGetir;
    }
}

