namespace KuyumcuStokTakip.Fatura
{
    partial class frmSatisFatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisFatura));
            this.lblCari = new System.Windows.Forms.Label();
            this.lblSatisTarih = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lueCari = new DevExpress.XtraEditors.LookUpEdit();
            this.dtSatisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtSatisTutar = new DevExpress.XtraEditors.TextEdit();
            this.lblFaturaNo = new System.Windows.Forms.Label();
            this.txtSatisFaturaNo = new System.Windows.Forms.TextBox();
            this.gridControlSatisFatura = new DevExpress.XtraGrid.GridControl();
            this.gridSatisFaturasi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridStokKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridGramMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMilyem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaliyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridIscilik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridHasMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridHasFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridEldekiMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkMuhtelif = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.lueCari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSatisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSatisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSatisFatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSatisFaturasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Location = new System.Drawing.Point(45, 68);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(39, 16);
            this.lblCari.TabIndex = 0;
            this.lblCari.Text = "*Cari:";
            // 
            // lblSatisTarih
            // 
            this.lblSatisTarih.AutoSize = true;
            this.lblSatisTarih.Location = new System.Drawing.Point(45, 118);
            this.lblSatisTarih.Name = "lblSatisTarih";
            this.lblSatisTarih.Size = new System.Drawing.Size(46, 16);
            this.lblSatisTarih.TabIndex = 1;
            this.lblSatisTarih.Text = "*Tarih:";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(852, 25);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(46, 16);
            this.lblTutar.TabIndex = 4;
            this.lblTutar.Text = "*Tutar:";
            // 
            // lueCari
            // 
            this.lueCari.Location = new System.Drawing.Point(152, 70);
            this.lueCari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueCari.Name = "lueCari";
            this.lueCari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCari.Properties.NullText = "Lütfen Seçiniz";
            this.lueCari.Size = new System.Drawing.Size(187, 22);
            this.lueCari.TabIndex = 7;
            // 
            // dtSatisTarihi
            // 
            this.dtSatisTarihi.EditValue = null;
            this.dtSatisTarihi.Location = new System.Drawing.Point(152, 112);
            this.dtSatisTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtSatisTarihi.Name = "dtSatisTarihi";
            this.dtSatisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSatisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSatisTarihi.Size = new System.Drawing.Size(187, 22);
            this.dtSatisTarihi.TabIndex = 9;
            // 
            // txtSatisTutar
            // 
            this.txtSatisTutar.Location = new System.Drawing.Point(945, 22);
            this.txtSatisTutar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSatisTutar.Name = "txtSatisTutar";
            this.txtSatisTutar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSatisTutar.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtSatisTutar.Size = new System.Drawing.Size(187, 22);
            this.txtSatisTutar.TabIndex = 12;
            // 
            // lblFaturaNo
            // 
            this.lblFaturaNo.AutoSize = true;
            this.lblFaturaNo.Location = new System.Drawing.Point(45, 30);
            this.lblFaturaNo.Name = "lblFaturaNo";
            this.lblFaturaNo.Size = new System.Drawing.Size(74, 16);
            this.lblFaturaNo.TabIndex = 15;
            this.lblFaturaNo.Text = "*Fatura No:";
            // 
            // txtSatisFaturaNo
            // 
            this.txtSatisFaturaNo.Location = new System.Drawing.Point(152, 27);
            this.txtSatisFaturaNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSatisFaturaNo.Name = "txtSatisFaturaNo";
            this.txtSatisFaturaNo.Size = new System.Drawing.Size(187, 22);
            this.txtSatisFaturaNo.TabIndex = 16;
            // 
            // gridControlSatisFatura
            // 
            this.gridControlSatisFatura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlSatisFatura.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlSatisFatura.Location = new System.Drawing.Point(0, 160);
            this.gridControlSatisFatura.MainView = this.gridSatisFaturasi;
            this.gridControlSatisFatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlSatisFatura.Name = "gridControlSatisFatura";
            this.gridControlSatisFatura.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.gridControlSatisFatura.Size = new System.Drawing.Size(1492, 441);
            this.gridControlSatisFatura.TabIndex = 17;
            this.gridControlSatisFatura.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSatisFaturasi});
            // 
            // gridSatisFaturasi
            // 
            this.gridSatisFaturasi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridStokKod,
            this.gridTutar,
            this.gridGramMiktar,
            this.gridMilyem,
            this.gridMaliyet,
            this.gridIscilik,
            this.gridHasMiktar,
            this.gridHasFiyat,
            this.gridEldekiMiktar});
            this.gridSatisFaturasi.GridControl = this.gridControlSatisFatura;
            this.gridSatisFaturasi.GroupPanelText = "Satış Fatura Sepet Listesi";
            this.gridSatisFaturasi.Name = "gridSatisFaturasi";
            this.gridSatisFaturasi.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridSatisFaturasi.OptionsView.RowAutoHeight = true;
            this.gridSatisFaturasi.OptionsView.ShowAutoFilterRow = true;
            this.gridSatisFaturasi.OptionsView.ShowGroupPanel = false;
            this.gridSatisFaturasi.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridSatisFaturasi_CellValueChanged);
            this.gridSatisFaturasi.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridSatisFaturasi_RowUpdated);
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
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridTutar
            // 
            this.gridTutar.Caption = "Tutar";
            this.gridTutar.FieldName = "SH_TUTARTL";
            this.gridTutar.MinWidth = 25;
            this.gridTutar.Name = "gridTutar";
            this.gridTutar.OptionsColumn.AllowEdit = false;
            this.gridTutar.Visible = true;
            this.gridTutar.VisibleIndex = 8;
            this.gridTutar.Width = 93;
            // 
            // gridGramMiktar
            // 
            this.gridGramMiktar.Caption = "Gram Miktar";
            this.gridGramMiktar.FieldName = "SH_GRAMMIKTAR";
            this.gridGramMiktar.MinWidth = 27;
            this.gridGramMiktar.Name = "gridGramMiktar";
            this.gridGramMiktar.Visible = true;
            this.gridGramMiktar.VisibleIndex = 3;
            this.gridGramMiktar.Width = 100;
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
            this.gridMilyem.Width = 94;
            // 
            // gridMaliyet
            // 
            this.gridMaliyet.Caption = "Maliyet";
            this.gridMaliyet.FieldName = "SH_MALIYET";
            this.gridMaliyet.MinWidth = 25;
            this.gridMaliyet.Name = "gridMaliyet";
            this.gridMaliyet.Visible = true;
            this.gridMaliyet.VisibleIndex = 4;
            this.gridMaliyet.Width = 94;
            // 
            // gridIscilik
            // 
            this.gridIscilik.Caption = "İşçilik";
            this.gridIscilik.FieldName = "SH_ISCILIK";
            this.gridIscilik.MinWidth = 25;
            this.gridIscilik.Name = "gridIscilik";
            this.gridIscilik.Visible = true;
            this.gridIscilik.VisibleIndex = 5;
            this.gridIscilik.Width = 94;
            // 
            // gridHasMiktar
            // 
            this.gridHasMiktar.Caption = "Has Miktarı";
            this.gridHasMiktar.FieldName = "SH_HASMIKTAR";
            this.gridHasMiktar.MinWidth = 25;
            this.gridHasMiktar.Name = "gridHasMiktar";
            this.gridHasMiktar.OptionsColumn.AllowEdit = false;
            this.gridHasMiktar.Visible = true;
            this.gridHasMiktar.VisibleIndex = 6;
            this.gridHasMiktar.Width = 94;
            // 
            // gridHasFiyat
            // 
            this.gridHasFiyat.Caption = "Has Fiyatı";
            this.gridHasFiyat.FieldName = "SH_HASFIYAT";
            this.gridHasFiyat.MinWidth = 25;
            this.gridHasFiyat.Name = "gridHasFiyat";
            this.gridHasFiyat.Visible = true;
            this.gridHasFiyat.VisibleIndex = 7;
            this.gridHasFiyat.Width = 94;
            // 
            // gridEldekiMiktar
            // 
            this.gridEldekiMiktar.Caption = "Eldeki Miktar";
            this.gridEldekiMiktar.FieldName = "UrunTotalGram";
            this.gridEldekiMiktar.MinWidth = 25;
            this.gridEldekiMiktar.Name = "gridEldekiMiktar";
            this.gridEldekiMiktar.OptionsColumn.AllowEdit = false;
            this.gridEldekiMiktar.OptionsColumn.ReadOnly = true;
            this.gridEldekiMiktar.Visible = true;
            this.gridEldekiMiktar.VisibleIndex = 2;
            this.gridEldekiMiktar.Width = 94;
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSil.ImageOptions.SvgImage")));
            this.btnSil.Location = new System.Drawing.Point(16, 607);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(111, 30);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(1355, 607);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(117, 30);
            this.btnKaydet.TabIndex = 19;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(539, 24);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(67, 16);
            this.lblAdSoyad.TabIndex = 20;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(636, 20);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(175, 22);
            this.txtAdSoyad.TabIndex = 21;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(636, 70);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(175, 22);
            this.txtTelefon.TabIndex = 22;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(636, 112);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(175, 22);
            this.txtAciklama.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Açıklama";
            // 
            // chkMuhtelif
            // 
            this.chkMuhtelif.AutoSize = true;
            this.chkMuhtelif.Location = new System.Drawing.Point(365, 72);
            this.chkMuhtelif.Name = "chkMuhtelif";
            this.chkMuhtelif.Size = new System.Drawing.Size(93, 25);
            this.chkMuhtelif.TabIndex = 26;
            this.chkMuhtelif.Text = "Muhtelif";
            this.chkMuhtelif.UseVisualStyleBackColor = true;
            this.chkMuhtelif.CheckedChanged += new System.EventHandler(this.chkMuhtelif_CheckedChanged);
            // 
            // frmSatisFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 641);
            this.Controls.Add(this.chkMuhtelif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.gridControlSatisFatura);
            this.Controls.Add(this.txtSatisFaturaNo);
            this.Controls.Add(this.lblFaturaNo);
            this.Controls.Add(this.txtSatisTutar);
            this.Controls.Add(this.dtSatisTarihi);
            this.Controls.Add(this.lueCari);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblSatisTarih);
            this.Controls.Add(this.lblCari);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSatisFatura";
            this.Text = "Satış Fatura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.lueCari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSatisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSatisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSatisFatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSatisFaturasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.Label lblSatisTarih;
        private System.Windows.Forms.Label lblTutar;
        private DevExpress.XtraEditors.LookUpEdit lueCari;
        private DevExpress.XtraEditors.DateEdit dtSatisTarihi;
        private DevExpress.XtraEditors.TextEdit txtSatisTutar;
        private System.Windows.Forms.Label lblFaturaNo;
        private System.Windows.Forms.TextBox txtSatisFaturaNo;
        private DevExpress.XtraGrid.GridControl gridControlSatisFatura;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSatisFaturasi;
        private DevExpress.XtraGrid.Columns.GridColumn gridStokKod;
        private DevExpress.XtraGrid.Columns.GridColumn gridTutar;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn gridGramMiktar;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridMilyem;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaliyet;
        private DevExpress.XtraGrid.Columns.GridColumn gridIscilik;
        private DevExpress.XtraGrid.Columns.GridColumn gridHasMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn gridHasFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn gridEldekiMiktar;
        private System.Windows.Forms.CheckBox chkMuhtelif;
    }
}