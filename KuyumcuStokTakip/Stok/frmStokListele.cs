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

namespace KuyumcuStokTakip.Stok
{
    public partial class frmStokListele : Form
    {

        private readonly StokListeTableAdapter _StokListeTa = new StokListeTableAdapter();
        public frmStokListele()
        {
            InitializeComponent();
            stokListele();
        }

        private void stokListele()
        {
            gridControlStokListesi.DataSource = _StokListeTa.StokListesiniGetir();
        }
        private void btnStokYeniKayıt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmStokYeniKayıt();
            frm.ShowDialog();
            stokListele();
        }
    }
}
