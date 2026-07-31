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
            string girilenAd = txtGrubAd.Text.Trim();
            string girilenKod = txtGrupKod.Text.Trim();

            if (string.IsNullOrEmpty(txtGrubAd.Text) || !string.IsNullOrEmpty(txtGrupKod.Text))
            {

                int kayitSayisi = (int)_UrunGrubuTableAdapter.GrupKontrolEt(girilenAd, girilenKod);

                if (kayitSayisi > 0)
                {
                    MessageBox.Show("Girdiğiniz Ürün Adı ('" + girilenAd + "') veya Kısa Kod ('" + girilenKod + "') sistemde zaten kayıtlı!\nLütfen farklı bir ad veya kod belirleyiniz.",
                                    "Mükerrer Kayıt",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                    return; 
                }

                _UrunGrubuTableAdapter.InsertQuery(txtGrupKod.Text, txtGrubAd.Text, chkUrunGrupAktifMi.Checked, 1, DateTime.Now);
                MessageBox.Show("Kayıt Başarılı!");
                urunGrubFormTemizle();
           
            }
            else
            {
                MessageBox.Show("lütfen zorunlu alanaları doldurun!");

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
