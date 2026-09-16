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
            this.XtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.xtpKullaniciBilgileri = new DevExpress.XtraTab.XtraTabPage();
            this.dtDogumTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblTelefonNo = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.xtpSifreGuncelleme = new DevExpress.XtraTab.XtraTabPage();
            this.lblEskiSifre = new System.Windows.Forms.Label();
            this.lblYeniSifre = new System.Windows.Forms.Label();
            this.lblYeniSifreTekrar = new System.Windows.Forms.Label();
            this.txtEskiSifre = new System.Windows.Forms.TextBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.txtYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabControl)).BeginInit();
            this.XtraTabControl.SuspendLayout();
            this.xtpKullaniciBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDogumTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDogumTarihi.Properties.CalendarTimeProperties)).BeginInit();
            this.xtpSifreGuncelleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // XtraTabControl
            // 
            this.XtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XtraTabControl.Location = new System.Drawing.Point(0, 0);
            this.XtraTabControl.Name = "XtraTabControl";
            this.XtraTabControl.SelectedTabPage = this.xtpKullaniciBilgileri;
            this.XtraTabControl.Size = new System.Drawing.Size(1117, 701);
            this.XtraTabControl.TabIndex = 0;
            this.XtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpKullaniciBilgileri,
            this.xtpSifreGuncelleme});
            // 
            // xtpKullaniciBilgileri
            // 
            this.xtpKullaniciBilgileri.Controls.Add(this.dtDogumTarihi);
            this.xtpKullaniciBilgileri.Controls.Add(this.txtTelefonNo);
            this.xtpKullaniciBilgileri.Controls.Add(this.txtAdSoyad);
            this.xtpKullaniciBilgileri.Controls.Add(this.lblDogumTarihi);
            this.xtpKullaniciBilgileri.Controls.Add(this.lblTelefonNo);
            this.xtpKullaniciBilgileri.Controls.Add(this.lblAdSoyad);
            this.xtpKullaniciBilgileri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xtpKullaniciBilgileri.Name = "xtpKullaniciBilgileri";
            this.xtpKullaniciBilgileri.Size = new System.Drawing.Size(1115, 676);
            this.xtpKullaniciBilgileri.Text = "Kullanıcı Bilgileri";
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.EditValue = null;
            this.dtDogumTarihi.Location = new System.Drawing.Point(107, 117);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDogumTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDogumTarihi.Size = new System.Drawing.Size(86, 20);
            this.dtDogumTarihi.TabIndex = 5;
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(107, 82);
            this.txtTelefonNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(86, 21);
            this.txtTelefonNo.TabIndex = 4;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(107, 44);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(86, 21);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(22, 124);
            this.lblDogumTarihi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(69, 13);
            this.lblDogumTarihi.TabIndex = 2;
            this.lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // lblTelefonNo
            // 
            this.lblTelefonNo.AutoSize = true;
            this.lblTelefonNo.Location = new System.Drawing.Point(22, 90);
            this.lblTelefonNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefonNo.Name = "lblTelefonNo";
            this.lblTelefonNo.Size = new System.Drawing.Size(59, 13);
            this.lblTelefonNo.TabIndex = 1;
            this.lblTelefonNo.Text = "Telefon No";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(22, 52);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // xtpSifreGuncelleme
            // 
            this.xtpSifreGuncelleme.Controls.Add(this.btnGuncelle);
            this.xtpSifreGuncelleme.Controls.Add(this.txtYeniSifreTekrar);
            this.xtpSifreGuncelleme.Controls.Add(this.txtYeniSifre);
            this.xtpSifreGuncelleme.Controls.Add(this.txtEskiSifre);
            this.xtpSifreGuncelleme.Controls.Add(this.lblYeniSifreTekrar);
            this.xtpSifreGuncelleme.Controls.Add(this.lblYeniSifre);
            this.xtpSifreGuncelleme.Controls.Add(this.lblEskiSifre);
            this.xtpSifreGuncelleme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xtpSifreGuncelleme.Name = "xtpSifreGuncelleme";
            this.xtpSifreGuncelleme.Size = new System.Drawing.Size(995, 597);
            this.xtpSifreGuncelleme.Text = "Şifre Güncelleme";
            // 
            // lblEskiSifre
            // 
            this.lblEskiSifre.AutoSize = true;
            this.lblEskiSifre.Location = new System.Drawing.Point(41, 41);
            this.lblEskiSifre.Name = "lblEskiSifre";
            this.lblEskiSifre.Size = new System.Drawing.Size(50, 13);
            this.lblEskiSifre.TabIndex = 0;
            this.lblEskiSifre.Text = "Eski Şifre";
            // 
            // lblYeniSifre
            // 
            this.lblYeniSifre.AutoSize = true;
            this.lblYeniSifre.Location = new System.Drawing.Point(39, 80);
            this.lblYeniSifre.Name = "lblYeniSifre";
            this.lblYeniSifre.Size = new System.Drawing.Size(52, 13);
            this.lblYeniSifre.TabIndex = 1;
            this.lblYeniSifre.Text = "Yeni Şifre";
            // 
            // lblYeniSifreTekrar
            // 
            this.lblYeniSifreTekrar.AutoSize = true;
            this.lblYeniSifreTekrar.Location = new System.Drawing.Point(39, 120);
            this.lblYeniSifreTekrar.Name = "lblYeniSifreTekrar";
            this.lblYeniSifreTekrar.Size = new System.Drawing.Size(86, 13);
            this.lblYeniSifreTekrar.TabIndex = 2;
            this.lblYeniSifreTekrar.Text = "Yeni Şifre Tekrar";
            // 
            // txtEskiSifre
            // 
            this.txtEskiSifre.Location = new System.Drawing.Point(166, 33);
            this.txtEskiSifre.Name = "txtEskiSifre";
            this.txtEskiSifre.Size = new System.Drawing.Size(91, 21);
            this.txtEskiSifre.TabIndex = 3;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(166, 72);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(91, 21);
            this.txtYeniSifre.TabIndex = 4;
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(166, 112);
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(91, 21);
            this.txtYeniSifreTekrar.TabIndex = 5;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(156, 163);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(111, 30);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            // 
            // frmKullaniciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 701);
            this.Controls.Add(this.XtraTabControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmKullaniciBilgileri";
            this.Text = "Kullanıcı Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabControl)).EndInit();
            this.XtraTabControl.ResumeLayout(false);
            this.xtpKullaniciBilgileri.ResumeLayout(false);
            this.xtpKullaniciBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDogumTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDogumTarihi.Properties)).EndInit();
            this.xtpSifreGuncelleme.ResumeLayout(false);
            this.xtpSifreGuncelleme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl XtraTabControl;
        private DevExpress.XtraTab.XtraTabPage xtpKullaniciBilgileri;
        private DevExpress.XtraTab.XtraTabPage xtpSifreGuncelleme;
        private DevExpress.XtraEditors.DateEdit dtDogumTarihi;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblTelefonNo;
        private System.Windows.Forms.Label lblAdSoyad;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private System.Windows.Forms.TextBox txtYeniSifreTekrar;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.TextBox txtEskiSifre;
        private System.Windows.Forms.Label lblYeniSifreTekrar;
        private System.Windows.Forms.Label lblYeniSifre;
        private System.Windows.Forms.Label lblEskiSifre;
    }
}