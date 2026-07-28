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

namespace KuyumcuStokTakip
{
    public partial class frmCariKayit : Form
    {

        private readonly CariTableAdapter _cariTableAdapter = new CariTableAdapter();
        private readonly CariTipTableAdapter _cariTipTableAdapter = new CariTipTableAdapter();

        public frmCariKayit()
        {
            InitializeComponent();

            cariTip();
        }

        private void cariTip()
        {
            gleCariTip.Properties.DataSource = _cariTipTableAdapter.GetData();
            gleCariTip.Properties.ValueMember = "ID";
            gleCariTip.Properties.DisplayMember = "Tip";
        }

        private void btnCariKayit_Click(object sender, EventArgs e)
        {
            _cariTableAdapter.InsertQuery(txtCariKod.Text,Convert.ToInt32(gleCariTip.EditValue),txtCariAd.Text,txtAdres.Text,txtNot.Text,txtTelefonNo.Text,1,DateTime.Now,true);

            
        }
    }
}
