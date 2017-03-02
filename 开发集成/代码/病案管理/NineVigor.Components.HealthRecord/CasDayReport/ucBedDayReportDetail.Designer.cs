namespace NineVigor.Components.HealthRecord.CasDayReport
{
    partial class ucBedDayReportDetail
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
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.caseDetail = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // fpSpread1
            // 
            this.fpSpread1.AccessibleDescription = "fpSpread1, Sheet1, Row 0, Column 0, ";
            this.fpSpread1.BackColor = System.Drawing.Color.Transparent;
            this.fpSpread1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.fpSpread1.Location = new System.Drawing.Point(0, 0);
            this.fpSpread1.Name = "fpSpread1";
            this.fpSpread1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fpSpread1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.caseDetail});
            this.fpSpread1.Size = new System.Drawing.Size(654, 239);
            this.fpSpread1.TabIndex = 136;
            this.fpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.fpSpread1.SetActiveViewport(0, 1, 0);
            // 
            // caseDetail
            // 
            this.caseDetail.Reset();
            caseDetail.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.caseDetail.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            caseDetail.ColumnCount = 5;
            caseDetail.RowCount = 0;
            this.caseDetail.ColumnHeader.Cells.Get(0, 0).Value = "部门编号";
            this.caseDetail.ColumnHeader.Cells.Get(0, 1).Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.caseDetail.ColumnHeader.Cells.Get(0, 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.caseDetail.ColumnHeader.Cells.Get(0, 1).Value = "住院号";
            this.caseDetail.ColumnHeader.Cells.Get(0, 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.caseDetail.ColumnHeader.Cells.Get(0, 2).Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.caseDetail.ColumnHeader.Cells.Get(0, 2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.caseDetail.ColumnHeader.Cells.Get(0, 2).Value = "床号";
            this.caseDetail.ColumnHeader.Cells.Get(0, 2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.caseDetail.ColumnHeader.Cells.Get(0, 3).Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.caseDetail.ColumnHeader.Cells.Get(0, 3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.caseDetail.ColumnHeader.Cells.Get(0, 3).Value = "姓名";
            this.caseDetail.ColumnHeader.Cells.Get(0, 3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.caseDetail.ColumnHeader.Cells.Get(0, 4).Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.caseDetail.ColumnHeader.Cells.Get(0, 4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.caseDetail.ColumnHeader.Cells.Get(0, 4).Value = "变更信息";
            this.caseDetail.ColumnHeader.Cells.Get(0, 4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.caseDetail.ColumnHeader.Rows.Get(0).Height = 19F;
            this.caseDetail.Columns.Get(0).Label = "患者类型";
            this.caseDetail.Columns.Get(0).Visible = true;
            this.caseDetail.Columns.Get(1).Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.caseDetail.Columns.Get(1).Label = "住院号";
            this.caseDetail.Columns.Get(1).Width = 154F;
            this.caseDetail.Columns.Get(2).Label = "床号";
            this.caseDetail.Columns.Get(2).Width = 85F;
            this.caseDetail.Columns.Get(3).Label = "姓名";
            this.caseDetail.Columns.Get(3).Width = 95F;
            this.caseDetail.Columns.Get(4).Label = "变更信息";
            this.caseDetail.Columns.Get(4).Width = 248F;
            this.caseDetail.OperationMode = FarPoint.Win.Spread.OperationMode.ReadOnly;
            this.caseDetail.RowHeader.Columns.Default.Resizable = false;
            this.caseDetail.RowHeader.Columns.Get(0).Width = 37F;
            this.caseDetail.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // ucBedDayReportDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fpSpread1);
            this.Name = "ucBedDayReportDetail";
            this.Size = new System.Drawing.Size(654, 239);
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView caseDetail;

    }
}
