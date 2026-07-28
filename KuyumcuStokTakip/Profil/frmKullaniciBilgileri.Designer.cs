namespace KuyumcuStokTakip.Profil
{
    partial class frmKullaniciBilgileri
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
            this.tcProfil = new DevExpress.XtraTab.XtraTabControl();
            this.tpKullaniciBilgileri = new DevExpress.XtraTab.XtraTabPage();
            this.tpSifreGuncelleme = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.tcProfil)).BeginInit();
            this.tcProfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcProfil
            // 
            this.tcProfil.Location = new System.Drawing.Point(6, 6);
            this.tcProfil.Name = "tcProfil";
            this.tcProfil.SelectedTabPage = this.tpKullaniciBilgileri;
            this.tcProfil.Size = new System.Drawing.Size(787, 437);
            this.tcProfil.TabIndex = 0;
            this.tcProfil.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpKullaniciBilgileri,
            this.tpSifreGuncelleme});
            // 
            // tpKullaniciBilgileri
            // 
            this.tpKullaniciBilgileri.Name = "tpKullaniciBilgileri";
            this.tpKullaniciBilgileri.Size = new System.Drawing.Size(785, 407);
            this.tpKullaniciBilgileri.Text = "Kullanıcı Bilgileri";
            // 
            // tpSifreGuncelleme
            // 
            this.tpSifreGuncelleme.Name = "tpSifreGuncelleme";
            this.tpSifreGuncelleme.Size = new System.Drawing.Size(785, 407);
            this.tpSifreGuncelleme.Text = "Şifre Güncelleme";
            // 
            // frmKullaniciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcProfil);
            this.Name = "frmKullaniciBilgileri";
            this.Text = "Kullanıcı Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.tcProfil)).EndInit();
            this.tcProfil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tcProfil;
        private DevExpress.XtraTab.XtraTabPage tpKullaniciBilgileri;
        private DevExpress.XtraTab.XtraTabPage tpSifreGuncelleme;
    }
}