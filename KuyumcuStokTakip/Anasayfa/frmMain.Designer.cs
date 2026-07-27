namespace KuyumcuStokTakip
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.rbnKuyumcuStokTakip = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.grpCari = new DevExpress.XtraBars.BarSubItem();
            this.btnCariKayitListesi = new DevExpress.XtraBars.BarButtonItem();
            this.grpStok = new DevExpress.XtraBars.BarSubItem();
            this.btnStokKayitListesi = new DevExpress.XtraBars.BarButtonItem();
            this.grpFatura = new DevExpress.XtraBars.BarSubItem();
            this.btnSatisFatura = new DevExpress.XtraBars.BarButtonItem();
            this.btnAlisFatura = new DevExpress.XtraBars.BarButtonItem();
            this.grpRapor = new DevExpress.XtraBars.BarSubItem();
            this.btnIslemGecmisi = new DevExpress.XtraBars.BarButtonItem();
            this.grpProfil = new DevExpress.XtraBars.BarSubItem();
            this.btnKullaniciBilgileri = new DevExpress.XtraBars.BarButtonItem();
            this.btnSifreGuncelleme = new DevExpress.XtraBars.BarButtonItem();
            this.rbnERP = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbnCariIslemler = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnStokIslemler = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnFaturaIslemler = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnRaporIslemler = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnProfilIslemler = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnParametre = new DevExpress.XtraBars.BarButtonItem();
            this.btnSatisIstatistikler = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.rbnKuyumcuStokTakip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbnKuyumcuStokTakip
            // 
            this.rbnKuyumcuStokTakip.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.rbnKuyumcuStokTakip.ExpandCollapseItem.Id = 0;
            this.rbnKuyumcuStokTakip.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbnKuyumcuStokTakip.ExpandCollapseItem,
            this.grpCari,
            this.btnCariKayitListesi,
            this.grpStok,
            this.btnStokKayitListesi,
            this.grpFatura,
            this.btnSatisFatura,
            this.grpRapor,
            this.grpProfil,
            this.btnKullaniciBilgileri,
            this.btnSifreGuncelleme,
            this.btnAlisFatura,
            this.btnIslemGecmisi,
            this.barButtonItem1,
            this.btnParametre,
            this.btnSatisIstatistikler});
            this.rbnKuyumcuStokTakip.Location = new System.Drawing.Point(0, 0);
            this.rbnKuyumcuStokTakip.Margin = new System.Windows.Forms.Padding(4);
            this.rbnKuyumcuStokTakip.MaxItemId = 23;
            this.rbnKuyumcuStokTakip.Name = "rbnKuyumcuStokTakip";
            this.rbnKuyumcuStokTakip.OptionsMenuMinWidth = 385;
            this.rbnKuyumcuStokTakip.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbnERP});
            this.rbnKuyumcuStokTakip.Size = new System.Drawing.Size(884, 193);
            // 
            // grpCari
            // 
            this.grpCari.Caption = "   Cari            ";
            this.grpCari.Id = 1;
            this.grpCari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpCari.ImageOptions.Image")));
            this.grpCari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("grpCari.ImageOptions.LargeImage")));
            this.grpCari.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCariKayitListesi)});
            this.grpCari.Name = "grpCari";
            // 
            // btnCariKayitListesi
            // 
            this.btnCariKayitListesi.Caption = "Cari Kayıtlar Listesi";
            this.btnCariKayitListesi.Id = 2;
            this.btnCariKayitListesi.Name = "btnCariKayitListesi";
            this.btnCariKayitListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCariKayitListesi_ItemClick);
            // 
            // grpStok
            // 
            this.grpStok.Caption = "Stok";
            this.grpStok.Id = 3;
            this.grpStok.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpStok.ImageOptions.Image")));
            this.grpStok.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("grpStok.ImageOptions.LargeImage")));
            this.grpStok.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnStokKayitListesi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnParametre)});
            this.grpStok.Name = "grpStok";
            // 
            // btnStokKayitListesi
            // 
            this.btnStokKayitListesi.Caption = "Stok Kayıt Listesi";
            this.btnStokKayitListesi.Id = 4;
            this.btnStokKayitListesi.Name = "btnStokKayitListesi";
            // 
            // grpFatura
            // 
            this.grpFatura.Caption = "Fatura";
            this.grpFatura.Id = 5;
            this.grpFatura.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpFatura.ImageOptions.Image")));
            this.grpFatura.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("grpFatura.ImageOptions.LargeImage")));
            this.grpFatura.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSatisFatura),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAlisFatura)});
            this.grpFatura.Name = "grpFatura";
            // 
            // btnSatisFatura
            // 
            this.btnSatisFatura.Caption = "Satış Fatura";
            this.btnSatisFatura.Id = 6;
            this.btnSatisFatura.Name = "btnSatisFatura";
            // 
            // btnAlisFatura
            // 
            this.btnAlisFatura.Caption = "Alış Fatura";
            this.btnAlisFatura.Id = 18;
            this.btnAlisFatura.Name = "btnAlisFatura";
            // 
            // grpRapor
            // 
            this.grpRapor.Caption = "Rapor";
            this.grpRapor.Id = 11;
            this.grpRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpRapor.ImageOptions.Image")));
            this.grpRapor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("grpRapor.ImageOptions.LargeImage")));
            this.grpRapor.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnIslemGecmisi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSatisIstatistikler)});
            this.grpRapor.Name = "grpRapor";
            // 
            // btnIslemGecmisi
            // 
            this.btnIslemGecmisi.Caption = "İşlem Geçmişi";
            this.btnIslemGecmisi.Id = 19;
            this.btnIslemGecmisi.Name = "btnIslemGecmisi";
            // 
            // grpProfil
            // 
            this.grpProfil.Caption = "Profil";
            this.grpProfil.Id = 13;
            this.grpProfil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpProfil.ImageOptions.Image")));
            this.grpProfil.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("grpProfil.ImageOptions.LargeImage")));
            this.grpProfil.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnKullaniciBilgileri),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSifreGuncelleme)});
            this.grpProfil.Name = "grpProfil";
            // 
            // btnKullaniciBilgileri
            // 
            this.btnKullaniciBilgileri.Caption = "Kullanıcı Bilgileri";
            this.btnKullaniciBilgileri.Id = 14;
            this.btnKullaniciBilgileri.Name = "btnKullaniciBilgileri";
            // 
            // btnSifreGuncelleme
            // 
            this.btnSifreGuncelleme.Caption = "Şifre Güncelleme";
            this.btnSifreGuncelleme.Id = 15;
            this.btnSifreGuncelleme.Name = "btnSifreGuncelleme";
            // 
            // rbnERP
            // 
            this.rbnERP.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbnCariIslemler,
            this.rbnStokIslemler,
            this.rbnFaturaIslemler,
            this.rbnRaporIslemler,
            this.rbnProfilIslemler});
            this.rbnERP.Name = "rbnERP";
            this.rbnERP.Text = "ERP";
            // 
            // rbnCariIslemler
            // 
            this.rbnCariIslemler.ItemLinks.Add(this.grpCari);
            this.rbnCariIslemler.Name = "rbnCariIslemler";
            this.rbnCariIslemler.Text = "Cari İşlemler";
            // 
            // rbnStokIslemler
            // 
            this.rbnStokIslemler.ItemLinks.Add(this.grpStok);
            this.rbnStokIslemler.Name = "rbnStokIslemler";
            this.rbnStokIslemler.Text = "Stok İşlemleri";
            // 
            // rbnFaturaIslemler
            // 
            this.rbnFaturaIslemler.ItemLinks.Add(this.grpFatura);
            this.rbnFaturaIslemler.Name = "rbnFaturaIslemler";
            this.rbnFaturaIslemler.Text = "Fatura İşlemleri";
            // 
            // rbnRaporIslemler
            // 
            this.rbnRaporIslemler.ItemLinks.Add(this.grpRapor);
            this.rbnRaporIslemler.Name = "rbnRaporIslemler";
            this.rbnRaporIslemler.Text = "Rapor İşlemleri";
            // 
            // rbnProfilIslemler
            // 
            this.rbnProfilIslemler.ItemLinks.Add(this.grpProfil);
            this.rbnProfilIslemler.Name = "rbnProfilIslemler";
            this.rbnProfilIslemler.Text = "Profil İşlemleri";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 20;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnParametre
            // 
            this.btnParametre.Caption = "Parametre";
            this.btnParametre.Id = 21;
            this.btnParametre.Name = "btnParametre";
            // 
            // btnSatisIstatistikler
            // 
            this.btnSatisIstatistikler.Caption = "Satış İstatistikleri";
            this.btnSatisIstatistikler.Id = 22;
            this.btnSatisIstatistikler.Name = "btnSatisIstatistikler";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 443);
            this.Controls.Add(this.rbnKuyumcuStokTakip);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Ribbon = this.rbnKuyumcuStokTakip;
            this.Text = "Kuyumcu Stok Takip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.rbnKuyumcuStokTakip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rbnKuyumcuStokTakip;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbnERP;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnCariIslemler;
        private DevExpress.XtraBars.BarSubItem grpCari;
        private DevExpress.XtraBars.BarButtonItem btnCariKayitListesi;
        private DevExpress.XtraBars.BarSubItem grpStok;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnStokIslemler;
        private DevExpress.XtraBars.BarButtonItem btnStokKayitListesi;
        private DevExpress.XtraBars.BarSubItem grpFatura;
        private DevExpress.XtraBars.BarButtonItem btnSatisFatura;
        private DevExpress.XtraBars.BarSubItem grpRapor;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnFaturaIslemler;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnRaporIslemler;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnProfilIslemler;
        private DevExpress.XtraBars.BarSubItem grpProfil;
        private DevExpress.XtraBars.BarButtonItem btnKullaniciBilgileri;
        private DevExpress.XtraBars.BarButtonItem btnSifreGuncelleme;
        private DevExpress.XtraBars.BarButtonItem btnAlisFatura;
        private DevExpress.XtraBars.BarButtonItem btnIslemGecmisi;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnParametre;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnSatisIstatistikler;
    }
}

