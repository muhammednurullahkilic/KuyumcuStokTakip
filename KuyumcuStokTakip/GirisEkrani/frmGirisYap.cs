using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace KuyumcuStokTakip.GirisEkrani
{
    public partial class frmGirisYap : DevExpress.XtraEditors.XtraForm
    {
        public frmGirisYap()
        {
            InitializeComponent();
        }


        private void frmGirisYap_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.BeniHatirla == true)
            {
                txtKullaniciAdi.Text = Properties.Settings.Default.KullaniciAdi;
                txtSifre.Text = Properties.Settings.Default.Sifre;
                chkBeniHatirla.Checked = true;
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullanciAdi = "admin";
            string Sifre = "123";

            
            if (txtKullaniciAdi.Text == kullanciAdi && txtSifre.Text == Sifre)
            {
                
                if (chkBeniHatirla.Checked == true)
                {
                    
                    Properties.Settings.Default.KullaniciAdi = txtKullaniciAdi.Text;
                    Properties.Settings.Default.Sifre = txtSifre.Text;
                    Properties.Settings.Default.BeniHatirla = true;
                }
                else
                {
                   
                    Properties.Settings.Default.KullaniciAdi = "";
                    Properties.Settings.Default.Sifre = "";
                    Properties.Settings.Default.BeniHatirla = false;
                }

                
                Properties.Settings.Default.Save();

               
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