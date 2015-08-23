namespace wf_21OOP
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
            this.lblTelNo = new System.Windows.Forms.Label();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnAramaYap = new System.Windows.Forms.Button();
            this.btnSms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(12, 9);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(45, 13);
            this.lblTelNo.TabIndex = 0;
            this.lblTelNo.Text = "Tel No :";
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(71, 6);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(100, 20);
            this.txtTelNo.TabIndex = 1;
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(71, 32);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(100, 56);
            this.txtMesaj.TabIndex = 3;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(12, 35);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(44, 13);
            this.lblMesaj.TabIndex = 2;
            this.lblMesaj.Text = "Mesaj : ";
            // 
            // btnAramaYap
            // 
            this.btnAramaYap.Location = new System.Drawing.Point(71, 95);
            this.btnAramaYap.Name = "btnAramaYap";
            this.btnAramaYap.Size = new System.Drawing.Size(100, 23);
            this.btnAramaYap.TabIndex = 4;
            this.btnAramaYap.Text = "Arama Yap";
            this.btnAramaYap.UseVisualStyleBackColor = true;
            this.btnAramaYap.Click += new System.EventHandler(this.btnAramaYap_Click);
            // 
            // btnSms
            // 
            this.btnSms.Location = new System.Drawing.Point(71, 124);
            this.btnSms.Name = "btnSms";
            this.btnSms.Size = new System.Drawing.Size(100, 23);
            this.btnSms.TabIndex = 5;
            this.btnSms.Text = "Sms Gönder";
            this.btnSms.UseVisualStyleBackColor = true;
            this.btnSms.Click += new System.EventHandler(this.btnSms_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 261);
            this.Controls.Add(this.btnSms);
            this.Controls.Add(this.btnAramaYap);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.lblTelNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnAramaYap;
        private System.Windows.Forms.Button btnSms;
    }
}

