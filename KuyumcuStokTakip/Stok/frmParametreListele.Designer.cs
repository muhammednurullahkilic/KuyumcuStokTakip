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
            this.gridControlUrunGrubu = new DevExpress.XtraGrid.GridControl();
            this.gridUrunGrubuParametre = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridUrunID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUrunAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUrunKısaKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUrunAktifMi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUrunGrupPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUpdatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlUrunAyar = new DevExpress.XtraGrid.GridControl();
            this.gridUrunAyarParametre = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridAyarID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAyarAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAyarAktifMi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAyarPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAyarCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAyarUpdatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunGrubu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunGrubuParametre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunAyar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunAyarParametre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
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
            this.barDockControlTop.Size = new System.Drawing.Size(1250, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 655);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1250, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 630);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1250, 25);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 630);
            // 
            // gridControlUrunGrubu
            // 
            this.gridControlUrunGrubu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUrunGrubu.Location = new System.Drawing.Point(0, 0);
            this.gridControlUrunGrubu.MainView = this.gridUrunGrubuParametre;
            this.gridControlUrunGrubu.MenuManager = this.barManager1;
            this.gridControlUrunGrubu.Name = "gridControlUrunGrubu";
            this.gridControlUrunGrubu.Size = new System.Drawing.Size(602, 630);
            this.gridControlUrunGrubu.TabIndex = 4;
            this.gridControlUrunGrubu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUrunGrubuParametre});
            // 
            // gridUrunGrubuParametre
            // 
            this.gridUrunGrubuParametre.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridUrunID,
            this.gridUrunAd,
            this.gridUrunKısaKod,
            this.gridUrunAktifMi,
            this.gridUrunGrupPersonel,
            this.gridCreatedDate,
            this.gridUpdatedDate});
            this.gridUrunGrubuParametre.GridControl = this.gridControlUrunGrubu;
            this.gridUrunGrubuParametre.GroupPanelText = "Ürün Grubu Parametre Listesi";
            this.gridUrunGrubuParametre.Name = "gridUrunGrubuParametre";
            // 
            // gridUrunID
            // 
            this.gridUrunID.Caption = "Ürün ID";
            this.gridUrunID.MinWidth = 25;
            this.gridUrunID.Name = "gridUrunID";
            this.gridUrunID.Visible = true;
            this.gridUrunID.VisibleIndex = 0;
            this.gridUrunID.Width = 94;
            // 
            // gridUrunAd
            // 
            this.gridUrunAd.Caption = "Ürün Ad";
            this.gridUrunAd.MinWidth = 25;
            this.gridUrunAd.Name = "gridUrunAd";
            this.gridUrunAd.Visible = true;
            this.gridUrunAd.VisibleIndex = 1;
            this.gridUrunAd.Width = 94;
            // 
            // gridUrunKısaKod
            // 
            this.gridUrunKısaKod.Caption = "Ürün Kısa Kod";
            this.gridUrunKısaKod.MinWidth = 25;
            this.gridUrunKısaKod.Name = "gridUrunKısaKod";
            this.gridUrunKısaKod.Visible = true;
            this.gridUrunKısaKod.VisibleIndex = 2;
            this.gridUrunKısaKod.Width = 94;
            // 
            // gridUrunAktifMi
            // 
            this.gridUrunAktifMi.Caption = "Aktif mi";
            this.gridUrunAktifMi.MinWidth = 25;
            this.gridUrunAktifMi.Name = "gridUrunAktifMi";
            this.gridUrunAktifMi.Visible = true;
            this.gridUrunAktifMi.VisibleIndex = 3;
            this.gridUrunAktifMi.Width = 94;
            // 
            // gridUrunGrupPersonel
            // 
            this.gridUrunGrupPersonel.Caption = "Personel";
            this.gridUrunGrupPersonel.MinWidth = 25;
            this.gridUrunGrupPersonel.Name = "gridUrunGrupPersonel";
            this.gridUrunGrupPersonel.Visible = true;
            this.gridUrunGrupPersonel.VisibleIndex = 4;
            this.gridUrunGrupPersonel.Width = 94;
            // 
            // gridCreatedDate
            // 
            this.gridCreatedDate.Caption = "Oluşturulma Tarihi";
            this.gridCreatedDate.MinWidth = 25;
            this.gridCreatedDate.Name = "gridCreatedDate";
            this.gridCreatedDate.Visible = true;
            this.gridCreatedDate.VisibleIndex = 5;
            this.gridCreatedDate.Width = 94;
            // 
            // gridUpdatedDate
            // 
            this.gridUpdatedDate.Caption = "Güncellenme Tarihi";
            this.gridUpdatedDate.MinWidth = 25;
            this.gridUpdatedDate.Name = "gridUpdatedDate";
            this.gridUpdatedDate.Visible = true;
            this.gridUpdatedDate.VisibleIndex = 6;
            this.gridUpdatedDate.Width = 94;
            // 
            // gridControlUrunAyar
            // 
            this.gridControlUrunAyar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUrunAyar.Location = new System.Drawing.Point(0, 0);
            this.gridControlUrunAyar.MainView = this.gridUrunAyarParametre;
            this.gridControlUrunAyar.MenuManager = this.barManager1;
            this.gridControlUrunAyar.Name = "gridControlUrunAyar";
            this.gridControlUrunAyar.Size = new System.Drawing.Size(636, 630);
            this.gridControlUrunAyar.TabIndex = 5;
            this.gridControlUrunAyar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUrunAyarParametre});
            // 
            // gridUrunAyarParametre
            // 
            this.gridUrunAyarParametre.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridAyarID,
            this.gridAyarAd,
            this.gridAyarAktifMi,
            this.gridAyarPersonel,
            this.gridAyarCreatedDate,
            this.gridAyarUpdatedDate});
            this.gridUrunAyarParametre.GridControl = this.gridControlUrunAyar;
            this.gridUrunAyarParametre.GroupPanelText = "Ürün Ayar Parametre Listesi";
            this.gridUrunAyarParametre.Name = "gridUrunAyarParametre";
            // 
            // gridAyarID
            // 
            this.gridAyarID.Caption = "Ayar ID";
            this.gridAyarID.MinWidth = 25;
            this.gridAyarID.Name = "gridAyarID";
            this.gridAyarID.Visible = true;
            this.gridAyarID.VisibleIndex = 0;
            this.gridAyarID.Width = 94;
            // 
            // gridAyarAd
            // 
            this.gridAyarAd.Caption = "Ayar Ad";
            this.gridAyarAd.MinWidth = 25;
            this.gridAyarAd.Name = "gridAyarAd";
            this.gridAyarAd.Visible = true;
            this.gridAyarAd.VisibleIndex = 1;
            this.gridAyarAd.Width = 94;
            // 
            // gridAyarAktifMi
            // 
            this.gridAyarAktifMi.Caption = "Aktif mi";
            this.gridAyarAktifMi.MinWidth = 25;
            this.gridAyarAktifMi.Name = "gridAyarAktifMi";
            this.gridAyarAktifMi.Visible = true;
            this.gridAyarAktifMi.VisibleIndex = 2;
            this.gridAyarAktifMi.Width = 94;
            // 
            // gridAyarPersonel
            // 
            this.gridAyarPersonel.Caption = "Personel";
            this.gridAyarPersonel.MinWidth = 25;
            this.gridAyarPersonel.Name = "gridAyarPersonel";
            this.gridAyarPersonel.Visible = true;
            this.gridAyarPersonel.VisibleIndex = 3;
            this.gridAyarPersonel.Width = 94;
            // 
            // gridAyarCreatedDate
            // 
            this.gridAyarCreatedDate.Caption = "Oluşturulma Tarihi";
            this.gridAyarCreatedDate.MinWidth = 25;
            this.gridAyarCreatedDate.Name = "gridAyarCreatedDate";
            this.gridAyarCreatedDate.Visible = true;
            this.gridAyarCreatedDate.VisibleIndex = 4;
            this.gridAyarCreatedDate.Width = 94;
            // 
            // gridAyarUpdatedDate
            // 
            this.gridAyarUpdatedDate.Caption = "Güncelleme Tarihi";
            this.gridAyarUpdatedDate.MinWidth = 25;
            this.gridAyarUpdatedDate.Name = "gridAyarUpdatedDate";
            this.gridAyarUpdatedDate.Visible = true;
            this.gridAyarUpdatedDate.VisibleIndex = 5;
            this.gridAyarUpdatedDate.Width = 94;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 25);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlUrunGrubu);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlUrunAyar);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1250, 630);
            this.splitContainerControl1.SplitterPosition = 602;
            this.splitContainerControl1.TabIndex = 10;
            // 
            // frmParametreListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 655);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmParametreListele";
            this.Text = "Parametre Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunGrubu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunGrubuParametre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunAyar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunAyarParametre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
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
        private DevExpress.XtraGrid.GridControl gridControlUrunAyar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUrunAyarParametre;
        private DevExpress.XtraGrid.GridControl gridControlUrunGrubu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUrunGrubuParametre;
        private DevExpress.XtraGrid.Columns.GridColumn gridAyarID;
        private DevExpress.XtraGrid.Columns.GridColumn gridAyarAd;
        private DevExpress.XtraGrid.Columns.GridColumn gridAyarAktifMi;
        private DevExpress.XtraGrid.Columns.GridColumn gridAyarPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn gridAyarCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridAyarUpdatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridUrunID;
        private DevExpress.XtraGrid.Columns.GridColumn gridUrunAd;
        private DevExpress.XtraGrid.Columns.GridColumn gridUrunKısaKod;
        private DevExpress.XtraGrid.Columns.GridColumn gridUrunAktifMi;
        private DevExpress.XtraGrid.Columns.GridColumn gridUrunGrupPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn gridCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridUpdatedDate;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}