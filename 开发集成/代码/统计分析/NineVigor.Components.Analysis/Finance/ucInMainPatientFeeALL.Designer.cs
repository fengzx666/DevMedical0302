namespace NineVigor.Components.Analysis.Finance
{
    partial class ucInMainPatientFeeALL
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PiePointOptions piePointOptions1 = new DevExpress.XtraCharts.PiePointOptions();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint(11, new object[] {
            ((object)(10))}, 0);
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint(12, new object[] {
            ((object)(20))}, 1);
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint(13, new object[] {
            ((object)(5))}, 3);
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint(14, new object[] {
            ((object)(8))}, 4);
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint(15, new object[] {
            ((object)(10))}, 5);
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint(16, new object[] {
            ((object)(20))}, 6);
            DevExpress.XtraCharts.SeriesPoint seriesPoint7 = new DevExpress.XtraCharts.SeriesPoint(17, new object[] {
            ((object)(25))}, 7);
            DevExpress.XtraCharts.SeriesPoint seriesPoint8 = new DevExpress.XtraCharts.SeriesPoint(18, new object[] {
            ((object)(10))}, 8);
            DevExpress.XtraCharts.SeriesPoint seriesPoint9 = new DevExpress.XtraCharts.SeriesPoint(19, new object[] {
            ((object)(10))}, 9);
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle1 = new DevExpress.XtraCharts.SeriesTitle();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel2 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView2 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel3 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtBeginDate = new System.Windows.Forms.DateTimePicker();
            this.nineCBSmallDept = new NineVigor.FrameWork.WinForms.Controls.NineComboBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtEnd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtBeginDate);
            this.groupBox1.Controls.Add(this.nineCBSmallDept);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 67);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分析条件";
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "yyyy-MM-dd";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(411, 20);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(101, 21);
            this.dtEnd.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "至 ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "分析月份：";
            // 
            // dtBeginDate
            // 
            this.dtBeginDate.CustomFormat = "yyyy-MM-dd";
            this.dtBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBeginDate.Location = new System.Drawing.Point(275, 18);
            this.dtBeginDate.Name = "dtBeginDate";
            this.dtBeginDate.Size = new System.Drawing.Size(101, 21);
            this.dtBeginDate.TabIndex = 8;
            // 
            // nineCBSmallDept
            // 
            this.nineCBSmallDept.ArrowBackColor = System.Drawing.SystemColors.Control;
            this.nineCBSmallDept.DropDownHeight = 424;
            this.nineCBSmallDept.FormattingEnabled = true;
            this.nineCBSmallDept.IntegralHeight = false;
            this.nineCBSmallDept.IsEnter2Tab = false;
            this.nineCBSmallDept.IsFlat = false;
            this.nineCBSmallDept.IsLike = true;
            this.nineCBSmallDept.IsListOnly = false;
            this.nineCBSmallDept.IsPopForm = true;
            this.nineCBSmallDept.IsShowCustomerList = false;
            this.nineCBSmallDept.IsShowID = false;
            this.nineCBSmallDept.Location = new System.Drawing.Point(58, 20);
            this.nineCBSmallDept.Name = "nineCBSmallDept";
            this.nineCBSmallDept.PopForm = null;
            this.nineCBSmallDept.ShowCustomerList = false;
            this.nineCBSmallDept.ShowID = false;
            this.nineCBSmallDept.Size = new System.Drawing.Size(121, 20);
            this.nineCBSmallDept.Style = NineVigor.FrameWork.WinForms.Controls.StyleType.Flat;
            this.nineCBSmallDept.TabIndex = 6;
            this.nineCBSmallDept.Tag = "";
            this.nineCBSmallDept.ToolBarUse = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "部门：";
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chartControl1.Legend.EquallySpacedItems = false;
            this.chartControl1.Location = new System.Drawing.Point(0, 67);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            pieSeriesLabel1.LineVisible = true;
            series1.Label = pieSeriesLabel1;
            piePointOptions1.PercentOptions.ValueAsPercent = false;
            piePointOptions1.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues;
            series1.LegendPointOptions = piePointOptions1;
            series1.Name = "Series 1";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4,
            seriesPoint5,
            seriesPoint6,
            seriesPoint7,
            seriesPoint8,
            seriesPoint9});
            series1.SynchronizePointOptions = false;
            series1.TopNOptions.Mode = DevExpress.XtraCharts.TopNMode.ThresholdPercent;
            series1.TopNOptions.ShowOthers = false;
            pieSeriesView1.RuntimeExploding = false;
            seriesTitle1.Text = "报销费用比例";
            pieSeriesView1.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle1});
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            pieSeriesLabel2.LineVisible = true;
            this.chartControl1.SeriesTemplate.Label = pieSeriesLabel2;
            pieSeriesView2.RuntimeExploding = false;
            this.chartControl1.SeriesTemplate.View = pieSeriesView2;
            this.chartControl1.Size = new System.Drawing.Size(384, 452);
            this.chartControl1.TabIndex = 6;
            chartTitle1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            chartTitle1.Text = "住院证开立时间段分析";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chartControl1.ToolTipOptions.ShowForSeries = true;
            // 
            // chartControl2
            // 
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl2.Diagram = xyDiagram1;
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Location = new System.Drawing.Point(384, 67);
            this.chartControl2.Name = "chartControl2";
            sideBySideBarSeriesLabel1.LineVisible = true;
            series2.Label = sideBySideBarSeriesLabel1;
            series2.Name = "Series 1";
            sideBySideBarSeriesLabel2.LineVisible = true;
            series3.Label = sideBySideBarSeriesLabel2;
            series3.Name = "Series 2";
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2,
        series3};
            sideBySideBarSeriesLabel3.LineVisible = true;
            this.chartControl2.SeriesTemplate.Label = sideBySideBarSeriesLabel3;
            this.chartControl2.Size = new System.Drawing.Size(388, 452);
            this.chartControl2.TabIndex = 8;
            // 
            // ucInMainPatientFeeALL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartControl2);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucInMainPatientFeeALL";
            this.Size = new System.Drawing.Size(772, 519);
            this.Load += new System.EventHandler(this.InitLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtBeginDate;
        private NineVigor.FrameWork.WinForms.Controls.NineComboBox nineCBSmallDept;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private DevExpress.XtraCharts.ChartControl chartControl2;
    }
}
