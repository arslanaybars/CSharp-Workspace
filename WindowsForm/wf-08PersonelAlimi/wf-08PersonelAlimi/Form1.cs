using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_08PersonelAlimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasvur_Click(object sender, EventArgs e)
        {
            int yas = DateTime.Now.Year - dtpDTarihi.Value.Year; // CurrentYear - BirthDate

            if (txtAdi.Text.Trim() == "" || txtSoyadi.Text.Trim() == "" || txtTelefon.Text.Trim() == "")
            {
                MessageBox.Show("İsim,soyad, tc kimlik numarası boş geçilmemelidir.");
            }
            else
            if (yas >= 20 && yas <= 35)
            {
                String egitimString = (cbEgitim.SelectedItem.ToString());
                if (egitimString == "Lisans" || egitimString == "Ön Lisans" || egitimString == "Y. Lisans")
                {
                    if (cbxIng.Checked)
                    {
                        if (cbxArap.Checked == true || cbxRus.Checked == true)
                        {
                            if (cbxYaz.Checked == true && cbxMSO.Checked == true)
                            {
                                if (cbxVeri.Checked == true || cbxWeb.Checked == true)
                                {
                                    if (rbKadin.Checked)
                                    {
                                        MessageBox.Show("İsim : " + txtAdi.Text +
                                                "\nSoyisim : " + txtSoyadi.Text +
                                                "\nTc Kimlik Numarasi : " + txtTCKno.Text +
                                                "\n\nBaşvurunuz Gerçekleşti"
                                                , "Başvuru Sonucu");
                                    }
                                    else if (rbErkek.Checked)
                                    {
                                        if (rbYapildi.Checked || rbTecilli.Checked)
                                            MessageBox.Show("İsim : " + txtAdi.Text +
                                                "\nSoyisim : " + txtSoyadi.Text +
                                                "\nTc Kimlik Numarasi : " + txtTCKno.Text +
                                                "\n\nBaşvurunuz Gerçekleşti"
                                                , "Başvuru Sonucu");
                                        else
                                            MessageBox.Show("Başvuru Gerçekleşmedi..");
                                    }
                                    else
                                        MessageBox.Show("Başvuru Gerçekleşmedi..");
                                }
                                else
                                    MessageBox.Show("Başvuru Gerçekleşmedi..");
                            }
                            else
                                MessageBox.Show("Başvuru Gerçekleşmedi..");
                        }
                        else
                            MessageBox.Show("Başvuru Gerçekleşmedi..");
                    }
                    else
                        MessageBox.Show("Başvuru Gerçekleşmedi..");
                }
                else
                    MessageBox.Show("Başvuru Gerçekleşmedi..");
            }
            else
                MessageBox.Show("Başvuru Gerçekleşmedi..");
        }


        private void cbEgitim_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbEgitim.SelectedItem.ToString());
            //MessageBox.Show(cbEgitim.SelectedIndex.ToString());
        }

        private void dtpDTarihi_ValueChanged(object sender, EventArgs e)
        {
            //int Age = DateTime.Today.Year - dtpDTarihi.Value.Year; // CurrentYear - BirthDate

            //MessageBox.Show(Age.ToString());
            //txtAge.Text = Age.ToString();
        }

        private void rbKadin_CheckedChanged(object sender, EventArgs e)
        {
            gbAskerlik.Enabled = false;     // Pasif Yapar.
            //gbAskerlik.Visible = false;     // Ekran Görüntüsü Kaldırlır.
        }

        private void rbErkek_CheckedChanged(object sender, EventArgs e)
        {
            gbAskerlik.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbEgitim.SelectedIndex = 0;
        }


    }
}
