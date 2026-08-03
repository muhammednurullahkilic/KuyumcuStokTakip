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
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.lblSatisTarih = new System.Windows.Forms.Label();
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.lblGramFiyat = new System.Windows.Forms.Label();
            this.lblIskonto = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lueMusteriAd = new DevExpress.XtraEditors.LookUpEdit();
            this.lueBarkodNo = new DevExpress.XtraEditors.LookUpEdit();
            this.dtSatisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtSatisGramFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtIskonto = new DevExpress.XtraEditors.TextEdit();
            this.txtSatisTutar = new DevExpress.XtraEditors.TextEdit();
            this.btnSatisFaturaOnayla = new DevExpress.XtraEditors.SimpleButton();
            this.lblFaturaNo = new System.Windows.Forms.Label();
            this.txtSatisFaturaNo = new System.Windows.Forms.TextBox();
            this.gridControlSatisFatura = new DevExpress.XtraGrid.GridControl();
            this.gridSatisFaturasi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridFaturaNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMusteriAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridBarkodNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridGramFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridIskonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lueMusteriAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBarkodNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSatisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSatisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisGramFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIskonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSatisFatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSatisFaturasi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Location = new System.Drawing.Point(53, 66);
            this.lblMusteriAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(64, 13);
            this.lblMusteriAd.TabIndex = 0;
            this.lblMusteriAd.Text = "*Müşteri Ad:";
            // 
            // lblSatisTarih
            // 
            this.lblSatisTarih.AutoSize = true;
            this.lblSatisTarih.Location = new System.Drawing.Point(53, 107);
            this.lblSatisTarih.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSatisTarih.Name = "lblSatisTarih";
            this.lblSatisTarih.Size = new System.Drawing.Size(38, 13);
            this.lblSatisTarih.TabIndex = 1;
            this.lblSatisTarih.Text = "*Tarih:";
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.Location = new System.Drawing.Point(329, 35);
            this.lblBarkodNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(65, 13);
            this.lblBarkodNo.TabIndex = 3;
            this.lblBarkodNo.Text = "*Barkod No:";
            // 
            // lblGramFiyat
            // 
            this.lblGramFiyat.AutoSize = true;
            this.lblGramFiyat.Location = new System.Drawing.Point(329, 72);
            this.lblGramFiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGramFiyat.Name = "lblGramFiyat";
            this.lblGramFiyat.Size = new System.Drawing.Size(64, 13);
            this.lblGramFiyat.TabIndex = 2;
            this.lblGramFiyat.Text = "*Gram Fiyat:";
            // 
            // lblIskonto
            // 
            this.lblIskonto.AutoSize = true;
            this.lblIskonto.Location = new System.Drawing.Point(329, 105);
            this.lblIskonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIskonto.Name = "lblIskonto";
            this.lblIskonto.Size = new System.Drawing.Size(49, 13);
            this.lblIskonto.TabIndex = 5;
            this.lblIskonto.Text = "*İskonto:";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(329, 141);
            this.lblTutar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(39, 13);
            this.lblTutar.TabIndex = 4;
            this.lblTutar.Text = "*Tutar:";
            // 
            // lueMusteriAd
            // 
            this.lueMusteriAd.Location = new System.Drawing.Point(133, 61);
            this.lueMusteriAd.Margin = new System.Windows.Forms.Padding(2);
            this.lueMusteriAd.Name = "lueMusteriAd";
            this.lueMusteriAd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMusteriAd.Properties.NullText = "";
            this.lueMusteriAd.Size = new System.Drawing.Size(140, 20);
            this.lueMusteriAd.TabIndex = 7;
            // 
            // lueBarkodNo
            // 
            this.lueBarkodNo.Location = new System.Drawing.Point(409, 33);
            this.lueBarkodNo.Margin = new System.Windows.Forms.Padding(2);
            this.lueBarkodNo.Name = "lueBarkodNo";
            this.lueBarkodNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBarkodNo.Properties.NullText = "";
            this.lueBarkodNo.Size = new System.Drawing.Size(140, 20);
            this.lueBarkodNo.TabIndex = 8;
            // 
            // dtSatisTarihi
            // 
            this.dtSatisTarihi.EditValue = null;
            this.dtSatisTarihi.Location = new System.Drawing.Point(133, 102);
            this.dtSatisTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtSatisTarihi.Name = "dtSatisTarihi";
            this.dtSatisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSatisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSatisTarihi.Size = new System.Drawing.Size(140, 20);
            this.dtSatisTarihi.TabIndex = 9;
            // 
            // txtSatisGramFiyat
            // 
            this.txtSatisGramFiyat.Location = new System.Drawing.Point(409, 67);
            this.txtSatisGramFiyat.Margin = new System.Windows.Forms.Padding(2);
            this.txtSatisGramFiyat.Name = "txtSatisGramFiyat";
            this.txtSatisGramFiyat.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSatisGramFiyat.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtSatisGramFiyat.Size = new System.Drawing.Size(140, 20);
            this.txtSatisGramFiyat.TabIndex = 10;
            // 
            // txtIskonto
            // 
            this.txtIskonto.Location = new System.Drawing.Point(409, 100);
            this.txtIskonto.Margin = new System.Windows.Forms.Padding(2);
            this.txtIskonto.Name = "txtIskonto";
            this.txtIskonto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtIskonto.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtIskonto.Size = new System.Drawing.Size(140, 20);
            this.txtIskonto.TabIndex = 11;
            // 
            // txtSatisTutar
            // 
            this.txtSatisTutar.Location = new System.Drawing.Point(409, 137);
            this.txtSatisTutar.Margin = new System.Windows.Forms.Padding(2);
            this.txtSatisTutar.Name = "txtSatisTutar";
            this.txtSatisTutar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSatisTutar.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtSatisTutar.Size = new System.Drawing.Size(140, 20);
            this.txtSatisTutar.TabIndex = 12;
            // 
            // btnSatisFaturaOnayla
            // 
            this.btnSatisFaturaOnayla.Location = new System.Drawing.Point(713, 122);
            this.btnSatisFaturaOnayla.Margin = new System.Windows.Forms.Padding(2);
            this.btnSatisFaturaOnayla.Name = "btnSatisFaturaOnayla";
            this.btnSatisFaturaOnayla.Size = new System.Drawing.Size(122, 32);
            this.btnSatisFaturaOnayla.TabIndex = 14;
            this.btnSatisFaturaOnayla.Text = "Onayla";
            // 
            // lblFaturaNo
            // 
            this.lblFaturaNo.AutoSize = true;
            this.lblFaturaNo.Location = new System.Drawing.Point(53, 35);
            this.lblFaturaNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFaturaNo.Name = "lblFaturaNo";
            this.lblFaturaNo.Size = new System.Drawing.Size(61, 13);
            this.lblFaturaNo.TabIndex = 15;
            this.lblFaturaNo.Text = "*Fatura No:";
            // 
            // txtSatisFaturaNo
            // 
            this.txtSatisFaturaNo.Location = new System.Drawing.Point(133, 33);
            this.txtSatisFaturaNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSatisFaturaNo.Name = "txtSatisFaturaNo";
            this.txtSatisFaturaNo.Size = new System.Drawing.Size(141, 20);
            this.txtSatisFaturaNo.TabIndex = 16;
            // 
            // gridControlSatisFatura
            // 
            this.gridControlSatisFatura.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlSatisFatura.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlSatisFatura.Location = new System.Drawing.Point(0, 181);
            this.gridControlSatisFatura.MainView = this.gridSatisFaturasi;
            this.gridControlSatisFatura.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlSatisFatura.Name = "gridControlSatisFatura";
            this.gridControlSatisFatura.Size = new System.Drawing.Size(1116, 340);
            this.gridControlSatisFatura.TabIndex = 17;
            this.gridControlSatisFatura.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSatisFaturasi});
            // 
            // gridSatisFaturasi
            // 
            this.gridSatisFaturasi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridFaturaNo,
            this.gridMusteriAd,
            this.gridTarih,
            this.gridBarkodNo,
            this.gridGramFiyat,
            this.gridIskonto,
            this.gridTutar});
            this.gridSatisFaturasi.DetailHeight = 284;
            this.gridSatisFaturasi.GridControl = this.gridControlSatisFatura;
            this.gridSatisFaturasi.GroupPanelText = "Satış Fatura Sepet Listesi";
            this.gridSatisFaturasi.Name = "gridSatisFaturasi";
            this.gridSatisFaturasi.OptionsEditForm.PopupEditFormWidth = 600;
            // 
            // gridFaturaNo
            // 
            this.gridFaturaNo.Caption = "Fatura No";
            this.gridFaturaNo.MinWidth = 19;
            this.gridFaturaNo.Name = "gridFaturaNo";
            this.gridFaturaNo.Visible = true;
            this.gridFaturaNo.VisibleIndex = 0;
            this.gridFaturaNo.Width = 70;
            // 
            // gridMusteriAd
            // 
            this.gridMusteriAd.Caption = "Müşteri Ad";
            this.gridMusteriAd.MinWidth = 19;
            this.gridMusteriAd.Name = "gridMusteriAd";
            this.gridMusteriAd.Visible = true;
            this.gridMusteriAd.VisibleIndex = 1;
            this.gridMusteriAd.Width = 70;
            // 
            // gridTarih
            // 
            this.gridTarih.Caption = "Tarih";
            this.gridTarih.MinWidth = 19;
            this.gridTarih.Name = "gridTarih";
            this.gridTarih.Visible = true;
            this.gridTarih.VisibleIndex = 2;
            this.gridTarih.Width = 70;
            // 
            // gridBarkodNo
            // 
            this.gridBarkodNo.Caption = "Barkod No";
            this.gridBarkodNo.MinWidth = 19;
            this.gridBarkodNo.Name = "gridBarkodNo";
            this.gridBarkodNo.Visible = true;
            this.gridBarkodNo.VisibleIndex = 3;
            this.gridBarkodNo.Width = 70;
            // 
            // gridGramFiyat
            // 
            this.gridGramFiyat.Caption = "Gram Fiyat";
            this.gridGramFiyat.MinWidth = 19;
            this.gridGramFiyat.Name = "gridGramFiyat";
            this.gridGramFiyat.Visible = true;
            this.gridGramFiyat.VisibleIndex = 4;
            this.gridGramFiyat.Width = 70;
            // 
            // gridIskonto
            // 
            this.gridIskonto.Caption = "İskonto";
            this.gridIskonto.MinWidth = 19;
            this.gridIskonto.Name = "gridIskonto";
            this.gridIskonto.Visible = true;
            this.gridIskonto.VisibleIndex = 5;
            this.gridIskonto.Width = 70;
            // 
            // gridTutar
            // 
            this.gridTutar.Caption = "Tutar";
            this.gridTutar.MinWidth = 19;
            this.gridTutar.Name = "gridTutar";
            this.gridTutar.Visible = true;
            this.gridTutar.VisibleIndex = 6;
            this.gridTutar.Width = 70;
            // 
            // frmSatisFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 521);
            this.Controls.Add(this.gridControlSatisFatura);
            this.Controls.Add(this.txtSatisFaturaNo);
            this.Controls.Add(this.lblFaturaNo);
            this.Controls.Add(this.btnSatisFaturaOnayla);
            this.Controls.Add(this.txtSatisTutar);
            this.Controls.Add(this.txtIskonto);
            this.Controls.Add(this.txtSatisGramFiyat);
            this.Controls.Add(this.dtSatisTarihi);
            this.Controls.Add(this.lueBarkodNo);
            this.Controls.Add(this.lueMusteriAd);
            this.Controls.Add(this.lblIskonto);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblBarkodNo);
            this.Controls.Add(this.lblGramFiyat);
            this.Controls.Add(this.lblSatisTarih);
            this.Controls.Add(this.lblMusteriAd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSatisFatura";
            this.Text = "Satış Fatura";
            ((System.ComponentModel.ISupportInitialize)(this.lueMusteriAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBarkodNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSatisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSatisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisGramFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIskonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSatisFatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSatisFaturasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.Label lblSatisTarih;
        private System.Windows.Forms.Label lblBarkodNo;
        private System.Windows.Forms.Label lblGramFiyat;
        private System.Windows.Forms.Label lblIskonto;
        private System.Windows.Forms.Label lblTutar;
        private DevExpress.XtraEditors.LookUpEdit lueMusteriAd;
        private DevExpress.XtraEditors.LookUpEdit lueBarkodNo;
        private DevExpress.XtraEditors.DateEdit dtSatisTarihi;
        private DevExpress.XtraEditors.TextEdit txtSatisGramFiyat;
        private DevExpress.XtraEditors.TextEdit txtIskonto;
        private DevExpress.XtraEditors.TextEdit txtSatisTutar;
        private DevExpress.XtraEditors.SimpleButton btnSatisFaturaOnayla;
        private System.Windows.Forms.Label lblFaturaNo;
        private System.Windows.Forms.TextBox txtSatisFaturaNo;
        private DevExpress.XtraGrid.GridControl gridControlSatisFatura;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSatisFaturasi;
        private DevExpress.XtraGrid.Columns.GridColumn gridFaturaNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridMusteriAd;
        private DevExpress.XtraGrid.Columns.GridColumn gridTarih;
        private DevExpress.XtraGrid.Columns.GridColumn gridBarkodNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridGramFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn gridIskonto;
        private DevExpress.XtraGrid.Columns.GridColumn gridTutar;
    }
}