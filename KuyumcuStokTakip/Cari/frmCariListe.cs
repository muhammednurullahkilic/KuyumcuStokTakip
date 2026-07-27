using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuyumcuStokTakip.Cari
{
    public partial class frmCariListe : Form
    {
        public frmCariListe()
        {
            InitializeComponent();
        }

        private void btnYeniKayit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmCariKayit();
            frm.ShowDialog();
        }
    }
}
