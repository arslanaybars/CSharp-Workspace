namespace wf_15CokBoyutlu
{
    partial class Form2
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
            this.lbOrtalamalar = new System.Windows.Forms.ListBox();
            this.lbOgrenciler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbOrtalamalar
            // 
            this.lbOrtalamalar.FormattingEnabled = true;
            this.lbOrtalamalar.Location = new System.Drawing.Point(157, 10);
            this.lbOrtalamalar.Name = "lbOrtalamalar";
            this.lbOrtalamalar.Size = new System.Drawing.Size(120, 238);
            this.lbOrtalamalar.TabIndex = 3;
            // 
            // lbOgrenciler
            // 
            this.lbOgrenciler.FormattingEnabled = true;
            this.lbOgrenciler.Location = new System.Drawing.Point(8, 12);
            this.lbOgrenciler.Name = "lbOgrenciler";
            this.lbOgrenciler.Size = new System.Drawing.Size(120, 238);
            this.lbOgrenciler.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbOrtalamalar);
            this.Controls.Add(this.lbOgrenciler);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbOrtalamalar;
        private System.Windows.Forms.ListBox lbOgrenciler;
    }
}