using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_12Sozluk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] Turkceler = { "kapı", "pencere", "öğretmen", "bilgisayar", "duvar", "saat", "yazılım", "donanım", "kalem", "masa", "nesne", "sınıf" };

        string[] Ingilizceler = { "door", "window", "teacher", "computer", "wall", "clock", "saftware", "hardware", "pencil", "table", "object", "class" };

        private void Form1_Load(object sender, EventArgs e)
        {
            lbKelimeler.Items.AddRange(Turkceler);
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (rbTurIng.Checked)
            {
                if (txtTurkce.Text.ToLower() != "")
                {
                    //txtIngilizce.Text = Ingilizceler[Array.IndexOf(Turkceler, txtTurkce.Text)];
                    for (int i = 0; i < Turkceler.Length; i++)
                    {
                        if (Turkceler[i] == txtTurkce.Text.ToLower())
                        {
                            txtIngilizce.Text = Ingilizceler[i];
                            break;
                        }
                    }
                }
            }
            else if (rbIngTur.Checked)
            {
                if (txtIngilizce.Text.ToLower() != "")
                {
                    for (int i = 0; i < Ingilizceler.Length; i++)
                    {
                        if (Ingilizceler[i] == txtIngilizce.Text.ToLower())
                        {
                            txtTurkce.Text = Turkceler[i];
                            break;
                        }
                    }
                }

            }
        }

        private void rbTurIng_CheckedChanged(object sender, EventArgs e)
        {
            lbKelimeler.Items.Clear();

            txtIngilizce.Text = "";
            txtTurkce.Text = "";
            txtIngilizce.ReadOnly = true;
            txtTurkce.ReadOnly = false;
            txtTurkce.Focus();

            lbKelimeler.Items.AddRange(Turkceler);    
            
        }

        private void rbIngTur_CheckedChanged(object sender, EventArgs e)
        {
            lbKelimeler.Items.Clear();

            txtIngilizce.Text = "";
            txtTurkce.Text = "";
            txtIngilizce.ReadOnly = false;
            txtTurkce.ReadOnly = true;
            txtIngilizce.Focus();

            lbKelimeler.Items.AddRange(Ingilizceler);    

        }

        private void lbKelimeler_DoubleClick(object sender, EventArgs e)
        {
            if (rbTurIng.Checked)
            {
                txtIngilizce.Clear();
                txtTurkce.Text = lbKelimeler.SelectedItem.ToString();
            }
            else if (rbIngTur.Checked)
            {
                txtTurkce.Clear();
                txtIngilizce.Text = lbKelimeler.SelectedItem.ToString();
            }
            else
                MessageBox.Show("Sıkıntı Büyük");
        }
    }
}
