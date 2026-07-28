using DevExpress.XtraEditors.Repository;
using KuyumcuStokTakip.Database.KuyumcuStokTakipTableAdapters;
using KuyumcuStokTakip.Database.KuyumcuStokTakipTableAdapters;
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
using KuyumcuStokTakip.Cari;

namespace KuyumcuStokTakip.Cari
{
    public partial class frmCariListe : Form
    {
      
        private readonly CariTableAdapter _cariTableAdapter = new CariTableAdapter();
        private readonly CariTipTableAdapter _cariTipTableAdapter = new CariTipTableAdapter();


        public frmCariListe()
        {
            InitializeComponent();
            
        }
        private void frmCariListe_Load(object sender, EventArgs e)
        {
            CariListeGetir();
        }
        public  void CariListeGetir()
        {
            gridControlCari.DataSource = _cariTableAdapter.GetData();
            
        }

        private void btnYeniKayit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmCariKayit();
            frm.ShowDialog();
            CariListeGetir();
        }

        
    }
}
