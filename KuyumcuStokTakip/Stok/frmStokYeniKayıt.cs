using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KuyumcuStokTakip.Database.KuyumcuStokTakipTableAdapters;

namespace KuyumcuStokTakip.Stok
{
    public partial class frmStokYeniKayıt : Form
    {

        private readonly StokTableAdapter _StokTableAdapter = new StokTableAdapter();
        private readonly CariTableAdapter _CariTableAdapter = new CariTableAdapter();
        private readonly UrunAyarTableAdapter _UrunAyarTableAdapter = new UrunAyarTableAdapter();
        private readonly UrunGrubuTableAdapter _UrunGrubuTableAdapter = new UrunGrubuTableAdapter();
        private readonly CariTipTableAdapter _CariTipTableAdapter = new CariTipTableAdapter();
        public frmStokYeniKayıt()
        {
            InitializeComponent();
            StokKayitVeri();
        }

        private void StokKayitVeri()        
        {

            lueUrunAd.Properties.DataSource = _UrunGrubuTableAdapter.GetData();
            lueUrunAd.Properties.DisplayMember = "GrupKod";
            lueUrunAd.Properties.ValueMember = "GrupID";
            lueUrunAd.Properties.NullText = "Lütfen Seçiniz...";
            lueUrunAd.Properties.Columns.Clear();
            lueUrunAd.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GrupAd", "Ürün Grubu"));

            lueUrunAyar.Properties.DataSource = _UrunAyarTableAdapter.GetData();
            lueUrunAyar.Properties.DisplayMember = "AyarAdi";
            lueUrunAyar.Properties.ValueMember = "AyarID";
            lueUrunAyar.Properties.Columns.Clear();
            lueUrunAyar.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AyarAdi", "Ayar"));
            lueUrunAyar.Properties.NullText = "Lütfen Seçiniz...";

            DataView _Toptanci = new DataView(_CariTableAdapter.GetData());

      

        }

        private void btnStokYeniUrunKayıt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lueUrunAd.Text) ||
                string.IsNullOrWhiteSpace(lueUrunAyar.Text) ||
                string.IsNullOrWhiteSpace(txtStokNo.Text))
            {
                
                MessageBox.Show("Lütfen zorunlu alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         

          
            try
            {
                _StokTableAdapter.InsertQuery(
                    Convert.ToInt32(lueUrunAd.EditValue),
                    Convert.ToInt32(lueUrunAyar.EditValue),                
                    txtStokNo.Text,
                    0,
                    chkAktifMi.Checked,
                    1,
                    DateTime.Now
                );

                MessageBox.Show("Kayıt Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                stokKayitListeTemizleme();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına kaydedilirken bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void stokKayitListeTemizleme()
        {
            lueUrunAd.Clear();
            lueUrunAyar.Clear();
            txtStokNo.Clear();
            chkAktifMi.Checked = false;
        }

        private void txtIscilik_Leave(object sender, EventArgs e)
        {
           
        }

        private void lueUrunAyar_Leave(object sender, EventArgs e)
        {
            // 1. Ürün Adı ve Ayar seçilmemişse barkod oluşturmaya çalışma
            if (string.IsNullOrWhiteSpace(lueUrunAd.Text) ||
                string.IsNullOrWhiteSpace(lueUrunAyar.Text))
            {
                return;
            }



            // 3. Barkod Anahtarını ve Toplam Değeri Oluşturma
            string barkodAnahtar = $"{lueUrunAd.Text}-{lueUrunAyar.Text}";
            txtStokNo.Text = barkodAnahtar;
        }

       
        
    }
}
