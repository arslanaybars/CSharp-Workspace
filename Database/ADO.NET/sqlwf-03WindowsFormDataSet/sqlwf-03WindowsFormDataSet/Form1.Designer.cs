namespace sqlwf_03WindowsFormDataSet
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
            this.btnGetir = new System.Windows.Forms.Button();
            this.dgvFilmler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(322, 12);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(177, 23);
            this.btnGetir.TabIndex = 0;
            this.btnGetir.Text = "Filmleri Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // dgvFilmler
            // 
            this.dgvFilmler.AllowUserToOrderColumns = true;
            this.dgvFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmler.Location = new System.Drawing.Point(12, 41);
            this.dgvFilmler.Name = "dgvFilmler";
            this.dgvFilmler.Size = new System.Drawing.Size(796, 359);
            this.dgvFilmler.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 419);
            this.Controls.Add(this.dgvFilmler);
            this.Controls.Add(this.btnGetir);
            this.Name = "Form1";
            this.Text = "Dissconected Access (Bağlantısız Erişim)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.DataGridView dgvFilmler;
    }
}

