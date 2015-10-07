using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf26_Collections
{
    public partial class frmHashTable : Form
    {
        public frmHashTable()
        {
            InitializeComponent();
        }

        Hashtable htable = new Hashtable();

        private void frmHashTable_Load(object sender, EventArgs e)
        {
            htable["Ezgi"] = 32;
            htable["Seray"] = 22;
            htable["Mustafa"] = 19;
            htable.Add("Kubilay", 21);
            htable.Add("Cihan", 23);
            htable.Add("Aybars", 25);

            foreach (DictionaryEntry ikili in htable)
            {
                string isim = (string)ikili.Key;
                lbListe1.Items.Add(isim);
                int yas = (int)ikili.Value;
                lbListe2.Items.Add(yas);
                int code = ikili.GetHashCode();
                lbListe3.Items.Add(code);
            }

            foreach (string isim in htable.Keys)
            {
                MessageBox.Show(isim);
            }

            foreach (int yas in htable.Values)
            {
                MessageBox.Show(yas.ToString());
            }

            int yasi = (int)htable["Cihan"];
            MessageBox.Show(yasi.ToString());

            if (htable.ContainsKey("Mustafa"))
            {
                MessageBox.Show("Koleksiyonda kayıtlı.");
            }
            else
            {
                MessageBox.Show("Koleksiyonda kayıtlı degil.");
            }

        }
    }
}
