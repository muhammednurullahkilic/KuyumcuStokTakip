using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KuyumcuStokTakip.Database.KuyumcuStokTakipTableAdapters;

namespace KuyumcuStokTakip.Stok
{
    public partial class frmParametreListele : Form
    {
        private readonly UrunGrubuTableAdapter _UrunGrubuTableAdapter = new UrunGrubuTableAdapter();
        private readonly UrunAyarTableAdapter _UrunAyarTableAdapter = new UrunAyarTableAdapter();
        public frmParametreListele()
        {
            InitializeComponent();
            UrunGruplist();
            AyarGruplist();
        }

        private void UrunGruplist()
        {
            gridControlUrunGrup.DataSource = _UrunGrubuTableAdapter.GetData();
        }

        private void AyarGruplist()
        {
            gridControlAyarGrup.DataSource = _UrunAyarTableAdapter.GetData();
        }

        private void btnUrunGrupKayıt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmUrunGrupKayit();
            frm.ShowDialog();
            UrunGruplist();
        }

        private void btnUrunAyarKayıt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmAyarKayit();
            frm.ShowDialog();
            AyarGruplist();
        }

        private void frmParametreListele_Load(object sender, EventArgs e)
        {
            AyarGruplist();
            UrunGruplist();
        }
    }
}
