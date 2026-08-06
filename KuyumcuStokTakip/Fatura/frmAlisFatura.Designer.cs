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
            this.lblStokKod = new System.Windows.Forms.Label();
            this.lblGramFiyat = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lueCari = new DevExpress.XtraEditors.LookUpEdit();
            this.lueBarkodNo = new DevExpress.XtraEditors.LookUpEdit();
            this.dtAlisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtAlisGramFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtAlisTutar = new DevExpress.XtraEditors.TextEdit();
            this.txtAlisFaturaNo = new System.Windows.Forms.TextBox();
            this.lblFaturaNo = new System.Windows.Forms.Label();
            this.gridControlAlisFatura = new DevExpress.XtraGrid.GridControl();
            this.gridAlisFaturasi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridStokKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridGramFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lblAciklama = new DevExpress.XtraEditors.LabelControl();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblGram = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gridGram = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lueCari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBarkodNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisGramFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAlisFatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlisFaturasi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Location = new System.Drawing.Point(28, 61);
            this.lblCari.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(32, 13);
            this.lblCari.TabIndex = 0;
            this.lblCari.Text = "*Cari:";
            // 
            // lblAlisTarih
            // 
            this.lblAlisTarih.AutoSize = true;
            this.lblAlisTarih.Location = new System.Drawing.Point(28, 93);
            this.lblAlisTarih.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlisTarih.Name = "lblAlisTarih";
            this.lblAlisTarih.Size = new System.Drawing.Size(38, 13);
            this.lblAlisTarih.TabIndex = 1;
            this.lblAlisTarih.Text = "*Tarih:";
            // 
            // lblStokKod
            // 
            this.lblStokKod.AutoSize = true;
            this.lblStokKod.Location = new System.Drawing.Point(540, 27);
            this.lblStokKod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStokKod.Name = "lblStokKod";
            this.lblStokKod.Size = new System.Drawing.Size(58, 13);
            this.lblStokKod.TabIndex = 3;
            this.lblStokKod.Text = "*Stok Kod:";
            // 
            // lblGramFiyat
            // 
            this.lblGramFiyat.AutoSize = true;
            this.lblGramFiyat.Location = new System.Drawing.Point(540, 96);
            this.lblGramFiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGramFiyat.Name = "lblGramFiyat";
            this.lblGramFiyat.Size = new System.Drawing.Size(64, 13);
            this.lblGramFiyat.TabIndex = 2;
            this.lblGramFiyat.Text = "*Gram Fiyat:";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(785, 26);
            this.lblTutar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(39, 13);
            this.lblTutar.TabIndex = 4;
            this.lblTutar.Text = "*Tutar:";
            // 
            // lueCari
            // 
            this.lueCari.Location = new System.Drawing.Point(118, 58);
            this.lueCari.Margin = new System.Windows.Forms.Padding(2);
            this.lueCari.Name = "lueCari";
            this.lueCari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCari.Properties.NullText = "Lütfen Seçiniz";
            this.lueCari.Size = new System.Drawing.Size(140, 20);
            this.lueCari.TabIndex = 7;
            // 
            // lueBarkodNo
            // 
            this.lueBarkodNo.Location = new System.Drawing.Point(621, 24);
            this.lueBarkodNo.Margin = new System.Windows.Forms.Padding(2);
            this.lueBarkodNo.Name = "lueBarkodNo";
            this.lueBarkodNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBarkodNo.Properties.NullText = "";
            this.lueBarkodNo.Size = new System.Drawing.Size(140, 20);
            this.lueBarkodNo.TabIndex = 8;
            // 
            // dtAlisTarihi
            // 
            this.dtAlisTarihi.EditValue = null;
            this.dtAlisTarihi.Location = new System.Drawing.Point(118, 90);
            this.dtAlisTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtAlisTarihi.Name = "dtAlisTarihi";
            this.dtAlisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtAlisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtAlisTarihi.Size = new System.Drawing.Size(140, 20);
            this.dtAlisTarihi.TabIndex = 9;
            // 
            // txtAlisGramFiyat
            // 
            this.txtAlisGramFiyat.Location = new System.Drawing.Point(621, 93);
            this.txtAlisGramFiyat.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlisGramFiyat.Name = "txtAlisGramFiyat";
            this.txtAlisGramFiyat.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtAlisGramFiyat.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtAlisGramFiyat.Size = new System.Drawing.Size(140, 20);
            this.txtAlisGramFiyat.TabIndex = 10;
            // 
            // txtAlisTutar
            // 
            this.txtAlisTutar.Location = new System.Drawing.Point(850, 23);
            this.txtAlisTutar.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlisTutar.Name = "txtAlisTutar";
            this.txtAlisTutar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtAlisTutar.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtAlisTutar.Size = new System.Drawing.Size(140, 20);
            this.txtAlisTutar.TabIndex = 12;
            // 
            // txtAlisFaturaNo
            // 
            this.txtAlisFaturaNo.Location = new System.Drawing.Point(118, 24);
            this.txtAlisFaturaNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlisFaturaNo.Name = "txtAlisFaturaNo";
            this.txtAlisFaturaNo.Size = new System.Drawing.Size(141, 20);
            this.txtAlisFaturaNo.TabIndex = 15;
            // 
            // lblFaturaNo
            // 
            this.lblFaturaNo.AutoSize = true;
            this.lblFaturaNo.Location = new System.Drawing.Point(28, 27);
            this.lblFaturaNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFaturaNo.Name = "lblFaturaNo";
            this.lblFaturaNo.Size = new System.Drawing.Size(61, 13);
            this.lblFaturaNo.TabIndex = 16;
            this.lblFaturaNo.Text = "*Fatura No:";
            // 
            // gridControlAlisFatura
            // 
            this.gridControlAlisFatura.Location = new System.Drawing.Point(-2, 150);
            this.gridControlAlisFatura.MainView = this.gridAlisFaturasi;
            this.gridControlAlisFatura.Name = "gridControlAlisFatura";
            this.gridControlAlisFatura.Size = new System.Drawing.Size(1002, 318);
            this.gridControlAlisFatura.TabIndex = 17;
            this.gridControlAlisFatura.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridAlisFaturasi});
            // 
            // gridAlisFaturasi
            // 
            this.gridAlisFaturasi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridStokKod,
            this.gridGramFiyat,
            this.gridTutar,
            this.gridSira,
            this.gridGram});
            this.gridAlisFaturasi.GridControl = this.gridControlAlisFatura;
            this.gridAlisFaturasi.GroupPanelText = "Alış Faturası Sepet Listesi";
            this.gridAlisFaturasi.Name = "gridAlisFaturasi";
            // 
            // gridStokKod
            // 
            this.gridStokKod.Caption = "Stok Kod";
            this.gridStokKod.FieldName = "StokKod";
            this.gridStokKod.Name = "gridStokKod";
            this.gridStokKod.Visible = true;
            this.gridStokKod.VisibleIndex = 1;
            // 
            // gridGramFiyat
            // 
            this.gridGramFiyat.Caption = "Gram Fiyat";
            this.gridGramFiyat.Name = "gridGramFiyat";
            this.gridGramFiyat.Visible = true;
            this.gridGramFiyat.VisibleIndex = 3;
            // 
            // gridTutar
            // 
            this.gridTutar.Caption = "Tutar";
            this.gridTutar.Name = "gridTutar";
            this.gridTutar.Visible = true;
            this.gridTutar.VisibleIndex = 4;
            // 
            // gridSira
            // 
            this.gridSira.Caption = "Sıra";
            this.gridSira.Name = "gridSira";
            this.gridSira.Visible = true;
            this.gridSira.VisibleIndex = 0;
            this.gridSira.Width = 56;
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSil.ImageOptions.SvgImage")));
            this.btnSil.Location = new System.Drawing.Point(3, 474);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(89, 26);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(900, 474);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(89, 26);
            this.btnKaydet.TabIndex = 20;
            this.btnKaydet.Text = "Kaydet";
            // 
            // lblAciklama
            // 
            this.lblAciklama.Location = new System.Drawing.Point(293, 96);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(45, 13);
            this.lblAciklama.TabIndex = 21;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(361, 93);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(140, 20);
            this.txtAciklama.TabIndex = 22;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(290, 29);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lblAdSoyad.TabIndex = 23;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(361, 26);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(140, 20);
            this.txtAdSoyad.TabIndex = 24;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(290, 61);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblTelefon.TabIndex = 25;
            this.lblTelefon.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(362, 58);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(139, 20);
            this.txtTelefon.TabIndex = 26;
            // 
            // lblGram
            // 
            this.lblGram.AutoSize = true;
            this.lblGram.Location = new System.Drawing.Point(540, 64);
            this.lblGram.Name = "lblGram";
            this.lblGram.Size = new System.Drawing.Size(36, 13);
            this.lblGram.TabIndex = 27;
            this.lblGram.Text = "*Gram";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(621, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 28;
            // 
            // gridGram
            // 
            this.gridGram.Caption = "Gram";
            this.gridGram.FieldName = "Gram";
            this.gridGram.Name = "gridGram";
            this.gridGram.Visible = true;
            this.gridGram.VisibleIndex = 2;
            // 
            // frmAlisFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 507);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblGram);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.gridControlAlisFatura);
            this.Controls.Add(this.lblFaturaNo);
            this.Controls.Add(this.txtAlisFaturaNo);
            this.Controls.Add(this.txtAlisTutar);
            this.Controls.Add(this.txtAlisGramFiyat);
            this.Controls.Add(this.dtAlisTarihi);
            this.Controls.Add(this.lueBarkodNo);
            this.Controls.Add(this.lueCari);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblStokKod);
            this.Controls.Add(this.lblGramFiyat);
            this.Controls.Add(this.lblAlisTarih);
            this.Controls.Add(this.lblCari);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAlisFatura";
            this.Text = "Alış Fatura";
            ((System.ComponentModel.ISupportInitialize)(this.lueCari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBarkodNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisGramFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAlisFatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlisFaturasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.Label lblAlisTarih;
        private System.Windows.Forms.Label lblStokKod;
        private System.Windows.Forms.Label lblGramFiyat;
        private System.Windows.Forms.Label lblTutar;
        private DevExpress.XtraEditors.LookUpEdit lueCari;
        private DevExpress.XtraEditors.LookUpEdit lueBarkodNo;
        private DevExpress.XtraEditors.DateEdit dtAlisTarihi;
        private DevExpress.XtraEditors.TextEdit txtAlisGramFiyat;
        private DevExpress.XtraEditors.TextEdit txtAlisTutar;
        private System.Windows.Forms.TextBox txtAlisFaturaNo;
        private System.Windows.Forms.Label lblFaturaNo;
        private DevExpress.XtraGrid.GridControl gridControlAlisFatura;
        private DevExpress.XtraGrid.Views.Grid.GridView gridAlisFaturasi;
        private DevExpress.XtraGrid.Columns.GridColumn gridStokKod;
        private DevExpress.XtraGrid.Columns.GridColumn gridGramFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn gridTutar;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn gridSira;
        private System.Windows.Forms.Label lblGram;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraGrid.Columns.GridColumn gridGram;
    }
}