using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid;
using KuyumcuStokTakip.Database.KuyumcuStokTakipTableAdapters;
using KuyumcuStokTakip.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuyumcuStokTakip.Fatura
{
    public partial class frmAlisFatura : Form
    {

        private readonly StokTableAdapter _StokListeTableAdapter = new StokTableAdapter();
        private readonly StokHareketTableAdapter _StokHareketTableAdapter = new StokHareketTableAdapter();
        private readonly FaturaTableAdapter _FaturaTableAdapter = new FaturaTableAdapter();
        private readonly CariTableAdapter _CariTableAdapter = new CariTableAdapter();
        public frmAlisFatura()
        {
            InitializeComponent();
            FisNoOlustur();
            InitStok();
            InitStokHareket();
            CariGetir();


        }

        private void CariGetir()
        {

            lueCari.Properties.DataSource = _CariTableAdapter.GetData();
            lueCari.Properties.DisplayMember = "CariKod";
            lueCari.Properties.ValueMember = "CariID";
            lueCari.Properties.NullText = "Lütfen Seçiniz...";
            lueCari.Properties.Columns.Clear();
            lueCari.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CariAd", "Cariler"));
            lueCari.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CariKod", "Cari Kodları"));
        }
        public void InitStokHareket()
        {
            var kayit = _FaturaTableAdapter.GetDataByFisNoKontrol(txtAlisFaturaNo.Text).FirstOrDefault();

            if(kayit==null)
            {
                gridControlAlisFatura.DataSource = _StokHareketTableAdapter.GetData();
            }
            else
            {
                gridControlAlisFatura.DataSource = _StokHareketTableAdapter.GetDataByStokHareketList(kayit.FaturaID);
            }

           
        }

        private string FisNoOlustur()
        {
            string onEk = "AF";
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
                fisNo = "AF0001";
                fisNo = onEk + "0001";
            }

            txtAlisFaturaNo.Text = fisNo;
            return fisNo;
        }
        public void InitStok()
        {
            repositoryItemGridLookUpEdit1.DataSource = _StokListeTableAdapter.GetData();
            repositoryItemGridLookUpEdit1.ValueMember = "StokID";
            repositoryItemGridLookUpEdit1.DisplayMember = "StokNo";
        }

        private void lueBarkodNo_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void gridAlisFatura_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            // Burada her satırdan sonra gridde bulunan tutar kolonları toplancak
            GenelTutarHesapla();
        }

        private void gridAlisFatura_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {

        }

        private void gridAlisFatura_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {// Stok Kodu hücresinde bir değişiklik olduysa
            if (e.Column.FieldName == gridStokKod.FieldName)
            {
                try
                {
                    // 1. Seçilen Stok ID'sini alıyoruz (FocusedRowHandle yerine e.RowHandle kullanmak daha güvenlidir)
                    var st_id = gridAlisFatura.GetRowCellValue(e.RowHandle, gridStokKod.FieldName) != DBNull.Value
                                ? Convert.ToInt32(gridAlisFatura.GetRowCellValue(e.RowHandle, gridStokKod.FieldName))
                                : 0;

                    if (st_id == 0) return;

                    // 2. ÇÖZÜM: Bütün listeyi değil, sadece seçilen 'st_id' değerine eşit olan stoğu buluyoruz
                    var stok = _StokListeTableAdapter.GetData().FirstOrDefault(x => x.StokID == st_id);

                    // 3. Eğer stok bulunduysa, o stoğa ait Milyem değerini aynı satırın Milyem hücresine yazdırıyoruz
                    if (stok != null)
                    {
                        gridAlisFatura.SetRowCellValue(e.RowHandle, gridAlisFatura.Columns[gridMilyem.FieldName], stok.Milyem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Milyem değeri getirilirken hata oluştu: " + ex.Message);
                }
            }
            else if ((e.Column.FieldName == gridGramMiktar.FieldName))
            {

                var Milyem = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMilyem.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMilyem.FieldName)) : 0;
                var gramMiktar = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridGramMiktar.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridGramMiktar.FieldName)) : 0;
                var Iscilik = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridIscilik.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridIscilik.FieldName)) : 0;
                var Maliyet = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMaliyet.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMaliyet.FieldName)) : 0;

                // 1. EKLENEN KISIM: Has Fiyatı Oku
                var HasFiyat = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridHasFiyat.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridHasFiyat.FieldName)) : 0;
                var HasMiktar = (Milyem * gramMiktar) + Iscilik + Maliyet;

                // Has Miktarı Yaz
                gridAlisFatura.SetRowCellValue(gridAlisFatura.FocusedRowHandle, gridAlisFatura.Columns[gridHasMiktar.FieldName], HasMiktar);

                // 2. EKLENEN KISIM: Tutarı anında güncelle
                gridAlisFatura.SetRowCellValue(gridAlisFatura.FocusedRowHandle, gridAlisFatura.Columns[gridTutar.FieldName], HasMiktar * HasFiyat);
                gridAlisFatura.SetRowCellValue(gridAlisFatura.FocusedRowHandle, gridAlisFatura.Columns[gridHasMiktar.FieldName], (Milyem * gramMiktar) + Iscilik + Maliyet); 
            }
            else if ((e.Column.FieldName == gridMaliyet.FieldName))
            {

                var Milyem = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMilyem.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMilyem.FieldName)) : 0;
                var gramMiktar = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridGramMiktar.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridGramMiktar.FieldName)) : 0;
                var Iscilik = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridIscilik.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridIscilik.FieldName)) : 0;
                var Maliyet = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMaliyet.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMaliyet.FieldName)) : 0;

                // 1. EKLENEN KISIM: Has Fiyatı Oku
                var HasFiyat = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridHasFiyat.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridHasFiyat.FieldName)) : 0;

                var HasMiktar = (Milyem * gramMiktar) + Iscilik + Maliyet;

                // Has Miktarı Yaz
                gridAlisFatura.SetRowCellValue(gridAlisFatura.FocusedRowHandle, gridAlisFatura.Columns[gridHasMiktar.FieldName], HasMiktar);

                // 2. EKLENEN KISIM: Tutarı anında güncelle
                gridAlisFatura.SetRowCellValue(gridAlisFatura.FocusedRowHandle, gridAlisFatura.Columns[gridTutar.FieldName], HasMiktar * HasFiyat);

                gridAlisFatura.SetRowCellValue(gridAlisFatura.FocusedRowHandle, gridAlisFatura.Columns[gridHasMiktar.FieldName], (Milyem * gramMiktar) + Iscilik + Maliyet);
            }
            else if ((e.Column.FieldName == gridIscilik.FieldName))
            {

                var Milyem = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMilyem.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMilyem.FieldName)) : 0;
                var gramMiktar = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridGramMiktar.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridGramMiktar.FieldName)) : 0;
                var Iscilik = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridIscilik.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridIscilik.FieldName)) : 0;
                var Maliyet = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMaliyet.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMaliyet.FieldName)) : 0;

                // 1. EKLENEN KISIM: Has Fiyatı Oku
                var HasFiyat = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridHasFiyat.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridHasFiyat.FieldName)) : 0;

                var HasMiktar = (Milyem * gramMiktar) + Iscilik + Maliyet;

                // Has Miktarı Yaz
                gridAlisFatura.SetRowCellValue(gridAlisFatura.FocusedRowHandle, gridAlisFatura.Columns[gridHasMiktar.FieldName], HasMiktar);

                // 2. EKLENEN KISIM: Tutarı anında güncelle
                gridAlisFatura.SetRowCellValue(gridAlisFatura.FocusedRowHandle, gridAlisFatura.Columns[gridTutar.FieldName], HasMiktar * HasFiyat);

                gridAlisFatura.SetRowCellValue(gridAlisFatura.FocusedRowHandle, gridAlisFatura.Columns[gridHasMiktar.FieldName], (Milyem * gramMiktar) + Iscilik + Maliyet);
            }
            else if ((e.Column.FieldName == gridHasFiyat.FieldName))
            {

                var Milyem = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMilyem.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMilyem.FieldName)) : 0;
                var gramMiktar = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridGramMiktar.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridGramMiktar.FieldName)) : 0;
                var Iscilik = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridIscilik.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridIscilik.FieldName)) : 0;
                var Maliyet = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMaliyet.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMaliyet.FieldName)) : 0;
                var HasFiyat = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridHasFiyat.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridHasFiyat.FieldName)) : 0;

                var HasMiktar = ((Milyem * gramMiktar) + Iscilik + Maliyet);
                gridAlisFatura.SetRowCellValue(gridAlisFatura.FocusedRowHandle, gridAlisFatura.Columns[gridTutar.FieldName], HasMiktar * HasFiyat);

            }

            gridAlisFatura.UpdateSummary();

            GenelTutarHesapla();
        }

        private void GenelTutarHesapla()
        {
            double genelToplam = 0;

            // Grid'deki tüm veri satırlarını tek tek dönüyoruz
            for (int i = 0; i < gridAlisFatura.DataRowCount; i++)
            {
                // Kodundaki gridTutar sütunundan değeri okuyoruz
                var satirTutari = gridAlisFatura.GetRowCellValue(i, gridTutar.FieldName);

                if (satirTutari != null && satirTutari != DBNull.Value)
                {
                    genelToplam += Convert.ToDouble(satirTutari);
                }
            }


            // 2. ÇÖZÜM BURADA: Eğer kullanıcı şu an "Yeni Kayıt (*)" satırına veri giriyorsa, 
            // bu satır henüz DataRowCount'a dahil edilmemiştir. O anki Tutar değerini okuyup ayrıca ekliyoruz!
            if (gridAlisFatura.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle)
            {
                var yeniSatirTutari = gridAlisFatura.GetRowCellValue(DevExpress.XtraGrid.GridControl.NewItemRowHandle, gridTutar.FieldName);

                if (yeniSatirTutari != null && yeniSatirTutari != DBNull.Value)
                {
                    genelToplam += Convert.ToDouble(yeniSatirTutari);
                }
            }

            // Toplamı yukarıdaki Tutar kutusuna atıyoruz
            txtAlisTutar.Text = genelToplam.ToString("N2");
        }
    }
}
