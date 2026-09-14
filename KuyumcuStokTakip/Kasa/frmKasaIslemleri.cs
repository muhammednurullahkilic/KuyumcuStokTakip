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

namespace KuyumcuStokTakip.Kasa
{
    public partial class frmKasaIslemleri : Form
    {

        private DateTime utcTime = DateTime.Now.ToUniversalTime().AddHours(3);

        private readonly CariTableAdapter _CariTableAdapter = new CariTableAdapter();

        private readonly KasaTableAdapter _KasaTableAdapter = new KasaTableAdapter();
        private readonly CariHareketTableAdapter _CariHareketTableAdapter = new CariHareketTableAdapter();


        private int _tip, _tur;
        public frmKasaIslemleri()
        {
            InitializeComponent();
            KasaFisNoOlustur();
            KasaListele();
            CariGetir();
            dtKasaTarih.Text = utcTime.ToString();
        }


        private void CariGetir()
        {    
            var cariListesi = _CariTableAdapter.GetData();
         
            lueCari.Properties.DataSource = cariListesi;
            lueCari.Properties.DisplayMember = "CariAd"; 
            lueCari.Properties.ValueMember = "CariID";   
            lueCari.Properties.NullText = "Lütfen Seçiniz"; 

            var view = lueCari.Properties.View;
            view.Columns.Clear(); 
            view.Columns.AddVisible("CariAd", "cariAdi").Width = 150;
            view.Columns.AddVisible("CariID", "cariID").Width = 50;
        }

        private void KasaListele()
        {
            gridControlKasaIslemleri.DataSource = _KasaTableAdapter.GetDataByKasaListesi();

            BakiyeYazdir();
        }


        private void BakiyeYazdir()
        {
            try
            {
                // DataSet'e yazdığımız o özel sorguyu çağırıp tek bir sayı olarak alıyoruz
                double guncelBakiye = Convert.ToDouble(_KasaTableAdapter.ScalarQueryKasaBakiyeGetir());

                // Label'a yazdırıyoruz
                lblKasaBakiye.Text = $"Güncel Kasa Bakiyesi: {guncelBakiye:N2} ₺";

                // Görsellik: Kasa eksideyse Kırmızı, artıdaysa Yeşil, sıfırsa Siyah yapalım
                if (guncelBakiye > 0)
                    lblKasaBakiye.ForeColor = Color.Green;
                else if (guncelBakiye < 0)
                    lblKasaBakiye.ForeColor = Color.Red;
                else
                    lblKasaBakiye.ForeColor = Color.Black;
            }
            catch (Exception)
            {
                lblKasaBakiye.Text = "Bakiye Hesaplanamadı";
            }
        }

        private void btnKasaKayit_Click(object sender, EventArgs e)
        {
            
            if (lueCari.EditValue == null || lueCari.EditValue == DBNull.Value || lueCari.EditValue.ToString() == "" || lueCari.Text == "Lütfen Seçiniz...")
            {
                MessageBox.Show("SİSTEM DİYOR Kİ: Cari seçimi arka planda boş görünüyor!\nListedeki bir cariyie gerçekten tıkladığınızdan emin olun.", "Hata Tespiti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(chkCikis.Checked == false && chkGiris.Checked==false)
            {
                MessageBox.Show("SİSTEM DİYOR Kİ: işlem türü seçilmemiş!\nbir işlem türü seçtiğinizden emin olun.", "Hata Tespiti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(dtKasaTarih.Text))
            {
                MessageBox.Show("SİSTEM DİYOR Kİ: Tarih alanı boş algılandı!", "Hata Tespiti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTutar.Text))
            {
                MessageBox.Show("SİSTEM DİYOR Kİ: tutar alanı boş algılandı!", "Hata Tespiti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if(chkGiris.Checked)
            {
                _tip = 1;
                _tur = 30;
            }
            else
            {
                _tip = 2;
                _tur = 40;
            }


          var kasaKayitID =  _KasaTableAdapter.InsertQuery(Convert.ToInt32(lueCari.EditValue), DateTime.Now, _tip, Convert.ToDouble(txtTutar.Text), " ", txtKasaNo.Text);

           _CariHareketTableAdapter.Insert(Convert.ToInt32(kasaKayitID), Convert.ToInt32(lueCari.EditValue), _tip, Convert.ToDateTime(dtKasaTarih.Text), Convert.ToDouble(txtTutar.Text), _tur);

        }


        private string KasaFisNoOlustur()
        {
            string onEk = "KS";
            var fisNo = " ";
            var maxFis = _KasaTableAdapter.ScalarQueryKasaFisNo(onEk);
            if (maxFis != null)
            {
                string sonKod = maxFis.ToString();
                string sonDortHane = sonKod.Substring(sonKod.Length - 4);
                int yeniSira = Convert.ToInt32(sonDortHane) + 1;
                fisNo = onEk + yeniSira.ToString("D4");
            }
            else
            {
                fisNo = "KS0001";
                fisNo = onEk + "0001";
            }

            txtKasaNo.Text = fisNo;
            return fisNo;
        }

        private void gridControlKasaIslemleri_Click(object sender, EventArgs e)
        {

        }

        private void formTemizle()
        {
            lueCari.EditValue = null;
            dtKasaTarih.Text = utcTime.ToString();
            txtAciklama.Clear();
            txtTutar.Clear();
            chkCikis.Checked = false;
            chkGiris.Checked = false;


            if (gridControlKasaIslemleri.DataSource is DataTable dt)
            {
                dt.Clear();
            }
            else
            {
                // Eğer grid doğrudan bir tabloya değil de listeye bağlıysa veri kaynağını sıfırlarız.
                gridControlKasaIslemleri.DataSource = null;
            }
        }
    }
}
