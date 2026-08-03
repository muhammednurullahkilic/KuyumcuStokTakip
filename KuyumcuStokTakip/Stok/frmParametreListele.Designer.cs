namespace KuyumcuStokTakip.Stok
{
    partial class frmParametreListele
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnUrunGrupKayıt = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunAyarKayıt = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtpUrunGrubu = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlUrunGrup = new DevExpress.XtraGrid.GridControl();
            this.gridUrunGrup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridUrunAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUrunKisaKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUrunGrupAktifMi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUrunGrupOlusturanPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUrunGrupOlusturmaTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUrunGrupGuncelleyenPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUrunGrupGuncellemeTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtpAyarGrup = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlAyarGrup = new DevExpress.XtraGrid.GridControl();
            this.gridAyarGrup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridAyar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAyarAktifMi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAyarOlusturanPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridOlusturmaTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAyarGüncelleyenPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAyarGuncellemeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtpUrunGrubu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunGrup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunGrup)).BeginInit();
            this.xtpAyarGrup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAyarGrup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAyarGrup)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnUrunGrupKayıt,
            this.btnUrunAyarKayıt});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUrunGrupKayıt),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUrunAyarKayıt)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnUrunGrupKayıt
            // 
            this.btnUrunGrupKayıt.Caption = "Ürün Grubu Kayıt";
            this.btnUrunGrupKayıt.Id = 0;
            this.btnUrunGrupKayıt.Name = "btnUrunGrupKayıt";
            this.btnUrunGrupKayıt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunGrupKayıt_ItemClick);
            // 
            // btnUrunAyarKayıt
            // 
            this.btnUrunAyarKayıt.Caption = "Ayar Grubu Kayıt";
            this.btnUrunAyarKayıt.Id = 1;
            this.btnUrunAyarKayıt.Name = "btnUrunAyarKayıt";
            this.btnUrunAyarKayıt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunAyarKayıt_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(938, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 532);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(938, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 512);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(938, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 512);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 20);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtpUrunGrubu;
            this.xtraTabControl1.Size = new System.Drawing.Size(938, 512);
            this.xtraTabControl1.TabIndex = 15;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpUrunGrubu,
            this.xtpAyarGrup});
            // 
            // xtpUrunGrubu
            // 
            this.xtpUrunGrubu.Controls.Add(this.gridControlUrunGrup);
            this.xtpUrunGrubu.Name = "xtpUrunGrubu";
            this.xtpUrunGrubu.Size = new System.Drawing.Size(936, 487);
            this.xtpUrunGrubu.Text = "Ürün Grubu Liste";
            // 
            // gridControlUrunGrup
            // 
            this.gridControlUrunGrup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUrunGrup.Location = new System.Drawing.Point(0, 0);
            this.gridControlUrunGrup.MainView = this.gridUrunGrup;
            this.gridControlUrunGrup.MenuManager = this.barManager1;
            this.gridControlUrunGrup.Name = "gridControlUrunGrup";
            this.gridControlUrunGrup.Size = new System.Drawing.Size(936, 487);
            this.gridControlUrunGrup.TabIndex = 0;
            this.gridControlUrunGrup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUrunGrup});
            // 
            // gridUrunGrup
            // 
            this.gridUrunGrup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridUrunAd,
            this.gridUrunKisaKod,
            this.gridUrunGrupAktifMi,
            this.gridUrunGrupOlusturanPersonel,
            this.gridUrunGrupOlusturmaTarih,
            this.gridUrunGrupGuncelleyenPersonel,
            this.gridUrunGrupGuncellemeTarih});
            this.gridUrunGrup.GridControl = this.gridControlUrunGrup;
            this.gridUrunGrup.GroupPanelText = "Ürün Grupları Listesi";
            this.gridUrunGrup.Name = "gridUrunGrup";
            this.gridUrunGrup.OptionsBehavior.Editable = false;
            // 
            // gridUrunAd
            // 
            this.gridUrunAd.Caption = "Ürün Ad";
            this.gridUrunAd.FieldName = "GrupAd";
            this.gridUrunAd.Name = "gridUrunAd";
            this.gridUrunAd.Visible = true;
            this.gridUrunAd.VisibleIndex = 0;
            // 
            // gridUrunKisaKod
            // 
            this.gridUrunKisaKod.Caption = "Ürün Kısa Kod";
            this.gridUrunKisaKod.FieldName = "GrupKod";
            this.gridUrunKisaKod.Name = "gridUrunKisaKod";
            this.gridUrunKisaKod.Visible = true;
            this.gridUrunKisaKod.VisibleIndex = 1;
            // 
            // gridUrunGrupAktifMi
            // 
            this.gridUrunGrupAktifMi.Caption = "Aktif Mi";
            this.gridUrunGrupAktifMi.FieldName = "isActive";
            this.gridUrunGrupAktifMi.Name = "gridUrunGrupAktifMi";
            this.gridUrunGrupAktifMi.Visible = true;
            this.gridUrunGrupAktifMi.VisibleIndex = 2;
            // 
            // gridUrunGrupOlusturanPersonel
            // 
            this.gridUrunGrupOlusturanPersonel.Caption = "Oluşturan Personel";
            this.gridUrunGrupOlusturanPersonel.FieldName = "CUser";
            this.gridUrunGrupOlusturanPersonel.Name = "gridUrunGrupOlusturanPersonel";
            this.gridUrunGrupOlusturanPersonel.Visible = true;
            this.gridUrunGrupOlusturanPersonel.VisibleIndex = 3;
            // 
            // gridUrunGrupOlusturmaTarih
            // 
            this.gridUrunGrupOlusturmaTarih.Caption = "Oluşturulma Tarihi";
            this.gridUrunGrupOlusturmaTarih.FieldName = "CDate";
            this.gridUrunGrupOlusturmaTarih.Name = "gridUrunGrupOlusturmaTarih";
            this.gridUrunGrupOlusturmaTarih.Visible = true;
            this.gridUrunGrupOlusturmaTarih.VisibleIndex = 4;
            // 
            // gridUrunGrupGuncelleyenPersonel
            // 
            this.gridUrunGrupGuncelleyenPersonel.Caption = "Güncelleyen Personel";
            this.gridUrunGrupGuncelleyenPersonel.FieldName = "MUserID";
            this.gridUrunGrupGuncelleyenPersonel.Name = "gridUrunGrupGuncelleyenPersonel";
            this.gridUrunGrupGuncelleyenPersonel.Visible = true;
            this.gridUrunGrupGuncelleyenPersonel.VisibleIndex = 5;
            // 
            // gridUrunGrupGuncellemeTarih
            // 
            this.gridUrunGrupGuncellemeTarih.Caption = "Güncelleme Tarih";
            this.gridUrunGrupGuncellemeTarih.FieldName = "MDate";
            this.gridUrunGrupGuncellemeTarih.Name = "gridUrunGrupGuncellemeTarih";
            this.gridUrunGrupGuncellemeTarih.Visible = true;
            this.gridUrunGrupGuncellemeTarih.VisibleIndex = 6;
            // 
            // xtpAyarGrup
            // 
            this.xtpAyarGrup.Controls.Add(this.gridControlAyarGrup);
            this.xtpAyarGrup.Name = "xtpAyarGrup";
            this.xtpAyarGrup.Size = new System.Drawing.Size(936, 487);
            this.xtpAyarGrup.Text = "Ayar Grubu Liste";
            // 
            // gridControlAyarGrup
            // 
            this.gridControlAyarGrup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAyarGrup.Location = new System.Drawing.Point(0, 0);
            this.gridControlAyarGrup.MainView = this.gridAyarGrup;
            this.gridControlAyarGrup.MenuManager = this.barManager1;
            this.gridControlAyarGrup.Name = "gridControlAyarGrup";
            this.gridControlAyarGrup.Size = new System.Drawing.Size(936, 487);
            this.gridControlAyarGrup.TabIndex = 0;
            this.gridControlAyarGrup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridAyarGrup});
            // 
            // gridAyarGrup
            // 
            this.gridAyarGrup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridAyar,
            this.gridAyarAktifMi,
            this.gridAyarOlusturanPersonel,
            this.gridOlusturmaTarihi,
            this.gridAyarGüncelleyenPersonel,
            this.gridAyarGuncellemeTarihi});
            this.gridAyarGrup.GridControl = this.gridControlAyarGrup;
            this.gridAyarGrup.GroupPanelText = "Ayar Gruplar Listesi";
            this.gridAyarGrup.Name = "gridAyarGrup";
            this.gridAyarGrup.OptionsBehavior.Editable = false;
            // 
            // gridAyar
            // 
            this.gridAyar.Caption = "Ayar";
            this.gridAyar.FieldName = "AyarAdi";
            this.gridAyar.Name = "gridAyar";
            this.gridAyar.Visible = true;
            this.gridAyar.VisibleIndex = 0;
            // 
            // gridAyarAktifMi
            // 
            this.gridAyarAktifMi.Caption = "Aktif Mi";
            this.gridAyarAktifMi.FieldName = "isActive";
            this.gridAyarAktifMi.Name = "gridAyarAktifMi";
            this.gridAyarAktifMi.Visible = true;
            this.gridAyarAktifMi.VisibleIndex = 1;
            // 
            // gridAyarOlusturanPersonel
            // 
            this.gridAyarOlusturanPersonel.Caption = "Oluşturan Personel";
            this.gridAyarOlusturanPersonel.FieldName = "CUser";
            this.gridAyarOlusturanPersonel.Name = "gridAyarOlusturanPersonel";
            this.gridAyarOlusturanPersonel.Visible = true;
            this.gridAyarOlusturanPersonel.VisibleIndex = 2;
            // 
            // gridOlusturmaTarihi
            // 
            this.gridOlusturmaTarihi.Caption = "Oluşturma Tarihi";
            this.gridOlusturmaTarihi.FieldName = "CDate";
            this.gridOlusturmaTarihi.Name = "gridOlusturmaTarihi";
            this.gridOlusturmaTarihi.Visible = true;
            this.gridOlusturmaTarihi.VisibleIndex = 3;
            // 
            // gridAyarGüncelleyenPersonel
            // 
            this.gridAyarGüncelleyenPersonel.Caption = "Güncelleyen Personel";
            this.gridAyarGüncelleyenPersonel.FieldName = "MUserID";
            this.gridAyarGüncelleyenPersonel.Name = "gridAyarGüncelleyenPersonel";
            this.gridAyarGüncelleyenPersonel.Visible = true;
            this.gridAyarGüncelleyenPersonel.VisibleIndex = 4;
            // 
            // gridAyarGuncellemeTarihi
            // 
            this.gridAyarGuncellemeTarihi.Caption = "Güncelleme Tarihi";
            this.gridAyarGuncellemeTarihi.FieldName = "MDate";
            this.gridAyarGuncellemeTarihi.Name = "gridAyarGuncellemeTarihi";
            this.gridAyarGuncellemeTarihi.Visible = true;
            this.gridAyarGuncellemeTarihi.VisibleIndex = 5;
            // 
            // frmParametreListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 532);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmParametreListele";
            this.Text = "Parametre Listesi";
            this.Load += new System.EventHandler(this.frmParametreListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtpUrunGrubu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunGrup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunGrup)).EndInit();
            this.xtpAyarGrup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAyarGrup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAyarGrup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnUrunGrupKayıt;
        private DevExpress.XtraBars.BarButtonItem btnUrunAyarKayıt;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtpUrunGrubu;
        private DevExpress.XtraGrid.GridControl gridControlUrunGrup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUrunGrup;
        private DevExpress.XtraTab.XtraTabPage xtpAyarGrup;
        private DevExpress.XtraGrid.GridControl gridControlAyarGrup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridAyarGrup;
        private DevExpress.XtraGrid.Columns.GridColumn gridUrunAd;
        private DevExpress.XtraGrid.Columns.GridColumn gridUrunKisaKod;
        private DevExpress.XtraGrid.Columns.GridColumn gridUrunGrupAktifMi;
        private DevExpress.XtraGrid.Columns.GridColumn gridUrunGrupOlusturanPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn gridUrunGrupOlusturmaTarih;
        private DevExpress.XtraGrid.Columns.GridColumn gridUrunGrupGuncelleyenPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn gridUrunGrupGuncellemeTarih;
        private DevExpress.XtraGrid.Columns.GridColumn gridAyar;
        private DevExpress.XtraGrid.Columns.GridColumn gridAyarAktifMi;
        private DevExpress.XtraGrid.Columns.GridColumn gridAyarOlusturanPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn gridOlusturmaTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn gridAyarGüncelleyenPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn gridAyarGuncellemeTarihi;
    }
}