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
    public partial class frmSatisIstatistikler : Form
    {
        private readonly Cari1TableAdapter _Cari1TableAdapter = new Cari1TableAdapter();

        private readonly UrunGrubu1TableAdapter _UrunGrubu1TableAdapter = new UrunGrubu1TableAdapter();
        public frmSatisIstatistikler()
        {
            InitializeComponent();
        }

        private void frmSatisIstatistikler_Load(object sender, EventArgs e)
        {
            // 1. Tasarım ekranından gelen hatalı/eksik bağlantıyı kodla temizliyoruz
            chartSatilanUrunTablosu.DataSource = null;

            // 2. Özel sorgumuzdan dönen veriyi sanal bir tabloya alıyoruz
            var veriTablosu = this._UrunGrubu1TableAdapter.GetData();

            // 3. Tabloyu BindingSource aracı olmadan doğrudan grafiğe bağlıyoruz
            chartSatilanUrunTablosu.DataSource = veriTablosu;

            // 4. İsim ve Değer sütunlarını kod üzerinden garanti altına alıyoruz
            chartSatilanUrunTablosu.Series[0].ArgumentDataMember = "UrunAdi";
            chartSatilanUrunTablosu.Series[0].ValueDataMembers.Clear();
            chartSatilanUrunTablosu.Series[0].ValueDataMembers.AddRange(new string[] { "ToplamMiktar" });


            chartToptanciSatisMiktari.DataSource = null;

            // Yeni oluşturduğumuz sorgudan veriyi çekiyoruz
            var veriTablosu2 = this._Cari1TableAdapter.GetDataByToptanciSatis();

            // Veriyi grafiğe bağlıyoruz
            chartToptanciSatisMiktari.DataSource = veriTablosu2;
            chartToptanciSatisMiktari.Series[0].ArgumentDataMember = "ToptanciAdi";
            chartToptanciSatisMiktari.Series[0].ValueDataMembers.Clear();
            chartToptanciSatisMiktari.Series[0].ValueDataMembers.AddRange(new string[] { "ToplamMiktar" });
        }
    }
}
