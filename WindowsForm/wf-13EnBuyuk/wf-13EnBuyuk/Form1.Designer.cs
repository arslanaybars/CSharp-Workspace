namespace wf_13EnBuyuk
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
            this.lblEnBuyuk = new System.Windows.Forms.Label();
            this.txtEnBuyuk = new System.Windows.Forms.TextBox();
            this.txtEnKucuk = new System.Windows.Forms.TextBox();
            this.lblEnKucuk = new System.Windows.Forms.Label();
            this.txtEnKucukOgrenci = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtEnBuyukOgrenci = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnBuyuk
            // 
            this.lblEnBuyuk.AutoSize = true;
            this.lblEnBuyuk.Location = new System.Drawing.Point(12, 9);
            this.lblEnBuyuk.Name = "lblEnBuyuk";
            this.lblEnBuyuk.Size = new System.Drawing.Size(53, 13);
            this.lblEnBuyuk.TabIndex = 0;
            this.lblEnBuyuk.Text = "En Büyük";
            // 
            // txtEnBuyuk
            // 
            this.txtEnBuyuk.Location = new System.Drawing.Point(12, 25);
            this.txtEnBuyuk.Name = "txtEnBuyuk";
            this.txtEnBuyuk.Size = new System.Drawing.Size(100, 20);
            this.txtEnBuyuk.TabIndex = 1;
            // 
            // txtEnKucuk
            // 
            this.txtEnKucuk.Location = new System.Drawing.Point(12, 70);
            this.txtEnKucuk.Name = "txtEnKucuk";
            this.txtEnKucuk.Size = new System.Drawing.Size(100, 20);
            this.txtEnKucuk.TabIndex = 3;
            // 
            // lblEnKucuk
            // 
            this.lblEnKucuk.AutoSize = true;
            this.lblEnKucuk.Location = new System.Drawing.Point(12, 54);
            this.lblEnKucuk.Name = "lblEnKucuk";
            this.lblEnKucuk.Size = new System.Drawing.Size(54, 13);
            this.lblEnKucuk.TabIndex = 2;
            this.lblEnKucuk.Text = "En Küçük";
            // 
            // txtEnKucukOgrenci
            // 
            this.txtEnKucukOgrenci.Location = new System.Drawing.Point(132, 70);
            this.txtEnKucukOgrenci.Name = "txtEnKucukOgrenci";
            this.txtEnKucukOgrenci.Size = new System.Drawing.Size(100, 20);
            this.txtEnKucukOgrenci.TabIndex = 7;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(132, 54);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 13);
            this.lbl.TabIndex = 6;
            // 
            // txtEnBuyukOgrenci
            // 
            this.txtEnBuyukOgrenci.Location = new System.Drawing.Point(132, 25);
            this.txtEnBuyukOgrenci.Name = "txtEnBuyukOgrenci";
            this.txtEnBuyukOgrenci.Size = new System.Drawing.Size(100, 20);
            this.txtEnBuyukOgrenci.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alan Öğrenci";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Alan Öğrenci";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnKucukOgrenci);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtEnBuyukOgrenci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEnKucuk);
            this.Controls.Add(this.lblEnKucuk);
            this.Controls.Add(this.txtEnBuyuk);
            this.Controls.Add(this.lblEnBuyuk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnBuyuk;
        private System.Windows.Forms.TextBox txtEnBuyuk;
        private System.Windows.Forms.TextBox txtEnKucuk;
        private System.Windows.Forms.Label lblEnKucuk;
        private System.Windows.Forms.TextBox txtEnKucukOgrenci;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtEnBuyukOgrenci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

