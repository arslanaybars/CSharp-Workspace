namespace wf26_Collections
{
    partial class frmStack
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
            this.lbListe2 = new System.Windows.Forms.ListBox();
            this.lbListe1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbListe2
            // 
            this.lbListe2.FormattingEnabled = true;
            this.lbListe2.Location = new System.Drawing.Point(138, 12);
            this.lbListe2.Name = "lbListe2";
            this.lbListe2.Size = new System.Drawing.Size(120, 381);
            this.lbListe2.TabIndex = 5;
            // 
            // lbListe1
            // 
            this.lbListe1.FormattingEnabled = true;
            this.lbListe1.Location = new System.Drawing.Point(12, 12);
            this.lbListe1.Name = "lbListe1";
            this.lbListe1.Size = new System.Drawing.Size(120, 381);
            this.lbListe1.TabIndex = 4;
            // 
            // frmStack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 404);
            this.Controls.Add(this.lbListe2);
            this.Controls.Add(this.lbListe1);
            this.Name = "frmStack";
            this.Text = "frmStack";
            this.Load += new System.EventHandler(this.frmStack_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbListe2;
        private System.Windows.Forms.ListBox lbListe1;
    }
}