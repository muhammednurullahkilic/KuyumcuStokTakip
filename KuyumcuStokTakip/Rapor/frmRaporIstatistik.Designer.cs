namespace KuyumcuStokTakip.Rapor
{
    partial class frmRaporIstatistik
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("Gelir", new object[] {
            ((object)(100000D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("Gider", new object[] {
            ((object)(85000D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint("Borç", new object[] {
            ((object)(50000D))});
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chartControlKasaDurumOzet = new DevExpress.XtraCharts.ChartControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridGüncelKasa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridStok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlKasaDurumOzet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGüncelKasa)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControlKasaDurumOzet
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControlKasaDurumOzet.Diagram = xyDiagram1;
            this.chartControlKasaDurumOzet.Dock = System.Windows.Forms.DockStyle.Left;
            this.chartControlKasaDurumOzet.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControlKasaDurumOzet.Location = new System.Drawing.Point(0, 0);
            this.chartControlKasaDurumOzet.Margin = new System.Windows.Forms.Padding(2);
            this.chartControlKasaDurumOzet.Name = "chartControlKasaDurumOzet";
            sideBySideBarSeriesLabel1.TextPattern = "{V:n0} ₺";
            series1.Label = sideBySideBarSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "kasaOzeti";
            seriesPoint1.ColorSerializable = "#00B050";
            seriesPoint2.ColorSerializable = "#F00000";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3});
            series1.SeriesID = 3;
            sideBySideBarSeriesView1.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            series1.View = sideBySideBarSeriesView1;
            this.chartControlKasaDurumOzet.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControlKasaDurumOzet.Size = new System.Drawing.Size(267, 450);
            this.chartControlKasaDurumOzet.TabIndex = 16;
            chartTitle1.Text = "Kasa Durum Özet";
            chartTitle1.TitleID = 0;
            this.chartControlKasaDurumOzet.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(267, 0);
            this.gridControl1.MainView = this.gridGüncelKasa;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(533, 450);
            this.gridControl1.TabIndex = 17;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridGüncelKasa});
            // 
            // gridGüncelKasa
            // 
            this.gridGüncelKasa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridStok,
            this.gridMiktar});
            this.gridGüncelKasa.GridControl = this.gridControl1;
            this.gridGüncelKasa.GroupPanelText = "Güncel Kasa Bakiye";
            this.gridGüncelKasa.Name = "gridGüncelKasa";
            // 
            // gridStok
            // 
            this.gridStok.Caption = "Stok";
            this.gridStok.Name = "gridStok";
            this.gridStok.Visible = true;
            this.gridStok.VisibleIndex = 0;
            // 
            // gridMiktar
            // 
            this.gridMiktar.Caption = "Miktar";
            this.gridMiktar.Name = "gridMiktar";
            this.gridMiktar.Visible = true;
            this.gridMiktar.VisibleIndex = 1;
            // 
            // frmRaporIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.chartControlKasaDurumOzet);
            this.Name = "frmRaporIstatistik";
            this.Text = "Rapor İstatistik";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlKasaDurumOzet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGüncelKasa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControlKasaDurumOzet;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridGüncelKasa;
        private DevExpress.XtraGrid.Columns.GridColumn gridStok;
        private DevExpress.XtraGrid.Columns.GridColumn gridMiktar;
    }
}