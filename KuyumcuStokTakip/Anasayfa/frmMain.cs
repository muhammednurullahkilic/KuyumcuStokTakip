using DevExpress.XtraSplashScreen;
using DevExpress.XtraTabbedMdi;
using KuyumcuStokTakip.Cari;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace KuyumcuStokTakip
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain(CultureInfo culture)
        {
            InitializeComponent();

        }

        private void btnCariKayitListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFormShow(new frmCariListe(), e.Item.Caption);
        }

        private void OpenFormShow(Form frm, string buttonText)
        {
            try
            {
                var index = GetTabbedPageIndex(frm.Text.ToString());
                if (index != null)
                {
                    if (index != -1)
                    {
                        xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[index];
                    }
                    else
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private int GetTabbedPageIndex(string sForm)
        {
            var index = -1;
            var iPageCount = xtraTabbedMdiManager1.Pages.Count;

            for (var i = 0; i < iPageCount; i++)
            {
                if (xtraTabbedMdiManager1.Pages[i].MdiChild.Text.ToString() != sForm) continue;
                index = i;
                break;
            }

            return index;
        }
    }

}
