using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KuyumcuStokTakip.Database;
using KuyumcuStokTakip.Database.KuyumcuStokTakipTableAdapters;

namespace KuyumcuStokTakip.Stok
{
    public partial class frmAyarKayit : Form
    {

        private readonly UrunAyarTableAdapter _UrunAyarTableAdapter = new UrunAyarTableAdapter();
        public frmAyarKayit()
        {
            InitializeComponent();
        }

        
        private void btnAyarKaydet_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(txtAyar.Text))
            {

                MessageBox.Show("lütfen zorunlu alanaları doldurun!");
            }
            else
            {
                int girilenAyar = Convert.ToInt32(txtAyar.Text.Trim());
                int kayitSayisi = (int)_UrunAyarTableAdapter.AyarKontrolEt(girilenAyar);

                if (kayitSayisi > 0)
                {
                   
                    MessageBox.Show("Girdiğiniz Ayar ('" + girilenAyar + "') sistemde zaten kayıtlı!\nLütfen farklı bir Ayar belirleyiniz.",
                                    "Mükerrer Kayıt",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                    return;
                }
                _UrunAyarTableAdapter.InsertQuery(Convert.ToInt32(txtAyar.Text), chkAyarAktifMi.Checked, 1, DateTime.Now);

                 MessageBox.Show("Kayıt Başarılı!");
                 ayarKayitFormTemizle();  
            }
        }

        private void ayarKayitFormTemizle()
        {
            txtAyar.Clear();
            chkAyarAktifMi.Checked = false;
        }
    }
}
