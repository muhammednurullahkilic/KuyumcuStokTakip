namespace KuyumcuStokTakip.GirisEkrani
{
    partial class frmGirisYap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            this.lblSifre = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new DevExpress.XtraEditors.SimpleButton();
            this.chkBeniHatirla = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Location = new System.Drawing.Point(23, 35);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(65, 13);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "*Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.Location = new System.Drawing.Point(23, 67);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(28, 13);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "*Şifre";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(117, 32);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(103, 21);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(117, 67);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(103, 21);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(81, 146);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(101, 17);
            this.btnGirisYap.TabIndex = 4;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // chkBeniHatirla
            // 
            this.chkBeniHatirla.AutoSize = true;
            this.chkBeniHatirla.Location = new System.Drawing.Point(117, 113);
            this.chkBeniHatirla.Name = "chkBeniHatirla";
            this.chkBeniHatirla.Size = new System.Drawing.Size(80, 17);
            this.chkBeniHatirla.TabIndex = 5;
            this.chkBeniHatirla.Text = "Beni Hatırla";
            this.chkBeniHatirla.UseVisualStyleBackColor = true;
            // 
            // frmGirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 211);
            this.Controls.Add(this.chkBeniHatirla);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGirisYap";
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.frmGirisYap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl lblSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private DevExpress.XtraEditors.SimpleButton btnGirisYap;
        private System.Windows.Forms.CheckBox chkBeniHatirla;
    }
}