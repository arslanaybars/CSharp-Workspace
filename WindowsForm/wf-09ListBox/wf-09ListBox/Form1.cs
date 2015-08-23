using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_09ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbListe.Items.Add("oya");
            lbListe.Items.Add("neşe");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtGirilen.Text.Trim() != "")
            {
                if (lbListe.Items.Contains(txtGirilen.Text.ToLower()))
                {
                    MessageBox.Show("Listede zaten mevcut!");
                }
                else
                {
                    lbListe.Items.Add(txtGirilen.Text.ToLower());
                    txtGirilen.Clear();
                    txtGirilen.Focus();
                }
            }
            else
                MessageBox.Show("Hatali bir giriş yaptınız.");

        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            //lbListe.Items.Remove("vedat");
            //lbListe.Items.RemoveAt(2);
            if (lbListe.SelectedIndex == -1)
            {
                MessageBox.Show("Silmek istediğiniz öğeyi seçiniz", "UYARI");
            }
            else
            {
                if (MessageBox.Show(lbListe.SelectedItem.ToString() + "'yı silmek istiyor musunuz ?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    lbListe.Items.RemoveAt(lbListe.SelectedIndex);
                    //lbListe.Items.Remove(lbListe.SelectedItem.toString());
                }
                else
                {

                }
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (txtGirilen.Text.Trim() != "")
            {
                if (lbListe.Items.Contains(txtGirilen.Text.ToLower()))
                {

                    /*
                     *   if(lbListe.Items.Contains(txtGirilen.Text.ToLower()))
                     *      lbListe.SetSelected == txtGirilen.Text.ToLower();
                    */

                    //MessageBox.Show(lbListe.Items[2].ToString());


                    int sayi = 0;

                    for (int i = 0; i < lbListe.Items.Count; i++)
                    {
                        if (lbListe.Items[i].ToString() == txtGirilen.Text.ToLower())
                        {
                            sayi = i;
                            lbListe.SelectedIndex = i;
                        }
                    }

                    //MessageBox.Show("index " + sayi);


                    int index = lbListe.FindString(txtGirilen.Text.Trim(), -1);
                    // sectir
                    lbListe.SetSelected(index, true);
                    // Send a success message:
                    MessageBox.Show("Bulunan item \"" + txtGirilen.Text.Trim() +
                     "\" index: " + index);

                }
                else
                {
                    MessageBox.Show("Girlen eleman listede yok");
                }
            }
            else
            {
                MessageBox.Show("İsim girmediniz");
            }
        }

        private void btnArayaEkle_Click(object sender, EventArgs e)
        {
            //lbListe.Items.Insert(2,txtGirilen.Text.ToLower());
            lbListe.Items.Insert(lbListe.SelectedIndex + 1, txtGirilen.Text.ToLower());
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
    }
}
