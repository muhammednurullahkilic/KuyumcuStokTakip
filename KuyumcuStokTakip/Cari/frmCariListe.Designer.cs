namespace KuyumcuStokTakip.Cari
{
    partial class frmCariListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariListe));
            this.gridControlCari = new DevExpress.XtraGrid.GridControl();
            this.gridCariListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridCariKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCariAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCariTipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTelefonNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridNot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAktifMi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCariListePersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCariListeCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCariListeUpdatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnCariYeniKayit = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcelExport = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportPdf = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCariListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCari
            // 
            this.gridControlCari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCari.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControlCari.Location = new System.Drawing.Point(0, 24);
            this.gridControlCari.MainView = this.gridCariListe;
            this.gridControlCari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControlCari.Name = "gridControlCari";
            this.gridControlCari.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControlCari.Size = new System.Drawing.Size(944, 521);
            this.gridControlCari.TabIndex = 0;
            this.gridControlCari.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridCariListe});
            // 
            // gridCariListe
            // 
            this.gridCariListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridCariKod,
            this.gridCariAdı,
            this.gridCariTipi,
            this.gridTelefonNo,
            this.gridAdres,
            this.gridNot,
            this.gridAktifMi,
            this.gridCariListePersonel,
            this.gridCariListeCreatedDate,
            this.gridCariListeUpdatedDate});
            this.gridCariListe.DetailHeight = 284;
            this.gridCariListe.GridControl = this.gridControlCari;
            this.gridCariListe.GroupPanelText = "Cari Liste";
            this.gridCariListe.Name = "gridCariListe";
            this.gridCariListe.OptionsBehavior.Editable = false;
            this.gridCariListe.OptionsEditForm.PopupEditFormWidth = 600;
            // 
            // gridCariKod
            // 
            this.gridCariKod.Caption = "Cari Kod";
            this.gridCariKod.FieldName = "CariKod";
            this.gridCariKod.MinWidth = 19;
            this.gridCariKod.Name = "gridCariKod";
            this.gridCariKod.Visible = true;
            this.gridCariKod.VisibleIndex = 1;
            this.gridCariKod.Width = 70;
            // 
            // gridCariAdı
            // 
            this.gridCariAdı.Caption = "Cari Adı";
            this.gridCariAdı.FieldName = "CariAd";
            this.gridCariAdı.MinWidth = 19;
            this.gridCariAdı.Name = "gridCariAdı";
            this.gridCariAdı.Visible = true;
            this.gridCariAdı.VisibleIndex = 0;
            this.gridCariAdı.Width = 56;
            // 
            // gridCariTipi
            // 
            this.gridCariTipi.Caption = "Cari Tipi";
            this.gridCariTipi.FieldName = "CariTipAdi";
            this.gridCariTipi.MinWidth = 19;
            this.gridCariTipi.Name = "gridCariTipi";
            this.gridCariTipi.Visible = true;
            this.gridCariTipi.VisibleIndex = 2;
            this.gridCariTipi.Width = 59;
            // 
            // gridTelefonNo
            // 
            this.gridTelefonNo.Caption = "Telefon No";
            this.gridTelefonNo.FieldName = "CariTelefon";
            this.gridTelefonNo.MinWidth = 19;
            this.gridTelefonNo.Name = "gridTelefonNo";
            this.gridTelefonNo.Visible = true;
            this.gridTelefonNo.VisibleIndex = 3;
            this.gridTelefonNo.Width = 59;
            // 
            // gridAdres
            // 
            this.gridAdres.Caption = "Adres";
            this.gridAdres.FieldName = "CariAdres";
            this.gridAdres.MinWidth = 19;
            this.gridAdres.Name = "gridAdres";
            this.gridAdres.Visible = true;
            this.gridAdres.VisibleIndex = 4;
            this.gridAdres.Width = 59;
            // 
            // gridNot
            // 
            this.gridNot.Caption = "Not";
            this.gridNot.FieldName = "CariNot";
            this.gridNot.MinWidth = 19;
            this.gridNot.Name = "gridNot";
            this.gridNot.Visible = true;
            this.gridNot.VisibleIndex = 5;
            this.gridNot.Width = 59;
            // 
            // gridAktifMi
            // 
            this.gridAktifMi.Caption = "Aktif mi";
            this.gridAktifMi.FieldName = "IsActive";
            this.gridAktifMi.MinWidth = 19;
            this.gridAktifMi.Name = "gridAktifMi";
            this.gridAktifMi.Visible = true;
            this.gridAktifMi.VisibleIndex = 6;
            this.gridAktifMi.Width = 59;
            // 
            // gridCariListePersonel
            // 
            this.gridCariListePersonel.Caption = "Personel";
            this.gridCariListePersonel.FieldName = "CUser";
            this.gridCariListePersonel.MinWidth = 19;
            this.gridCariListePersonel.Name = "gridCariListePersonel";
            this.gridCariListePersonel.Visible = true;
            this.gridCariListePersonel.VisibleIndex = 7;
            this.gridCariListePersonel.Width = 59;
            // 
            // gridCariListeCreatedDate
            // 
            this.gridCariListeCreatedDate.Caption = "Oluşturulma Tarihi";
            this.gridCariListeCreatedDate.FieldName = "CDate";
            this.gridCariListeCreatedDate.MinWidth = 19;
            this.gridCariListeCreatedDate.Name = "gridCariListeCreatedDate";
            this.gridCariListeCreatedDate.Visible = true;
            this.gridCariListeCreatedDate.VisibleIndex = 8;
            this.gridCariListeCreatedDate.Width = 59;
            // 
            // gridCariListeUpdatedDate
            // 
            this.gridCariListeUpdatedDate.Caption = "Güncelleme Tarihi";
            this.gridCariListeUpdatedDate.FieldName = "MDate";
            this.gridCariListeUpdatedDate.MinWidth = 19;
            this.gridCariListeUpdatedDate.Name = "gridCariListeUpdatedDate";
            this.gridCariListeUpdatedDate.Visible = true;
            this.gridCariListeUpdatedDate.VisibleIndex = 9;
            this.gridCariListeUpdatedDate.Width = 64;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
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
            this.btnCariYeniKayit,
            this.btnExcelExport,
            this.btnExportPdf});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(2632, 164);
            this.bar2.FloatSize = new System.Drawing.Size(179, 32);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCariYeniKayit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcelExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportPdf)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnCariYeniKayit
            // 
            this.btnCariYeniKayit.Caption = "Yeni Kayıt";
            this.btnCariYeniKayit.Id = 0;
            this.btnCariYeniKayit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCariYeniKayit.ImageOptions.Image")));
            this.btnCariYeniKayit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCariYeniKayit.ImageOptions.LargeImage")));
            this.btnCariYeniKayit.Name = "btnCariYeniKayit";
            this.btnCariYeniKayit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYeniKayit_ItemClick);
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Caption = "Excel\'e aktar";
            this.btnExcelExport.Id = 1;
            this.btnExcelExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelExport.ImageOptions.Image")));
            this.btnExcelExport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExcelExport.ImageOptions.LargeImage")));
            this.btnExcelExport.Name = "btnExcelExport";
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.Caption = "Pdf olarak aktar";
            this.btnExportPdf.Id = 2;
            this.btnExportPdf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportPdf.ImageOptions.Image")));
            this.btnExportPdf.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExportPdf.ImageOptions.LargeImage")));
            this.btnExportPdf.Name = "btnExportPdf";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(944, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 545);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(944, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 521);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(944, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 521);
            // 
            // frmCariListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 545);
            this.Controls.Add(this.gridControlCari);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCariListe";
            this.Text = "Cari Liste";
            this.Load += new System.EventHandler(this.frmCariListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCariListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCari;
        private DevExpress.XtraGrid.Views.Grid.GridView gridCariListe;
        private DevExpress.XtraGrid.Columns.GridColumn gridCariAdı;
        private DevExpress.XtraGrid.Columns.GridColumn gridCariTipi;
        private DevExpress.XtraGrid.Columns.GridColumn gridTelefonNo;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnCariYeniKayit;
        private DevExpress.XtraBars.BarButtonItem btnExcelExport;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn gridAdres;
        private DevExpress.XtraGrid.Columns.GridColumn gridNot;
        private DevExpress.XtraGrid.Columns.GridColumn gridAktifMi;
        private DevExpress.XtraBars.BarButtonItem btnExportPdf;
        private DevExpress.XtraGrid.Columns.GridColumn gridCariListePersonel;
        private DevExpress.XtraGrid.Columns.GridColumn gridCariListeCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridCariListeUpdatedDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridCariKod;
    }
}