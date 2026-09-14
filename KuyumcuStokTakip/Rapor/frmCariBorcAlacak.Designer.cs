namespace KuyumcuStokTakip.Rapor
{
    partial class frmCariBorcAlacak
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblBakiyeDurum = new System.Windows.Forms.Label();
            this.lblToplamSatis = new System.Windows.Forms.Label();
            this.lblToplamAlis = new System.Windows.Forms.Label();
            this.btnCariSorgu = new DevExpress.XtraEditors.SimpleButton();
            this.lblCariSorgu = new System.Windows.Forms.Label();
            this.lueCariArama = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlCariBorcAlacak = new DevExpress.XtraGrid.GridControl();
            this.gridCariBorcAlacak = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridCariID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCariAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFisNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridHasMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridHasFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridBorc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAlacak = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueCariArama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCariBorcAlacak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCariBorcAlacak)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblBakiyeDurum);
            this.panelControl1.Controls.Add(this.lblToplamSatis);
            this.panelControl1.Controls.Add(this.lblToplamAlis);
            this.panelControl1.Controls.Add(this.btnCariSorgu);
            this.panelControl1.Controls.Add(this.lblCariSorgu);
            this.panelControl1.Controls.Add(this.lueCariArama);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1459, 338);
            this.panelControl1.TabIndex = 0;
            // 
            // lblBakiyeDurum
            // 
            this.lblBakiyeDurum.AutoSize = true;
            this.lblBakiyeDurum.Location = new System.Drawing.Point(688, 122);
            this.lblBakiyeDurum.Name = "lblBakiyeDurum";
            this.lblBakiyeDurum.Size = new System.Drawing.Size(119, 16);
            this.lblBakiyeDurum.TabIndex = 5;
            this.lblBakiyeDurum.Text = "Durum Bekleniyor...";
            // 
            // lblToplamSatis
            // 
            this.lblToplamSatis.AutoSize = true;
            this.lblToplamSatis.Location = new System.Drawing.Point(688, 77);
            this.lblToplamSatis.Name = "lblToplamSatis";
            this.lblToplamSatis.Size = new System.Drawing.Size(127, 16);
            this.lblToplamSatis.TabIndex = 4;
            this.lblToplamSatis.Text = "Toplam Satış: 0.00 ₺";
            // 
            // lblToplamAlis
            // 
            this.lblToplamAlis.AutoSize = true;
            this.lblToplamAlis.Location = new System.Drawing.Point(688, 35);
            this.lblToplamAlis.Name = "lblToplamAlis";
            this.lblToplamAlis.Size = new System.Drawing.Size(119, 16);
            this.lblToplamAlis.TabIndex = 3;
            this.lblToplamAlis.Text = "Toplam Alış: 0.00 ₺";
            // 
            // btnCariSorgu
            // 
            this.btnCariSorgu.Location = new System.Drawing.Point(179, 95);
            this.btnCariSorgu.Name = "btnCariSorgu";
            this.btnCariSorgu.Size = new System.Drawing.Size(142, 40);
            this.btnCariSorgu.TabIndex = 2;
            this.btnCariSorgu.Text = "Sorgula";
            this.btnCariSorgu.Click += new System.EventHandler(this.btnCariSorgu_Click);
            // 
            // lblCariSorgu
            // 
            this.lblCariSorgu.AutoSize = true;
            this.lblCariSorgu.Location = new System.Drawing.Point(76, 38);
            this.lblCariSorgu.Name = "lblCariSorgu";
            this.lblCariSorgu.Size = new System.Drawing.Size(68, 16);
            this.lblCariSorgu.TabIndex = 1;
            this.lblCariSorgu.Text = "Cari Sorgu";
            // 
            // lueCariArama
            // 
            this.lueCariArama.Location = new System.Drawing.Point(179, 36);
            this.lueCariArama.Name = "lueCariArama";
            this.lueCariArama.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCariArama.Properties.NullText = "";
            this.lueCariArama.Properties.PopupView = this.searchLookUpEdit1View;
            this.lueCariArama.Size = new System.Drawing.Size(142, 22);
            this.lueCariArama.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridControlCariBorcAlacak
            // 
            this.gridControlCariBorcAlacak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCariBorcAlacak.Location = new System.Drawing.Point(0, 338);
            this.gridControlCariBorcAlacak.MainView = this.gridCariBorcAlacak;
            this.gridControlCariBorcAlacak.Name = "gridControlCariBorcAlacak";
            this.gridControlCariBorcAlacak.Size = new System.Drawing.Size(1459, 390);
            this.gridControlCariBorcAlacak.TabIndex = 1;
            this.gridControlCariBorcAlacak.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridCariBorcAlacak});
            // 
            // gridCariBorcAlacak
            // 
            this.gridCariBorcAlacak.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridCariID,
            this.gridCariAd,
            this.gridFisNo,
            this.gridHasMiktar,
            this.gridHasFiyat,
            this.gridTarih,
            this.gridBorc,
            this.gridAlacak});
            this.gridCariBorcAlacak.GridControl = this.gridControlCariBorcAlacak;
            this.gridCariBorcAlacak.Name = "gridCariBorcAlacak";
            this.gridCariBorcAlacak.OptionsView.ShowFooter = true;
            // 
            // gridCariID
            // 
            this.gridCariID.Caption = "Cari ID";
            this.gridCariID.FieldName = "CariID";
            this.gridCariID.MinWidth = 25;
            this.gridCariID.Name = "gridCariID";
            this.gridCariID.Visible = true;
            this.gridCariID.VisibleIndex = 1;
            this.gridCariID.Width = 94;
            // 
            // gridCariAd
            // 
            this.gridCariAd.Caption = "Cari Adı";
            this.gridCariAd.FieldName = "CariAd";
            this.gridCariAd.MinWidth = 25;
            this.gridCariAd.Name = "gridCariAd";
            this.gridCariAd.Visible = true;
            this.gridCariAd.VisibleIndex = 2;
            this.gridCariAd.Width = 94;
            // 
            // gridFisNo
            // 
            this.gridFisNo.Caption = "Fatura No";
            this.gridFisNo.FieldName = "FT_FISNO";
            this.gridFisNo.MinWidth = 25;
            this.gridFisNo.Name = "gridFisNo";
            this.gridFisNo.Visible = true;
            this.gridFisNo.VisibleIndex = 3;
            this.gridFisNo.Width = 94;
            // 
            // gridHasMiktar
            // 
            this.gridHasMiktar.Caption = "Has Miktarı";
            this.gridHasMiktar.FieldName = "SH_HASMIKTAR";
            this.gridHasMiktar.MinWidth = 25;
            this.gridHasMiktar.Name = "gridHasMiktar";
            this.gridHasMiktar.Visible = true;
            this.gridHasMiktar.VisibleIndex = 4;
            this.gridHasMiktar.Width = 94;
            // 
            // gridHasFiyat
            // 
            this.gridHasFiyat.Caption = "Has Fiyat";
            this.gridHasFiyat.FieldName = "SH_HASFIYAT";
            this.gridHasFiyat.MinWidth = 25;
            this.gridHasFiyat.Name = "gridHasFiyat";
            this.gridHasFiyat.Visible = true;
            this.gridHasFiyat.VisibleIndex = 5;
            this.gridHasFiyat.Width = 94;
            // 
            // gridTarih
            // 
            this.gridTarih.Caption = "Tarih";
            this.gridTarih.FieldName = "CH_TARIH";
            this.gridTarih.MinWidth = 25;
            this.gridTarih.Name = "gridTarih";
            this.gridTarih.Visible = true;
            this.gridTarih.VisibleIndex = 0;
            this.gridTarih.Width = 94;
            // 
            // gridBorc
            // 
            this.gridBorc.Caption = "Borç";
            this.gridBorc.DisplayFormat.FormatString = "N2";
            this.gridBorc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridBorc.FieldName = "Borc";
            this.gridBorc.MinWidth = 25;
            this.gridBorc.Name = "gridBorc";
            this.gridBorc.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Borc", "{0:N2}")});
            this.gridBorc.Visible = true;
            this.gridBorc.VisibleIndex = 6;
            this.gridBorc.Width = 94;
            // 
            // gridAlacak
            // 
            this.gridAlacak.Caption = "Alacak";
            this.gridAlacak.DisplayFormat.FormatString = "N2";
            this.gridAlacak.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridAlacak.FieldName = "Alacak";
            this.gridAlacak.MinWidth = 25;
            this.gridAlacak.Name = "gridAlacak";
            this.gridAlacak.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Alacak", "{0:N2}")});
            this.gridAlacak.Visible = true;
            this.gridAlacak.VisibleIndex = 7;
            this.gridAlacak.Width = 94;
            // 
            // frmCariBorcAlacak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 728);
            this.Controls.Add(this.gridControlCariBorcAlacak);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmCariBorcAlacak";
            this.Text = "Cari Borç Alacak";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueCariArama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCariBorcAlacak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCariBorcAlacak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label lblCariSorgu;
        private DevExpress.XtraEditors.SearchLookUpEdit lueCariArama;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton btnCariSorgu;
        private System.Windows.Forms.Label lblBakiyeDurum;
        private System.Windows.Forms.Label lblToplamSatis;
        private System.Windows.Forms.Label lblToplamAlis;
        private DevExpress.XtraGrid.GridControl gridControlCariBorcAlacak;
        private DevExpress.XtraGrid.Views.Grid.GridView gridCariBorcAlacak;
        private DevExpress.XtraGrid.Columns.GridColumn gridCariID;
        private DevExpress.XtraGrid.Columns.GridColumn gridCariAd;
        private DevExpress.XtraGrid.Columns.GridColumn gridFisNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridHasMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn gridHasFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn gridTarih;
        private DevExpress.XtraGrid.Columns.GridColumn gridBorc;
        private DevExpress.XtraGrid.Columns.GridColumn gridAlacak;
    }
}