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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSagaTek_Click(object sender, EventArgs e)
        {
            lbSecilenler.Items.Add(lbKullanıcılar.SelectedItem.ToString());
            lbKullanıcılar.Items.Remove(lbKullanıcılar.SelectedItem.ToString());
        }

        private void btnSagaCok_Click(object sender, EventArgs e)
        {
            //if (lbKullanıcılar.SelectedIndex != -1)
            //{
            //    for (int i = 0; i < lbKullanıcılar.Items.Count; i++)
            //    {

            //            if (lbKullanıcılar.Items[i].ToString() == lbKullanıcılar.SelectedItem.ToString())
            //            {
            //                lbSecilenler.Items.Add(lbKullanıcılar.SelectedItems[j]);
            //           }

            //    }
            //}

            for (int i = lbKullanıcılar.SelectedItems.Count - 1; i > -1; i--)
            {
                lbSecilenler.Items.Add(lbKullanıcılar.SelectedItems[i].ToString());
                lbKullanıcılar.Items.Remove(lbKullanıcılar.SelectedItems[i].ToString());
            }

        }

        private void btnSolaTek_Click(object sender, EventArgs e)
        {
            lbKullanıcılar.Items.Add(lbSecilenler.SelectedItem.ToString());
            lbSecilenler.Items.Remove(lbSecilenler.SelectedItem.ToString());
        }

        private void btnSolaCok_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbSecilenler.SelectedItems.Count; i++)
            {
                lbKullanıcılar.Items.Add(lbSecilenler.SelectedItems[i].ToString());
                lbSecilenler.Items.Remove(lbSecilenler.SelectedItems[i--].ToString());
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
