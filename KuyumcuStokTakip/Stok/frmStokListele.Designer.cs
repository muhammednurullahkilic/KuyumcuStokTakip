namespace KuyumcuStokTakip.Stok
{
    partial class frmStokListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokListele));
            this.gridControlStokListesi = new DevExpress.XtraGrid.GridControl();
            this.gridStokListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridStokNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridGuncelleyenPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUrunAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUrunAyar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTotalGram = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridOlusturanPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUpdatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUrunAktifMi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnStokYeniKayıt = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportPdf = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStokListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlStokListesi
            // 
            this.gridControlStokListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlStokListesi.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlStokListesi.Location = new System.Drawing.Point(0, 24);
            this.gridControlStokListesi.MainView = this.gridStokListesi;
            this.gridControlStokListesi.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlStokListesi.Name = "gridControlStokListesi";
            this.gridControlStokListesi.Size = new System.Drawing.Size(1068, 268);
            this.gridControlStokListesi.TabIndex = 0;
            this.gridControlStokListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridStokListesi});
            // 
            // gridStokListesi
            // 
            this.gridStokListesi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridStokNo,
            this.gridGuncelleyenPersonel,
            this.gridUrunAd,
            this.gridUrunAyar,
            this.gridTotalGram,
            this.gridOlusturanPersonel,
            this.gridCreatedDate,
            this.gridUpdatedDate,
            this.gridUrunAktifMi});
            this.gridStokListesi.DetailHeight = 284;
            this.gridStokListesi.GridControl = this.gridControlStokListesi;
            this.gridStokListesi.GroupPanelText = "Stok Listesi";
            this.gridStokListesi.Name = "gridStokListesi";
            this.gridStokListesi.OptionsBehavior.Editable = false;
            this.gridStokListesi.OptionsEditForm.PopupEditFormWidth = 600;
            this.gridStokListesi.OptionsView.EnableAppearanceEvenRow = true;
            this.gridStokListesi.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridStokListesi.OptionsView.RowAutoHeight = true;
            this.gridStokListesi.OptionsView.ShowAutoFilterRow = true;
            this.gridStokListesi.OptionsView.ShowFooter = true;
            this.gridStokListesi.OptionsView.ShowGroupPanel = false;
            // 
            // gridStokNo
            // 
            this.gridStokNo.Caption = "Ürün No";
            this.gridStokNo.FieldName = "StokNo";
            this.gridStokNo.MinWidth = 19;
            this.gridStokNo.Name = "gridStokNo";
            this.gridStokNo.Visible = true;
            this.gridStokNo.VisibleIndex = 0;
            this.gridStokNo.Width = 96;
            // 
            // gridGuncelleyenPersonel
            // 
            this.gridGuncelleyenPersonel.Caption = "Güncelleyen Personel";
            this.gridGuncelleyenPersonel.FieldName = "MUserID";
            this.gridGuncelleyenPersonel.Name = "gridGuncelleyenPersonel";
            this.gridGuncelleyenPersonel.Visible = true;
            this.gridGuncelleyenPersonel.VisibleIndex = 7;
            this.gridGuncelleyenPersonel.Width = 56;
            // 
            // gridUrunAd
            // 
            this.gridUrunAd.Caption = "Ürün Ad";
            this.gridUrunAd.FieldName = "GrupAd";
            this.gridUrunAd.MinWidth = 19;
            this.gridUrunAd.Name = "gridUrunAd";
            this.gridUrunAd.Visible = true;
            this.gridUrunAd.VisibleIndex = 1;
            this.gridUrunAd.Width = 43;
            // 
            // gridUrunAyar
            // 
            this.gridUrunAyar.Caption = "Ürün Ayar";
            this.gridUrunAyar.FieldName = "AyarAdi";
            this.gridUrunAyar.MinWidth = 19;
            this.gridUrunAyar.Name = "gridUrunAyar";
            this.gridUrunAyar.Visible = true;
            this.gridUrunAyar.VisibleIndex = 2;
            this.gridUrunAyar.Width = 52;
            // 
            // gridTotalGram
            // 
            this.gridTotalGram.Caption = "Total Gram";
            this.gridTotalGram.FieldName = "UrunTotalGram";
            this.gridTotalGram.GroupFormat.FormatString = "N2";
            this.gridTotalGram.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridTotalGram.MinWidth = 19;
            this.gridTotalGram.Name = "gridTotalGram";
            this.gridTotalGram.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UrunGram", "{0:N2}")});
            this.gridTotalGram.Visible = true;
            this.gridTotalGram.VisibleIndex = 3;
            this.gridTotalGram.Width = 31;
            // 
            // gridOlusturanPersonel
            // 
            this.gridOlusturanPersonel.Caption = "Oluşturan Personel";
            this.gridOlusturanPersonel.FieldName = "CUser";
            this.gridOlusturanPersonel.MinWidth = 19;
            this.gridOlusturanPersonel.Name = "gridOlusturanPersonel";
            this.gridOlusturanPersonel.Visible = true;
            this.gridOlusturanPersonel.VisibleIndex = 5;
            this.gridOlusturanPersonel.Width = 54;
            // 
            // gridCreatedDate
            // 
            this.gridCreatedDate.Caption = "Oluşturulma Tarihi";
            this.gridCreatedDate.FieldName = "CDate";
            this.gridCreatedDate.MinWidth = 19;
            this.gridCreatedDate.Name = "gridCreatedDate";
            this.gridCreatedDate.Visible = true;
            this.gridCreatedDate.VisibleIndex = 6;
            this.gridCreatedDate.Width = 82;
            // 
            // gridUpdatedDate
            // 
            this.gridUpdatedDate.Caption = "Güncellenme Tarihi";
            this.gridUpdatedDate.FieldName = "MDate";
            this.gridUpdatedDate.MinWidth = 19;
            this.gridUpdatedDate.Name = "gridUpdatedDate";
            this.gridUpdatedDate.Visible = true;
            this.gridUpdatedDate.VisibleIndex = 8;
            this.gridUpdatedDate.Width = 92;
            // 
            // gridUrunAktifMi
            // 
            this.gridUrunAktifMi.Caption = "Aktif Mi";
            this.gridUrunAktifMi.FieldName = "isActive";
            this.gridUrunAktifMi.MinWidth = 19;
            this.gridUrunAktifMi.Name = "gridUrunAktifMi";
            this.gridUrunAktifMi.Visible = true;
            this.gridUrunAktifMi.VisibleIndex = 4;
            this.gridUrunAktifMi.Width = 49;
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
            this.btnStokYeniKayıt,
            this.btnExportExcel,
            this.btnExportPdf});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnStokYeniKayıt),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportPdf)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnStokYeniKayıt
            // 
            this.btnStokYeniKayıt.Caption = "Yeni Kayıt";
            this.btnStokYeniKayıt.Id = 0;
            this.btnStokYeniKayıt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStokYeniKayıt.ImageOptions.Image")));
            this.btnStokYeniKayıt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStokYeniKayıt.ImageOptions.LargeImage")));
            this.btnStokYeniKayıt.Name = "btnStokYeniKayıt";
            this.btnStokYeniKayıt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStokYeniKayıt_ItemClick);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Caption = "Excel Export";
            this.btnExportExcel.Id = 1;
            this.btnExportExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.ImageOptions.Image")));
            this.btnExportExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.ImageOptions.LargeImage")));
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportExcel_ItemClick);
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.Caption = "PDF Export";
            this.btnExportPdf.Id = 2;
            this.btnExportPdf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportPdf.ImageOptions.Image")));
            this.btnExportPdf.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExportPdf.ImageOptions.LargeImage")));
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportPdf_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(1068, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 292);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1068, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 268);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1068, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 268);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frmStokListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 292);
            this.Controls.Add(this.gridControlStokListesi);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStokListele";
            this.Text = "Stok Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStokListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlStokListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridStokListesi;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnStokYeniKayıt;
        private DevExpress.XtraBars.BarButtonItem btnExportExcel;
        private DevExpress.XtraBars.BarButtonItem btnExportPdf;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn gridUrunAd;
        private DevExpress.XtraGrid.Columns.GridColumn gridUrunAyar;
        private DevExpress.XtraGrid.Columns.GridColumn gridTotalGram;
        private DevExpress.XtraGrid.Columns.GridColumn gridStokNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridOlusturanPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn gridCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridUpdatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridUrunAktifMi;
        private DevExpress.XtraGrid.Columns.GridColumn gridGuncelleyenPersonel;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}