using DevExpress.XtraEditors.Repository;
using KuyumcuStokTakip.Database.KuyumcuStokTakipTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace KuyumcuStokTakip.Fatura
{
    public partial class frmSatisFatura : Form
    {
        private DateTime utcTime = DateTime.Now.ToUniversalTime().AddHours(3);
        private readonly StokTableAdapter _StokListeTableAdapter = new StokTableAdapter();
        private readonly StokHareketTableAdapter _StokHareketTableAdapter = new StokHareketTableAdapter();
        private readonly FaturaTableAdapter _FaturaTableAdapter = new FaturaTableAdapter();
        private readonly CariTableAdapter _CariTableAdapter = new CariTableAdapter();
        private readonly CariHareketTableAdapter _CariHareketTableAdapter = new CariHareketTableAdapter();

        private readonly KasaTableAdapter _KasaTableAdapter = new KasaTableAdapter();


        string KasafisNo = " ";
        private TransactionScope _scopeInsertSatisFatura;
        public frmSatisFatura()
        {
            InitializeComponent();
            FisNoOlustur();
            InitStok();
            InitStokHareket();
            CariGetir();
            formTemizle();
            dtSatisTarihi.Text = utcTime.ToString();
        }

        private void CariGetir()
        {

            var cariListesi = _CariTableAdapter.GetData();

            cariListesi.DefaultView.RowFilter = "CariTipAdi = 'Musteri'";

            lueCari.Properties.DataSource = cariListesi.DefaultView;

            lueCari.Properties.DisplayMember = "CariAd";
            lueCari.Properties.ValueMember = "CariID";
            lueCari.Properties.NullText = "Lütfen Seçiniz...";

            lueCari.Properties.Columns.Clear();
            lueCari.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CariKod", "Cari Kodu", 75));
            lueCari.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CariAd", "Cari Adı", 150));
        }
        public void InitStokHareket()
        {
            var kayit = _FaturaTableAdapter.GetDataByFisNoKontrol(txtSatisFaturaNo.Text).FirstOrDefault();

            if (kayit == null)
            {
                gridControlSatisFatura.DataSource = _StokHareketTableAdapter.GetDataList();
            }
            else
            {
                gridControlSatisFatura.DataSource = _StokHareketTableAdapter.GetDataByStokHareketList(kayit.FaturaID);
            }
        }

        private string FisNoOlustur()
        {
            string onEk = "SF";
            var fisNo = " ";
            var maxFis = _FaturaTableAdapter.ScalarQueryByFisNo(onEk);
            if (maxFis != null)
            {
                string sonKod = maxFis.ToString();
                string sonDortHane = sonKod.Substring(sonKod.Length - 4);
                int yeniSira = Convert.ToInt32(sonDortHane) + 1;
                fisNo = onEk + yeniSira.ToString("D4");
            }
            else
            {
                fisNo = "SF0001";
                fisNo = onEk + "0001";
            }

            txtSatisFaturaNo.Text = fisNo;
            return fisNo;
        }
        public void InitStok()
        {
            repositoryItemGridLookUpEdit1.DataSource = _StokListeTableAdapter.GetData();
            repositoryItemGridLookUpEdit1.ValueMember = "StokID";
            repositoryItemGridLookUpEdit1.DisplayMember = "StokNo";

            var view = repositoryItemGridLookUpEdit1.View;

            view.Columns.Clear();


            var colId = view.Columns.AddVisible("StokID", "Stok ID");
            colId.Width = 50; 

            var colNo = view.Columns.AddVisible("StokNo", "Stok No");
            colNo.Width = 150;
        }

   
        private void gridSatisFaturasi_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            GenelTutarHesapla();
        }


        private void btnKaydet_Click(object sender, EventArgs e)

        {

            try

            {
                // 1. Fatura No Testi
                if (string.IsNullOrWhiteSpace(txtSatisFaturaNo.Text))
                {
                    MessageBox.Show("SİSTEM DİYOR Kİ: Fatura Numarası alanı boş algılandı!", "Hata Tespiti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. Tarih Testi
                if (string.IsNullOrWhiteSpace(dtSatisTarihi.Text))
                {
                    MessageBox.Show("SİSTEM DİYOR Kİ: Tarih alanı boş algılandı!", "Hata Tespiti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Cari Seçimi Testi (DevExpress Null/DBNull/Empty kontrolleri dahil)
                if (lueCari.EditValue == null || lueCari.EditValue == DBNull.Value || lueCari.EditValue.ToString() == "" || lueCari.Text == "Lütfen Seçiniz...")
                {
                    MessageBox.Show("SİSTEM DİYOR Kİ: Cari seçimi arka planda boş görünüyor!\nListedeki bir cariyie gerçekten tıkladığınızdan emin olun.", "Hata Tespiti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. KONTROL: BOŞ FATURA ENGELLENMESİ

                // DataRowCount 0 ise grid'e hiç satır (stok) girilmemiş demektir.

                if (gridSatisFaturasi.DataRowCount == 0)

                {

                    MessageBox.Show("Faturaya hiç ürün eklemediniz! Lütfen tabloya en az bir kalem giriş yapın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return; // İşlemi burada kes

                }

                // 3. KONTROL: AYNI FİŞ NUMARASI ENGELLENMESİ

                // Yazılan fiş numarasını veritabanında arıyoruz, varsa kayıt işlemini durduruyoruz.

                var ayniFisVarMi = _FaturaTableAdapter.GetDataByFisNoKontrol(txtSatisFaturaNo.Text).FirstOrDefault();

                if (ayniFisVarMi != null)

                {

                    MessageBox.Show($"Bu Fiş Numarası ({txtSatisFaturaNo.Text}) daha önce kullanılmış!\nLütfen farklı bir numara girin.", "Mükerrer Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return; // İşlemi burada kes

                }

                // TÜM KONTROLLERDEN GEÇTİYSE KAYIT İŞLEMİ BAŞLAR

                using (_scopeInsertSatisFatura = new TransactionScope())

                {

                    // Faturayı Kaydet

                    var etkilenenSatir = _FaturaTableAdapter.InsertQuery(Convert.ToDateTime(dtSatisTarihi.Text), txtSatisFaturaNo.Text, Convert.ToInt32(lueCari.EditValue), txtAdSoyad.Text,

                    txtTelefon.Text, txtAciklama.Text, 2, 0, Convert.ToDouble(txtSatisTutar.Text), 1, DateTime.Now, false);



                    if (etkilenenSatir <= 0)

                    {

                        MessageBox.Show("Kayıt eklenemedi! Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;

                    }



                    // Gerçek ID'yi Al

                    var eklenenFatura = _FaturaTableAdapter.GetDataByFisNoKontrol(txtSatisFaturaNo.Text).FirstOrDefault();

                    int gercekFaturaId = eklenenFatura.FaturaID;



                    // Stok Hareketlerini Kaydet

                    for (var i = 0; i < gridSatisFaturasi.RowCount - 1; i++)

                    {

                        // Ekstra Güvenlik: Kullanıcı yarım satır açıp bıraktıysa o satırı atla

                        var stokKod = gridSatisFaturasi.GetRowCellValue(i, gridStokKod.FieldName);

                        if (stokKod == null || stokKod == DBNull.Value || string.IsNullOrEmpty(stokKod.ToString()))

                            continue;



                        _StokHareketTableAdapter.Insert(

                        gercekFaturaId,

                        Convert.ToDateTime(dtSatisTarihi.Text), 2,

                        Convert.ToInt32(gridSatisFaturasi.GetRowCellValue(i, gridStokKod.FieldName)?.ToString() ?? "0"),

                        Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(i, gridGramMiktar.FieldName)?.ToString() ?? "0"),

                        Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(i, gridIscilik.FieldName)?.ToString() ?? "0"),

                        Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(i, gridMaliyet.FieldName)?.ToString() ?? "0"),

                        Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(i, gridHasMiktar.FieldName)?.ToString() ?? "0"),

                        Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(i, gridMilyem.FieldName)?.ToString() ?? "0"),

                        Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(i, gridTutar.FieldName)?.ToString() ?? "0"),

                        Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(i, gridHasFiyat.FieldName)?.ToString() ?? "0")



                        );

                    }



                    // Cari Hareketi Kaydet

                    _CariHareketTableAdapter.Insert(gercekFaturaId, Convert.ToInt32(lueCari.EditValue), 2, Convert.ToDateTime(dtSatisTarihi.Text), Convert.ToDouble(txtSatisTutar.Text),20);

                    if (chkMuhtelif.Checked)
                    {

                        KasaFisNoOlustur();
                        var kasaKayitID = _KasaTableAdapter.InsertQuery(Convert.ToInt32(lueCari.EditValue), DateTime.Now, 1, Convert.ToDouble(txtSatisTutar.Text), " ", KasafisNo);

                        _CariHareketTableAdapter.Insert(Convert.ToInt32(kasaKayitID), Convert.ToInt32(lueCari.EditValue), 1, Convert.ToDateTime(dtSatisTarihi.Text), Convert.ToDouble(txtSatisTutar.Text), 30);

                    }

                    // İşlemi onayla

                    _scopeInsertSatisFatura.Complete();



                } // <--- DİKKAT: Veritabanına kayıt işlemi tam bu noktada ("}") kalıcı olarak yazılır!





                // 4. SON İŞLEMLER (Transaction BİTTİKTEN Sonra)

                MessageBox.Show("Kayıt Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                formTemizle(); // Artık veritabanı güncellendiği için FisNoOlustur yeni kaydı görebilir ve numarayı artırabilir!



            }

            catch (Exception ex)

            {

                MessageBox.Show("Yönetilemeyen bir hata ile karşılaşıldı:\n" + ex.Message, "Sistem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private string KasaFisNoOlustur()
        {
            string onEk = "KS";

            var maxFis = _KasaTableAdapter.ScalarQueryKasaFisNo(onEk);
            if (maxFis != null)
            {
                string sonKod = maxFis.ToString();
                string sonDortHane = sonKod.Substring(sonKod.Length - 4);
                int yeniSira = Convert.ToInt32(sonDortHane) + 1;
                KasafisNo = onEk + yeniSira.ToString("D4");
            }
            else
            {
                KasafisNo = "KS0001";
                KasafisNo = onEk + "0001";
            }

            txtSatisFaturaNo.Text = KasafisNo;
            return KasafisNo;
        }

        private void gridSatisFaturasi_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == gridStokKod.FieldName)
            {
                try
                {
                    var st_id = gridSatisFaturasi.GetRowCellValue(e.RowHandle, gridStokKod.FieldName) != DBNull.Value
                                ? Convert.ToInt32(gridSatisFaturasi.GetRowCellValue(e.RowHandle, gridStokKod.FieldName))
                                : 0;

                    if (st_id == 0) return;

                    var stok = _StokListeTableAdapter.GetData().FirstOrDefault(x => x.StokID == st_id);

                    if (stok != null)
                    {
                        gridSatisFaturasi.SetRowCellValue(e.RowHandle, gridSatisFaturasi.Columns[gridMilyem.FieldName], stok.Milyem);
                        gridSatisFaturasi.SetRowCellValue(e.RowHandle, gridSatisFaturasi.Columns[gridEldekiMiktar.FieldName], stok.UrunTotalGram);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Milyem değeri getirilirken hata oluştu: " + ex.Message);
                }
            }
            else if ((e.Column.FieldName == gridGramMiktar.FieldName))
            {
                var gramMiktar = gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridGramMiktar.FieldName) != DBNull.Value ? Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridGramMiktar.FieldName)) : 0;

                // DÜZELTME 2: Stok miktarını yeni sütundan okuduk ve eksiye düşme kontrolü ekledik
                var eldekiMiktar = gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, "UrunTotalGram") != DBNull.Value ? Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, "UrunTotalGram")) : 0;

                if (gramMiktar > eldekiMiktar)
                {
                    MessageBox.Show($"Stok yetersiz!\nBu üründen elinizde sadece {eldekiMiktar:N2} gram bulunuyor.", "Geçersiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gridSatisFaturasi.SetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridGramMiktar.FieldName, 0);
                    return; // Hatalı miktar girilirse hesaplamaya girmeden işlemi durdurur
                }

                // SENİN ORİJİNAL HESAPLAMA KODLARIN (Değiştirilmedi)
                var Milyem = gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridMilyem.FieldName) != DBNull.Value ? Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridMilyem.FieldName)) : 0;
                var Iscilik = gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridIscilik.FieldName) != DBNull.Value ? Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridIscilik.FieldName)) : 0;
                var Maliyet = gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridMaliyet.FieldName) != DBNull.Value ? Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridMaliyet.FieldName)) : 0;

                var HasFiyat = gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridHasFiyat.FieldName) != DBNull.Value ? Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridHasFiyat.FieldName)) : 0;
                var HasMiktar = (Milyem * gramMiktar) + Iscilik + Maliyet;

                gridSatisFaturasi.SetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridSatisFaturasi.Columns[gridHasMiktar.FieldName], HasMiktar);

                gridSatisFaturasi.SetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridSatisFaturasi.Columns[gridTutar.FieldName], HasMiktar * HasFiyat);
                gridSatisFaturasi.SetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridSatisFaturasi.Columns[gridHasMiktar.FieldName], (Milyem * gramMiktar) + Iscilik + Maliyet);
            }
            else if ((e.Column.FieldName == gridMaliyet.FieldName))
            {

                var Milyem = gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridMilyem.FieldName) != DBNull.Value ? Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridMilyem.FieldName)) : 0;
                var gramMiktar = gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridGramMiktar.FieldName) != DBNull.Value ? Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridGramMiktar.FieldName)) : 0;
                var Iscilik = gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridIscilik.FieldName) != DBNull.Value ? Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridIscilik.FieldName)) : 0;
                var Maliyet = gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridMaliyet.FieldName) != DBNull.Value ? Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridMaliyet.FieldName)) : 0;

                var HasFiyat = gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridHasFiyat.FieldName) != DBNull.Value ? Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridHasFiyat.FieldName)) : 0;

                var HasMiktar = (Milyem * gramMiktar) + Iscilik + Maliyet;

                gridSatisFaturasi.SetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridSatisFaturasi.Columns[gridHasMiktar.FieldName], HasMiktar);

                gridSatisFaturasi.SetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridSatisFaturasi.Columns[gridTutar.FieldName], HasMiktar * HasFiyat);

                gridSatisFaturasi.SetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridSatisFaturasi.Columns[gridHasMiktar.FieldName], (Milyem * gramMiktar) + Iscilik + Maliyet);
            }
            else if ((e.Column.FieldName == gridIscilik.FieldName))
            {

                var Milyem = gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridMilyem.FieldName) != DBNull.Value ? Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridMilyem.FieldName)) : 0;
                var gramMiktar = gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridGramMiktar.FieldName) != DBNull.Value ? Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridGramMiktar.FieldName)) : 0;
                var Iscilik = gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridIscilik.FieldName) != DBNull.Value ? Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridIscilik.FieldName)) : 0;
                var Maliyet = gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridMaliyet.FieldName) != DBNull.Value ? Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridMaliyet.FieldName)) : 0;

                var HasFiyat = gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridHasFiyat.FieldName) != DBNull.Value ? Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridHasFiyat.FieldName)) : 0;

                var HasMiktar = (Milyem * gramMiktar) + Iscilik + Maliyet;

                gridSatisFaturasi.SetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridSatisFaturasi.Columns[gridHasMiktar.FieldName], HasMiktar);

                gridSatisFaturasi.SetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridSatisFaturasi.Columns[gridTutar.FieldName], HasMiktar * HasFiyat);

                gridSatisFaturasi.SetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridSatisFaturasi.Columns[gridHasMiktar.FieldName], (Milyem * gramMiktar) + Iscilik + Maliyet);
            }
            else if ((e.Column.FieldName == gridHasFiyat.FieldName))
            {

                var Milyem = gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridMilyem.FieldName) != DBNull.Value ? Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridMilyem.FieldName)) : 0;
                var gramMiktar = gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridGramMiktar.FieldName) != DBNull.Value ? Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridGramMiktar.FieldName)) : 0;
                var Iscilik = gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridIscilik.FieldName) != DBNull.Value ? Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridIscilik.FieldName)) : 0;
                var Maliyet = gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridMaliyet.FieldName) != DBNull.Value ? Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridMaliyet.FieldName)) : 0;
                var HasFiyat = gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridHasFiyat.FieldName) != DBNull.Value ? Convert.ToDouble(gridSatisFaturasi.GetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridHasFiyat.FieldName)) : 0;

                var HasMiktar = ((Milyem * gramMiktar) + Iscilik + Maliyet);
                gridSatisFaturasi.SetRowCellValue(gridSatisFaturasi.FocusedRowHandle, gridSatisFaturasi.Columns[gridTutar.FieldName], HasMiktar * HasFiyat);

            }

            gridSatisFaturasi.UpdateSummary();

            GenelTutarHesapla();
        }

        private void GenelTutarHesapla()
        {
            double genelToplam = 0;


            for (int i = 0; i < gridSatisFaturasi.DataRowCount; i++)
            {

                var satirTutari = gridSatisFaturasi.GetRowCellValue(i, gridTutar.FieldName);

                if (satirTutari != null && satirTutari != DBNull.Value)
                {
                    genelToplam += Convert.ToDouble(satirTutari);
                }
            }


            if (gridSatisFaturasi.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle)
            {
                var yeniSatirTutari = gridSatisFaturasi.GetRowCellValue(DevExpress.XtraGrid.GridControl.NewItemRowHandle, gridTutar.FieldName);

                if (yeniSatirTutari != null && yeniSatirTutari != DBNull.Value)
                {
                    genelToplam += Convert.ToDouble(yeniSatirTutari);
                }
            }

            txtSatisTutar.Text = genelToplam.ToString("N2");
        }

        

        private void formTemizle()
        {
            lueCari.EditValue = null;
            dtSatisTarihi.Text = utcTime.ToString();
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtAciklama.Clear();
            txtSatisTutar.Text = "0.00";


            if (gridControlSatisFatura.DataSource is DataTable dt)
            {
                dt.Clear();
            }
            else
            {
                // Eğer grid doğrudan bir tabloya değil de listeye bağlıysa veri kaynağını sıfırlarız.
                gridControlSatisFatura.DataSource = null;
            }

            // YENİ FATURA İÇİN HAZIRLIK (Opsiyonel ama tavsiye edilir)
            // Form temizlendikten sonra sıradaki fatura için yeni bir Fiş/Fatura Numarası oluşturmak isteyebilirsin.
            FisNoOlustur();
        }

        private void chkMuhtelif_CheckedChanged(object sender, EventArgs e)
        {
            // Eğer Muhtelif kutucuğu İŞARETLENDİYSE
            if (chkMuhtelif.Checked)
            {
                // ÇÖZÜM BURADA: DataSet'te yazdığın "GetDataByCariAd" sorgusuna parametreyi gönderip çağırıyoruz
                var muhtelifCari = _CariTableAdapter.GetDataByCariKod("M0001").FirstOrDefault();

                if (muhtelifCari != null)
                {
                    // Bulduğumuz carinin ID'sini LookUpEdit'e atıyoruz
                    lueCari.EditValue = muhtelifCari.CariID;

                    // Kullanıcı bu seçimi yanlışlıkla değiştirmesin diye kilitliyoruz
                    lueCari.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sistemde 'Muhtelif Alış Satış' adında bir cari bulunamadı!", "Kayıt Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkMuhtelif.Checked = false; // Hataya düştüğü için tiki geri kaldırıyoruz
                }
            }
            // Eğer Muhtelif kutucuğundan TİK KALDIRILDIYSA
            else
            {
                lueCari.EditValue = null; // Seçimi temizle
                lueCari.Enabled = true;   // Kilidi aç, kullanıcı normal cari seçebilsin
            }
        }
    }
}
