using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuyumcuStokTakip.GirisEkrani
{
    public partial class frmGirisYap : DevExpress.XtraEditors.XtraForm
    {
        public frmGirisYap()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullanciAdi = "admin";
            string Sifre = "123";
            bool isLogin = false;

            if (txtKullaniciAdi.Text == kullanciAdi && txtSifre.Text == Sifre)
            {
                frmMain anaForm = new frmMain(System.Globalization.CultureInfo.CurrentCulture);
                anaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                
            }


        }
    }
}