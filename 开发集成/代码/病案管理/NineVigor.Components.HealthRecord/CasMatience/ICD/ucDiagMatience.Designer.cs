namespace NineVigor.Components.HealthRecord.CasMatience.ICD
{
    partial class ucDiagMatience
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.enableCheckTime = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cbValid = new System.Windows.Forms.CheckBox();
            this.dtModifyEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtModifyBegin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.nvfilterCode = new NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.nineSpread1 = new NineVigor.FrameWork.WinForms.Controls.NineSpread();
            this.nineSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvfilterCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nineSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nineSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.enableCheckTime);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.checkBox1);
            this.panelTop.Controls.Add(this.checkBox2);
            this.panelTop.Controls.Add(this.cbValid);
            this.panelTop.Controls.Add(this.dtModifyEnd);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.dtModifyBegin);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.nvfilterCode);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(909, 75);
            this.panelTop.TabIndex = 2;
            // 
            // enableCheckTime
            // 
            this.enableCheckTime.AutoSize = true;
            this.enableCheckTime.Location = new System.Drawing.Point(91, 15);
            this.enableCheckTime.Name = "enableCheckTime";
            this.enableCheckTime.Size = new System.Drawing.Size(15, 14);
            this.enableCheckTime.TabIndex = 13;
            this.enableCheckTime.UseVisualStyleBackColor = true;
            this.enableCheckTime.CheckedChanged += new System.EventHandler(this.enableCheckTime_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(292, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(522, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "可过滤ICD编码、名称（含院内院外）右键可进行单列过滤";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(630, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 16);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "是否维护院内";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(552, 14);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "是否星键";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbValid
            // 
            this.cbValid.AutoSize = true;
            this.cbValid.Location = new System.Drawing.Point(476, 14);
            this.cbValid.Name = "cbValid";
            this.cbValid.Size = new System.Drawing.Size(72, 16);
            this.cbValid.TabIndex = 9;
            this.cbValid.Text = "是否无效";
            this.cbValid.UseVisualStyleBackColor = true;
            this.cbValid.CheckedChanged += new System.EventHandler(this.cbValid_CheckedChanged);
            // 
            // dtModifyEnd
            // 
            this.dtModifyEnd.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtModifyEnd.Enabled = false;
            this.dtModifyEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtModifyEnd.Location = new System.Drawing.Point(277, 11);
            this.dtModifyEnd.Name = "dtModifyEnd";
            this.dtModifyEnd.Size = new System.Drawing.Size(135, 21);
            this.dtModifyEnd.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "至";
            // 
            // dtModifyBegin
            // 
            this.dtModifyBegin.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtModifyBegin.Enabled = false;
            this.dtModifyBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtModifyBegin.Location = new System.Drawing.Point(113, 11);
            this.dtModifyBegin.Name = "dtModifyBegin";
            this.dtModifyBegin.Size = new System.Drawing.Size(135, 21);
            this.dtModifyBegin.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "修改时间：";
            // 
            // nvfilterCode
            // 
            this.nvfilterCode.Location = new System.Drawing.Point(84, 40);
            this.nvfilterCode.Name = "nvfilterCode";
            this.nvfilterCode.Size = new System.Drawing.Size(181, 20);
            this.nvfilterCode.TabIndex = 8;
            this.nvfilterCode.EditValueChanged += new System.EventHandler(this.nvfilterCode_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "过滤条件：";
            // 
            // nineSpread1
            // 
            this.nineSpread1.AccessibleDescription = "nineSpread1, Sheet1, Row 0, Column 0, ";
            this.nineSpread1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nineSpread1.FileName = "";
            this.nineSpread1.IsAutoSaveGridStatus = false;
            this.nineSpread1.IsCanCustomConfigColumn = false;
            this.nineSpread1.IsShowExport = true;
            this.nineSpread1.IsShowMenuStrip = true;
            this.nineSpread1.Location = new System.Drawing.Point(0, 75);
            this.nineSpread1.Name = "nineSpread1";
            this.nineSpread1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.nineSpread1_Sheet1});
            this.nineSpread1.Size = new System.Drawing.Size(909, 365);
            this.nineSpread1.Style = NineVigor.FrameWork.WinForms.Controls.StyleType.Fixed3D;
            this.nineSpread1.TabIndex = 3;
            // 
            // nineSpread1_Sheet1
            // 
            this.nineSpread1_Sheet1.Reset();
            nineSpread1_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.nineSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            nineSpread1_Sheet1.ColumnCount = 26;
            nineSpread1_Sheet1.RowCount = 10;
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "序号";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "ICD编码";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "ICD名称";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "院内编码";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "院内名称";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "适用性别";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "诊断标记";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 7).Value = "对照编码";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 8).Value = "星编码";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 9).Value = "有效状态";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 10).Value = "序号";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 11).Value = "操作人";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 12).Value = "操作时间";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 13).Value = "疾病死亡原因";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 14).Value = "疾病分类码";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 15).Value = "标准住院日";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 16).Value = "30种疾病标志";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 17).Value = "传染病标志";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 18).Value = "肿瘤标志";
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(0, 19).Value = "自定义码";
            this.nineSpread1_Sheet1.Columns.Get(0).Label = "序号";
            this.nineSpread1_Sheet1.Columns.Get(0).Visible = false;
            this.nineSpread1_Sheet1.Columns.Get(2).Label = "ICD名称";
            this.nineSpread1_Sheet1.Columns.Get(2).Width = 123F;
            this.nineSpread1_Sheet1.Columns.Get(4).Label = "院内名称";
            this.nineSpread1_Sheet1.Columns.Get(4).Width = 95F;
            this.nineSpread1_Sheet1.Columns.Get(5).Label = "适用性别";
            this.nineSpread1_Sheet1.Columns.Get(5).Width = 65F;
            this.nineSpread1_Sheet1.Columns.Get(6).Label = "诊断标记";
            this.nineSpread1_Sheet1.Columns.Get(6).Width = 72F;
            this.nineSpread1_Sheet1.Columns.Get(7).Label = "对照编码";
            this.nineSpread1_Sheet1.Columns.Get(7).Width = 67F;
            this.nineSpread1_Sheet1.Columns.Get(13).Label = "疾病死亡原因";
            this.nineSpread1_Sheet1.Columns.Get(13).Width = 100F;
            this.nineSpread1_Sheet1.Columns.Get(14).Label = "疾病分类码";
            this.nineSpread1_Sheet1.Columns.Get(14).Width = 83F;
            this.nineSpread1_Sheet1.Columns.Get(15).Label = "标准住院日";
            this.nineSpread1_Sheet1.Columns.Get(15).Width = 86F;
            this.nineSpread1_Sheet1.Columns.Get(16).Label = "30种疾病标志";
            this.nineSpread1_Sheet1.Columns.Get(16).Width = 94F;
            this.nineSpread1_Sheet1.Columns.Get(17).Label = "传染病标志";
            this.nineSpread1_Sheet1.Columns.Get(17).Width = 87F;
            this.nineSpread1_Sheet1.Columns.Get(20).Visible = false;
            this.nineSpread1_Sheet1.Columns.Get(21).Visible = false;
            this.nineSpread1_Sheet1.Columns.Get(22).Visible = false;
            this.nineSpread1_Sheet1.Columns.Get(23).Visible = false;
            this.nineSpread1_Sheet1.Columns.Get(24).Visible = false;
            this.nineSpread1_Sheet1.Columns.Get(25).Visible = false;
            this.nineSpread1_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode;
            this.nineSpread1_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.nineSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // ucDiagMatience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nineSpread1);
            this.Controls.Add(this.panelTop);
            this.Name = "ucDiagMatience";
            this.Size = new System.Drawing.Size(909, 440);
            this.Load += new System.EventHandler(this.ucDiagMatience_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvfilterCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nineSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nineSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVTextEdit nvfilterCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtModifyBegin;
        private System.Windows.Forms.DateTimePicker dtModifyEnd;
        private NineVigor.FrameWork.WinForms.Controls.NineSpread nineSpread1;
        private FarPoint.Win.Spread.SheetView nineSpread1_Sheet1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox cbValid;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox enableCheckTime;
    }
}
