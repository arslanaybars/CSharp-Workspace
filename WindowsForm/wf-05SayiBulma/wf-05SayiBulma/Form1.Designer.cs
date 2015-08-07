namespace wf_05SayiBulma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTahmin = new System.Windows.Forms.Label();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.lblCan = new System.Windows.Forms.Label();
            this.lblRandom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGameOver = new System.Windows.Forms.Button();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.rbBaslangic = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbIeri = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTahmin
            // 
            this.lblTahmin.AutoSize = true;
            this.lblTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTahmin.Location = new System.Drawing.Point(111, 38);
            this.lblTahmin.Name = "lblTahmin";
            this.lblTahmin.Size = new System.Drawing.Size(92, 20);
            this.lblTahmin.TabIndex = 0;
            this.lblTahmin.Text = "Tahmininiz :";
            // 
            // txtTahmin
            // 
            this.txtTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTahmin.Location = new System.Drawing.Point(107, 61);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(100, 23);
            this.txtTahmin.TabIndex = 1;
            this.txtTahmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTahmin
            // 
            this.btnTahmin.Location = new System.Drawing.Point(107, 91);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(100, 23);
            this.btnTahmin.TabIndex = 2;
            this.btnTahmin.Text = "Tahmin Et";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // lblCan
            // 
            this.lblCan.AutoSize = true;
            this.lblCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCan.ForeColor = System.Drawing.Color.Coral;
            this.lblCan.Location = new System.Drawing.Point(70, 163);
            this.lblCan.Name = "lblCan";
            this.lblCan.Size = new System.Drawing.Size(175, 20);
            this.lblCan.TabIndex = 3;
            this.lblCan.Text = " 5 can hakkınız kaldı.";
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(140, 197);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(35, 13);
            this.lblRandom.TabIndex = 4;
            this.lblRandom.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "1 ile 100 arasında bir sayi tahmin ediniz !";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(74, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGameOver
            // 
            this.btnGameOver.Location = new System.Drawing.Point(155, 226);
            this.btnGameOver.Name = "btnGameOver";
            this.btnGameOver.Size = new System.Drawing.Size(75, 23);
            this.btnGameOver.TabIndex = 7;
            this.btnGameOver.Text = "GameOver";
            this.btnGameOver.UseVisualStyleBackColor = true;
            this.btnGameOver.Click += new System.EventHandler(this.btnGameOver_Click);
            // 
            // pbResim
            // 
            this.pbResim.Image = ((System.Drawing.Image)(resources.GetObject("pbResim.Image")));
            this.pbResim.Location = new System.Drawing.Point(16, 258);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(286, 147);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 8;
            this.pbResim.TabStop = false;
            // 
            // rbBaslangic
            // 
            this.rbBaslangic.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.rbBaslangic.AutoSize = true;
            this.rbBaslangic.Checked = true;
            this.rbBaslangic.Location = new System.Drawing.Point(12, 130);
            this.rbBaslangic.Name = "rbBaslangic";
            this.rbBaslangic.Size = new System.Drawing.Size(113, 17);
            this.rbBaslangic.TabIndex = 9;
            this.rbBaslangic.TabStop = true;
            this.rbBaslangic.Text = "Başlangıç Seviyesi";
            this.rbBaslangic.UseVisualStyleBackColor = true;
            this.rbBaslangic.CheckedChanged += new System.EventHandler(this.rbBaslangic_CheckedChanged);
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(122, 130);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(80, 17);
            this.rbOrta.TabIndex = 10;
            this.rbOrta.Text = "Orta Seviye";
            this.rbOrta.UseVisualStyleBackColor = true;
            this.rbOrta.CheckedChanged += new System.EventHandler(this.rbOrta_CheckedChanged);
            // 
            // rbIeri
            // 
            this.rbIeri.AutoSize = true;
            this.rbIeri.Location = new System.Drawing.Point(220, 130);
            this.rbIeri.Name = "rbIeri";
            this.rbIeri.Size = new System.Drawing.Size(72, 17);
            this.rbIeri.TabIndex = 11;
            this.rbIeri.Text = "ileriSeviye";
            this.rbIeri.UseVisualStyleBackColor = true;
            this.rbIeri.CheckedChanged += new System.EventHandler(this.rbIeri_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTahmin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(317, 257);
            this.ControlBox = false;
            this.Controls.Add(this.rbIeri);
            this.Controls.Add(this.rbOrta);
            this.Controls.Add(this.rbBaslangic);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.btnGameOver);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.lblCan);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.lblTahmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Sayı Bulma Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTahmin;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.Label lblCan;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGameOver;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.RadioButton rbBaslangic;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbIeri;
    }
}

