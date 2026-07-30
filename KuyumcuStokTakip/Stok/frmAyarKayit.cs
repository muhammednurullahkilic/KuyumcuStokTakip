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
