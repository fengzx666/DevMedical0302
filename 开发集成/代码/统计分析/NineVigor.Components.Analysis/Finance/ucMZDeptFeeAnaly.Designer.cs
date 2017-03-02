namespace NineVigor.Components.Analysis.Finance
{
    partial class ucMZDeptFeeAnaly
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel3 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbExeDept = new System.Windows.Forms.RadioButton();
            this.rbRecepDept = new System.Windows.Forms.RadioButton();
            this.nvTextEdit2 = new NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbBeforeCheck = new System.Windows.Forms.RadioButton();
            this.rbCurCheck = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.nvTextEdit1 = new NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.dtBeginDate = new System.Windows.Forms.DateTimePicker();
            this.nineCBSmallDept = new NineVigor.FrameWork.WinForms.Controls.NineComboBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.nineComboBox1 = new NineVigor.FrameWork.WinForms.Controls.NineComboBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvTextEdit2.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nineComboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.nvTextEdit2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nvTextEdit1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtBeginDate);
            this.groupBox1.Controls.Add(this.nineCBSmallDept);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 104);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分析条件";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbExeDept);
            this.groupBox3.Controls.Add(this.rbRecepDept);
            this.groupBox3.Location = new System.Drawing.Point(601, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 34);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // rbExeDept
            // 
            this.rbExeDept.AutoSize = true;
            this.rbExeDept.Location = new System.Drawing.Point(109, 14);
            this.rbExeDept.Name = "rbExeDept";
            this.rbExeDept.Size = new System.Drawing.Size(71, 16);
            this.rbExeDept.TabIndex = 1;
            this.rbExeDept.Text = "执行科室";
            this.rbExeDept.UseVisualStyleBackColor = true;
            // 
            // rbRecepDept
            // 
            this.rbRecepDept.AutoSize = true;
            this.rbRecepDept.Checked = true;
            this.rbRecepDept.Location = new System.Drawing.Point(7, 14);
            this.rbRecepDept.Name = "rbRecepDept";
            this.rbRecepDept.Size = new System.Drawing.Size(71, 16);
            this.rbRecepDept.TabIndex = 0;
            this.rbRecepDept.TabStop = true;
            this.rbRecepDept.Text = "开单科室";
            this.rbRecepDept.UseVisualStyleBackColor = true;
            // 
            // nvTextEdit2
            // 
            this.nvTextEdit2.Location = new System.Drawing.Point(597, 48);
            this.nvTextEdit2.Name = "nvTextEdit2";
            this.nvTextEdit2.Size = new System.Drawing.Size(100, 20);
            this.nvTextEdit2.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "往期对比分析月度数：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBeforeCheck);
            this.groupBox2.Controls.Add(this.rbCurCheck);
            this.groupBox2.Location = new System.Drawing.Point(376, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 34);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // rbBeforeCheck
            // 
            this.rbBeforeCheck.AutoSize = true;
            this.rbBeforeCheck.Location = new System.Drawing.Point(109, 14);
            this.rbBeforeCheck.Name = "rbBeforeCheck";
            this.rbBeforeCheck.Size = new System.Drawing.Size(71, 16);
            this.rbBeforeCheck.TabIndex = 1;
            this.rbBeforeCheck.Text = "往期分析";
            this.rbBeforeCheck.UseVisualStyleBackColor = true;
            // 
            // rbCurCheck
            // 
            this.rbCurCheck.AutoSize = true;
            this.rbCurCheck.Checked = true;
            this.rbCurCheck.Location = new System.Drawing.Point(7, 14);
            this.rbCurCheck.Name = "rbCurCheck";
            this.rbCurCheck.Size = new System.Drawing.Size(71, 16);
            this.rbCurCheck.TabIndex = 0;
            this.rbCurCheck.TabStop = true;
            this.rbCurCheck.Text = "同期分析";
            this.rbCurCheck.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "分析月份：";
            // 
            // nvTextEdit1
            // 
            this.nvTextEdit1.EditValue = "1";
            this.nvTextEdit1.Location = new System.Drawing.Point(352, 48);
            this.nvTextEdit1.Name = "nvTextEdit1";
            this.nvTextEdit1.Size = new System.Drawing.Size(100, 20);
            this.nvTextEdit1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "同期向前对比分析月份数：";
            // 
            // dtBeginDate
            // 
            this.dtBeginDate.CustomFormat = "yyyy-MM";
            this.dtBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBeginDate.Location = new System.Drawing.Point(79, 47);
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
            this.nineCBSmallDept.ShowAll = false;
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
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.EquallySpacedItems = false;
            this.chartControl1.Location = new System.Drawing.Point(0, 104);
            this.chartControl1.Name = "chartControl1";
            pointSeriesLabel1.LineVisible = true;
            series1.Label = pointSeriesLabel1;
            series1.Name = "Series 1";
            series1.View = lineSeriesView1;
            pointSeriesLabel2.LineVisible = true;
            series2.Label = pointSeriesLabel2;
            series2.Name = "Series 2";
            series2.View = lineSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            pointSeriesLabel3.LineVisible = true;
            this.chartControl1.SeriesTemplate.Label = pointSeriesLabel3;
            this.chartControl1.SeriesTemplate.View = lineSeriesView3;
            this.chartControl1.Size = new System.Drawing.Size(833, 404);
            this.chartControl1.TabIndex = 5;
            // 
            // nineComboBox1
            // 
            this.nineComboBox1.ArrowBackColor = System.Drawing.SystemColors.Control;
            this.nineComboBox1.DropDownHeight = 424;
            this.nineComboBox1.FormattingEnabled = true;
            this.nineComboBox1.IntegralHeight = false;
            this.nineComboBox1.IsEnter2Tab = false;
            this.nineComboBox1.IsFlat = false;
            this.nineComboBox1.IsLike = true;
            this.nineComboBox1.IsListOnly = false;
            this.nineComboBox1.IsPopForm = true;
            this.nineComboBox1.IsShowCustomerList = false;
            this.nineComboBox1.IsShowID = false;
            this.nineComboBox1.Location = new System.Drawing.Point(249, 18);
            this.nineComboBox1.Name = "nineComboBox1";
            this.nineComboBox1.PopForm = null;
            this.nineComboBox1.ShowAll = false;
            this.nineComboBox1.ShowCustomerList = false;
            this.nineComboBox1.ShowID = false;
            this.nineComboBox1.Size = new System.Drawing.Size(121, 20);
            this.nineComboBox1.Style = NineVigor.FrameWork.WinForms.Controls.StyleType.Flat;
            this.nineComboBox1.TabIndex = 23;
            this.nineComboBox1.Tag = "";
            this.nineComboBox1.ToolBarUse = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "部门：";
            // 
            // ucMZDeptFeeAnaly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucMZDeptFeeAnaly";
            this.Size = new System.Drawing.Size(833, 508);
            this.Load += new System.EventHandler(this.ucMZDeptFeeAnaly_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvTextEdit2.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit nvTextEdit2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbBeforeCheck;
        private System.Windows.Forms.RadioButton rbCurCheck;
        private System.Windows.Forms.Label label6;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit nvTextEdit1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtBeginDate;
        private NineVigor.FrameWork.WinForms.Controls.NineComboBox nineCBSmallDept;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbExeDept;
        private System.Windows.Forms.RadioButton rbRecepDept;
        private NineVigor.FrameWork.WinForms.Controls.NineComboBox nineComboBox1;
        private System.Windows.Forms.Label label1;
    }
}
