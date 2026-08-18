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

namespace KuyumcuStokTakip.Rapor
{
    public partial class frmIslemGecmisiListele : Form
    {
        private readonly StokTableAdapter _StokTableAdapter = new StokTableAdapter();
        private readonly StokHareketTableAdapter _StokHareketTableAdapter = new StokHareketTableAdapter();
        private readonly CariHareketTableAdapter _CariHareketTableAdapter = new CariHareketTableAdapter();


        public frmIslemGecmisiListele()
        {
            InitializeComponent();
            IslemGecmisiListele();
        }

        private void IslemGecmisiListele()
        {
            gridControlAlisFaturaListesi.DataSource = _StokHareketTableAdapter.GetDataByIslemGecmisi(1);

            gridControlSatisFaturaListesi.DataSource = _StokHareketTableAdapter.GetDataByIslemGecmisi(2);
        }

        private void frmIslemGecmisiListele_Load(object sender, EventArgs e)
        {
            IslemGecmisiListele();
        }
    }
}
