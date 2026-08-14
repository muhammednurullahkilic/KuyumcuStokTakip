using DevExpress.XtraEditors;
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
using System.Transactions;
using System.Windows.Forms;

namespace KuyumcuStokTakip.Fatura
{
    public partial class frmAlisFatura : Form
    {
        private DateTime utcTime = DateTime.Now.ToUniversalTime().AddHours(3);
        private readonly StokTableAdapter _StokListeTableAdapter = new StokTableAdapter();
        private readonly StokHareketTableAdapter _StokHareketTableAdapter = new StokHareketTableAdapter();
        private readonly FaturaTableAdapter _FaturaTableAdapter = new FaturaTableAdapter();
        private readonly CariTableAdapter _CariTableAdapter = new CariTableAdapter();

        private readonly CariHareketTableAdapter _CariHareketTableAdapter = new CariHareketTableAdapter();


        private TransactionScope _scopeInsertAlisFatura;
        public frmAlisFatura()
        {
            InitializeComponent();
            FisNoOlustur();
            InitStok();
            InitStokHareket();
            CariGetir();
            formTemizle();
            dtAlisTarihi.Text = utcTime.ToString();
            
        }

        private void CariGetir()
        {

            //lueCari.Properties.DataSource = _CariTableAdapter.GetData();
            //lueCari.Properties.DisplayMember = "CariKod";
            //lueCari.Properties.ValueMember = "CariID";
            //lueCari.Properties.NullText = "Lütfen Seçiniz...";
            //lueCari.Properties.Columns.Clear();
            //lueCari.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CariAd", "Cariler"));
            //lueCari.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CariKod", "Cari Kodları"));

            
            lueCari.Properties.DataSource = _CariTableAdapter.GetData();
            lueCari.Properties.ValueMember = "CariID";
            lueCari.Properties.DisplayMember = "CariAd";

                
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

            var view = repositoryItemGridLookUpEdit1.View;       
        }


        private void gridAlisFatura_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {

            GenelTutarHesapla();
        }

 

        private void gridAlisFatura_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == gridStokKod.FieldName)
            {
                try
                {
                    var st_id = gridAlisFatura.GetRowCellValue(e.RowHandle, gridStokKod.FieldName) != DBNull.Value
                                ? Convert.ToInt32(gridAlisFatura.GetRowCellValue(e.RowHandle, gridStokKod.FieldName))
                                : 0;

                    if (st_id == 0) return;

                    var stok = _StokListeTableAdapter.GetData().FirstOrDefault(x => x.StokID == st_id);

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

                var HasFiyat = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridHasFiyat.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridHasFiyat.FieldName)) : 0;
                var HasMiktar = (Milyem * gramMiktar) + Iscilik + Maliyet;

                gridAlisFatura.SetRowCellValue(gridAlisFatura.FocusedRowHandle, gridAlisFatura.Columns[gridHasMiktar.FieldName], HasMiktar);

                gridAlisFatura.SetRowCellValue(gridAlisFatura.FocusedRowHandle, gridAlisFatura.Columns[gridTutar.FieldName], HasMiktar * HasFiyat);
                gridAlisFatura.SetRowCellValue(gridAlisFatura.FocusedRowHandle, gridAlisFatura.Columns[gridHasMiktar.FieldName], (Milyem * gramMiktar) + Iscilik + Maliyet); 
            }
            else if ((e.Column.FieldName == gridMaliyet.FieldName))
            {

                var Milyem = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMilyem.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMilyem.FieldName)) : 0;
                var gramMiktar = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridGramMiktar.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridGramMiktar.FieldName)) : 0;
                var Iscilik = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridIscilik.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridIscilik.FieldName)) : 0;
                var Maliyet = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMaliyet.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMaliyet.FieldName)) : 0;

                var HasFiyat = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridHasFiyat.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridHasFiyat.FieldName)) : 0;

                var HasMiktar = (Milyem * gramMiktar) + Iscilik + Maliyet;

                gridAlisFatura.SetRowCellValue(gridAlisFatura.FocusedRowHandle, gridAlisFatura.Columns[gridHasMiktar.FieldName], HasMiktar);

                gridAlisFatura.SetRowCellValue(gridAlisFatura.FocusedRowHandle, gridAlisFatura.Columns[gridTutar.FieldName], HasMiktar * HasFiyat);

                gridAlisFatura.SetRowCellValue(gridAlisFatura.FocusedRowHandle, gridAlisFatura.Columns[gridHasMiktar.FieldName], (Milyem * gramMiktar) + Iscilik + Maliyet);
            }
            else if ((e.Column.FieldName == gridIscilik.FieldName))
            {

                var Milyem = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMilyem.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMilyem.FieldName)) : 0;
                var gramMiktar = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridGramMiktar.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridGramMiktar.FieldName)) : 0;
                var Iscilik = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridIscilik.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridIscilik.FieldName)) : 0;
                var Maliyet = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMaliyet.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridMaliyet.FieldName)) : 0;

                var HasFiyat = gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridHasFiyat.FieldName) != DBNull.Value ? Convert.ToDouble(gridAlisFatura.GetRowCellValue(gridAlisFatura.FocusedRowHandle, gridHasFiyat.FieldName)) : 0;

                var HasMiktar = (Milyem * gramMiktar) + Iscilik + Maliyet;

                gridAlisFatura.SetRowCellValue(gridAlisFatura.FocusedRowHandle, gridAlisFatura.Columns[gridHasMiktar.FieldName], HasMiktar);


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


            for (int i = 0; i < gridAlisFatura.DataRowCount; i++)
            {

                var satirTutari = gridAlisFatura.GetRowCellValue(i, gridTutar.FieldName);

                if (satirTutari != null && satirTutari != DBNull.Value)
                {
                    genelToplam += Convert.ToDouble(satirTutari);
                }
            }


            if (gridAlisFatura.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle)
            {
                var yeniSatirTutari = gridAlisFatura.GetRowCellValue(DevExpress.XtraGrid.GridControl.NewItemRowHandle, gridTutar.FieldName);

                if (yeniSatirTutari != null && yeniSatirTutari != DBNull.Value)
                {
                    genelToplam += Convert.ToDouble(yeniSatirTutari);
                }
            }

            txtAlisTutar.Text = genelToplam.ToString("N2");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (_scopeInsertAlisFatura = new TransactionScope())
                {

                    if (string.IsNullOrWhiteSpace(txtAlisFaturaNo.Text) ||
                        string.IsNullOrWhiteSpace(lueCari.Text) ||
                        string.IsNullOrWhiteSpace(dtAlisTarihi.Text))
                    {

                        MessageBox.Show("Lütfen zorunlu alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    var ftId = _FaturaTableAdapter.InsertQuery(Convert.ToDateTime(dtAlisTarihi.Text), txtAlisFaturaNo.Text, Convert.ToInt32(lueCari.EditValue), txtAdSoyad.Text,
                        txtTelefon.Text, txtAciklama.Text, 1, 0, Convert.ToDouble(txtAlisTutar.Text), 1, DateTime.Now, false);


                    if (Convert.ToInt32(ftId) <= 0)
                    {
                        MessageBox.Show("Kayıt eklenemedi! Aynı fiş numarası mevcut olabilir veya başka bir hata oluştu.",
                                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);                    
                    }


                   

                    for (var i = 0; i < gridAlisFatura.RowCount - 1; i++)
                    {
                        _StokHareketTableAdapter.Insert(Convert.ToInt32(ftId), Convert.ToDateTime(dtAlisTarihi.Text), 1,
                            Convert.ToInt32(string.IsNullOrEmpty(gridAlisFatura.GetRowCellValue(i, gridStokKod.FieldName).ToString()) ? "0" : gridAlisFatura.GetRowCellValue(i, gridStokKod.FieldName).ToString()),
                            Convert.ToDouble(string.IsNullOrEmpty(gridAlisFatura.GetRowCellValue(i, gridGramMiktar.FieldName).ToString()) ? "0" : gridAlisFatura.GetRowCellValue(i, gridGramMiktar.FieldName).ToString()),
                            Convert.ToDouble(string.IsNullOrEmpty(gridAlisFatura.GetRowCellValue(i, gridIscilik.FieldName).ToString()) ? "0" : gridAlisFatura.GetRowCellValue(i, gridIscilik.FieldName).ToString()),
                            Convert.ToDouble(string.IsNullOrEmpty(gridAlisFatura.GetRowCellValue(i, gridMaliyet.FieldName).ToString()) ? "0" : gridAlisFatura.GetRowCellValue(i, gridMaliyet.FieldName).ToString()),
                            Convert.ToDouble(string.IsNullOrEmpty(gridAlisFatura.GetRowCellValue(i, gridHasMiktar.FieldName).ToString()) ? "0" : gridAlisFatura.GetRowCellValue(i, gridHasMiktar.FieldName).ToString()),
                            Convert.ToDouble(string.IsNullOrEmpty(gridAlisFatura.GetRowCellValue(i, gridMilyem.FieldName).ToString()) ? "0" : gridAlisFatura.GetRowCellValue(i, gridMilyem.FieldName).ToString()),
                            Convert.ToDouble(string.IsNullOrEmpty(gridAlisFatura.GetRowCellValue(i, gridTutar.FieldName).ToString()) ? "0" : gridAlisFatura.GetRowCellValue(i, gridTutar.FieldName).ToString()),
                            Convert.ToDouble(string.IsNullOrEmpty(gridAlisFatura.GetRowCellValue(i, gridHasFiyat.FieldName).ToString()) ? "0" : gridAlisFatura.GetRowCellValue(i, gridHasFiyat.FieldName).ToString()));
                    }



                    _CariHareketTableAdapter.Insert(Convert.ToInt32(ftId), Convert.ToInt32(lueCari.EditValue), 1, Convert.ToDateTime(dtAlisTarihi.Text), Convert.ToDouble(txtAlisTutar.Text));

                    MessageBox.Show("Kayıt Başarılı", Text, MessageBoxButtons.OK);
                    _scopeInsertAlisFatura.Complete();
                    formTemizle();


                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(
                //    "Yönetilemeyen bir hata ile karşılaşıldı.Ekran görüntüsü alarak sistem yöneticiniz ile görüşün "  );
            }
            
        }

        private void formTemizle()
        {
            txtAlisFaturaNo.Clear();
            lueCari.EditValue = null;
            dtAlisTarihi.Text = utcTime.ToString();
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtAciklama.Clear();
            txtAlisTutar.Text = "0.00";


            if (gridControlAlisFatura.DataSource is DataTable dt)
            {
                dt.Clear();
            }
            else
            {
                // Eğer grid doğrudan bir tabloya değil de listeye bağlıysa veri kaynağını sıfırlarız.
                gridControlAlisFatura.DataSource = null;
            }

            // YENİ FATURA İÇİN HAZIRLIK (Opsiyonel ama tavsiye edilir)
            // Form temizlendikten sonra sıradaki fatura için yeni bir Fiş/Fatura Numarası oluşturmak isteyebilirsin.
            FisNoOlustur();
        }


    }
}