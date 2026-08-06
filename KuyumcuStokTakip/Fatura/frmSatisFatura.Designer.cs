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
            this.lblStokKod = new System.Windows.Forms.Label();
            this.lblGramFiyat = new System.Windows.Forms.Label();
            this.lblIskonto = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lueMusteriAd = new DevExpress.XtraEditors.LookUpEdit();
            this.lueBarkodNo = new DevExpress.XtraEditors.LookUpEdit();
            this.dtSatisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtSatisGramFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtIskonto = new DevExpress.XtraEditors.TextEdit();
            this.txtSatisTutar = new DevExpress.XtraEditors.TextEdit();
            this.lblFaturaNo = new System.Windows.Forms.Label();
            this.txtSatisFaturaNo = new System.Windows.Forms.TextBox();
            this.gridControlSatisFatura = new DevExpress.XtraGrid.GridControl();
            this.gridSatisFaturasi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridStokKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridGramFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridIskonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridGram = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGram = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Location = new System.Drawing.Point(38, 68);
            this.lblCari.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(32, 13);
            this.lblCari.TabIndex = 0;
            this.lblCari.Text = "*Cari:";
            // 
            // lblSatisTarih
            // 
            this.lblSatisTarih.AutoSize = true;
            this.lblSatisTarih.Location = new System.Drawing.Point(38, 109);
            this.lblSatisTarih.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSatisTarih.Name = "lblSatisTarih";
            this.lblSatisTarih.Size = new System.Drawing.Size(38, 13);
            this.lblSatisTarih.TabIndex = 1;
            this.lblSatisTarih.Text = "*Tarih:";
            // 
            // lblStokKod
            // 
            this.lblStokKod.AutoSize = true;
            this.lblStokKod.Location = new System.Drawing.Point(550, 34);
            this.lblStokKod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStokKod.Name = "lblStokKod";
            this.lblStokKod.Size = new System.Drawing.Size(58, 13);
            this.lblStokKod.TabIndex = 3;
            this.lblStokKod.Text = "*Stok Kod:";
            // 
            // lblGramFiyat
            // 
            this.lblGramFiyat.AutoSize = true;
            this.lblGramFiyat.Location = new System.Drawing.Point(548, 111);
            this.lblGramFiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGramFiyat.Name = "lblGramFiyat";
            this.lblGramFiyat.Size = new System.Drawing.Size(64, 13);
            this.lblGramFiyat.TabIndex = 2;
            this.lblGramFiyat.Text = "*Gram Fiyat:";
            // 
            // lblIskonto
            // 
            this.lblIskonto.AutoSize = true;
            this.lblIskonto.Location = new System.Drawing.Point(819, 37);
            this.lblIskonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIskonto.Name = "lblIskonto";
            this.lblIskonto.Size = new System.Drawing.Size(49, 13);
            this.lblIskonto.TabIndex = 5;
            this.lblIskonto.Text = "*İskonto:";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(819, 73);
            this.lblTutar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(39, 13);
            this.lblTutar.TabIndex = 4;
            this.lblTutar.Text = "*Tutar:";
            // 
            // lueMusteriAd
            // 
            this.lueMusteriAd.Location = new System.Drawing.Point(118, 70);
            this.lueMusteriAd.Margin = new System.Windows.Forms.Padding(2);
            this.lueMusteriAd.Name = "lueMusteriAd";
            this.lueMusteriAd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMusteriAd.Properties.NullText = "Lütfen Seçiniz";
            this.lueMusteriAd.Size = new System.Drawing.Size(140, 20);
            this.lueMusteriAd.TabIndex = 7;
            // 
            // lueBarkodNo
            // 
            this.lueBarkodNo.Location = new System.Drawing.Point(630, 32);
            this.lueBarkodNo.Margin = new System.Windows.Forms.Padding(2);
            this.lueBarkodNo.Name = "lueBarkodNo";
            this.lueBarkodNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBarkodNo.Properties.NullText = "";
            this.lueBarkodNo.Size = new System.Drawing.Size(138, 20);
            this.lueBarkodNo.TabIndex = 8;
            // 
            // dtSatisTarihi
            // 
            this.dtSatisTarihi.EditValue = null;
            this.dtSatisTarihi.Location = new System.Drawing.Point(118, 104);
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
            this.txtSatisGramFiyat.Location = new System.Drawing.Point(630, 106);
            this.txtSatisGramFiyat.Margin = new System.Windows.Forms.Padding(2);
            this.txtSatisGramFiyat.Name = "txtSatisGramFiyat";
            this.txtSatisGramFiyat.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSatisGramFiyat.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtSatisGramFiyat.Size = new System.Drawing.Size(138, 20);
            this.txtSatisGramFiyat.TabIndex = 10;
            // 
            // txtIskonto
            // 
            this.txtIskonto.Location = new System.Drawing.Point(899, 32);
            this.txtIskonto.Margin = new System.Windows.Forms.Padding(2);
            this.txtIskonto.Name = "txtIskonto";
            this.txtIskonto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtIskonto.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtIskonto.Size = new System.Drawing.Size(140, 20);
            this.txtIskonto.TabIndex = 11;
            // 
            // txtSatisTutar
            // 
            this.txtSatisTutar.Location = new System.Drawing.Point(899, 70);
            this.txtSatisTutar.Margin = new System.Windows.Forms.Padding(2);
            this.txtSatisTutar.Name = "txtSatisTutar";
            this.txtSatisTutar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSatisTutar.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtSatisTutar.Size = new System.Drawing.Size(140, 20);
            this.txtSatisTutar.TabIndex = 12;
            // 
            // lblFaturaNo
            // 
            this.lblFaturaNo.AutoSize = true;
            this.lblFaturaNo.Location = new System.Drawing.Point(38, 37);
            this.lblFaturaNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFaturaNo.Name = "lblFaturaNo";
            this.lblFaturaNo.Size = new System.Drawing.Size(61, 13);
            this.lblFaturaNo.TabIndex = 15;
            this.lblFaturaNo.Text = "*Fatura No:";
            // 
            // txtSatisFaturaNo
            // 
            this.txtSatisFaturaNo.Location = new System.Drawing.Point(118, 35);
            this.txtSatisFaturaNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSatisFaturaNo.Name = "txtSatisFaturaNo";
            this.txtSatisFaturaNo.Size = new System.Drawing.Size(141, 20);
            this.txtSatisFaturaNo.TabIndex = 16;
            // 
            // gridControlSatisFatura
            // 
            this.gridControlSatisFatura.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlSatisFatura.Location = new System.Drawing.Point(-1, 182);
            this.gridControlSatisFatura.MainView = this.gridSatisFaturasi;
            this.gridControlSatisFatura.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlSatisFatura.Name = "gridControlSatisFatura";
            this.gridControlSatisFatura.Size = new System.Drawing.Size(1116, 294);
            this.gridControlSatisFatura.TabIndex = 17;
            this.gridControlSatisFatura.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSatisFaturasi});
            // 
            // gridSatisFaturasi
            // 
            this.gridSatisFaturasi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridStokKod,
            this.gridGramFiyat,
            this.gridIskonto,
            this.gridTutar,
            this.gridGram});
            this.gridSatisFaturasi.DetailHeight = 284;
            this.gridSatisFaturasi.GridControl = this.gridControlSatisFatura;
            this.gridSatisFaturasi.GroupPanelText = "Satış Fatura Sepet Listesi";
            this.gridSatisFaturasi.Name = "gridSatisFaturasi";
            this.gridSatisFaturasi.OptionsEditForm.PopupEditFormWidth = 600;
            // 
            // gridStokKod
            // 
            this.gridStokKod.Caption = "StokKod";
            this.gridStokKod.FieldName = "StokKod";
            this.gridStokKod.MinWidth = 19;
            this.gridStokKod.Name = "gridStokKod";
            this.gridStokKod.Visible = true;
            this.gridStokKod.VisibleIndex = 0;
            this.gridStokKod.Width = 70;
            // 
            // gridGramFiyat
            // 
            this.gridGramFiyat.Caption = "Gram Fiyat";
            this.gridGramFiyat.MinWidth = 19;
            this.gridGramFiyat.Name = "gridGramFiyat";
            this.gridGramFiyat.Visible = true;
            this.gridGramFiyat.VisibleIndex = 2;
            this.gridGramFiyat.Width = 70;
            // 
            // gridIskonto
            // 
            this.gridIskonto.Caption = "İskonto";
            this.gridIskonto.MinWidth = 19;
            this.gridIskonto.Name = "gridIskonto";
            this.gridIskonto.Visible = true;
            this.gridIskonto.VisibleIndex = 3;
            this.gridIskonto.Width = 70;
            // 
            // gridTutar
            // 
            this.gridTutar.Caption = "Tutar";
            this.gridTutar.MinWidth = 19;
            this.gridTutar.Name = "gridTutar";
            this.gridTutar.Visible = true;
            this.gridTutar.VisibleIndex = 4;
            this.gridTutar.Width = 70;
            // 
            // gridGram
            // 
            this.gridGram.Caption = "Gram";
            this.gridGram.FieldName = "Gram";
            this.gridGram.Name = "gridGram";
            this.gridGram.Visible = true;
            this.gridGram.VisibleIndex = 1;
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSil.ImageOptions.SvgImage")));
            this.btnSil.Location = new System.Drawing.Point(12, 481);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(109, 36);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(985, 481);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(119, 36);
            this.btnKaydet.TabIndex = 19;
            this.btnKaydet.Text = "Kaydet";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(299, 32);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lblAdSoyad.TabIndex = 20;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(372, 29);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(132, 20);
            this.txtAdSoyad.TabIndex = 21;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(372, 70);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(132, 20);
            this.txtTelefon.TabIndex = 22;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(372, 104);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(132, 20);
            this.txtAciklama.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Açıklama";
            // 
            // lblGram
            // 
            this.lblGram.AutoSize = true;
            this.lblGram.Location = new System.Drawing.Point(558, 69);
            this.lblGram.Name = "lblGram";
            this.lblGram.Size = new System.Drawing.Size(32, 13);
            this.lblGram.TabIndex = 26;
            this.lblGram.Text = "Gram";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(630, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 27;
            // 
            // frmSatisFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 521);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblGram);
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
            this.Controls.Add(this.txtIskonto);
            this.Controls.Add(this.txtSatisGramFiyat);
            this.Controls.Add(this.dtSatisTarihi);
            this.Controls.Add(this.lueBarkodNo);
            this.Controls.Add(this.lueMusteriAd);
            this.Controls.Add(this.lblIskonto);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblStokKod);
            this.Controls.Add(this.lblGramFiyat);
            this.Controls.Add(this.lblSatisTarih);
            this.Controls.Add(this.lblCari);
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

        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.Label lblSatisTarih;
        private System.Windows.Forms.Label lblStokKod;
        private System.Windows.Forms.Label lblGramFiyat;
        private System.Windows.Forms.Label lblIskonto;
        private System.Windows.Forms.Label lblTutar;
        private DevExpress.XtraEditors.LookUpEdit lueMusteriAd;
        private DevExpress.XtraEditors.LookUpEdit lueBarkodNo;
        private DevExpress.XtraEditors.DateEdit dtSatisTarihi;
        private DevExpress.XtraEditors.TextEdit txtSatisGramFiyat;
        private DevExpress.XtraEditors.TextEdit txtIskonto;
        private DevExpress.XtraEditors.TextEdit txtSatisTutar;
        private System.Windows.Forms.Label lblFaturaNo;
        private System.Windows.Forms.TextBox txtSatisFaturaNo;
        private DevExpress.XtraGrid.GridControl gridControlSatisFatura;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSatisFaturasi;
        private DevExpress.XtraGrid.Columns.GridColumn gridStokKod;
        private DevExpress.XtraGrid.Columns.GridColumn gridGramFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn gridIskonto;
        private DevExpress.XtraGrid.Columns.GridColumn gridTutar;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGram;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraGrid.Columns.GridColumn gridGram;
    }
}