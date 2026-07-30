using KuyumcuStokTakip.Database.KuyumcuStokTakipTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuyumcuStokTakip.Stok
{
    public partial class frmUrunGrupKayit : Form
    {
        private readonly UrunGrubuTableAdapter _UrunGrubuTableAdapter = new UrunGrubuTableAdapter();
        public frmUrunGrupKayit()
        {
            InitializeComponent();
        }


        private void btnUrunGrubuKaydet_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(txtGrubAd.Text) || !string.IsNullOrEmpty(txtGrupKod.Text))
            {
                
                MessageBox.Show("lütfen zorunlu alanaları doldurun!");
            }
            else
            {
                _UrunGrubuTableAdapter.InsertQuery(txtGrupKod.Text, txtGrubAd.Text, chkUrunGrupAktifMi.Checked, 1, DateTime.Now);
                MessageBox.Show("Kayıt Başarılı!");
                urunGrubFormTemizle();
            }
        }

        private void urunGrubFormTemizle()
        {
            txtGrubAd.Clear();
            txtGrupKod.Clear();
            chkUrunGrupAktifMi.Checked = false;
        }

    }
}
