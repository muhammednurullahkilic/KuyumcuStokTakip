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
            this.btnKasaKayit = new DevExpress.XtraEditors.SimpleButton();
            this.lblCari = new System.Windows.Forms.Label();
            this.lblIslemTuru = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.lueCari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKasaIslemleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasaIslemleri)).BeginInit();
            this.SuspendLayout();
            // 
            // lueCari
            // 
            this.lueCari.Location = new System.Drawing.Point(211, 136);
            this.lueCari.Name = "lueCari";
            this.lueCari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
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
            this.txtTutar.Location = new System.Drawing.Point(620, 51);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(149, 22);
            this.txtTutar.TabIndex = 2;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(620, 92);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(149, 22);
            this.txtAciklama.TabIndex = 3;
            // 
            // btnKasaKayit
            // 
            this.btnKasaKayit.Location = new System.Drawing.Point(639, 132);
            this.btnKasaKayit.Name = "btnKasaKayit";
            this.btnKasaKayit.Size = new System.Drawing.Size(103, 30);
            this.btnKasaKayit.TabIndex = 4;
            this.btnKasaKayit.Text = "Kayıt";
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Location = new System.Drawing.Point(99, 142);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(36, 16);
            this.lblCari.TabIndex = 5;
            this.lblCari.Text = "Cari*";
            // 
            // lblIslemTuru
            // 
            this.lblIslemTuru.AutoSize = true;
            this.lblIslemTuru.Location = new System.Drawing.Point(97, 98);
            this.lblIslemTuru.Name = "lblIslemTuru";
            this.lblIslemTuru.Size = new System.Drawing.Size(74, 16);
            this.lblIslemTuru.TabIndex = 6;
            this.lblIslemTuru.Text = "İşlem Türü*";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(517, 57);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(43, 16);
            this.lblTutar.TabIndex = 7;
            this.lblTutar.Text = "Tutar*";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(517, 98);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(63, 16);
            this.lblAciklama.TabIndex = 8;
            this.lblAciklama.Text = "Açıklama";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(216, 51);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(144, 22);
            this.dateEdit1.TabIndex = 9;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(97, 57);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(38, 16);
            this.lblTarih.TabIndex = 10;
            this.lblTarih.Text = "Tarih";
            // 
            // chkGiris
            // 
            this.chkGiris.AutoSize = true;
            this.chkGiris.Location = new System.Drawing.Point(215, 94);
            this.chkGiris.Name = "chkGiris";
            this.chkGiris.Size = new System.Drawing.Size(56, 20);
            this.chkGiris.TabIndex = 11;
            this.chkGiris.Text = "Giriş";
            this.chkGiris.UseVisualStyleBackColor = true;
            // 
            // chkCikis
            // 
            this.chkCikis.AutoSize = true;
            this.chkCikis.Location = new System.Drawing.Point(328, 94);
            this.chkCikis.Name = "chkCikis";
            this.chkCikis.Size = new System.Drawing.Size(58, 20);
            this.chkCikis.TabIndex = 12;
            this.chkCikis.Text = "Çıkış";
            this.chkCikis.UseVisualStyleBackColor = true;
            // 
            // gridControlKasaIslemleri
            // 
            this.gridControlKasaIslemleri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlKasaIslemleri.Location = new System.Drawing.Point(0, 368);
            this.gridControlKasaIslemleri.MainView = this.gridKasaIslemleri;
            this.gridControlKasaIslemleri.Name = "gridControlKasaIslemleri";
            this.gridControlKasaIslemleri.Size = new System.Drawing.Size(1643, 500);
            this.gridControlKasaIslemleri.TabIndex = 13;
            this.gridControlKasaIslemleri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKasaIslemleri});
            // 
            // gridKasaIslemleri
            // 
            this.gridKasaIslemleri.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridKasaID,
            this.gridCariAd,
            this.gridTarih,
            this.gridIslemTuru,
            this.gridTutar,
            this.gridAciklama});
            this.gridKasaIslemleri.GridControl = this.gridControlKasaIslemleri;
            this.gridKasaIslemleri.GroupPanelText = "Kasa Giriş Çıkış Özet";
            this.gridKasaIslemleri.Name = "gridKasaIslemleri";
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
            this.gridIslemTuru.FieldName = "IslemTuru";
            this.gridIslemTuru.MinWidth = 25;
            this.gridIslemTuru.Name = "gridIslemTuru";
            this.gridIslemTuru.OptionsColumn.AllowEdit = false;
            this.gridIslemTuru.Visible = true;
            this.gridIslemTuru.VisibleIndex = 2;
            this.gridIslemTuru.Width = 94;
            // 
            // gridTutar
            // 
            this.gridTutar.Caption = "Tutar";
            this.gridTutar.FieldName = "Tutar";
            this.gridTutar.MinWidth = 25;
            this.gridTutar.Name = "gridTutar";
            this.gridTutar.OptionsColumn.AllowEdit = false;
            this.gridTutar.Visible = true;
            this.gridTutar.VisibleIndex = 4;
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
            this.gridAciklama.VisibleIndex = 5;
            this.gridAciklama.Width = 94;
            // 
            // frmKasaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 694);
            this.Controls.Add(this.gridControlKasaIslemleri);
            this.Controls.Add(this.chkCikis);
            this.Controls.Add(this.chkGiris);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblIslemTuru);
            this.Controls.Add(this.lblCari);
            this.Controls.Add(this.btnKasaKayit);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.lueCari);
            this.Name = "frmKasaIslemleri";
            this.Text = "Kasa İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.lueCari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKasaIslemleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasaIslemleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit lueCari;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtAciklama;
        private DevExpress.XtraEditors.SimpleButton btnKasaKayit;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.Label lblIslemTuru;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblAciklama;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
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
    }
}