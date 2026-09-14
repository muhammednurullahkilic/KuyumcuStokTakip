namespace KuyumcuStokTakip.Kasa
{
    partial class frmKasaIslemleri
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
            this.lueCari = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblCari = new System.Windows.Forms.Label();
            this.lblIslemTuru = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.dtKasaTarih = new DevExpress.XtraEditors.DateEdit();
            this.lblTarih = new System.Windows.Forms.Label();
            this.chkGiris = new System.Windows.Forms.CheckBox();
            this.chkCikis = new System.Windows.Forms.CheckBox();
            this.gridControlKasaIslemleri = new DevExpress.XtraGrid.GridControl();
            this.gridKasaIslemleri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridKasaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCariAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridIslemTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridGirisTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCikisTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblKasaBakiye = new System.Windows.Forms.Label();
            this.txtKasaNo = new System.Windows.Forms.TextBox();
            this.lblKasaNo = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnKasaKayit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lueCari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtKasaTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtKasaTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKasaIslemleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasaIslemleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lueCari
            // 
            this.lueCari.Location = new System.Drawing.Point(181, 133);
            this.lueCari.Name = "lueCari";
            this.lueCari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCari.Properties.NullText = "";
            this.lueCari.Properties.PopupView = this.searchLookUpEdit1View;
            this.lueCari.Size = new System.Drawing.Size(149, 22);
            this.lueCari.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(590, 48);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(149, 23);
            this.txtTutar.TabIndex = 2;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(590, 89);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(149, 23);
            this.txtAciklama.TabIndex = 3;
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Location = new System.Drawing.Point(69, 139);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(38, 16);
            this.lblCari.TabIndex = 5;
            this.lblCari.Text = "Cari*";
            // 
            // lblIslemTuru
            // 
            this.lblIslemTuru.AutoSize = true;
            this.lblIslemTuru.Location = new System.Drawing.Point(67, 95);
            this.lblIslemTuru.Name = "lblIslemTuru";
            this.lblIslemTuru.Size = new System.Drawing.Size(77, 16);
            this.lblIslemTuru.TabIndex = 6;
            this.lblIslemTuru.Text = "İşlem Türü*";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(487, 54);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(46, 16);
            this.lblTutar.TabIndex = 7;
            this.lblTutar.Text = "Tutar*";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(487, 95);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(58, 16);
            this.lblAciklama.TabIndex = 8;
            this.lblAciklama.Text = "Açıklama";
            // 
            // dtKasaTarih
            // 
            this.dtKasaTarih.EditValue = null;
            this.dtKasaTarih.Location = new System.Drawing.Point(186, 48);
            this.dtKasaTarih.Name = "dtKasaTarih";
            this.dtKasaTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtKasaTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtKasaTarih.Size = new System.Drawing.Size(144, 22);
            this.dtKasaTarih.TabIndex = 9;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(67, 54);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(37, 16);
            this.lblTarih.TabIndex = 10;
            this.lblTarih.Text = "Tarih";
            // 
            // chkGiris
            // 
            this.chkGiris.AutoSize = true;
            this.chkGiris.Location = new System.Drawing.Point(185, 91);
            this.chkGiris.Name = "chkGiris";
            this.chkGiris.Size = new System.Drawing.Size(54, 20);
            this.chkGiris.TabIndex = 11;
            this.chkGiris.Text = "Giriş";
            this.chkGiris.UseVisualStyleBackColor = true;
            // 
            // chkCikis
            // 
            this.chkCikis.AutoSize = true;
            this.chkCikis.Location = new System.Drawing.Point(298, 91);
            this.chkCikis.Name = "chkCikis";
            this.chkCikis.Size = new System.Drawing.Size(55, 20);
            this.chkCikis.TabIndex = 12;
            this.chkCikis.Text = "Çıkış";
            this.chkCikis.UseVisualStyleBackColor = true;
            // 
            // gridControlKasaIslemleri
            // 
            this.gridControlKasaIslemleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKasaIslemleri.Location = new System.Drawing.Point(0, 182);
            this.gridControlKasaIslemleri.MainView = this.gridKasaIslemleri;
            this.gridControlKasaIslemleri.Name = "gridControlKasaIslemleri";
            this.gridControlKasaIslemleri.Size = new System.Drawing.Size(1714, 760);
            this.gridControlKasaIslemleri.TabIndex = 13;
            this.gridControlKasaIslemleri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKasaIslemleri});
            this.gridControlKasaIslemleri.Click += new System.EventHandler(this.gridControlKasaIslemleri_Click);
            // 
            // gridKasaIslemleri
            // 
            this.gridKasaIslemleri.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridKasaID,
            this.gridCariAd,
            this.gridTarih,
            this.gridIslemTuru,
            this.gridTutar,
            this.gridAciklama,
            this.gridGirisTutar,
            this.gridCikisTutar});
            this.gridKasaIslemleri.GridControl = this.gridControlKasaIslemleri;
            this.gridKasaIslemleri.GroupPanelText = "Kasa Giriş Çıkış Özet";
            this.gridKasaIslemleri.Name = "gridKasaIslemleri";
            this.gridKasaIslemleri.OptionsView.ShowFooter = true;
            // 
            // gridKasaID
            // 
            this.gridKasaID.Caption = "Kasa ID";
            this.gridKasaID.FieldName = "KasaID";
            this.gridKasaID.MinWidth = 25;
            this.gridKasaID.Name = "gridKasaID";
            this.gridKasaID.OptionsColumn.AllowEdit = false;
            this.gridKasaID.Visible = true;
            this.gridKasaID.VisibleIndex = 0;
            this.gridKasaID.Width = 94;
            // 
            // gridCariAd
            // 
            this.gridCariAd.Caption = "Cari Adı";
            this.gridCariAd.FieldName = "CariAd";
            this.gridCariAd.MinWidth = 25;
            this.gridCariAd.Name = "gridCariAd";
            this.gridCariAd.OptionsColumn.AllowEdit = false;
            this.gridCariAd.Visible = true;
            this.gridCariAd.VisibleIndex = 3;
            this.gridCariAd.Width = 94;
            // 
            // gridTarih
            // 
            this.gridTarih.Caption = "Tarih";
            this.gridTarih.FieldName = "Tarih";
            this.gridTarih.MinWidth = 25;
            this.gridTarih.Name = "gridTarih";
            this.gridTarih.OptionsColumn.AllowEdit = false;
            this.gridTarih.Visible = true;
            this.gridTarih.VisibleIndex = 1;
            this.gridTarih.Width = 94;
            // 
            // gridIslemTuru
            // 
            this.gridIslemTuru.Caption = "İşlem Türü";
            this.gridIslemTuru.FieldName = "IslemTuruAd";
            this.gridIslemTuru.MinWidth = 25;
            this.gridIslemTuru.Name = "gridIslemTuru";
            this.gridIslemTuru.OptionsColumn.AllowEdit = false;
            this.gridIslemTuru.Visible = true;
            this.gridIslemTuru.VisibleIndex = 2;
            this.gridIslemTuru.Width = 94;
            // 
            // gridTutar
            // 
            this.gridTutar.Caption = "Bakiye";
            this.gridTutar.DisplayFormat.FormatString = "N2";
            this.gridTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridTutar.FieldName = "KasaBakiye";
            this.gridTutar.MinWidth = 25;
            this.gridTutar.Name = "gridTutar";
            this.gridTutar.OptionsColumn.AllowEdit = false;
            this.gridTutar.Visible = true;
            this.gridTutar.VisibleIndex = 7;
            this.gridTutar.Width = 94;
            // 
            // gridAciklama
            // 
            this.gridAciklama.Caption = "Açıklama";
            this.gridAciklama.FieldName = "Aciklama";
            this.gridAciklama.MinWidth = 25;
            this.gridAciklama.Name = "gridAciklama";
            this.gridAciklama.OptionsColumn.AllowEdit = false;
            this.gridAciklama.Visible = true;
            this.gridAciklama.VisibleIndex = 4;
            this.gridAciklama.Width = 94;
            // 
            // gridGirisTutar
            // 
            this.gridGirisTutar.Caption = "Giriş Tutar";
            this.gridGirisTutar.DisplayFormat.FormatString = "N2";
            this.gridGirisTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridGirisTutar.FieldName = "GirisTutar";
            this.gridGirisTutar.MinWidth = 25;
            this.gridGirisTutar.Name = "gridGirisTutar";
            this.gridGirisTutar.OptionsColumn.AllowEdit = false;
            this.gridGirisTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GirisTutar", "{0:N2}")});
            this.gridGirisTutar.Visible = true;
            this.gridGirisTutar.VisibleIndex = 5;
            this.gridGirisTutar.Width = 94;
            // 
            // gridCikisTutar
            // 
            this.gridCikisTutar.Caption = "Çıkış Tutar";
            this.gridCikisTutar.DisplayFormat.FormatString = "N2";
            this.gridCikisTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridCikisTutar.FieldName = "CikisTutar";
            this.gridCikisTutar.MinWidth = 25;
            this.gridCikisTutar.Name = "gridCikisTutar";
            this.gridCikisTutar.OptionsColumn.AllowEdit = false;
            this.gridCikisTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CikisTutar", "{0:N2}")});
            this.gridCikisTutar.Visible = true;
            this.gridCikisTutar.VisibleIndex = 6;
            this.gridCikisTutar.Width = 94;
            // 
            // lblKasaBakiye
            // 
            this.lblKasaBakiye.AutoSize = true;
            this.lblKasaBakiye.Location = new System.Drawing.Point(878, 66);
            this.lblKasaBakiye.Name = "lblKasaBakiye";
            this.lblKasaBakiye.Size = new System.Drawing.Size(157, 16);
            this.lblKasaBakiye.TabIndex = 14;
            this.lblKasaBakiye.Text = "Güncel Kasa Bakiye: 0.00₺";
            // 
            // txtKasaNo
            // 
            this.txtKasaNo.Location = new System.Drawing.Point(590, 139);
            this.txtKasaNo.Name = "txtKasaNo";
            this.txtKasaNo.Size = new System.Drawing.Size(149, 23);
            this.txtKasaNo.TabIndex = 15;
            // 
            // lblKasaNo
            // 
            this.lblKasaNo.AutoSize = true;
            this.lblKasaNo.Location = new System.Drawing.Point(487, 142);
            this.lblKasaNo.Name = "lblKasaNo";
            this.lblKasaNo.Size = new System.Drawing.Size(53, 16);
            this.lblKasaNo.TabIndex = 16;
            this.lblKasaNo.Text = "Kasa No";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtAciklama);
            this.panelControl1.Controls.Add(this.dtKasaTarih);
            this.panelControl1.Controls.Add(this.chkCikis);
            this.panelControl1.Controls.Add(this.lueCari);
            this.panelControl1.Controls.Add(this.lblAciklama);
            this.panelControl1.Controls.Add(this.lblTutar);
            this.panelControl1.Controls.Add(this.lblKasaNo);
            this.panelControl1.Controls.Add(this.chkGiris);
            this.panelControl1.Controls.Add(this.lblIslemTuru);
            this.panelControl1.Controls.Add(this.txtTutar);
            this.panelControl1.Controls.Add(this.lblKasaBakiye);
            this.panelControl1.Controls.Add(this.lblTarih);
            this.panelControl1.Controls.Add(this.txtKasaNo);
            this.panelControl1.Controls.Add(this.lblCari);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1714, 182);
            this.panelControl1.TabIndex = 18;
            // 
            // btnKasaKayit
            // 
            this.btnKasaKayit.Location = new System.Drawing.Point(1599, 21);
            this.btnKasaKayit.Name = "btnKasaKayit";
            this.btnKasaKayit.Size = new System.Drawing.Size(103, 30);
            this.btnKasaKayit.TabIndex = 4;
            this.btnKasaKayit.Text = "Kayıt";
            this.btnKasaKayit.Click += new System.EventHandler(this.btnKasaKayit_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(12, 20);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(90, 26);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            // 
            // panelControl2
            // 
            this.panelControl2.AutoSize = true;
            this.panelControl2.Controls.Add(this.btnSil);
            this.panelControl2.Controls.Add(this.btnKasaKayit);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 942);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1714, 58);
            this.panelControl2.TabIndex = 19;
            // 
            // frmKasaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1714, 1000);
            this.Controls.Add(this.gridControlKasaIslemleri);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmKasaIslemleri";
            this.Text = "Kasa İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.lueCari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtKasaTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtKasaTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKasaIslemleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasaIslemleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit lueCari;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.Label lblIslemTuru;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblAciklama;
        private DevExpress.XtraEditors.DateEdit dtKasaTarih;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.CheckBox chkGiris;
        private System.Windows.Forms.CheckBox chkCikis;
        private DevExpress.XtraGrid.GridControl gridControlKasaIslemleri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKasaIslemleri;
        private DevExpress.XtraGrid.Columns.GridColumn gridKasaID;
        private DevExpress.XtraGrid.Columns.GridColumn gridCariAd;
        private DevExpress.XtraGrid.Columns.GridColumn gridTarih;
        private DevExpress.XtraGrid.Columns.GridColumn gridIslemTuru;
        private DevExpress.XtraGrid.Columns.GridColumn gridTutar;
        private DevExpress.XtraGrid.Columns.GridColumn gridAciklama;
        private System.Windows.Forms.Label lblKasaBakiye;
        private System.Windows.Forms.TextBox txtKasaNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridGirisTutar;
        private DevExpress.XtraGrid.Columns.GridColumn gridCikisTutar;
        private System.Windows.Forms.Label lblKasaNo;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKasaKayit;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}