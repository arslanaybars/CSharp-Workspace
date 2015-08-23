namespace wf_09ListBox
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
            this.lbKullanıcılar = new System.Windows.Forms.ListBox();
            this.lbSecilenler = new System.Windows.Forms.ListBox();
            this.btnSagaTek = new System.Windows.Forms.Button();
            this.btnSagaCok = new System.Windows.Forms.Button();
            this.btnSolaTek = new System.Windows.Forms.Button();
            this.btnSolaCok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbKullanıcılar
            // 
            this.lbKullanıcılar.FormattingEnabled = true;
            this.lbKullanıcılar.Items.AddRange(new object[] {
            "Ayşe",
            "Hasan",
            "Oya",
            "Neşe",
            "Vedat",
            "Niyazi",
            "Sedat"});
            this.lbKullanıcılar.Location = new System.Drawing.Point(12, 11);
            this.lbKullanıcılar.Name = "lbKullanıcılar";
            this.lbKullanıcılar.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbKullanıcılar.Size = new System.Drawing.Size(120, 238);
            this.lbKullanıcılar.TabIndex = 0;
            // 
            // lbSecilenler
            // 
            this.lbSecilenler.FormattingEnabled = true;
            this.lbSecilenler.Location = new System.Drawing.Point(219, 11);
            this.lbSecilenler.Name = "lbSecilenler";
            this.lbSecilenler.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSecilenler.Size = new System.Drawing.Size(120, 238);
            this.lbSecilenler.TabIndex = 1;
            // 
            // btnSagaTek
            // 
            this.btnSagaTek.Location = new System.Drawing.Point(138, 66);
            this.btnSagaTek.Name = "btnSagaTek";
            this.btnSagaTek.Size = new System.Drawing.Size(75, 23);
            this.btnSagaTek.TabIndex = 2;
            this.btnSagaTek.Text = ">";
            this.btnSagaTek.UseVisualStyleBackColor = true;
            this.btnSagaTek.Click += new System.EventHandler(this.btnSagaTek_Click);
            // 
            // btnSagaCok
            // 
            this.btnSagaCok.Location = new System.Drawing.Point(138, 95);
            this.btnSagaCok.Name = "btnSagaCok";
            this.btnSagaCok.Size = new System.Drawing.Size(75, 23);
            this.btnSagaCok.TabIndex = 3;
            this.btnSagaCok.Text = ">>";
            this.btnSagaCok.UseVisualStyleBackColor = true;
            this.btnSagaCok.Click += new System.EventHandler(this.btnSagaCok_Click);
            // 
            // btnSolaTek
            // 
            this.btnSolaTek.Location = new System.Drawing.Point(138, 134);
            this.btnSolaTek.Name = "btnSolaTek";
            this.btnSolaTek.Size = new System.Drawing.Size(75, 23);
            this.btnSolaTek.TabIndex = 4;
            this.btnSolaTek.Text = "<";
            this.btnSolaTek.UseVisualStyleBackColor = true;
            this.btnSolaTek.Click += new System.EventHandler(this.btnSolaTek_Click);
            // 
            // btnSolaCok
            // 
            this.btnSolaCok.Location = new System.Drawing.Point(138, 163);
            this.btnSolaCok.Name = "btnSolaCok";
            this.btnSolaCok.Size = new System.Drawing.Size(75, 23);
            this.btnSolaCok.TabIndex = 5;
            this.btnSolaCok.Text = "<<";
            this.btnSolaCok.UseVisualStyleBackColor = true;
            this.btnSolaCok.Click += new System.EventHandler(this.btnSolaCok_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 256);
            this.Controls.Add(this.btnSolaCok);
            this.Controls.Add(this.btnSolaTek);
            this.Controls.Add(this.btnSagaCok);
            this.Controls.Add(this.btnSagaTek);
            this.Controls.Add(this.lbSecilenler);
            this.Controls.Add(this.lbKullanıcılar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbKullanıcılar;
        private System.Windows.Forms.ListBox lbSecilenler;
        private System.Windows.Forms.Button btnSagaTek;
        private System.Windows.Forms.Button btnSagaCok;
        private System.Windows.Forms.Button btnSolaTek;
        private System.Windows.Forms.Button btnSolaCok;
    }
}