namespace KuyumcuStokTakip.Fatura
{
    partial class frmAlisFatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlisFatura));
            this.lblCari = new System.Windows.Forms.Label();
            this.lblAlisTarih = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lueCari = new DevExpress.XtraEditors.LookUpEdit();
            this.dtAlisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtAlisTutar = new DevExpress.XtraEditors.TextEdit();
            this.txtAlisFaturaNo = new System.Windows.Forms.TextBox();
            this.lblFaturaNo = new System.Windows.Forms.Label();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lblAciklama = new DevExpress.XtraEditors.LabelControl();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.gridControlAlisFatura = new DevExpress.XtraGrid.GridControl();
            this.gridAlisFatura = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridStokKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridGramMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaliyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridIscilik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMilyem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridHasMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridHasFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lueCari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAlisFatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlisFatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Location = new System.Drawing.Point(37, 75);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(39, 16);
            this.lblCari.TabIndex = 0;
            this.lblCari.Text = "*Cari:";
            // 
            // lblAlisTarih
            // 
            this.lblAlisTarih.AutoSize = true;
            this.lblAlisTarih.Location = new System.Drawing.Point(37, 114);
            this.lblAlisTarih.Name = "lblAlisTarih";
            this.lblAlisTarih.Size = new System.Drawing.Size(46, 16);
            this.lblAlisTarih.TabIndex = 1;
            this.lblAlisTarih.Text = "*Tarih:";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(705, 36);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(46, 16);
            this.lblTutar.TabIndex = 4;
            this.lblTutar.Text = "*Tutar:";
            // 
            // lueCari
            // 
            this.lueCari.Location = new System.Drawing.Point(157, 71);
            this.lueCari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueCari.Name = "lueCari";
            this.lueCari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCari.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CariAd", "cariAdi"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CariID", "cariID")});
            this.lueCari.Properties.NullText = "Lütfen Seçiniz";
            this.lueCari.Properties.ValueMember = "CariID";
            this.lueCari.Size = new System.Drawing.Size(187, 22);
            this.lueCari.TabIndex = 1;
            // 
            // dtAlisTarihi
            // 
            this.dtAlisTarihi.EditValue = null;
            this.dtAlisTarihi.Location = new System.Drawing.Point(157, 111);
            this.dtAlisTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtAlisTarihi.Name = "dtAlisTarihi";
            this.dtAlisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtAlisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtAlisTarihi.Size = new System.Drawing.Size(187, 22);
            this.dtAlisTarihi.TabIndex = 2;
            // 
            // txtAlisTutar
            // 
            this.txtAlisTutar.Location = new System.Drawing.Point(792, 32);
            this.txtAlisTutar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlisTutar.Name = "txtAlisTutar";
            this.txtAlisTutar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtAlisTutar.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtAlisTutar.Size = new System.Drawing.Size(187, 22);
            this.txtAlisTutar.TabIndex = 12;
            // 
            // txtAlisFaturaNo
            // 
            this.txtAlisFaturaNo.Location = new System.Drawing.Point(157, 30);
            this.txtAlisFaturaNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlisFaturaNo.Name = "txtAlisFaturaNo";
            this.txtAlisFaturaNo.Size = new System.Drawing.Size(187, 22);
            this.txtAlisFaturaNo.TabIndex = 0;
            // 
            // lblFaturaNo
            // 
            this.lblFaturaNo.AutoSize = true;
            this.lblFaturaNo.Location = new System.Drawing.Point(37, 33);
            this.lblFaturaNo.Name = "lblFaturaNo";
            this.lblFaturaNo.Size = new System.Drawing.Size(74, 16);
            this.lblFaturaNo.TabIndex = 16;
            this.lblFaturaNo.Text = "*Fatura No:";
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSil.ImageOptions.SvgImage")));
            this.btnSil.Location = new System.Drawing.Point(4, 583);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(119, 32);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(1251, 583);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(119, 32);
            this.btnKaydet.TabIndex = 20;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblAciklama
            // 
            this.lblAciklama.Location = new System.Drawing.Point(391, 118);
            this.lblAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(56, 16);
            this.lblAciklama.TabIndex = 21;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(481, 114);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(185, 22);
            this.txtAciklama.TabIndex = 5;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(387, 36);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(67, 16);
            this.lblAdSoyad.TabIndex = 23;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(481, 32);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(185, 22);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(387, 75);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(53, 16);
            this.lblTelefon.TabIndex = 25;
            this.lblTelefon.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(483, 71);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(184, 22);
            this.txtTelefon.TabIndex = 4;
            // 
            // gridControlAlisFatura
            // 
            this.gridControlAlisFatura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlAlisFatura.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlAlisFatura.Location = new System.Drawing.Point(4, 166);
            this.gridControlAlisFatura.MainView = this.gridAlisFatura;
            this.gridControlAlisFatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlAlisFatura.Name = "gridControlAlisFatura";
            this.gridControlAlisFatura.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.gridControlAlisFatura.Size = new System.Drawing.Size(1366, 411);
            this.gridControlAlisFatura.TabIndex = 29;
            this.gridControlAlisFatura.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridAlisFatura});
            // 
            // gridAlisFatura
            // 
            this.gridAlisFatura.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridStokKod,
            this.gridGramMiktar,
            this.gridMaliyet,
            this.gridIscilik,
            this.gridMilyem,
            this.gridHasMiktar,
            this.gridTutar,
            this.gridHasFiyat});
            this.gridAlisFatura.GridControl = this.gridControlAlisFatura;
            this.gridAlisFatura.Name = "gridAlisFatura";
            this.gridAlisFatura.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridAlisFatura.OptionsView.RowAutoHeight = true;
            this.gridAlisFatura.OptionsView.ShowAutoFilterRow = true;
            this.gridAlisFatura.OptionsView.ShowGroupPanel = false;
            this.gridAlisFatura.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridAlisFatura_CellValueChanged);
            this.gridAlisFatura.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridAlisFatura_RowUpdated);
            // 
            // gridStokKod
            // 
            this.gridStokKod.Caption = "Stok Kod";
            this.gridStokKod.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.gridStokKod.FieldName = "StokID";
            this.gridStokKod.MinWidth = 25;
            this.gridStokKod.Name = "gridStokKod";
            this.gridStokKod.Visible = true;
            this.gridStokKod.VisibleIndex = 0;
            this.gridStokKod.Width = 93;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.NullText = "";
            this.repositoryItemGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Stok ID";
            this.gridColumn1.FieldName = "StokID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Stok No";
            this.gridColumn2.FieldName = "StokNo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridGramMiktar
            // 
            this.gridGramMiktar.Caption = "Gram Miktar";
            this.gridGramMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridGramMiktar.FieldName = "SH_GRAMMIKTAR";
            this.gridGramMiktar.MinWidth = 25;
            this.gridGramMiktar.Name = "gridGramMiktar";
            this.gridGramMiktar.Visible = true;
            this.gridGramMiktar.VisibleIndex = 2;
            this.gridGramMiktar.Width = 93;
            // 
            // gridMaliyet
            // 
            this.gridMaliyet.Caption = "Maliyet";
            this.gridMaliyet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridMaliyet.FieldName = "SH_MALIYET";
            this.gridMaliyet.MinWidth = 25;
            this.gridMaliyet.Name = "gridMaliyet";
            this.gridMaliyet.Visible = true;
            this.gridMaliyet.VisibleIndex = 3;
            this.gridMaliyet.Width = 93;
            // 
            // gridIscilik
            // 
            this.gridIscilik.Caption = "İşçilik";
            this.gridIscilik.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridIscilik.FieldName = "SH_ISCILIK";
            this.gridIscilik.MinWidth = 25;
            this.gridIscilik.Name = "gridIscilik";
            this.gridIscilik.Visible = true;
            this.gridIscilik.VisibleIndex = 4;
            this.gridIscilik.Width = 93;
            // 
            // gridMilyem
            // 
            this.gridMilyem.Caption = "Milyem";
            this.gridMilyem.FieldName = "SH_MILYEM";
            this.gridMilyem.MinWidth = 25;
            this.gridMilyem.Name = "gridMilyem";
            this.gridMilyem.OptionsColumn.AllowEdit = false;
            this.gridMilyem.Visible = true;
            this.gridMilyem.VisibleIndex = 1;
            this.gridMilyem.Width = 93;
            // 
            // gridHasMiktar
            // 
            this.gridHasMiktar.Caption = "Has Miktar";
            this.gridHasMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridHasMiktar.FieldName = "SH_HASMIKTAR";
            this.gridHasMiktar.MinWidth = 25;
            this.gridHasMiktar.Name = "gridHasMiktar";
            this.gridHasMiktar.OptionsColumn.AllowEdit = false;
            this.gridHasMiktar.Visible = true;
            this.gridHasMiktar.VisibleIndex = 5;
            this.gridHasMiktar.Width = 93;
            // 
            // gridTutar
            // 
            this.gridTutar.Caption = "Tutar";
            this.gridTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridTutar.FieldName = "SH_TUTARTL";
            this.gridTutar.MinWidth = 25;
            this.gridTutar.Name = "gridTutar";
            this.gridTutar.OptionsColumn.AllowEdit = false;
            this.gridTutar.Visible = true;
            this.gridTutar.VisibleIndex = 7;
            this.gridTutar.Width = 93;
            // 
            // gridHasFiyat
            // 
            this.gridHasFiyat.Caption = "Has Fiyat";
            this.gridHasFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridHasFiyat.FieldName = "SH_HASFIYAT";
            this.gridHasFiyat.MinWidth = 25;
            this.gridHasFiyat.Name = "gridHasFiyat";
            this.gridHasFiyat.Visible = true;
            this.gridHasFiyat.VisibleIndex = 6;
            this.gridHasFiyat.Width = 94;
            // 
            // frmAlisFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 624);
            this.Controls.Add(this.gridControlAlisFatura);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblFaturaNo);
            this.Controls.Add(this.txtAlisFaturaNo);
            this.Controls.Add(this.txtAlisTutar);
            this.Controls.Add(this.dtAlisTarihi);
            this.Controls.Add(this.lueCari);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblAlisTarih);
            this.Controls.Add(this.lblCari);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAlisFatura";
            this.Text = "Alış Fatura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.lueCari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAlisFatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlisFatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.Label lblAlisTarih;
        private System.Windows.Forms.Label lblTutar;
        private DevExpress.XtraEditors.LookUpEdit lueCari;
        private DevExpress.XtraEditors.DateEdit dtAlisTarihi;
        private DevExpress.XtraEditors.TextEdit txtAlisTutar;
        private System.Windows.Forms.TextBox txtAlisFaturaNo;
        private System.Windows.Forms.Label lblFaturaNo;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private DevExpress.XtraGrid.GridControl gridControlAlisFatura;
        private DevExpress.XtraGrid.Views.Grid.GridView gridAlisFatura;
        private DevExpress.XtraGrid.Columns.GridColumn gridStokKod;
        private DevExpress.XtraGrid.Columns.GridColumn gridGramMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaliyet;
        private DevExpress.XtraGrid.Columns.GridColumn gridIscilik;
        private DevExpress.XtraGrid.Columns.GridColumn gridMilyem;
        private DevExpress.XtraGrid.Columns.GridColumn gridHasMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn gridTutar;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridHasFiyat;
    }
}