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
                string.IsNullOrWhiteSpace(txtStokNo.Text) || 
                string.IsNullOrWhiteSpace(txtMilyem.Text))
            {
                
                MessageBox.Show("Lütfen zorunlu alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Seçilen Ürün Adı (GrupID) ve Ürün Ayar (AyarID) değerlerini alıyoruz
            int secilenGrupID = Convert.ToInt32(lueUrunAd.EditValue);
            int secilenAyarID = Convert.ToInt32(lueUrunAyar.EditValue);

            // 2. Veritabanında bu kayıt var mı diye kontrol ediyoruz
            if (StokKaydiZatenVarMi(secilenGrupID, secilenAyarID))
            {
                MessageBox.Show("Bu ürün ve ayar kombinasyonu ile zaten bir stok mevcut. Aynı stok tekrar açılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi burada kesiyoruz, kayıt kodlarına geçmesini engelliyoruz.
            }



            try
            {
                _StokTableAdapter.InsertQuery(
                    Convert.ToInt32(lueUrunAd.EditValue),
                    Convert.ToInt32(lueUrunAyar.EditValue),                
                    txtStokNo.Text,
                    0,
                    Convert.ToDouble(txtMilyem.Text),
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


        // Veritabanı kontrol metodumuz
        private bool StokKaydiZatenVarMi(int grupId, int ayarId)
        {
            // Projendeki TableAdapter'ı tanımlıyoruz (İsmi senin projene göre değişebilir)
            // Örnek: var stokAdapter = new KuyumcuDataSetTableAdapters.StokTableAdapter();
            var stokAdapter = new StokTableAdapter();

            // DataSet'te oluşturduğumuz metoda parametreleri gönderip dönen sayıyı (COUNT) alıyoruz
            // Dönüş tipi object olabileceği için nullable int (int?) veya Convert kullanarak alabiliriz
            int kayitSayisi = Convert.ToInt32(stokAdapter.StokKayitSayisiGetir(grupId, ayarId));

            // Eğer sayı 0'dan büyükse kayıt zaten vardır
            if (kayitSayisi > 0)
            {
                return true;
            }

            return false;
        }

        private void stokKayitListeTemizleme()
        {
            lueUrunAd.Clear();
            lueUrunAyar.Clear();
            txtStokNo.Clear();
            txtMilyem.Clear();
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
