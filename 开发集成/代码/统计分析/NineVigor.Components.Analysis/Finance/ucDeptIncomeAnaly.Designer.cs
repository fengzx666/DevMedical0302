namespace NineVigor.Components.Analysis.Finance
{
    partial class ucDeptIncomeAnaly
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
            FarPoint.Win.Spread.CellType.TextCellType textCellType1 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType2 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType3 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType4 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType5 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType6 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType7 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType8 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType9 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType10 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType11 = new FarPoint.Win.Spread.CellType.TextCellType();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.nineSpreadUserInfo = new NineVigor.FrameWork.WinForms.Controls.NineSpread();
            this.nineSpreadUserInfo_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtBeginDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.nineCBSmallDept = new NineVigor.FrameWork.WinForms.Controls.NineComboBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.nineCBSBigDept = new NineVigor.FrameWork.WinForms.Controls.NineComboBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.nineCBBigDept = new NineVigor.FrameWork.WinForms.Controls.NineComboBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.nineSpreadUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nineSpreadUserInfo_Sheet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
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
            this.chartControl1.Location = new System.Drawing.Point(5, 64);
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
            this.chartControl1.Size = new System.Drawing.Size(928, 398);
            this.chartControl1.TabIndex = 0;
            // 
            // nineSpreadUserInfo
            // 
            this.nineSpreadUserInfo.AccessibleDescription = "nineSpreadUserInfo, Sheet1, Row 0, Column 0, ";
            this.nineSpreadUserInfo.BackColor = System.Drawing.Color.White;
            this.nineSpreadUserInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nineSpreadUserInfo.FileName = "";
            this.nineSpreadUserInfo.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.nineSpreadUserInfo.IsAutoSaveGridStatus = false;
            this.nineSpreadUserInfo.IsCanCustomConfigColumn = false;
            this.nineSpreadUserInfo.IsShowExport = true;
            this.nineSpreadUserInfo.IsShowMenuStrip = true;
            this.nineSpreadUserInfo.Location = new System.Drawing.Point(0, 468);
            this.nineSpreadUserInfo.Name = "nineSpreadUserInfo";
            this.nineSpreadUserInfo.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.nineSpreadUserInfo_Sheet1});
            this.nineSpreadUserInfo.Size = new System.Drawing.Size(989, 124);
            this.nineSpreadUserInfo.Style = NineVigor.FrameWork.WinForms.Controls.StyleType.Fixed3D;
            this.nineSpreadUserInfo.TabIndex = 1;
            this.nineSpreadUserInfo.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            // 
            // nineSpreadUserInfo_Sheet1
            // 
            this.nineSpreadUserInfo_Sheet1.Reset();
            nineSpreadUserInfo_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.nineSpreadUserInfo_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            nineSpreadUserInfo_Sheet1.ColumnCount = 10;
            nineSpreadUserInfo_Sheet1.RowCount = 5;
            this.nineSpreadUserInfo_Sheet1.Cells.Get(0, 0).CellType = textCellType1;
            this.nineSpreadUserInfo_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "人员编号";
            this.nineSpreadUserInfo_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "人员姓名";
            this.nineSpreadUserInfo_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "性别";
            this.nineSpreadUserInfo_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "人员类别";
            this.nineSpreadUserInfo_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "职务";
            this.nineSpreadUserInfo_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "职级";
            this.nineSpreadUserInfo_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "教学职称";
            this.nineSpreadUserInfo_Sheet1.ColumnHeader.Cells.Get(0, 7).Value = "序号";
            this.nineSpreadUserInfo_Sheet1.ColumnHeader.Cells.Get(0, 8).Value = "是否停用";
            this.nineSpreadUserInfo_Sheet1.ColumnHeader.Cells.Get(0, 9).Value = "科室名称";
            this.nineSpreadUserInfo_Sheet1.Columns.Get(0).CellType = textCellType2;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(0).Label = "人员编号";
            this.nineSpreadUserInfo_Sheet1.Columns.Get(0).Locked = true;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(1).CellType = textCellType3;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(1).Label = "人员姓名";
            this.nineSpreadUserInfo_Sheet1.Columns.Get(1).Locked = true;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(1).Width = 96F;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(2).CellType = textCellType4;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(2).Label = "性别";
            this.nineSpreadUserInfo_Sheet1.Columns.Get(2).Locked = true;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(2).Width = 62F;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(3).CellType = textCellType5;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(3).Label = "人员类别";
            this.nineSpreadUserInfo_Sheet1.Columns.Get(3).Locked = true;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(3).Width = 80F;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(4).CellType = textCellType6;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(4).Label = "职务";
            this.nineSpreadUserInfo_Sheet1.Columns.Get(4).Locked = true;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(4).Width = 82F;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(5).CellType = textCellType7;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(5).Label = "职级";
            this.nineSpreadUserInfo_Sheet1.Columns.Get(5).Locked = true;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(5).Width = 89F;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(6).CellType = textCellType8;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(6).Label = "教学职称";
            this.nineSpreadUserInfo_Sheet1.Columns.Get(6).Locked = true;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(6).Width = 76F;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(7).CellType = textCellType9;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(7).Label = "序号";
            this.nineSpreadUserInfo_Sheet1.Columns.Get(7).Locked = true;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(8).CellType = textCellType10;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(8).Label = "是否停用";
            this.nineSpreadUserInfo_Sheet1.Columns.Get(9).CellType = textCellType11;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(9).Label = "科室名称";
            this.nineSpreadUserInfo_Sheet1.Columns.Get(9).Locked = true;
            this.nineSpreadUserInfo_Sheet1.Columns.Get(9).Width = 95F;
            this.nineSpreadUserInfo_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode;
            this.nineSpreadUserInfo_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.nineSpreadUserInfo_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtEndDate);
            this.groupBox1.Controls.Add(this.dtBeginDate);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nineCBSmallDept);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nineCBSBigDept);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nineCBBigDept);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 42);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(786, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = " 至 ";
            // 
            // dtEndDate
            // 
            this.dtEndDate.CustomFormat = "yyyy-MM-dd";
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndDate.Location = new System.Drawing.Point(819, 15);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(100, 21);
            this.dtEndDate.TabIndex = 9;
            // 
            // dtBeginDate
            // 
            this.dtBeginDate.CustomFormat = "yyyy-MM-dd";
            this.dtBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBeginDate.Location = new System.Drawing.Point(681, 15);
            this.dtBeginDate.Name = "dtBeginDate";
            this.dtBeginDate.Size = new System.Drawing.Size(101, 21);
            this.dtBeginDate.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "收起";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.nineCBSmallDept.Location = new System.Drawing.Point(442, 16);
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
            this.label3.Location = new System.Drawing.Point(395, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "部门：";
            // 
            // nineCBSBigDept
            // 
            this.nineCBSBigDept.ArrowBackColor = System.Drawing.SystemColors.Control;
            this.nineCBSBigDept.DropDownHeight = 424;
            this.nineCBSBigDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nineCBSBigDept.FormattingEnabled = true;
            this.nineCBSBigDept.IntegralHeight = false;
            this.nineCBSBigDept.IsEnter2Tab = false;
            this.nineCBSBigDept.IsFlat = false;
            this.nineCBSBigDept.IsLike = true;
            this.nineCBSBigDept.IsListOnly = false;
            this.nineCBSBigDept.IsPopForm = true;
            this.nineCBSBigDept.IsShowCustomerList = false;
            this.nineCBSBigDept.IsShowID = false;
            this.nineCBSBigDept.Location = new System.Drawing.Point(67, 18);
            this.nineCBSBigDept.Name = "nineCBSBigDept";
            this.nineCBSBigDept.PopForm = null;
            this.nineCBSBigDept.ShowCustomerList = false;
            this.nineCBSBigDept.ShowID = false;
            this.nineCBSBigDept.Size = new System.Drawing.Size(121, 20);
            this.nineCBSBigDept.Style = NineVigor.FrameWork.WinForms.Controls.StyleType.Flat;
            this.nineCBSBigDept.TabIndex = 4;
            this.nineCBSBigDept.Tag = "";
            this.nineCBSBigDept.ToolBarUse = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "学部：";
            // 
            // nineCBBigDept
            // 
            this.nineCBBigDept.ArrowBackColor = System.Drawing.SystemColors.Control;
            this.nineCBBigDept.DropDownHeight = 424;
            this.nineCBBigDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nineCBBigDept.FormattingEnabled = true;
            this.nineCBBigDept.IntegralHeight = false;
            this.nineCBBigDept.IsEnter2Tab = false;
            this.nineCBBigDept.IsFlat = false;
            this.nineCBBigDept.IsLike = true;
            this.nineCBBigDept.IsListOnly = false;
            this.nineCBBigDept.IsPopForm = true;
            this.nineCBBigDept.IsShowCustomerList = false;
            this.nineCBBigDept.IsShowID = false;
            this.nineCBBigDept.Location = new System.Drawing.Point(252, 16);
            this.nineCBBigDept.Name = "nineCBBigDept";
            this.nineCBBigDept.PopForm = null;
            this.nineCBBigDept.ShowCustomerList = false;
            this.nineCBBigDept.ShowID = false;
            this.nineCBBigDept.Size = new System.Drawing.Size(121, 20);
            this.nineCBBigDept.Style = NineVigor.FrameWork.WinForms.Controls.StyleType.Flat;
            this.nineCBBigDept.TabIndex = 2;
            this.nineCBBigDept.Tag = "";
            this.nineCBBigDept.ToolBarUse = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "科室：";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Controls.Add(this.chartControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(989, 468);
            this.panelControl1.TabIndex = 3;
            // 
            // ucDeptIncomeAnaly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.nineSpreadUserInfo);
            this.Name = "ucDeptIncomeAnaly";
            this.Size = new System.Drawing.Size(989, 592);
            this.Load += new System.EventHandler(this.ucDeptIncomeAnaly_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.nineSpreadUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nineSpreadUserInfo_Sheet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private NineVigor.FrameWork.WinForms.Controls.NineSpread nineSpreadUserInfo;
        private FarPoint.Win.Spread.SheetView nineSpreadUserInfo_Sheet1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private NineVigor.FrameWork.WinForms.Controls.NineComboBox nineCBBigDept;
        private NineVigor.FrameWork.WinForms.Controls.NineComboBox nineCBSBigDept;
        private System.Windows.Forms.Label label2;
        private NineVigor.FrameWork.WinForms.Controls.NineComboBox nineCBSmallDept;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtBeginDate;
    }
}
