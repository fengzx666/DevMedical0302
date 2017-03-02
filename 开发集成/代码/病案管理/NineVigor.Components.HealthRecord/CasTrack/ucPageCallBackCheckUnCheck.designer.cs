namespace NineVigor.Components.HealthRecord.CasTrack
{
    partial class ucPageCallBackCheckUnCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPageCallBackCheckUnCheck));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.label1 = new System.Windows.Forms.Label();
            this.nineSpread1 = new NineVigor.FrameWork.WinForms.Controls.NineSpread();
            this.nineSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.gTopControl = new DevExpress.XtraEditors.GroupControl();
            this.btnUnCheck = new NineVigor.FrameWork.WinForms.Controls.Common.NVButtonEdit();
            this.neuLabel1 = new NineVigor.FrameWork.WinForms.Controls.Common.NVLabel();
            this.txtPatientNOSearch = new NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit();
            this.tbName = new NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.nineSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nineSpread1_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTopControl)).BeginInit();
            this.gTopControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientNOSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(305, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "姓名";
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
            this.nineSpread1.Size = new System.Drawing.Size(817, 454);
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
            nineSpread1_Sheet1.ColumnCount = 10;
            nineSpread1_Sheet1.RowCount = 5;
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "选择";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "病案号";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "住院次数";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "患者姓名";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "出院科别";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "入院日期";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "出院日期";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 7).Value = "回收确认时间";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 8).Value = "确认人";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 9).Value = "住院流水号";
            this.nineSpread1_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.nineSpread1_Sheet1.Columns.Get(0).Label = "选择";
            this.nineSpread1_Sheet1.Columns.Get(0).Width = 51F;
            this.nineSpread1_Sheet1.Columns.Get(1).Label = "病案号";
            this.nineSpread1_Sheet1.Columns.Get(1).Width = 92F;
            this.nineSpread1_Sheet1.Columns.Get(3).Label = "患者姓名";
            this.nineSpread1_Sheet1.Columns.Get(3).Width = 68F;
            this.nineSpread1_Sheet1.Columns.Get(4).Label = "出院科别";
            this.nineSpread1_Sheet1.Columns.Get(4).Width = 145F;
            this.nineSpread1_Sheet1.Columns.Get(5).Label = "入院日期";
            this.nineSpread1_Sheet1.Columns.Get(5).Width = 87F;
            this.nineSpread1_Sheet1.Columns.Get(6).Label = "出院日期";
            this.nineSpread1_Sheet1.Columns.Get(6).Width = 100F;
            this.nineSpread1_Sheet1.Columns.Get(7).Label = "回收确认时间";
            this.nineSpread1_Sheet1.Columns.Get(7).Width = 93F;
            this.nineSpread1_Sheet1.Columns.Get(8).Label = "确认人";
            this.nineSpread1_Sheet1.Columns.Get(8).Width = 65F;
            this.nineSpread1_Sheet1.Columns.Get(9).Label = "住院流水号";
            this.nineSpread1_Sheet1.Columns.Get(9).Width = 109F;
            this.nineSpread1_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.nineSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // gTopControl
            // 
            this.gTopControl.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.5F);
            this.gTopControl.AppearanceCaption.Options.UseFont = true;
            this.gTopControl.CaptionImage = ((System.Drawing.Image)(resources.GetObject("gTopControl.CaptionImage")));
            this.gTopControl.Controls.Add(this.tbName);
            this.gTopControl.Controls.Add(this.neuLabel1);
            this.gTopControl.Controls.Add(this.txtPatientNOSearch);
            this.gTopControl.Controls.Add(this.btnUnCheck);
            this.gTopControl.Controls.Add(this.label1);
            this.gTopControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gTopControl.Location = new System.Drawing.Point(0, 0);
            this.gTopControl.Name = "gTopControl";
            this.gTopControl.Size = new System.Drawing.Size(851, 80);
            this.gTopControl.TabIndex = 5;
            this.gTopControl.Text = "病历回收检索信息区域";
            // 
            // btnUnCheck
            // 
            this.btnUnCheck.EditValue = "取消回收";
            this.btnUnCheck.Location = new System.Drawing.Point(492, 36);
            this.btnUnCheck.Name = "btnUnCheck";
            this.btnUnCheck.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.btnUnCheck.Properties.Appearance.Options.UseFont = true;
            this.btnUnCheck.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "取消回收", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnReSet.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnUnCheck.Size = new System.Drawing.Size(94, 30);
            this.btnUnCheck.TabIndex = 14;
            this.btnUnCheck.TabStop = false;
            this.btnUnCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // neuLabel1
            // 
            this.neuLabel1.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.neuLabel1.Location = new System.Drawing.Point(10, 42);
            this.neuLabel1.Name = "neuLabel1";
            this.neuLabel1.Size = new System.Drawing.Size(136, 16);
            this.neuLabel1.TabIndex = 16;
            this.neuLabel1.Text = "病案号/住院流水号";
            // 
            // txtPatientNOSearch
            // 
            this.txtPatientNOSearch.Location = new System.Drawing.Point(152, 39);
            this.txtPatientNOSearch.Name = "txtPatientNOSearch";
            this.txtPatientNOSearch.Properties.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPatientNOSearch.Properties.Appearance.Options.UseFont = true;
            this.txtPatientNOSearch.Size = new System.Drawing.Size(140, 22);
            this.txtPatientNOSearch.TabIndex = 15;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(342, 39);
            this.tbName.Name = "tbName";
            this.tbName.Properties.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbName.Properties.Appearance.Options.UseFont = true;
            this.tbName.Size = new System.Drawing.Size(128, 22);
            this.tbName.TabIndex = 17;
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
            this.groupControl1.Size = new System.Drawing.Size(851, 458);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "回收病历列表";
            // 
            // ucPageCallBackCheckUnCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gTopControl);
            this.Name = "ucPageCallBackCheckUnCheck";
            this.Size = new System.Drawing.Size(851, 538);
            this.Load += new System.EventHandler(this.UcMetCasFirstPageCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nineSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nineSpread1_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTopControl)).EndInit();
            this.gTopControl.ResumeLayout(false);
            this.gTopControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientNOSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NineVigor.FrameWork.WinForms.Controls.NineSpread nineSpread1;
        private FarPoint.Win.Spread.SheetView nineSpread1_Sheet1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl gTopControl;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVButtonEdit btnUnCheck;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit tbName;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVLabel neuLabel1;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit txtPatientNOSearch;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}
