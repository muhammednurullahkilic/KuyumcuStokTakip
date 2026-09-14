namespace KuyumcuStokTakip.Rapor
{
    partial class frmSatisIstatistikler
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel2 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView2 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chartSatilanUrunTablosu = new DevExpress.XtraCharts.ChartControl();
            this.urunGrubu1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kuyumcuStokTakipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kuyumcuStokTakip = new KuyumcuStokTakip.Database.KuyumcuStokTakip();
            this.chartToptanciSatisMiktari = new DevExpress.XtraCharts.ChartControl();
            this.urunGrubu1TableAdapter = new KuyumcuStokTakip.Database.KuyumcuStokTakipTableAdapters.UrunGrubu1TableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.chartSatilanUrunTablosu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunGrubu1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuyumcuStokTakipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuyumcuStokTakip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartToptanciSatisMiktari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartSatilanUrunTablosu
            // 
            this.chartSatilanUrunTablosu.DataSource = this.urunGrubu1BindingSource;
            this.chartSatilanUrunTablosu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartSatilanUrunTablosu.Location = new System.Drawing.Point(4, 4);
            this.chartSatilanUrunTablosu.Margin = new System.Windows.Forms.Padding(4);
            this.chartSatilanUrunTablosu.Name = "chartSatilanUrunTablosu";
            pieSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default;
            pieSeriesLabel1.TextPattern = "{A}: {VP:P2}";
            series1.Label = pieSeriesLabel1;
            series1.Name = "Series 1";
            series1.SeriesID = 0;
            series1.View = pieSeriesView1;
            this.chartSatilanUrunTablosu.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartSatilanUrunTablosu.Size = new System.Drawing.Size(745, 798);
            this.chartSatilanUrunTablosu.TabIndex = 0;
            chartTitle1.Text = "Satılan Ürün Tablosu";
            chartTitle1.TitleID = 0;
            this.chartSatilanUrunTablosu.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // urunGrubu1BindingSource
            // 
            this.urunGrubu1BindingSource.DataMember = "UrunGrubu1";
            this.urunGrubu1BindingSource.DataSource = this.kuyumcuStokTakipBindingSource;
            // 
            // kuyumcuStokTakipBindingSource
            // 
            this.kuyumcuStokTakipBindingSource.DataSource = this.kuyumcuStokTakip;
            this.kuyumcuStokTakipBindingSource.Position = 0;
            // 
            // kuyumcuStokTakip
            // 
            this.kuyumcuStokTakip.DataSetName = "KuyumcuStokTakip";
            this.kuyumcuStokTakip.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chartToptanciSatisMiktari
            // 
            this.chartToptanciSatisMiktari.DataSource = this.kuyumcuStokTakip.Cari;
            this.chartToptanciSatisMiktari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartToptanciSatisMiktari.Location = new System.Drawing.Point(757, 4);
            this.chartToptanciSatisMiktari.Margin = new System.Windows.Forms.Padding(4);
            this.chartToptanciSatisMiktari.Name = "chartToptanciSatisMiktari";
            pieSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default;
            pieSeriesLabel2.TextPattern = "{A}: {VP:P2}";
            series2.Label = pieSeriesLabel2;
            series2.Name = "Series 1";
            series2.SeriesID = 0;
            series2.View = pieSeriesView2;
            this.chartToptanciSatisMiktari.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartToptanciSatisMiktari.Size = new System.Drawing.Size(746, 798);
            this.chartToptanciSatisMiktari.TabIndex = 1;
            chartTitle2.Text = "Toptancı Satış Miktarı";
            chartTitle2.TitleID = 0;
            this.chartToptanciSatisMiktari.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            // 
            // urunGrubu1TableAdapter
            // 
            this.urunGrubu1TableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartSatilanUrunTablosu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartToptanciSatisMiktari, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1507, 806);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // frmSatisIstatistikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 806);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSatisIstatistikler";
            this.Text = "Satış İstatistikleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSatisIstatistikler_Load);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSatilanUrunTablosu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunGrubu1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuyumcuStokTakipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuyumcuStokTakip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartToptanciSatisMiktari)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartSatilanUrunTablosu;
        private DevExpress.XtraCharts.ChartControl chartToptanciSatisMiktari;
        private System.Windows.Forms.BindingSource kuyumcuStokTakipBindingSource;
        private Database.KuyumcuStokTakip kuyumcuStokTakip;
        private System.Windows.Forms.BindingSource urunGrubu1BindingSource;
        private Database.KuyumcuStokTakipTableAdapters.UrunGrubu1TableAdapter urunGrubu1TableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}