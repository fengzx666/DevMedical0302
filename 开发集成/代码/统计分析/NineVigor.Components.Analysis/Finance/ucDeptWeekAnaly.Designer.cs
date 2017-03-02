namespace NineVigor.Components.Analysis.Finance
{
    partial class ucDeptWeekAnaly
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
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel7 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel8 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel9 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvTextEdit2.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel9)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(726, 104);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分析条件";
            // 
            // nvTextEdit2
            // 
            this.nvTextEdit2.Location = new System.Drawing.Point(79, 78);
            this.nvTextEdit2.Name = "nvTextEdit2";
            this.nvTextEdit2.Size = new System.Drawing.Size(100, 20);
            this.nvTextEdit2.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "往期年度数：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBeforeCheck);
            this.groupBox2.Controls.Add(this.rbCurCheck);
            this.groupBox2.Location = new System.Drawing.Point(216, 6);
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
            this.rbBeforeCheck.CheckedChanged += new System.EventHandler(this.rbBeforeCheck_CheckedChanged);
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
            this.rbCurCheck.CheckedChanged += new System.EventHandler(this.rbCurCheck_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "分析周日期：";
            // 
            // nvTextEdit1
            // 
            this.nvTextEdit1.EditValue = "1";
            this.nvTextEdit1.Location = new System.Drawing.Point(330, 48);
            this.nvTextEdit1.Name = "nvTextEdit1";
            this.nvTextEdit1.Size = new System.Drawing.Size(100, 20);
            this.nvTextEdit1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "向前对比分析周数：";
            // 
            // dtBeginDate
            // 
            this.dtBeginDate.CustomFormat = "yyyy-MM-dd";
            this.dtBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBeginDate.Location = new System.Drawing.Point(85, 47);
            this.dtBeginDate.Name = "dtBeginDate";
            this.dtBeginDate.Size = new System.Drawing.Size(101, 21);
            this.dtBeginDate.TabIndex = 8;
            // 
            // nineCBSmallDept
            // 
            this.nineCBSmallDept.ArrowBackColor = System.Drawing.SystemColors.Control;
            this.nineCBSmallDept.DropDownHeight = 424;
            this.nineCBSmallDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            xyDiagram3.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram3.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram3.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram3;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 104);
            this.chartControl1.Name = "chartControl1";
            sideBySideBarSeriesLabel7.LineVisible = true;
            series5.Label = sideBySideBarSeriesLabel7;
            series5.Name = "Series 1";
            sideBySideBarSeriesLabel8.LineVisible = true;
            series6.Label = sideBySideBarSeriesLabel8;
            series6.Name = "Series 2";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series5,
        series6};
            sideBySideBarSeriesLabel9.LineVisible = true;
            this.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel9;
            this.chartControl1.Size = new System.Drawing.Size(726, 354);
            this.chartControl1.TabIndex = 4;
            // 
            // ucDeptWeekAnaly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucDeptWeekAnaly";
            this.Size = new System.Drawing.Size(726, 458);
            this.Load += new System.EventHandler(this.ucDeptWeekAnaly_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvTextEdit2.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtBeginDate;
        private NineVigor.FrameWork.WinForms.Controls.NineComboBox nineCBSmallDept;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit nvTextEdit1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbBeforeCheck;
        private System.Windows.Forms.RadioButton rbCurCheck;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit nvTextEdit2;
        private System.Windows.Forms.Label label7;
    }
}
