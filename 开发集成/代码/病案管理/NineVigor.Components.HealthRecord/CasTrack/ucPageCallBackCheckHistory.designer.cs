namespace NineVigor.Components.HealthRecord.CasTrack
{
    partial class ucPageCallBackCheckHistory
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
            FarPoint.Win.Spread.CellType.TextCellType textCellType1 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.NumberCellType numberCellType1 = new FarPoint.Win.Spread.CellType.NumberCellType();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPageCallBackCheckHistory));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.nineSpread3 = new NineVigor.FrameWork.WinForms.Controls.NineSpread();
            this.nineSpread3_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.gTopControl = new DevExpress.XtraEditors.GroupControl();
            this.dateTimeEnd = new NineVigor.FrameWork.WinForms.Controls.Common.NVDateTimePicker();
            this.nvLabel2 = new NineVigor.FrameWork.WinForms.Controls.Common.NVLabel();
            this.dateTimeBegin = new NineVigor.FrameWork.WinForms.Controls.Common.NVDateTimePicker();
            this.nvLabel1 = new NineVigor.FrameWork.WinForms.Controls.Common.NVLabel();
            this.btnQry = new NineVigor.FrameWork.WinForms.Controls.Common.NVButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.nineSpread3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nineSpread3_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTopControl)).BeginInit();
            this.gTopControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnQry.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nineSpread3
            // 
            this.nineSpread3.AccessibleDescription = "neuSpread3, Sheet1, Row 0, Column 0, ";
            this.nineSpread3.BackColor = System.Drawing.Color.White;
            this.nineSpread3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nineSpread3.FileName = "";
            this.nineSpread3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nineSpread3.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.nineSpread3.IsAutoSaveGridStatus = false;
            this.nineSpread3.IsCanCustomConfigColumn = false;
            this.nineSpread3.IsShowExport = true;
            this.nineSpread3.IsShowMenuStrip = true;
            this.nineSpread3.Location = new System.Drawing.Point(0, 80);
            this.nineSpread3.Name = "nineSpread3";
            this.nineSpread3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nineSpread3.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.nineSpread3_Sheet1});
            this.nineSpread3.Size = new System.Drawing.Size(1280, 419);
            this.nineSpread3.Style = NineVigor.FrameWork.WinForms.Controls.StyleType.Fixed3D;
            this.nineSpread3.TabIndex = 661;
            this.nineSpread3.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            // 
            // nineSpread3_Sheet1
            // 
            this.nineSpread3_Sheet1.Reset();
            nineSpread3_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.nineSpread3_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            nineSpread3_Sheet1.ColumnCount = 12;
            nineSpread3_Sheet1.RowCount = 1;
            this.nineSpread3_Sheet1.ColumnHeader.Rows.Get(0).Height = 19F;
            this.nineSpread3_Sheet1.Columns.Get(0).CellType = textCellType1;
            this.nineSpread3_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.nineSpread3_Sheet1.Columns.Get(0).Width = 75F;
            numberCellType1.DecimalPlaces = 0;
            this.nineSpread3_Sheet1.Columns.Get(1).CellType = numberCellType1;
            this.nineSpread3_Sheet1.Columns.Get(1).Width = 95F;
            this.nineSpread3_Sheet1.Columns.Get(2).Width = 65F;
            this.nineSpread3_Sheet1.Columns.Get(3).Width = 69F;
            this.nineSpread3_Sheet1.Columns.Get(4).Width = 68F;
            this.nineSpread3_Sheet1.Columns.Get(5).Width = 110F;
            this.nineSpread3_Sheet1.Columns.Get(6).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.nineSpread3_Sheet1.Columns.Get(6).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.nineSpread3_Sheet1.Columns.Get(6).Width = 182F;
            this.nineSpread3_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.nineSpread3_Sheet1.RowHeader.Columns.Get(0).Width = 38F;
            this.nineSpread3_Sheet1.Rows.Get(0).Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nineSpread3_Sheet1.Rows.Get(0).Height = 30F;
            this.nineSpread3_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // gTopControl
            // 
            this.gTopControl.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.5F);
            this.gTopControl.AppearanceCaption.Options.UseFont = true;
            this.gTopControl.CaptionImage = ((System.Drawing.Image)(resources.GetObject("gTopControl.CaptionImage")));
            this.gTopControl.Controls.Add(this.btnQry);
            this.gTopControl.Controls.Add(this.dateTimeEnd);
            this.gTopControl.Controls.Add(this.nvLabel2);
            this.gTopControl.Controls.Add(this.dateTimeBegin);
            this.gTopControl.Controls.Add(this.nvLabel1);
            this.gTopControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gTopControl.Location = new System.Drawing.Point(0, 0);
            this.gTopControl.Name = "gTopControl";
            this.gTopControl.Size = new System.Drawing.Size(1280, 80);
            this.gTopControl.TabIndex = 6;
            this.gTopControl.Text = "病历回收检索信息区域";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimeEnd.Font = new System.Drawing.Font("宋体", 14.25F);
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.IsEnter2Tab = false;
            this.dateTimeEnd.Location = new System.Drawing.Point(367, 35);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(200, 29);
            this.dateTimeEnd.Style = NineVigor.FrameWork.WinForms.Controls.StyleType.Fixed3D;
            this.dateTimeEnd.TabIndex = 20;
            // 
            // nvLabel2
            // 
            this.nvLabel2.Appearance.Font = new System.Drawing.Font("宋体", 18F);
            this.nvLabel2.Location = new System.Drawing.Point(333, 38);
            this.nvLabel2.Name = "nvLabel2";
            this.nvLabel2.Size = new System.Drawing.Size(24, 24);
            this.nvLabel2.TabIndex = 19;
            this.nvLabel2.Text = "至";
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimeBegin.Font = new System.Drawing.Font("宋体", 14.25F);
            this.dateTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeBegin.IsEnter2Tab = false;
            this.dateTimeBegin.Location = new System.Drawing.Point(123, 35);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(200, 29);
            this.dateTimeBegin.Style = NineVigor.FrameWork.WinForms.Controls.StyleType.Fixed3D;
            this.dateTimeBegin.TabIndex = 18;
            // 
            // nvLabel1
            // 
            this.nvLabel1.Appearance.Font = new System.Drawing.Font("宋体", 18F);
            this.nvLabel1.Location = new System.Drawing.Point(6, 38);
            this.nvLabel1.Name = "nvLabel1";
            this.nvLabel1.Size = new System.Drawing.Size(96, 24);
            this.nvLabel1.TabIndex = 17;
            this.nvLabel1.Text = "回收时间";
            // 
            // btnQry
            // 
            this.btnQry.EditValue = "查询";
            this.btnQry.Location = new System.Drawing.Point(573, 35);
            this.btnQry.Name = "btnQry";
            this.btnQry.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.btnQry.Properties.Appearance.Options.UseFont = true;
            this.btnQry.Properties.Appearance.Options.UseTextOptions = true;
            this.btnQry.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.btnQry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "取消回收", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnHisQuery.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnQry.Size = new System.Drawing.Size(69, 28);
            this.btnQry.TabIndex = 21;
            this.btnQry.TabStop = false;
            // 
            // ucPageCallBackCheckHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 499);
            this.Controls.Add(this.nineSpread3);
            this.Controls.Add(this.gTopControl);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ucPageCallBackCheckHistory";
            this.Text = "回收时间区域检索";
            this.Load += new System.EventHandler(this.UcMetCasFirstPageCheckHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nineSpread3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nineSpread3_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTopControl)).EndInit();
            this.gTopControl.ResumeLayout(false);
            this.gTopControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnQry.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NineVigor.FrameWork.WinForms.Controls.NineSpread nineSpread3;
        private FarPoint.Win.Spread.SheetView nineSpread3_Sheet1;
        private DevExpress.XtraEditors.GroupControl gTopControl;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVLabel nvLabel1;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVDateTimePicker dateTimeBegin;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVDateTimePicker dateTimeEnd;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVLabel nvLabel2;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVButtonEdit btnQry;
    }
}
