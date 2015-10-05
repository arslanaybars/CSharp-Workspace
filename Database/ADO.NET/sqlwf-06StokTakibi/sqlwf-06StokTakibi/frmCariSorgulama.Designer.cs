namespace sqlwf_06StokTakibi
{
    partial class frmCariSorgulama
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
            this.dgvCariler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnvanaGore = new System.Windows.Forms.TextBox();
            this.rbAlici = new System.Windows.Forms.RadioButton();
            this.rbSatici = new System.Windows.Forms.RadioButton();
            this.rbTumu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCariler
            // 
            this.dgvCariler.AllowUserToAddRows = false;
            this.dgvCariler.AllowUserToDeleteRows = false;
            this.dgvCariler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCariler.Location = new System.Drawing.Point(12, 210);
            this.dgvCariler.Name = "dgvCariler";
            this.dgvCariler.ReadOnly = true;
            this.dgvCariler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCariler.Size = new System.Drawing.Size(739, 282);
            this.dgvCariler.TabIndex = 0;
            this.dgvCariler.DoubleClick += new System.EventHandler(this.dgvCariler_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ünvana Göre Arama";
            // 
            // txtUnvanaGore
            // 
            this.txtUnvanaGore.Location = new System.Drawing.Point(12, 184);
            this.txtUnvanaGore.Name = "txtUnvanaGore";
            this.txtUnvanaGore.Size = new System.Drawing.Size(100, 20);
            this.txtUnvanaGore.TabIndex = 2;
            // 
            // rbAlici
            // 
            this.rbAlici.AutoSize = true;
            this.rbAlici.Location = new System.Drawing.Point(133, 185);
            this.rbAlici.Name = "rbAlici";
            this.rbAlici.Size = new System.Drawing.Size(55, 17);
            this.rbAlici.TabIndex = 3;
            this.rbAlici.TabStop = true;
            this.rbAlici.Text = "Alıcılar";
            this.rbAlici.UseVisualStyleBackColor = true;
            this.rbAlici.CheckedChanged += new System.EventHandler(this.rbAlici_CheckedChanged);
            // 
            // rbSatici
            // 
            this.rbSatici.AutoSize = true;
            this.rbSatici.Location = new System.Drawing.Point(194, 185);
            this.rbSatici.Name = "rbSatici";
            this.rbSatici.Size = new System.Drawing.Size(62, 17);
            this.rbSatici.TabIndex = 4;
            this.rbSatici.TabStop = true;
            this.rbSatici.Text = "Satıcılar";
            this.rbSatici.UseVisualStyleBackColor = true;
            this.rbSatici.CheckedChanged += new System.EventHandler(this.rbSaticilar_CheckedChanged);
            // 
            // rbTumu
            // 
            this.rbTumu.AutoSize = true;
            this.rbTumu.Location = new System.Drawing.Point(262, 185);
            this.rbTumu.Name = "rbTumu";
            this.rbTumu.Size = new System.Drawing.Size(85, 17);
            this.rbTumu.TabIndex = 5;
            this.rbTumu.TabStop = true;
            this.rbTumu.Text = "Tüm Firmalar";
            this.rbTumu.UseVisualStyleBackColor = true;
            this.rbTumu.CheckedChanged += new System.EventHandler(this.rbTumu_CheckedChanged);
            // 
            // frmCariSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(763, 504);
            this.Controls.Add(this.rbTumu);
            this.Controls.Add(this.rbSatici);
            this.Controls.Add(this.rbAlici);
            this.Controls.Add(this.txtUnvanaGore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCariler);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCariSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müteri Cari Sorgulama";
            this.Load += new System.EventHandler(this.frmCariSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCariler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnvanaGore;
        private System.Windows.Forms.RadioButton rbAlici;
        private System.Windows.Forms.RadioButton rbSatici;
        private System.Windows.Forms.RadioButton rbTumu;
    }
}