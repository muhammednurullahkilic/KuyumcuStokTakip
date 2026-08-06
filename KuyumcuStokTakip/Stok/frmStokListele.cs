using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraSpellChecker.Native;
using KuyumcuStokTakip.Database.KuyumcuStokTakipTableAdapters;
using KuyumcuStokTakip.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KuyumcuStokTakip.Stok
{
    public partial class frmStokListele : Form
    {

        private readonly StokTableAdapter _StokListeTa = new StokTableAdapter();
        public frmStokListele()
        {
            InitializeComponent();
            stokListele();
        }

        private void stokListele()
        {
            gridControlStokListesi.DataSource = _StokListeTa.StokList();
        }
        private void btnStokYeniKayıt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmStokYeniKayıt();
            frm.ShowDialog();
            stokListele();
        }

        private void btnExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //// Önce önizleme: Temp'e yaz ve aç
            //gridView.BestFitColumns();
            //string tempPath = Path.Combine(Path.GetTempPath(), $"Preview_{Guid.NewGuid():N}.xlsx"); // XLSX önerilir
            //gridView.ExportToXlsx(tempPath);

            //Process.Start(new ProcessStartInfo { FileName = tempPath, UseShellExecute = true });

            //// İstersen burada direkt return edip sadece önizleme yaparsın:
            //return;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = $"{"StokListesi"} - {DateTime.Today.Date.ToString("dd.MM.yyyy")}";
            sfd.Filter = "Excel Dosyalari (*.xls)|*.xls";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                gridStokListesi.BestFitColumns();
                gridStokListesi.ExportToXls(sfd.FileName, null);

                
                //if (!File.Exists(sfd.FileName))
                //{
                //    MessageBox.Show(Resources.kayit_bulunamadi, Resources.Uyari, MessageBoxButtons.OK,
                //        MessageBoxIcon.Warning);
                //    return;
                //}

                Process.Start(sfd.FileName);
            }
        }

        private void btnExportPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Yalnızca önizleme yapmak isterseniz mevcut kodunuzu kullanabilirsiniz:
            // printableComponentLink1.CreateDocument();
            // printableComponentLink1.ShowPreview();
            // return;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = $"StokListesi - {DateTime.Today.Date.ToString("dd.MM.yyyy")}";
            sfd.Filter = "PDF Dosyaları (*.pdf)|*.pdf";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Sütun genişliklerini içeriğe göre ayarla
                gridStokListesi.BestFitColumns();

                // Grid'i PDF olarak dışa aktar
                gridStokListesi.ExportToPdf(sfd.FileName);

                // Kaydedilen dosyayı varsayılan PDF okuyucu ile aç
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = sfd.FileName,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PDF dosyası açılırken bir hata oluştu: " + ex.Message,
                                    "Hata",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }
    }

}
