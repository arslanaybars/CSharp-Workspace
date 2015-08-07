namespace wf_11Arrays
{
    partial class Form3
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
            this.lbIlkHali = new System.Windows.Forms.ListBox();
            this.lbSonHali = new System.Windows.Forms.ListBox();
            this.lbSıralı = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbIlkHali
            // 
            this.lbIlkHali.FormattingEnabled = true;
            this.lbIlkHali.Location = new System.Drawing.Point(12, 12);
            this.lbIlkHali.Name = "lbIlkHali";
            this.lbIlkHali.Size = new System.Drawing.Size(89, 199);
            this.lbIlkHali.TabIndex = 0;
            // 
            // lbSonHali
            // 
            this.lbSonHali.FormattingEnabled = true;
            this.lbSonHali.Location = new System.Drawing.Point(107, 12);
            this.lbSonHali.Name = "lbSonHali";
            this.lbSonHali.Size = new System.Drawing.Size(89, 199);
            this.lbSonHali.TabIndex = 1;
            // 
            // lbSıralı
            // 
            this.lbSıralı.FormattingEnabled = true;
            this.lbSıralı.Location = new System.Drawing.Point(202, 12);
            this.lbSıralı.Name = "lbSıralı";
            this.lbSıralı.Size = new System.Drawing.Size(89, 199);
            this.lbSıralı.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 217);
            this.Controls.Add(this.lbSıralı);
            this.Controls.Add(this.lbSonHali);
            this.Controls.Add(this.lbIlkHali);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbIlkHali;
        private System.Windows.Forms.ListBox lbSonHali;
        private System.Windows.Forms.ListBox lbSıralı;
    }
}