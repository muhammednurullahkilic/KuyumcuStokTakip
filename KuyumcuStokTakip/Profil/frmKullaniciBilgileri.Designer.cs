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
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTelefonNo = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.dtDogumTarihi = new DevExpress.XtraEditors.DateEdit();
            this.lblEskiSifre = new System.Windows.Forms.Label();
            this.lblYeniSifre = new System.Windows.Forms.Label();
            this.lblYeniSifreTekrar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnSifreGuncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tcProfil)).BeginInit();
            this.tcProfil.SuspendLayout();
            this.tpKullaniciBilgileri.SuspendLayout();
            this.tpSifreGuncelleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDogumTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDogumTarihi.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // tcProfil
            // 
            this.tcProfil.Location = new System.Drawing.Point(4, 5);
            this.tcProfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcProfil.Name = "tcProfil";
            this.tcProfil.SelectedTabPage = this.tpKullaniciBilgileri;
            this.tcProfil.Size = new System.Drawing.Size(590, 355);
            this.tcProfil.TabIndex = 0;
            this.tcProfil.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpKullaniciBilgileri,
            this.tpSifreGuncelleme});
            // 
            // tpKullaniciBilgileri
            // 
            this.tpKullaniciBilgileri.Controls.Add(this.dtDogumTarihi);
            this.tpKullaniciBilgileri.Controls.Add(this.txtTelefonNo);
            this.tpKullaniciBilgileri.Controls.Add(this.txtAdSoyad);
            this.tpKullaniciBilgileri.Controls.Add(this.lblDogumTarihi);
            this.tpKullaniciBilgileri.Controls.Add(this.lblTelefonNo);
            this.tpKullaniciBilgileri.Controls.Add(this.lblAdSoyad);
            this.tpKullaniciBilgileri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpKullaniciBilgileri.Name = "tpKullaniciBilgileri";
            this.tpKullaniciBilgileri.Size = new System.Drawing.Size(588, 330);
            this.tpKullaniciBilgileri.Text = "Kullanıcı Bilgileri";
            // 
            // tpSifreGuncelleme
            // 
            this.tpSifreGuncelleme.Controls.Add(this.btnSifreGuncelle);
            this.tpSifreGuncelleme.Controls.Add(this.textBox3);
            this.tpSifreGuncelleme.Controls.Add(this.textBox2);
            this.tpSifreGuncelleme.Controls.Add(this.textBox1);
            this.tpSifreGuncelleme.Controls.Add(this.lblYeniSifreTekrar);
            this.tpSifreGuncelleme.Controls.Add(this.lblYeniSifre);
            this.tpSifreGuncelleme.Controls.Add(this.lblEskiSifre);
            this.tpSifreGuncelleme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpSifreGuncelleme.Name = "tpSifreGuncelleme";
            this.tpSifreGuncelleme.Size = new System.Drawing.Size(588, 330);
            this.tpSifreGuncelleme.Text = "Şifre Güncelleme";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(30, 39);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(57, 13);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblTelefonNo
            // 
            this.lblTelefonNo.AutoSize = true;
            this.lblTelefonNo.Location = new System.Drawing.Point(30, 72);
            this.lblTelefonNo.Name = "lblTelefonNo";
            this.lblTelefonNo.Size = new System.Drawing.Size(63, 13);
            this.lblTelefonNo.TabIndex = 1;
            this.lblTelefonNo.Text = "Telefon No:";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(30, 107);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(73, 13);
            this.lblDogumTarihi.TabIndex = 2;
            this.lblDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(122, 36);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(92, 21);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(122, 69);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(92, 21);
            this.txtTelefonNo.TabIndex = 4;
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.EditValue = null;
            this.dtDogumTarihi.Location = new System.Drawing.Point(122, 104);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDogumTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDogumTarihi.Size = new System.Drawing.Size(94, 20);
            this.dtDogumTarihi.TabIndex = 5;
            // 
            // lblEskiSifre
            // 
            this.lblEskiSifre.AutoSize = true;
            this.lblEskiSifre.Location = new System.Drawing.Point(34, 53);
            this.lblEskiSifre.Name = "lblEskiSifre";
            this.lblEskiSifre.Size = new System.Drawing.Size(60, 13);
            this.lblEskiSifre.TabIndex = 0;
            this.lblEskiSifre.Text = "*Eski Şifre:";
            // 
            // lblYeniSifre
            // 
            this.lblYeniSifre.AutoSize = true;
            this.lblYeniSifre.Location = new System.Drawing.Point(34, 90);
            this.lblYeniSifre.Name = "lblYeniSifre";
            this.lblYeniSifre.Size = new System.Drawing.Size(62, 13);
            this.lblYeniSifre.TabIndex = 1;
            this.lblYeniSifre.Text = "*Yeni Şifre:";
            // 
            // lblYeniSifreTekrar
            // 
            this.lblYeniSifreTekrar.AutoSize = true;
            this.lblYeniSifreTekrar.Location = new System.Drawing.Point(34, 130);
            this.lblYeniSifreTekrar.Name = "lblYeniSifreTekrar";
            this.lblYeniSifreTekrar.Size = new System.Drawing.Size(96, 13);
            this.lblYeniSifreTekrar.TabIndex = 2;
            this.lblYeniSifreTekrar.Text = "*Yeni Şifre Tekrar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 21);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 21);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 21);
            this.textBox3.TabIndex = 5;
            // 
            // btnSifreGuncelle
            // 
            this.btnSifreGuncelle.Location = new System.Drawing.Point(142, 173);
            this.btnSifreGuncelle.Name = "btnSifreGuncelle";
            this.btnSifreGuncelle.Size = new System.Drawing.Size(86, 24);
            this.btnSifreGuncelle.TabIndex = 6;
            this.btnSifreGuncelle.Text = "Güncelle";
            // 
            // frmKullaniciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tcProfil);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmKullaniciBilgileri";
            this.Text = "Kullanıcı Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.tcProfil)).EndInit();
            this.tcProfil.ResumeLayout(false);
            this.tpKullaniciBilgileri.ResumeLayout(false);
            this.tpKullaniciBilgileri.PerformLayout();
            this.tpSifreGuncelleme.ResumeLayout(false);
            this.tpSifreGuncelleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDogumTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDogumTarihi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tcProfil;
        private DevExpress.XtraTab.XtraTabPage tpKullaniciBilgileri;
        private DevExpress.XtraTab.XtraTabPage tpSifreGuncelleme;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblTelefonNo;
        private System.Windows.Forms.Label lblAdSoyad;
        private DevExpress.XtraEditors.DateEdit dtDogumTarihi;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private DevExpress.XtraEditors.SimpleButton btnSifreGuncelle;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblYeniSifreTekrar;
        private System.Windows.Forms.Label lblYeniSifre;
        private System.Windows.Forms.Label lblEskiSifre;
    }
}