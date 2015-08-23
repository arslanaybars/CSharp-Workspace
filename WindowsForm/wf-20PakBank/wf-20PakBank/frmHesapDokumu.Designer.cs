namespace wf_20PakBank
{
    partial class frmHesapDokumu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHesapDokumu));
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.lblAdi = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTCKno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHesapTürü = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lvHareketler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToplamCekilen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtToplamYatan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnYazici = new System.Windows.Forms.Button();
            this.btnParaIslemleri = new System.Windows.Forms.Button();
            this.pdocHareketler = new System.Drawing.Printing.PrintDocument();
            this.ppdHareketler = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.Location = new System.Drawing.Point(22, 13);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(67, 13);
            this.lblHesapNo.TabIndex = 0;
            this.lblHesapNo.Text = "Hesap No  : ";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(101, 9);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(100, 20);
            this.txtHesapNo.TabIndex = 1;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(207, 8);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(22, 40);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(31, 13);
            this.lblAdi.TabIndex = 3;
            this.lblAdi.Text = "Adı : ";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(101, 37);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.ReadOnly = true;
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 4;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(101, 63);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.ReadOnly = true;
            this.txtSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtSoyadi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyadı : ";
            // 
            // txtTCKno
            // 
            this.txtTCKno.Location = new System.Drawing.Point(101, 89);
            this.txtTCKno.Name = "txtTCKno";
            this.txtTCKno.ReadOnly = true;
            this.txtTCKno.Size = new System.Drawing.Size(100, 20);
            this.txtTCKno.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tc Kimlik No :";
            // 
            // txtHesapTürü
            // 
            this.txtHesapTürü.Location = new System.Drawing.Point(101, 115);
            this.txtHesapTürü.Name = "txtHesapTürü";
            this.txtHesapTürü.ReadOnly = true;
            this.txtHesapTürü.Size = new System.Drawing.Size(100, 20);
            this.txtHesapTürü.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hesap Türü : ";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(101, 141);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(100, 20);
            this.txtTarih.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Açılış Tarihi : ";
            // 
            // lvHareketler
            // 
            this.lvHareketler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvHareketler.Location = new System.Drawing.Point(25, 172);
            this.lvHareketler.Name = "lvHareketler";
            this.lvHareketler.Size = new System.Drawing.Size(344, 221);
            this.lvHareketler.TabIndex = 13;
            this.lvHareketler.UseCompatibleStateImageBehavior = false;
            this.lvHareketler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hesap No";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İşlem Tarihi";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İşlem Tutarı";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "İşlem Tipi";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(269, 451);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(100, 20);
            this.txtBakiye.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Bakiye :";
            // 
            // txtToplamCekilen
            // 
            this.txtToplamCekilen.Location = new System.Drawing.Point(269, 425);
            this.txtToplamCekilen.Name = "txtToplamCekilen";
            this.txtToplamCekilen.ReadOnly = true;
            this.txtToplamCekilen.Size = new System.Drawing.Size(100, 20);
            this.txtToplamCekilen.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Toplam Çekilen :";
            // 
            // txtToplamYatan
            // 
            this.txtToplamYatan.Location = new System.Drawing.Point(269, 399);
            this.txtToplamYatan.Name = "txtToplamYatan";
            this.txtToplamYatan.ReadOnly = true;
            this.txtToplamYatan.Size = new System.Drawing.Size(100, 20);
            this.txtToplamYatan.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Toplam Yatan :";
            // 
            // btnYazici
            // 
            this.btnYazici.Location = new System.Drawing.Point(25, 439);
            this.btnYazici.Name = "btnYazici";
            this.btnYazici.Size = new System.Drawing.Size(136, 23);
            this.btnYazici.TabIndex = 20;
            this.btnYazici.Text = "Yazıcıya Gönder";
            this.btnYazici.UseVisualStyleBackColor = true;
            this.btnYazici.Click += new System.EventHandler(this.btnYazici_Click);
            // 
            // btnParaIslemleri
            // 
            this.btnParaIslemleri.Location = new System.Drawing.Point(25, 410);
            this.btnParaIslemleri.Name = "btnParaIslemleri";
            this.btnParaIslemleri.Size = new System.Drawing.Size(136, 23);
            this.btnParaIslemleri.TabIndex = 21;
            this.btnParaIslemleri.Text = "Para İşlemleri";
            this.btnParaIslemleri.UseVisualStyleBackColor = true;
            this.btnParaIslemleri.Click += new System.EventHandler(this.btnParaIslemleri_Click);
            // 
            // pdocHareketler
            // 
            this.pdocHareketler.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdocHareketler_PrintPage);
            // 
            // ppdHareketler
            // 
            this.ppdHareketler.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdHareketler.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdHareketler.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdHareketler.Document = this.pdocHareketler;
            this.ppdHareketler.Enabled = true;
            this.ppdHareketler.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdHareketler.Icon")));
            this.ppdHareketler.Name = "ppdHareketler";
            this.ppdHareketler.Visible = false;
            // 
            // frmHesapDokumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 498);
            this.Controls.Add(this.btnParaIslemleri);
            this.Controls.Add(this.btnYazici);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToplamCekilen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtToplamYatan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lvHareketler);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHesapTürü);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTCKno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.lblHesapNo);
            this.Name = "frmHesapDokumu";
            this.Text = "Hesap Dökümü";
            this.Load += new System.EventHandler(this.frmHesapDokumu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHesapNo;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTCKno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHesapTürü;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvHareketler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToplamCekilen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtToplamYatan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnYazici;
        private System.Windows.Forms.Button btnParaIslemleri;
        private System.Drawing.Printing.PrintDocument pdocHareketler;
        private System.Windows.Forms.PrintPreviewDialog ppdHareketler;
    }
}