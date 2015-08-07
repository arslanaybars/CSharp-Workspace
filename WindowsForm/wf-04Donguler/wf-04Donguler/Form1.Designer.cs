namespace wf_04Donguler
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
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.btnSayilar = new System.Windows.Forms.Button();
            this.btnCiftSayilar = new System.Windows.Forms.Button();
            this.lbCiftSayilar = new System.Windows.Forms.ListBox();
            this.btnTekSayilar = new System.Windows.Forms.Button();
            this.lbTekSayilar = new System.Windows.Forms.ListBox();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.txtCiftToplam = new System.Windows.Forms.TextBox();
            this.txtTekToplam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbSayilar
            // 
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.Location = new System.Drawing.Point(12, 12);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(120, 173);
            this.lbSayilar.TabIndex = 0;
            this.lbSayilar.UseTabStops = false;
            // 
            // btnSayilar
            // 
            this.btnSayilar.Location = new System.Drawing.Point(12, 191);
            this.btnSayilar.Name = "btnSayilar";
            this.btnSayilar.Size = new System.Drawing.Size(120, 23);
            this.btnSayilar.TabIndex = 1;
            this.btnSayilar.Text = "Sayılar";
            this.btnSayilar.UseVisualStyleBackColor = true;
            this.btnSayilar.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // btnCiftSayilar
            // 
            this.btnCiftSayilar.Location = new System.Drawing.Point(156, 191);
            this.btnCiftSayilar.Name = "btnCiftSayilar";
            this.btnCiftSayilar.Size = new System.Drawing.Size(120, 23);
            this.btnCiftSayilar.TabIndex = 3;
            this.btnCiftSayilar.Text = "Çift Sayilar";
            this.btnCiftSayilar.UseVisualStyleBackColor = true;
            this.btnCiftSayilar.Click += new System.EventHandler(this.btnCiftSayilar_Click);
            // 
            // lbCiftSayilar
            // 
            this.lbCiftSayilar.FormattingEnabled = true;
            this.lbCiftSayilar.Location = new System.Drawing.Point(156, 12);
            this.lbCiftSayilar.Name = "lbCiftSayilar";
            this.lbCiftSayilar.Size = new System.Drawing.Size(120, 173);
            this.lbCiftSayilar.TabIndex = 2;
            this.lbCiftSayilar.UseTabStops = false;
            // 
            // btnTekSayilar
            // 
            this.btnTekSayilar.Location = new System.Drawing.Point(300, 191);
            this.btnTekSayilar.Name = "btnTekSayilar";
            this.btnTekSayilar.Size = new System.Drawing.Size(120, 23);
            this.btnTekSayilar.TabIndex = 5;
            this.btnTekSayilar.Text = "Tek Sayılar";
            this.btnTekSayilar.UseVisualStyleBackColor = true;
            this.btnTekSayilar.Click += new System.EventHandler(this.btnTekSayilar_Click);
            // 
            // lbTekSayilar
            // 
            this.lbTekSayilar.FormattingEnabled = true;
            this.lbTekSayilar.Location = new System.Drawing.Point(300, 12);
            this.lbTekSayilar.Name = "lbTekSayilar";
            this.lbTekSayilar.Size = new System.Drawing.Size(120, 173);
            this.lbTekSayilar.TabIndex = 4;
            this.lbTekSayilar.UseTabStops = false;
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(12, 220);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.ReadOnly = true;
            this.txtToplam.Size = new System.Drawing.Size(120, 20);
            this.txtToplam.TabIndex = 6;
            this.txtToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCiftToplam
            // 
            this.txtCiftToplam.Location = new System.Drawing.Point(156, 220);
            this.txtCiftToplam.Name = "txtCiftToplam";
            this.txtCiftToplam.ReadOnly = true;
            this.txtCiftToplam.Size = new System.Drawing.Size(120, 20);
            this.txtCiftToplam.TabIndex = 7;
            this.txtCiftToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTekToplam
            // 
            this.txtTekToplam.Location = new System.Drawing.Point(300, 220);
            this.txtTekToplam.Name = "txtTekToplam";
            this.txtTekToplam.ReadOnly = true;
            this.txtTekToplam.Size = new System.Drawing.Size(120, 20);
            this.txtTekToplam.TabIndex = 8;
            this.txtTekToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 259);
            this.Controls.Add(this.txtTekToplam);
            this.Controls.Add(this.txtCiftToplam);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.btnTekSayilar);
            this.Controls.Add(this.lbTekSayilar);
            this.Controls.Add(this.btnCiftSayilar);
            this.Controls.Add(this.lbCiftSayilar);
            this.Controls.Add(this.btnSayilar);
            this.Controls.Add(this.lbSayilar);
            this.Name = "Form1";
            this.Text = "Döngüler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSayilar;
        private System.Windows.Forms.Button btnSayilar;
        private System.Windows.Forms.Button btnCiftSayilar;
        private System.Windows.Forms.ListBox lbCiftSayilar;
        private System.Windows.Forms.Button btnTekSayilar;
        private System.Windows.Forms.ListBox lbTekSayilar;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.TextBox txtCiftToplam;
        private System.Windows.Forms.TextBox txtTekToplam;
    }
}

