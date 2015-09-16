namespace sqlwf_02VideoMarket
{
    partial class frmMusteriSorgulama
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
            this.txtAdaGore = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lvMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoyadaGore = new System.Windows.Forms.TextBox();
            this.txtTelefonaGore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdreseGore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAdaGore
            // 
            this.txtAdaGore.Location = new System.Drawing.Point(12, 33);
            this.txtAdaGore.Name = "txtAdaGore";
            this.txtAdaGore.Size = new System.Drawing.Size(115, 20);
            this.txtAdaGore.TabIndex = 28;
            this.txtAdaGore.TextChanged += new System.EventHandler(this.txtAdaGore_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ada Göre";
            // 
            // lvMusteriler
            // 
            this.lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvMusteriler.FullRowSelect = true;
            this.lvMusteriler.Location = new System.Drawing.Point(12, 59);
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(478, 299);
            this.lvMusteriler.TabIndex = 27;
            this.lvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lvMusteriler.View = System.Windows.Forms.View.Details;
            this.lvMusteriler.DoubleClick += new System.EventHandler(this.lvMusteriler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Musteri No";
            this.columnHeader1.Width = 1;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adres";
            this.columnHeader5.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Soyada Göre";
            // 
            // txtSoyadaGore
            // 
            this.txtSoyadaGore.Location = new System.Drawing.Point(133, 33);
            this.txtSoyadaGore.Name = "txtSoyadaGore";
            this.txtSoyadaGore.Size = new System.Drawing.Size(115, 20);
            this.txtSoyadaGore.TabIndex = 32;
            this.txtSoyadaGore.TextChanged += new System.EventHandler(this.txtSoyadaGore_TextChanged);
            // 
            // txtTelefonaGore
            // 
            this.txtTelefonaGore.Location = new System.Drawing.Point(254, 33);
            this.txtTelefonaGore.Name = "txtTelefonaGore";
            this.txtTelefonaGore.Size = new System.Drawing.Size(115, 20);
            this.txtTelefonaGore.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Telefona Göre";
            // 
            // txtAdreseGore
            // 
            this.txtAdreseGore.Location = new System.Drawing.Point(375, 33);
            this.txtAdreseGore.Name = "txtAdreseGore";
            this.txtAdreseGore.Size = new System.Drawing.Size(115, 20);
            this.txtAdreseGore.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Adrese Göre";
            // 
            // frmMusteriSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 375);
            this.Controls.Add(this.txtAdreseGore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefonaGore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoyadaGore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdaGore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lvMusteriler);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMusteriSorgulama";
            this.Text = "Müşteri Sorgulama";
            this.Load += new System.EventHandler(this.frmMusteriSorgulama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdaGore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoyadaGore;
        private System.Windows.Forms.TextBox txtTelefonaGore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdreseGore;
        private System.Windows.Forms.Label label3;
    }
}