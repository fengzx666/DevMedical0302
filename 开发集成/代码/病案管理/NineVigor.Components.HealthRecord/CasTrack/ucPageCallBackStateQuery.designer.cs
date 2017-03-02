namespace NineVigor.Components.HealthRecord.CasTrack
{
    partial class ucPageCallBackStateQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPageCallBackStateQuery));
            this.gTopControl = new DevExpress.XtraEditors.GroupControl();
            this.txtFilter = new NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit();
            this.neuLabel1 = new NineVigor.FrameWork.WinForms.Controls.Common.NVLabel();
            this.txtPatientNo = new NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.nineSpread1 = new NineVigor.FrameWork.WinForms.Controls.NineSpread();
            this.nineSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.gTopControl)).BeginInit();
            this.gTopControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nineSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nineSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // gTopControl
            // 
            this.gTopControl.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.5F);
            this.gTopControl.AppearanceCaption.Options.UseFont = true;
            this.gTopControl.CaptionImage = ((System.Drawing.Image)(resources.GetObject("gTopControl.CaptionImage")));
            this.gTopControl.Controls.Add(this.txtFilter);
            this.gTopControl.Controls.Add(this.neuLabel1);
            this.gTopControl.Controls.Add(this.txtPatientNo);
            this.gTopControl.Controls.Add(this.label1);
            this.gTopControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gTopControl.Location = new System.Drawing.Point(0, 0);
            this.gTopControl.Name = "gTopControl";
            this.gTopControl.Size = new System.Drawing.Size(1281, 80);
            this.gTopControl.TabIndex = 9;
            this.gTopControl.Text = "病历状态检索信息区域";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(378, 39);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Properties.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFilter.Properties.Appearance.Options.UseFont = true;
            this.txtFilter.Size = new System.Drawing.Size(128, 22);
            this.txtFilter.TabIndex = 17;
            // 
            // neuLabel1
            // 
            this.neuLabel1.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.neuLabel1.Location = new System.Drawing.Point(10, 42);
            this.neuLabel1.Name = "neuLabel1";
            this.neuLabel1.Size = new System.Drawing.Size(112, 16);
            this.neuLabel1.TabIndex = 16;
            this.neuLabel1.Text = "病案号（姓名）";
            // 
            // txtPatientNo
            // 
            this.txtPatientNo.Location = new System.Drawing.Point(128, 39);
            this.txtPatientNo.Name = "txtPatientNo";
            this.txtPatientNo.Properties.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPatientNo.Properties.Appearance.Options.UseFont = true;
            this.txtPatientNo.Size = new System.Drawing.Size(171, 22);
            this.txtPatientNo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(305, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "过滤条件";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.5F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Left;
            this.groupControl1.Controls.Add(this.nineSpread1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 80);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1281, 435);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "病历信息列表";
            // 
            // nineSpread1
            // 
            this.nineSpread1.AccessibleDescription = "nineSpread1, Sheet1, Row 0, Column 0, ";
            this.nineSpread1.BackColor = System.Drawing.Color.White;
            this.nineSpread1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nineSpread1.FileName = "";
            this.nineSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.nineSpread1.IsAutoSaveGridStatus = false;
            this.nineSpread1.IsCanCustomConfigColumn = false;
            this.nineSpread1.IsShowExport = true;
            this.nineSpread1.IsShowMenuStrip = true;
            this.nineSpread1.Location = new System.Drawing.Point(32, 2);
            this.nineSpread1.Name = "nineSpread1";
            this.nineSpread1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nineSpread1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.nineSpread1_Sheet1});
            this.nineSpread1.Size = new System.Drawing.Size(1247, 431);
            this.nineSpread1.Style = NineVigor.FrameWork.WinForms.Controls.StyleType.Fixed3D;
            this.nineSpread1.TabIndex = 1;
            this.nineSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            // 
            // nineSpread1_Sheet1
            // 
            this.nineSpread1_Sheet1.Reset();
            nineSpread1_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.nineSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            nineSpread1_Sheet1.ColumnCount = 17;
            nineSpread1_Sheet1.RowCount = 5;
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "科室";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "回收状态";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "回收人";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "回收时间";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "录入人";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "录入时间";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "住院号";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 7).Value = "住院次数";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 8).Value = "姓名";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 9).Value = "性别";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 10).Value = "年龄";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 11).Value = "入院日期";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 12).Value = "出院日期";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 13).Value = "状态";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 14).Value = "住院天数";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 15).Value = "录入状态";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 16).Value = "住院流水号";
            this.nineSpread1_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.nineSpread1_Sheet1.Columns.Get(0).Label = "科室";
            this.nineSpread1_Sheet1.Columns.Get(0).Width = 113F;
            this.nineSpread1_Sheet1.Columns.Get(1).Label = "回收状态";
            this.nineSpread1_Sheet1.Columns.Get(1).Width = 68F;
            this.nineSpread1_Sheet1.Columns.Get(3).Label = "回收时间";
            this.nineSpread1_Sheet1.Columns.Get(3).Width = 94F;
            this.nineSpread1_Sheet1.Columns.Get(4).Label = "录入人";
            this.nineSpread1_Sheet1.Columns.Get(4).Width = 66F;
            this.nineSpread1_Sheet1.Columns.Get(5).Label = "录入时间";
            this.nineSpread1_Sheet1.Columns.Get(5).Width = 103F;
            this.nineSpread1_Sheet1.Columns.Get(6).Label = "住院号";
            this.nineSpread1_Sheet1.Columns.Get(6).Width = 100F;
            this.nineSpread1_Sheet1.Columns.Get(7).Label = "住院次数";
            this.nineSpread1_Sheet1.Columns.Get(7).Width = 93F;
            this.nineSpread1_Sheet1.Columns.Get(8).Label = "姓名";
            this.nineSpread1_Sheet1.Columns.Get(8).Width = 65F;
            this.nineSpread1_Sheet1.Columns.Get(16).Label = "住院流水号";
            this.nineSpread1_Sheet1.Columns.Get(16).Width = 93F;
            this.nineSpread1_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.nineSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // ucPageCallBackStateQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gTopControl);
            this.Name = "ucPageCallBackStateQuery";
            this.Size = new System.Drawing.Size(1281, 515);
            ((System.ComponentModel.ISupportInitialize)(this.gTopControl)).EndInit();
            this.gTopControl.ResumeLayout(false);
            this.gTopControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nineSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nineSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gTopControl;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit txtFilter;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVLabel neuLabel1;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit txtPatientNo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private NineVigor.FrameWork.WinForms.Controls.NineSpread nineSpread1;
        private FarPoint.Win.Spread.SheetView nineSpread1_Sheet1;

    }
}
