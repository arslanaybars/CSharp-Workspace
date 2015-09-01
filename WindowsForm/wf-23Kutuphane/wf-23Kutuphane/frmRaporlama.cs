using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_23Kutuphane
{
    public partial class frmRaporlama : Form
    {
        public frmRaporlama()
        {
            InitializeComponent();
        }

        private void frmRaporlama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            cKitapTuru kt = new cKitapTuru();
            kt.KitapTurleriGetir(cbKitapTurleri);
            cbKitapTurleri.Items.Insert(0, "Tüm Kitap Türleri");
            cbKitapTurleri.SelectedIndex = 0;

            cYazar y = new cYazar();
            y.YazarlarGetir(cbYazarlar);
            cbYazarlar.Items.Insert(0, "Tüm Yazarlar");

            cbYazarlar.SelectedIndex = 0;

            cYayinEvi yevi = new cYayinEvi();
            yevi.YayinEvleriniGetir(cbYayinEvleri);
            cbYayinEvleri.Items.Insert(0, "Tüm Yayınevleri");
            cbYayinEvleri.SelectedIndex = 0;
        }

        private void btnSorgulama_Click(object sender, EventArgs e)
        {
            cKitap k = new cKitap();
            k.kitaplariGetirByDetayli(lvDetaylar, cbKitapTurleri.SelectedItem.ToString(), cbYayinEvleri.SelectedItem.ToString(), cbYazarlar.SelectedItem.ToString());
            //if (cbKitapTurleri.SelectedItem.ToString() == "Tüm Kitap Türleri" && cbYazarlar.SelectedItem.ToString() == "Tüm Yazarlar" && cbYayinEvleri.SelectedItem.ToString() == "Tüm Yayınevleri")
            //{
            //    k.KitaplariGetir(lvDetaylar);
            //}
            //else
            //{
            //    k.kitaplariGetirByDetayli(lvDetaylar, cbKitapTurleri.SelectedItem.ToString(), cbYayinEvleri.SelectedItem.ToString(), cbYazarlar.SelectedItem.ToString());
            }
        }
    }
