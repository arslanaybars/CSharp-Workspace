namespace sqlwf_10EntityDataModel
{
    partial class form1
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
            this.btnMusterileriGetir = new System.Windows.Forms.Button();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMusterileriGetir
            // 
            this.btnMusterileriGetir.Location = new System.Drawing.Point(155, 12);
            this.btnMusterileriGetir.Name = "btnMusterileriGetir";
            this.btnMusterileriGetir.Size = new System.Drawing.Size(193, 23);
            this.btnMusterileriGetir.TabIndex = 0;
            this.btnMusterileriGetir.Text = "Müşterileri Getir";
            this.btnMusterileriGetir.UseVisualStyleBackColor = true;
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Location = new System.Drawing.Point(12, 41);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.Size = new System.Drawing.Size(488, 282);
            this.dgvMusteriler.TabIndex = 1;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 335);
            this.Controls.Add(this.dgvMusteriler);
            this.Controls.Add(this.btnMusterileriGetir);
            this.Name = "form1";
            this.Text = "Entity Data Model";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusterileriGetir;
        private System.Windows.Forms.DataGridView dgvMusteriler;
    }
}

