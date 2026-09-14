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

namespace KuyumcuStokTakip.Rapor
{
    public partial class frmCariBorcAlacak : Form
    {

        private readonly CariHareketTableAdapter _CariHareketTableAdapter = new CariHareketTableAdapter();
        private readonly StokHareketTableAdapter _StokHareketTableAdapter = new StokHareketTableAdapter();
        private readonly FaturaTableAdapter _FaturaTableAdapter = new FaturaTableAdapter();

        private readonly CariTableAdapter _CariTableAdapter = new CariTableAdapter();

        public frmCariBorcAlacak()
        {
            InitializeComponent();
            CariGetir();
        }


        private void CariGetir()
        {
            // 1. Veritabanından tüm carileri çekiyoruz
            var cariListesi = _CariTableAdapter.GetData();

            // 2. Araca (SearchLookUpEdit) veriyi bağlıyoruz
            lueCariArama.Properties.DataSource = cariListesi;
            lueCariArama.Properties.DisplayMember = "CariAd"; // Ekranda görünecek olan
            lueCariArama.Properties.ValueMember = "CariID";   // Arka planda tutulacak kimlik (ID)
            lueCariArama.Properties.NullText = "Lütfen Seçiniz"; // Boşken yazacak metin

            // 3. TABLO TASARIMI (Senin istediğin görüntü)
            var view = lueCariArama.Properties.View;
            view.Columns.Clear(); // Önce varsayılan dağınık sütunları temizle

            // Senin görselindeki isimlerle (cariAdi ve cariID) sütunları ekliyoruz
            view.Columns.AddVisible("CariAd", "cariAdi").Width = 150;
            view.Columns.AddVisible("CariID", "cariID").Width = 50;
        }
        private void btnCariSorgu_Click(object sender, EventArgs e)
        {
            var secilenCariId = lueCariArama.EditValue;

            if (secilenCariId == null || string.IsNullOrWhiteSpace(secilenCariId.ToString()))
            {
                MessageBox.Show("Lütfen sorgulamak için bir Cari seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. DataSet'teki CariHareketTableAdapter üzerinden yeni sorgumuzu çağırıyoruz
            var cariHareketleri = _CariHareketTableAdapter.GetDataByCariEkstre(Convert.ToInt32(secilenCariId));

            // 2. Tabloyu Grid'e bağlıyoruz (Grid sütun isimlerini bu yeni sorguya göre ayarlamalısın)
            gridControlCariBorcAlacak.DataSource = cariHareketleri;

            // 3. YENİ KURALA GÖRE DİNAMİK HESAPLAMA
            double toplamAlis = 0;     // Tür 10
            double toplamSatis = 0;    // Tür 20
            double toplamTahsilat = 0; // Tür 30 (Kasa Gelir)
            double toplamOdeme = 0;    // Tür 40 (Kasa Gider)

            foreach (var row in cariHareketleri)
            {
                // Null korumalı veri okuma
                double tutar = row.IsCH_TUTARNull() ? 0 : Convert.ToDouble(row.CH_TUTAR);
                int tur = row.IsCH_TURNull() ? 0 : Convert.ToInt32(row.CH_TUR);

                if (tur == 10) toplamAlis += tutar;
                else if (tur == 20) toplamSatis += tutar;
                else if (tur == 30) toplamTahsilat += tutar;
                else if (tur == 40) toplamOdeme += tutar;
            }

            // Ekrana Detayları (Opsiyonel olarak) Yazdırabilirsin
            lblToplamAlis.Text = $"Alış Faturası Toplamı: {toplamAlis:N2} ₺";
            lblToplamSatis.Text = $"Satış Faturası Toplamı: {toplamSatis:N2} ₺";

            // 4. BAKİYE MATEMATİĞİ (Çok Kritik Kısım)
            // Müşterinin bize borçlandığı tutarlar: (Satış Faturası + Bizim yaptığımız Ödeme)
            double borclandigiTutar = toplamSatis + toplamOdeme;

            // Müşterinin bizden alacaklandığı (veya borcunu ödediği) tutarlar: (Alış Faturası + Bize yaptığı Tahsilat)
            double alacaklandigiTutar = toplamAlis + toplamTahsilat;

            // Net Bakiye = Bize Olan Borcu Eksi (-) Bizden Alacağı
            double bakiye = borclandigiTutar - alacaklandigiTutar;

            // 5. DURUM EKRANI
            if (bakiye > 0)
            {
                lblBakiyeDurum.Text = $"Durum: {bakiye:N2} ₺ BİZE BORÇLU";
                lblBakiyeDurum.ForeColor = Color.Green;
            }
            else if (bakiye < 0)
            {
                lblBakiyeDurum.Text = $"Durum: {Math.Abs(bakiye):N2} ₺ BİZDEN ALACAKLI";
                lblBakiyeDurum.ForeColor = Color.Red;
            }
            else
            {
                lblBakiyeDurum.Text = "Durum: (Bakiye Sıfır)";
                lblBakiyeDurum.ForeColor = Color.Black;
            }
        }
    }
}
