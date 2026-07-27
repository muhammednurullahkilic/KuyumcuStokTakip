namespace KuyumcuStokTakip.GirisEkrani
{
    partial class frmGiris
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
            this.txtKullaniciAdiGiris = new DevExpress.XtraEditors.TextEdit();
            this.txtSifreGiris = new DevExpress.XtraEditors.TextEdit();
            this.lblKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            this.lblSifre = new DevExpress.XtraEditors.LabelControl();
            this.btnGirisYap = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdiGiris.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreGiris.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullaniciAdiGiris
            // 
            this.txtKullaniciAdiGiris.Location = new System.Drawing.Point(120, 39);
            this.txtKullaniciAdiGiris.Name = "txtKullaniciAdiGiris";
            this.txtKullaniciAdiGiris.Size = new System.Drawing.Size(121, 22);
            this.txtKullaniciAdiGiris.TabIndex = 0;
            // 
            // txtSifreGiris
            // 
            this.txtSifreGiris.Location = new System.Drawing.Point(120, 83);
            this.txtSifreGiris.Name = "txtSifreGiris";
            this.txtSifreGiris.Size = new System.Drawing.Size(121, 22);
            this.txtSifreGiris.TabIndex = 1;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Location = new System.Drawing.Point(12, 45);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(81, 16);
            this.lblKullaniciAdi.TabIndex = 2;
            this.lblKullaniciAdi.Text = "*Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.Location = new System.Drawing.Point(12, 86);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(40, 16);
            this.lblSifre.TabIndex = 3;
            this.lblSifre.Text = "*Şifre:";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(120, 143);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(118, 35);
            this.btnGirisYap.TabIndex = 4;
            this.btnGirisYap.Text = "Giriş Yap";
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 260);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.txtSifreGiris);
            this.Controls.Add(this.txtKullaniciAdiGiris);
            this.Name = "frmGiris";
            this.Text = "frmGiris";
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdiGiris.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreGiris.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtKullaniciAdiGiris;
        private DevExpress.XtraEditors.TextEdit txtSifreGiris;
        private DevExpress.XtraEditors.LabelControl lblKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl lblSifre;
        private DevExpress.XtraEditors.SimpleButton btnGirisYap;
    }
}