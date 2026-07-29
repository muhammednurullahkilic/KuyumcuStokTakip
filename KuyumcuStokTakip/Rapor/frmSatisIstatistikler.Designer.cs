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
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel3 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView3 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle3 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel4 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView4 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle4 = new DevExpress.XtraCharts.ChartTitle();
            this.chartSatilanUrunTablosu = new DevExpress.XtraCharts.ChartControl();
            this.chartToptanciSatisMiktari = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartSatilanUrunTablosu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartToptanciSatisMiktari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView4)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSatilanUrunTablosu
            // 
            this.chartSatilanUrunTablosu.Dock = System.Windows.Forms.DockStyle.Left;
            this.chartSatilanUrunTablosu.Location = new System.Drawing.Point(0, 0);
            this.chartSatilanUrunTablosu.Name = "chartSatilanUrunTablosu";
            pieSeriesLabel3.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default;
            pieSeriesLabel3.TextPattern = "{A}: {VP:P2}";
            series3.Label = pieSeriesLabel3;
            series3.Name = "Series 1";
            series3.SeriesID = 0;
            series3.View = pieSeriesView3;
            this.chartSatilanUrunTablosu.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.chartSatilanUrunTablosu.Size = new System.Drawing.Size(558, 655);
            this.chartSatilanUrunTablosu.TabIndex = 0;
            chartTitle3.Text = "Satılan Ürün Tablosu";
            chartTitle3.TitleID = 0;
            this.chartSatilanUrunTablosu.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle3});
            // 
            // chartToptanciSatisMiktari
            // 
            this.chartToptanciSatisMiktari.Dock = System.Windows.Forms.DockStyle.Right;
            this.chartToptanciSatisMiktari.Location = new System.Drawing.Point(557, 0);
            this.chartToptanciSatisMiktari.Name = "chartToptanciSatisMiktari";
            pieSeriesLabel4.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default;
            pieSeriesLabel4.TextPattern = "{A}: {VP:P2}";
            series4.Label = pieSeriesLabel4;
            series4.Name = "Series 1";
            series4.SeriesID = 0;
            series4.View = pieSeriesView4;
            this.chartToptanciSatisMiktari.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4};
            this.chartToptanciSatisMiktari.Size = new System.Drawing.Size(573, 655);
            this.chartToptanciSatisMiktari.TabIndex = 1;
            chartTitle4.Text = "Toptancı Satış Miktarı";
            chartTitle4.TitleID = 0;
            this.chartToptanciSatisMiktari.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle4});
            // 
            // frmSatisIstatistikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 655);
            this.Controls.Add(this.chartToptanciSatisMiktari);
            this.Controls.Add(this.chartSatilanUrunTablosu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSatisIstatistikler";
            this.Text = "Satış İstatistikleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSatilanUrunTablosu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartToptanciSatisMiktari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartSatilanUrunTablosu;
        private DevExpress.XtraCharts.ChartControl chartToptanciSatisMiktari;
    }
}