namespace NineVigor.Components.HealthRecord.CasLend
{
    partial class ucReturnCase
    {
        /// <summary> 
        /// 必需的设计器变量。

        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVLabel label9;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit CardNO;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVLabel label1;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVCheckEdit cbReturn;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVDateTimePicker dtReturn;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit txName;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVLabel label10;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit txReturn;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucReturnCase));
            this.neuLabel1 = new NineVigor.FrameWork.WinForms.Controls.Common.NVLabel();
            this.neuTextBox1 = new NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit();
            this.dtContinue = new NineVigor.FrameWork.WinForms.Controls.Common.NVDateTimePicker();
            this.cbContinueLend = new NineVigor.FrameWork.WinForms.Controls.Common.NVCheckEdit();
            this.txReturn = new NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit();
            this.label10 = new NineVigor.FrameWork.WinForms.Controls.Common.NVLabel();
            this.dtReturn = new NineVigor.FrameWork.WinForms.Controls.Common.NVDateTimePicker();
            this.label1 = new NineVigor.FrameWork.WinForms.Controls.Common.NVLabel();
            this.txName = new NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit();
            this.label9 = new NineVigor.FrameWork.WinForms.Controls.Common.NVLabel();
            this.CardNO = new NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit();
            this.cbReturn = new NineVigor.FrameWork.WinForms.Controls.Common.NVCheckEdit();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.neuTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbContinueLend.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txReturn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardNO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReturn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // neuLabel1
            // 
            this.neuLabel1.Location = new System.Drawing.Point(6, 29);
            this.neuLabel1.Name = "neuLabel1";
            this.neuLabel1.Size = new System.Drawing.Size(101, 14);
            this.neuLabel1.TabIndex = 47;
            this.neuLabel1.Text = "病案号/住院流水号";
            // 
            // neuTextBox1
            // 
            this.neuTextBox1.Location = new System.Drawing.Point(109, 26);
            this.neuTextBox1.Name = "neuTextBox1";
            this.neuTextBox1.Size = new System.Drawing.Size(107, 20);
            this.neuTextBox1.TabIndex = 48;
            this.neuTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.neuTextBox1_KeyDown);
            // 
            // dtContinue
            // 
            this.dtContinue.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtContinue.Enabled = false;
            this.dtContinue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtContinue.IsEnter2Tab = false;
            this.dtContinue.Location = new System.Drawing.Point(585, 26);
            this.dtContinue.Name = "dtContinue";
            this.dtContinue.Size = new System.Drawing.Size(147, 21);
            this.dtContinue.Style = NineVigor.FrameWork.WinForms.Controls.StyleType.Fixed3D;
            this.dtContinue.TabIndex = 45;
            // 
            // cbContinueLend
            // 
            this.cbContinueLend.Location = new System.Drawing.Point(532, 28);
            this.cbContinueLend.Name = "cbContinueLend";
            this.cbContinueLend.Properties.Appearance.Options.UseTextOptions = true;
            this.cbContinueLend.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbContinueLend.Properties.Caption = "续借";
            this.cbContinueLend.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cbContinueLend.Size = new System.Drawing.Size(51, 19);
            this.cbContinueLend.TabIndex = 46;
            this.cbContinueLend.CheckedChanged += new System.EventHandler(this.cbContinueLend_CheckedChanged);
            this.cbContinueLend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbContinueLend_KeyDown);
            // 
            // txReturn
            // 
            this.txReturn.Location = new System.Drawing.Point(292, 49);
            this.txReturn.Name = "txReturn";
            this.txReturn.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txReturn.Properties.Appearance.Options.UseBackColor = true;
            this.txReturn.Size = new System.Drawing.Size(440, 20);
            this.txReturn.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(238, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 14);
            this.label10.TabIndex = 43;
            this.label10.Text = "返还情况";
            // 
            // dtReturn
            // 
            this.dtReturn.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtReturn.IsEnter2Tab = false;
            this.dtReturn.Location = new System.Drawing.Point(61, 46);
            this.dtReturn.Name = "dtReturn";
            this.dtReturn.Size = new System.Drawing.Size(137, 21);
            this.dtReturn.Style = NineVigor.FrameWork.WinForms.Controls.StyleType.Fixed3D;
            this.dtReturn.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(396, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "姓名";
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(426, 26);
            this.txName.Name = "txName";
            this.txName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txName.Properties.Appearance.Options.UseBackColor = true;
            this.txName.Size = new System.Drawing.Size(100, 20);
            this.txName.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(238, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 14);
            this.label9.TabIndex = 19;
            this.label9.Text = "借阅人工号";
            // 
            // CardNO
            // 
            this.CardNO.Location = new System.Drawing.Point(303, 26);
            this.CardNO.Name = "CardNO";
            this.CardNO.Size = new System.Drawing.Size(88, 20);
            this.CardNO.TabIndex = 20;
            this.CardNO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CardNO_KeyDown);
            // 
            // cbReturn
            // 
            this.cbReturn.EditValue = true;
            this.cbReturn.Location = new System.Drawing.Point(10, 47);
            this.cbReturn.Name = "cbReturn";
            this.cbReturn.Properties.Caption = "返还";
            this.cbReturn.Size = new System.Drawing.Size(48, 19);
            this.cbReturn.TabIndex = 42;
            this.cbReturn.CheckedChanged += new System.EventHandler(this.cbReturn_CheckedChanged);
            this.cbReturn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbReturn_KeyDown);
            // 
            // fpSpread1
            // 
            this.fpSpread1.AccessibleDescription = "fpSpread1, Sheet1, Row 0, Column 0, ";
            this.fpSpread1.BackColor = System.Drawing.SystemColors.Control;
            this.fpSpread1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.fpSpread1.Location = new System.Drawing.Point(0, 78);
            this.fpSpread1.Name = "fpSpread1";
            this.fpSpread1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fpSpread1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.fpSpread1.Size = new System.Drawing.Size(800, 522);
            this.fpSpread1.TabIndex = 1;
            this.fpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.fpSpread1.SetActiveViewport(0, 1, 0);
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            fpSpread1_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.fpSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            fpSpread1_Sheet1.ColumnCount = 9;
            fpSpread1_Sheet1.RowCount = 0;
            this.fpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "选择";
            this.fpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "病案号";
            this.fpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "借阅人姓名";
            this.fpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "病人姓名";
            this.fpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "病人性别";
            this.fpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "借阅原因";
            this.fpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "借阅日期";
            this.fpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 7).Value = "住院流水号";
            this.fpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 8).Value = "借出人";
            this.fpSpread1_Sheet1.Columns.Get(1).Label = "病案号";
            this.fpSpread1_Sheet1.Columns.Get(1).Width = 81F;
            this.fpSpread1_Sheet1.Columns.Get(2).Label = "借阅人姓名";
            this.fpSpread1_Sheet1.Columns.Get(2).Width = 72F;
            this.fpSpread1_Sheet1.Columns.Get(3).Label = "病人姓名";
            this.fpSpread1_Sheet1.Columns.Get(3).Width = 73F;
            this.fpSpread1_Sheet1.Columns.Get(5).Label = "借阅原因";
            this.fpSpread1_Sheet1.Columns.Get(5).Width = 71F;
            this.fpSpread1_Sheet1.Columns.Get(6).Label = "借阅日期";
            this.fpSpread1_Sheet1.Columns.Get(6).Width = 126F;
            this.fpSpread1_Sheet1.Columns.Get(7).Label = "住院流水号";
            this.fpSpread1_Sheet1.Columns.Get(7).Width = 97F;
            this.fpSpread1_Sheet1.Columns.Get(8).Label = "借出人";
            this.fpSpread1_Sheet1.Columns.Get(8).Width = 94F;
            this.fpSpread1_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.fpSpread1_Sheet1.RowHeader.Columns.Get(0).Width = 37F;
            this.fpSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.neuLabel1);
            this.groupControl1.Controls.Add(this.CardNO);
            this.groupControl1.Controls.Add(this.neuTextBox1);
            this.groupControl1.Controls.Add(this.cbReturn);
            this.groupControl1.Controls.Add(this.dtContinue);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.cbContinueLend);
            this.groupControl1.Controls.Add(this.txName);
            this.groupControl1.Controls.Add(this.txReturn);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.dtReturn);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(800, 78);
            this.groupControl1.TabIndex = 49;
            this.groupControl1.Text = "病历借阅信息";
            // 
            // ucReturnCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.fpSpread1);
            this.Controls.Add(this.groupControl1);
            this.Name = "ucReturnCase";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.frmReturnCase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.neuTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbContinueLend.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txReturn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardNO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReturn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NineVigor.FrameWork.WinForms.Controls.Common.NVDateTimePicker dtContinue;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVCheckEdit cbContinueLend;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVLabel neuLabel1;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit neuTextBox1;
        private DevExpress.XtraEditors.GroupControl groupControl1;

    }
}
