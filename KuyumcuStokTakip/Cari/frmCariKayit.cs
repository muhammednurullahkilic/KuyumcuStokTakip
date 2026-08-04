using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KuyumcuStokTakip.Cari;
using KuyumcuStokTakip.Database.KuyumcuStokTakipTableAdapters;


namespace KuyumcuStokTakip
{
    public partial class frmCariKayit : Form
    {


        private readonly CariTableAdapter _cariTableAdapter = new CariTableAdapter();
        private readonly CariTipTableAdapter _cariTipTableAdapter = new CariTipTableAdapter();

        public frmCariKayit()
        {
            InitializeComponent();

            cariTip();
        }

        private void cariTip()
        {
            gleCariTip.Properties.DataSource = _cariTipTableAdapter.GetData();
            gleCariTip.Properties.ValueMember = "ID";
            gleCariTip.Properties.DisplayMember = "Tip";
            gleCariTip.Properties.NullText = "Lütfen Seçiniz...";
        }

        private void btnCariKayit_Click(object sender, EventArgs e)
        {

            string girilenCariKod = txtCariKod.Text.Trim();
            if (string.IsNullOrWhiteSpace(txtCariAd.Text) || string.IsNullOrWhiteSpace(txtCariKod.Text) || string.IsNullOrWhiteSpace(gleCariTip.Text))
            {
                MessageBox.Show("Lütfen Zorunlu Kısımları Doldurun!");
            }
            else
            {
                int kayitSayisi = (int)_cariTableAdapter.CariKodKontrolEt(girilenCariKod);

                if (kayitSayisi > 0)
                {
                    // Eğer sayı 0'dan büyükse, ya 'Bilezik' adı ya da 'BLZ' kodu içeride var demektir.
                    MessageBox.Show("Girdiğiniz Cari Kodu ('" + girilenCariKod + "')  sistemde zaten kayıtlı!\nLütfen farklı Cari kod belirleyiniz.",
                                    "Mükerrer Kayıt",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                    return; // İşlemi kes, Insert komutuna inmesine izin verme
                }
                _cariTableAdapter.InsertQuery(txtCariKod.Text, Convert.ToInt32(gleCariTip.EditValue), txtCariAd.Text, txtAdres.Text, txtNot.Text, txtTelefonNo.Text, 1, DateTime.Now, true);
                MessageBox.Show("Kayıt Başarılı");
                CariKayitFormTemizle();
            }
        }

        private string cariKodOlustur(string onEk)
        {
            
            var cariKod = " ";
            var maxFis = _cariTableAdapter.ScalarQueryCariKod(onEk);
            if(maxFis != null)
            {
                // Gelen veriyi string'e çeviriyoruz (Örn: "T0005")
                string sonKod = maxFis.ToString();

                // Gelen kodun son 4 hanesini alıyoruz ("0005")
                string sonDortHane = sonKod.Substring(sonKod.Length - 4);

                // Sayıya çevirip 1 artırıyoruz (5 + 1 = 6)
                int yeniSira = Convert.ToInt32(sonDortHane) + 1;

                // "T" ön eki ile yeni sayıyı 4 haneli olacak şekilde (D4) birleştiriyoruz
                cariKod = onEk + yeniSira.ToString("D4");
            }
            else
            {
                cariKod = "T0001";
                cariKod = onEk + "0001";
            }

            txtCariKod.Text = cariKod;
            return cariKod;
            
        }
        private void CariKayitFormTemizle()
        {
            txtCariAd.Clear();
            txtCariKod.Clear();
            txtAdres.Clear();
            txtNot.Clear();
            txtTelefonNo.Clear();
            gleCariTip.Clear();
            chkCariAktifMi.Checked = false;

        }

        private void gleCariTip_EditValueChanged(object sender, EventArgs e)
        {
            // Seçim yapılmamışsa veya boşsa işlem yapma
            if (gleCariTip.EditValue == null || string.IsNullOrWhiteSpace(gleCariTip.Text))
                return;

            // Veritabanınızdaki kayıtlı tiplerin adlarına göre kontrol ediyoruz.
            // "Toptancı" ve "Müşteri" yazılarını kendi veritabanınızdaki (CariTip tablosu) 
            // birebir aynı yazılışla eşleştirin.
            if (gleCariTip.Text == "Toptancı")
            {
                cariKodOlustur("T");
            }
            else if (gleCariTip.Text == "Musteri") // veya "Musteri" vb.
            {
                cariKodOlustur("M");
            }
        }
    }
}
