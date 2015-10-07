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
    public partial class frmSortedList : Form
    {
        public frmSortedList()
        {
            InitializeComponent();
        }

        SortedList slist = new SortedList();

        private void frmSortedList_Load(object sender, EventArgs e)
        {
            slist["Ezgi"] = 32;
            slist["Seray"] = 22;
            slist["Mustafa"] = 19;
            slist.Add("Kubilay", 21);
            slist.Add("Cihan", 23);
            slist.Add("Aybars", 25);
            slist.Add("Demet", 18);

            foreach (DictionaryEntry ikili in slist)
            {
                string isim = (string)ikili.Key;
                lbListe1.Items.Add(isim);
                int yas = (int)ikili.Value;
                lbListe2.Items.Add(yas);
                int code = ikili.GetHashCode();
                lbListe3.Items.Add(code);
            }
        }
    }
}
