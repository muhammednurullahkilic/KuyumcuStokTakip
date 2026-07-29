namespace KuyumcuStokTakip.Rapor
{
    partial class frmIslemGecmisiListele
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlSatisFaturaListesi = new DevExpress.XtraGrid.GridControl();
            this.gridSatisFaturaListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridSatisFaturaNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSatisMusteriAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSatisSatisBarkodNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSatisGramFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSatisIskonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSatisTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSatisOlusturanPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSatisOlusturulmaTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSatisGüncelleyenPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSatisGuncellemeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlAlisFaturaListesi = new DevExpress.XtraGrid.GridControl();
            this.gridAlisFaturaListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridAlisFaturaNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAlisMusteriAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAlisBarkodNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAlisGramFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAlisTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAlisOlusturanPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAlisOlusturmaTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAlisGuncelleyenPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAlisGüncellemeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSatisFaturaListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSatisFaturaListesi)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAlisFaturaListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlisFaturaListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(8, 5);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1202, 446);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControlSatisFaturaListesi);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1200, 421);
            this.xtraTabPage1.Text = "Satış Fatura Liste";
            // 
            // gridControlSatisFaturaListesi
            // 
            this.gridControlSatisFaturaListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSatisFaturaListesi.Location = new System.Drawing.Point(0, 0);
            this.gridControlSatisFaturaListesi.MainView = this.gridSatisFaturaListesi;
            this.gridControlSatisFaturaListesi.Name = "gridControlSatisFaturaListesi";
            this.gridControlSatisFaturaListesi.Size = new System.Drawing.Size(1200, 421);
            this.gridControlSatisFaturaListesi.TabIndex = 0;
            this.gridControlSatisFaturaListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSatisFaturaListesi});
            // 
            // gridSatisFaturaListesi
            // 
            this.gridSatisFaturaListesi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridSatisFaturaNo,
            this.gridSatisMusteriAd,
            this.gridSatisSatisBarkodNo,
            this.gridSatisGramFiyat,
            this.gridSatisIskonto,
            this.gridSatisTutar,
            this.gridSatisOlusturanPersonel,
            this.gridSatisOlusturulmaTarihi,
            this.gridSatisGüncelleyenPersonel,
            this.gridSatisGuncellemeTarihi});
            this.gridSatisFaturaListesi.GridControl = this.gridControlSatisFaturaListesi;
            this.gridSatisFaturaListesi.GroupPanelText = "Satış Listesi";
            this.gridSatisFaturaListesi.Name = "gridSatisFaturaListesi";
            // 
            // gridSatisFaturaNo
            // 
            this.gridSatisFaturaNo.Caption = "Fatura No";
            this.gridSatisFaturaNo.Name = "gridSatisFaturaNo";
            this.gridSatisFaturaNo.Visible = true;
            this.gridSatisFaturaNo.VisibleIndex = 0;
            // 
            // gridSatisMusteriAd
            // 
            this.gridSatisMusteriAd.Caption = "Müşteri Ad";
            this.gridSatisMusteriAd.Name = "gridSatisMusteriAd";
            this.gridSatisMusteriAd.Visible = true;
            this.gridSatisMusteriAd.VisibleIndex = 1;
            // 
            // gridSatisSatisBarkodNo
            // 
            this.gridSatisSatisBarkodNo.Caption = "Barkod No";
            this.gridSatisSatisBarkodNo.Name = "gridSatisSatisBarkodNo";
            this.gridSatisSatisBarkodNo.Visible = true;
            this.gridSatisSatisBarkodNo.VisibleIndex = 2;
            // 
            // gridSatisGramFiyat
            // 
            this.gridSatisGramFiyat.Caption = "Gram Fiyat";
            this.gridSatisGramFiyat.Name = "gridSatisGramFiyat";
            this.gridSatisGramFiyat.Visible = true;
            this.gridSatisGramFiyat.VisibleIndex = 3;
            // 
            // gridSatisIskonto
            // 
            this.gridSatisIskonto.Caption = "İskonto";
            this.gridSatisIskonto.Name = "gridSatisIskonto";
            this.gridSatisIskonto.Visible = true;
            this.gridSatisIskonto.VisibleIndex = 4;
            // 
            // gridSatisTutar
            // 
            this.gridSatisTutar.Caption = "Tutar";
            this.gridSatisTutar.Name = "gridSatisTutar";
            this.gridSatisTutar.Visible = true;
            this.gridSatisTutar.VisibleIndex = 5;
            // 
            // gridSatisOlusturanPersonel
            // 
            this.gridSatisOlusturanPersonel.Caption = "Oluşturan Personel";
            this.gridSatisOlusturanPersonel.Name = "gridSatisOlusturanPersonel";
            this.gridSatisOlusturanPersonel.Visible = true;
            this.gridSatisOlusturanPersonel.VisibleIndex = 6;
            // 
            // gridSatisOlusturulmaTarihi
            // 
            this.gridSatisOlusturulmaTarihi.Caption = "Oluşturulma Tarihi";
            this.gridSatisOlusturulmaTarihi.Name = "gridSatisOlusturulmaTarihi";
            this.gridSatisOlusturulmaTarihi.Visible = true;
            this.gridSatisOlusturulmaTarihi.VisibleIndex = 7;
            // 
            // gridSatisGüncelleyenPersonel
            // 
            this.gridSatisGüncelleyenPersonel.Caption = "Güncelleyen Personel";
            this.gridSatisGüncelleyenPersonel.Name = "gridSatisGüncelleyenPersonel";
            this.gridSatisGüncelleyenPersonel.Visible = true;
            this.gridSatisGüncelleyenPersonel.VisibleIndex = 8;
            // 
            // gridSatisGuncellemeTarihi
            // 
            this.gridSatisGuncellemeTarihi.Caption = "Güncellenme Tarihi";
            this.gridSatisGuncellemeTarihi.Name = "gridSatisGuncellemeTarihi";
            this.gridSatisGuncellemeTarihi.Visible = true;
            this.gridSatisGuncellemeTarihi.VisibleIndex = 9;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControlAlisFaturaListesi);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1200, 421);
            this.xtraTabPage2.Text = "Alış Fatura Listesi";
            // 
            // gridControlAlisFaturaListesi
            // 
            this.gridControlAlisFaturaListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAlisFaturaListesi.Location = new System.Drawing.Point(0, 0);
            this.gridControlAlisFaturaListesi.MainView = this.gridAlisFaturaListesi;
            this.gridControlAlisFaturaListesi.Name = "gridControlAlisFaturaListesi";
            this.gridControlAlisFaturaListesi.Size = new System.Drawing.Size(1200, 421);
            this.gridControlAlisFaturaListesi.TabIndex = 0;
            this.gridControlAlisFaturaListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridAlisFaturaListesi});
            // 
            // gridAlisFaturaListesi
            // 
            this.gridAlisFaturaListesi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridAlisFaturaNo,
            this.gridAlisMusteriAd,
            this.gridAlisBarkodNo,
            this.gridAlisGramFiyat,
            this.gridAlisTutar,
            this.gridAlisOlusturanPersonel,
            this.gridAlisOlusturmaTarihi,
            this.gridAlisGuncelleyenPersonel,
            this.gridAlisGüncellemeTarihi});
            this.gridAlisFaturaListesi.GridControl = this.gridControlAlisFaturaListesi;
            this.gridAlisFaturaListesi.GroupPanelText = "Alış Listesi";
            this.gridAlisFaturaListesi.Name = "gridAlisFaturaListesi";
            // 
            // gridAlisFaturaNo
            // 
            this.gridAlisFaturaNo.Caption = "Fatura No";
            this.gridAlisFaturaNo.Name = "gridAlisFaturaNo";
            this.gridAlisFaturaNo.Visible = true;
            this.gridAlisFaturaNo.VisibleIndex = 0;
            // 
            // gridAlisMusteriAd
            // 
            this.gridAlisMusteriAd.Caption = "Müşteri Ad";
            this.gridAlisMusteriAd.Name = "gridAlisMusteriAd";
            this.gridAlisMusteriAd.Visible = true;
            this.gridAlisMusteriAd.VisibleIndex = 1;
            // 
            // gridAlisBarkodNo
            // 
            this.gridAlisBarkodNo.Caption = "Barkod No";
            this.gridAlisBarkodNo.Name = "gridAlisBarkodNo";
            this.gridAlisBarkodNo.Visible = true;
            this.gridAlisBarkodNo.VisibleIndex = 2;
            // 
            // gridAlisGramFiyat
            // 
            this.gridAlisGramFiyat.Caption = "Gram Fiyat";
            this.gridAlisGramFiyat.Name = "gridAlisGramFiyat";
            this.gridAlisGramFiyat.Visible = true;
            this.gridAlisGramFiyat.VisibleIndex = 3;
            // 
            // gridAlisTutar
            // 
            this.gridAlisTutar.Caption = "Tutar";
            this.gridAlisTutar.Name = "gridAlisTutar";
            this.gridAlisTutar.Visible = true;
            this.gridAlisTutar.VisibleIndex = 4;
            // 
            // gridAlisOlusturanPersonel
            // 
            this.gridAlisOlusturanPersonel.Caption = "Oluşturan Personel";
            this.gridAlisOlusturanPersonel.Name = "gridAlisOlusturanPersonel";
            this.gridAlisOlusturanPersonel.Visible = true;
            this.gridAlisOlusturanPersonel.VisibleIndex = 5;
            // 
            // gridAlisOlusturmaTarihi
            // 
            this.gridAlisOlusturmaTarihi.Caption = "Oluşturma Tarihi";
            this.gridAlisOlusturmaTarihi.Name = "gridAlisOlusturmaTarihi";
            this.gridAlisOlusturmaTarihi.Visible = true;
            this.gridAlisOlusturmaTarihi.VisibleIndex = 6;
            // 
            // gridAlisGuncelleyenPersonel
            // 
            this.gridAlisGuncelleyenPersonel.Caption = "Güncelleyen Personel";
            this.gridAlisGuncelleyenPersonel.Name = "gridAlisGuncelleyenPersonel";
            this.gridAlisGuncelleyenPersonel.Visible = true;
            this.gridAlisGuncelleyenPersonel.VisibleIndex = 7;
            // 
            // gridAlisGüncellemeTarihi
            // 
            this.gridAlisGüncellemeTarihi.Caption = "Güncelleme Tarihi";
            this.gridAlisGüncellemeTarihi.Name = "gridAlisGüncellemeTarihi";
            this.gridAlisGüncellemeTarihi.Visible = true;
            this.gridAlisGüncellemeTarihi.VisibleIndex = 8;
            // 
            // frmIslemGecmisiListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 453);
            this.Controls.Add(this.xtraTabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmIslemGecmisiListele";
            this.Text = "İşlem Geçmişi Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSatisFaturaListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSatisFaturaListesi)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAlisFaturaListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlisFaturaListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gridControlSatisFaturaListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSatisFaturaListesi;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControlAlisFaturaListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridAlisFaturaListesi;
        private DevExpress.XtraGrid.Columns.GridColumn gridSatisFaturaNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridSatisMusteriAd;
        private DevExpress.XtraGrid.Columns.GridColumn gridSatisSatisBarkodNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridSatisGramFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn gridSatisIskonto;
        private DevExpress.XtraGrid.Columns.GridColumn gridSatisTutar;
        private DevExpress.XtraGrid.Columns.GridColumn gridSatisOlusturanPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn gridSatisOlusturulmaTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn gridSatisGüncelleyenPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn gridSatisGuncellemeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn gridAlisFaturaNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridAlisMusteriAd;
        private DevExpress.XtraGrid.Columns.GridColumn gridAlisBarkodNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridAlisGramFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn gridAlisTutar;
        private DevExpress.XtraGrid.Columns.GridColumn gridAlisOlusturanPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn gridAlisOlusturmaTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn gridAlisGuncelleyenPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn gridAlisGüncellemeTarihi;
    }
}