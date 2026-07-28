using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuyumcuStokTakip.Stok
{
    public partial class frmParametreListele : Form
    {
        public frmParametreListele()
        {
            InitializeComponent();
        }

        private void btnUrunGrupKayıt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmUrunGrupKayit();
            frm.ShowDialog();
        }

        private void btnUrunAyarKayıt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmAyarKayit();
            frm.ShowDialog();
        }
    }
}
