namespace wf_15CokBoyutlu
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
            this.lbOgrenciler = new System.Windows.Forms.ListBox();
            this.lbNot1 = new System.Windows.Forms.ListBox();
            this.lbNot2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbOgrenciler
            // 
            this.lbOgrenciler.FormattingEnabled = true;
            this.lbOgrenciler.Location = new System.Drawing.Point(13, 13);
            this.lbOgrenciler.Name = "lbOgrenciler";
            this.lbOgrenciler.Size = new System.Drawing.Size(120, 238);
            this.lbOgrenciler.TabIndex = 0;
            this.lbOgrenciler.SelectedIndexChanged += new System.EventHandler(this.lbOgrenciler_SelectedIndexChanged);
            // 
            // lbNot1
            // 
            this.lbNot1.FormattingEnabled = true;
            this.lbNot1.Location = new System.Drawing.Point(162, 11);
            this.lbNot1.Name = "lbNot1";
            this.lbNot1.Size = new System.Drawing.Size(120, 238);
            this.lbNot1.TabIndex = 1;
            this.lbNot1.SelectedIndexChanged += new System.EventHandler(this.lbNot1_SelectedIndexChanged);
            // 
            // lbNot2
            // 
            this.lbNot2.FormattingEnabled = true;
            this.lbNot2.Location = new System.Drawing.Point(288, 11);
            this.lbNot2.Name = "lbNot2";
            this.lbNot2.Size = new System.Drawing.Size(120, 238);
            this.lbNot2.TabIndex = 2;
            this.lbNot2.SelectedIndexChanged += new System.EventHandler(this.lbNot2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 261);
            this.Controls.Add(this.lbNot2);
            this.Controls.Add(this.lbNot1);
            this.Controls.Add(this.lbOgrenciler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbOgrenciler;
        private System.Windows.Forms.ListBox lbNot1;
        private System.Windows.Forms.ListBox lbNot2;
    }
}

