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

            _Toptanci.RowFilter = "CariTipAdi = 'Toptancı'";

            lueToptanci.Properties.DataSource = _Toptanci;
            lueToptanci.Properties.DisplayMember = "CariAd";
            lueToptanci.Properties.ValueMember = "CariID";
            lueToptanci.Properties.Columns.Clear();
            lueToptanci.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CariAd", "Toptancı Adı"));
            lueToptanci.Properties.NullText = "Lütfen Seçiniz...";

        }

        private void btnStokYeniUrunKayıt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lueUrunAd.Text) ||
                string.IsNullOrWhiteSpace(lueUrunAyar.Text) ||
                string.IsNullOrWhiteSpace(lueToptanci.Text) ||
                string.IsNullOrWhiteSpace(txtUrunGram.Text) ||
                string.IsNullOrWhiteSpace(txtUrunMaliyet.Text) ||
                string.IsNullOrWhiteSpace(txtIscilik.Text) ||
                string.IsNullOrWhiteSpace(txtBarkodNo.Text))
            {
                
                MessageBox.Show("Lütfen zorunlu alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            decimal gram, maliyet, iscilik;

            if (!decimal.TryParse(txtUrunGram.Text, out gram) ||
                !decimal.TryParse(txtUrunMaliyet.Text, out maliyet) ||
                !decimal.TryParse(txtIscilik.Text, out iscilik))
            {
               
                MessageBox.Show("Gram, Maliyet ve İşçilik alanlarına sadece geçerli bir sayı giriniz!", "Hatalı Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            try
            {
                _StokTableAdapter.InsertQuery(
                    Convert.ToInt32(lueUrunAd.EditValue),
                    Convert.ToInt32(lueUrunAyar.EditValue),
                    Convert.ToInt32(lueToptanci.EditValue),
                    gram,     
                    maliyet, 
                    iscilik,  
                    txtBarkodNo.Text,
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
            lueToptanci.Clear();
            txtUrunGram.Clear();
            txtUrunMaliyet.Clear();
            txtIscilik.Clear();
            txtBarkodNo.Clear();
            chkAktifMi.Checked = false;
        }

        private void txtIscilik_Leave(object sender, EventArgs e)
        {
            // 1. Ürün Adı ve Ayar seçilmemişse barkod oluşturmaya çalışma
            if (string.IsNullOrWhiteSpace(lueUrunAd.Text) ||
                string.IsNullOrWhiteSpace(lueUrunAyar.Text))
            {
                return;
            }

            // 2. Güvenli Sayısal Çeviri (Programın çökmesini engeller)
            decimal gram = 0, maliyet = 0, iscilik = 0;

            // Eğer bu üç alandan herhangi biri boşsa veya sayı değilse, hesaplama yapmadan metottan çık
            if (!decimal.TryParse(txtUrunGram.Text, out gram) ||
                !decimal.TryParse(txtUrunMaliyet.Text, out maliyet) ||
                !decimal.TryParse(txtIscilik.Text, out iscilik))
            {
                return;
            }

            // 3. Barkod Anahtarını ve Toplam Değeri Oluşturma
            string barkodAnahtar = $"{lueUrunAd.Text}-{lueUrunAyar.Text}-";
            decimal toplamDeger = gram + maliyet + iscilik;

            // 4. SQL'den Son Barkodu Getirme
            var maxBarkod = _StokTableAdapter.ScalarQueryBarkodNo(barkodAnahtar);

            int yeniSira = 1;

            // maxBarkod boş dönmediyse ve beklediğimiz formatta geldiyse
            if (maxBarkod != null && maxBarkod.ToString().Length >= 4)
            {
                string sonDortHane = maxBarkod.ToString().Substring(maxBarkod.ToString().Length - 4);

                // TryParse burada da kullanılabilir ama veritabanından kesin sayı geldiğinden eminseniz Convert.ToInt32 yeterlidir
                yeniSira = Convert.ToInt32(sonDortHane) + 1;
            }

            // 5. Yeni Barkodu Yazdırma
            string yeniBarkodNo = $"{barkodAnahtar}{toplamDeger.ToString("0.00")}-{yeniSira.ToString("D4")}";
            txtBarkodNo.Text = yeniBarkodNo;
        }
    }
}
