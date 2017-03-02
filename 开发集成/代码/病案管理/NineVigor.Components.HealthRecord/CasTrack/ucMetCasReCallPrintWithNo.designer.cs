namespace NineVigor.Components.HealthRecord.CasTrack
{
    partial class ucMetCasReCallPrintWithNo
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
            FarPoint.Win.BevelBorder bevelBorder1 = new FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered, System.Drawing.SystemColors.ControlLightLight, System.Drawing.SystemColors.ControlDark, 1, false, false, true, true);
            FarPoint.Win.BevelBorder bevelBorder2 = new FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered, System.Drawing.SystemColors.ControlLightLight, System.Drawing.SystemColors.ControlDark, 1, false, false, true, true);
            FarPoint.Win.Spread.CellType.TextCellType textCellType1 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.LineBorder lineBorder1 = new FarPoint.Win.LineBorder(System.Drawing.SystemColors.WindowFrame);
            FarPoint.Win.LineBorder lineBorder2 = new FarPoint.Win.LineBorder(System.Drawing.SystemColors.WindowFrame, 1, false, true, true, true);
            FarPoint.Win.LineBorder lineBorder3 = new FarPoint.Win.LineBorder(System.Drawing.SystemColors.WindowFrame, 1, true, false, true, true);
            FarPoint.Win.Spread.CellType.TextCellType textCellType2 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.LineBorder lineBorder4 = new FarPoint.Win.LineBorder(System.Drawing.SystemColors.WindowFrame, 1, false, false, true, true);
            FarPoint.Win.LineBorder lineBorder5 = new FarPoint.Win.LineBorder(System.Drawing.SystemColors.WindowFrame, 1, false, false, false, false);
            FarPoint.Win.Spread.TipAppearance tipAppearance1 = new FarPoint.Win.Spread.TipAppearance();
            this.neuGroupBox1 = new System.Windows.Forms.GroupBox();
            this.neuLabel5 = new System.Windows.Forms.Label();
            this.neuTextBox1 = new System.Windows.Forms.TextBox();
            this.cmbOperCode = new NineVigor.FrameWork.WinForms.Controls.NineComboBox(this.components);
            this.neuLabel4 = new System.Windows.Forms.Label();
            this.neuLabel3 = new System.Windows.Forms.Label();
            this.cmbDept = new NineVigor.FrameWork.WinForms.Controls.NineComboBox(this.components);
            this.dtpEndDate = new NineVigor.FrameWork.WinForms.Controls.Common.NVDateTimePicker();
            this.ntbNM = new System.Windows.Forms.TextBox();
            this.dtpBeginDate = new NineVigor.FrameWork.WinForms.Controls.Common.NVDateTimePicker();
            this.neuLabel2 = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.neuLabel1 = new System.Windows.Forms.Label();
            this.neuSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.neuSpread2 = new NineVigor.FrameWork.WinForms.Controls.NineSpread();
            this.neuGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neuSpread1_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neuSpread2)).BeginInit();
            this.SuspendLayout();
            // 
            // neuGroupBox1
            // 
            this.neuGroupBox1.Controls.Add(this.neuLabel5);
            this.neuGroupBox1.Controls.Add(this.neuTextBox1);
            this.neuGroupBox1.Controls.Add(this.cmbOperCode);
            this.neuGroupBox1.Controls.Add(this.neuLabel4);
            this.neuGroupBox1.Controls.Add(this.neuLabel3);
            this.neuGroupBox1.Controls.Add(this.cmbDept);
            this.neuGroupBox1.Controls.Add(this.dtpEndDate);
            this.neuGroupBox1.Controls.Add(this.ntbNM);
            this.neuGroupBox1.Controls.Add(this.dtpBeginDate);
            this.neuGroupBox1.Controls.Add(this.neuLabel2);
            this.neuGroupBox1.Controls.Add(this.lblDept);
            this.neuGroupBox1.Controls.Add(this.neuLabel1);
            this.neuGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.neuGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.neuGroupBox1.Name = "neuGroupBox1";
            this.neuGroupBox1.Size = new System.Drawing.Size(885, 70);
            
            this.neuGroupBox1.TabIndex = 6;
            this.neuGroupBox1.TabStop = false;
            // 
            // neuLabel5
            // 
            this.neuLabel5.AutoSize = true;
            this.neuLabel5.ForeColor = System.Drawing.Color.Blue;
            this.neuLabel5.Location = new System.Drawing.Point(446, 47);
            this.neuLabel5.Name = "neuLabel5";
            this.neuLabel5.Size = new System.Drawing.Size(77, 12);
            
            this.neuLabel5.TabIndex = 14;
            this.neuLabel5.Text = "指定打印号：";
            this.neuLabel5.Visible = false;
            // 
            // neuTextBox1
            // 
            
            this.neuTextBox1.Location = new System.Drawing.Point(527, 43);
            this.neuTextBox1.Name = "neuTextBox1";
            this.neuTextBox1.Size = new System.Drawing.Size(149, 21);
            
            this.neuTextBox1.TabIndex = 15;
            this.neuTextBox1.Visible = false;
            // 
            // cmbOperCode
            // 
            this.cmbOperCode.ArrowBackColor = System.Drawing.SystemColors.Control;
            this.cmbOperCode.DropDownHeight = 424;
            this.cmbOperCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperCode.FormattingEnabled = true;
            this.cmbOperCode.IntegralHeight = false;
            this.cmbOperCode.IsEnter2Tab = false;
            this.cmbOperCode.IsFlat = false;
            this.cmbOperCode.IsLike = true;
            this.cmbOperCode.IsListOnly = false;
            this.cmbOperCode.IsPopForm = true;
            this.cmbOperCode.IsShowCustomerList = false;
            this.cmbOperCode.IsShowID = false;
            this.cmbOperCode.Location = new System.Drawing.Point(67, 45);
            this.cmbOperCode.Name = "cmbOperCode";
            this.cmbOperCode.PopForm = null;
            this.cmbOperCode.ShowCustomerList = false;
            
            this.cmbOperCode.Size = new System.Drawing.Size(132, 20);
            
            this.cmbOperCode.TabIndex = 13;
            this.cmbOperCode.Tag = "";
            this.cmbOperCode.ToolBarUse = false;
            // 
            // neuLabel4
            // 
            this.neuLabel4.AutoSize = true;
            this.neuLabel4.ForeColor = System.Drawing.Color.Blue;
            this.neuLabel4.Location = new System.Drawing.Point(18, 50);
            this.neuLabel4.Name = "neuLabel4";
            this.neuLabel4.Size = new System.Drawing.Size(47, 12);
            
            this.neuLabel4.TabIndex = 12;
            this.neuLabel4.Text = "回收人:";
            // 
            // neuLabel3
            // 
            this.neuLabel3.AutoSize = true;
            this.neuLabel3.ForeColor = System.Drawing.Color.Blue;
            this.neuLabel3.Location = new System.Drawing.Point(246, 49);
            this.neuLabel3.Name = "neuLabel3";
            this.neuLabel3.Size = new System.Drawing.Size(47, 12);
            
            this.neuLabel3.TabIndex = 10;
            this.neuLabel3.Text = "病案号:";
            // 
            // cmbDept
            // 
            this.cmbDept.ArrowBackColor = System.Drawing.SystemColors.Control;
            this.cmbDept.DropDownHeight = 424;
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.IntegralHeight = false;
            this.cmbDept.IsEnter2Tab = false;
            this.cmbDept.IsFlat = false;
            this.cmbDept.IsLike = true;
            this.cmbDept.IsListOnly = false;
            this.cmbDept.IsPopForm = true;
            this.cmbDept.IsShowCustomerList = false;
            this.cmbDept.IsShowID = false;
            this.cmbDept.Location = new System.Drawing.Point(474, 17);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.PopForm = null;
            this.cmbDept.ShowCustomerList = false;
            
            this.cmbDept.Size = new System.Drawing.Size(132, 20);
            
            this.cmbDept.TabIndex = 3;
            this.cmbDept.Tag = "";
            this.cmbDept.ToolBarUse = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.IsEnter2Tab = false;
            this.dtpEndDate.Location = new System.Drawing.Point(265, 17);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(160, 21);
            
            this.dtpEndDate.TabIndex = 1;
            // 
            // ntbNM
            // 
          
            this.ntbNM.Location = new System.Drawing.Point(299, 44);
            this.ntbNM.Name = "ntbNM";
            this.ntbNM.Size = new System.Drawing.Size(126, 21);
            
            this.ntbNM.TabIndex = 11;
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBeginDate.IsEnter2Tab = false;
            this.dtpBeginDate.Location = new System.Drawing.Point(67, 17);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(165, 21);
            this.dtpBeginDate.TabIndex = 1;
            // 
            // neuLabel2
            // 
            this.neuLabel2.AutoSize = true;
            this.neuLabel2.ForeColor = System.Drawing.Color.Blue;
            this.neuLabel2.Location = new System.Drawing.Point(240, 21);
            this.neuLabel2.Name = "neuLabel2";
            this.neuLabel2.Size = new System.Drawing.Size(17, 12);
            
            this.neuLabel2.TabIndex = 0;
            this.neuLabel2.Text = "至";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.ForeColor = System.Drawing.Color.Blue;
            this.lblDept.Location = new System.Drawing.Point(437, 21);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(35, 12);
           
            this.lblDept.TabIndex = 0;
            this.lblDept.Text = "部门:";
            // 
            // neuLabel1
            // 
            this.neuLabel1.AutoSize = true;
            this.neuLabel1.ForeColor = System.Drawing.Color.Blue;
            this.neuLabel1.Location = new System.Drawing.Point(6, 22);
            this.neuLabel1.Name = "neuLabel1";
            this.neuLabel1.Size = new System.Drawing.Size(59, 12);
            
            this.neuLabel1.TabIndex = 0;
            this.neuLabel1.Text = "回收日期:";
            // 
            // neuSpread1_Sheet1
            // 
            this.neuSpread1_Sheet1.Reset();
            this.neuSpread1_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.neuSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.neuSpread1_Sheet1.ColumnCount = 10;
            this.neuSpread1_Sheet1.ColumnHeader.RowCount = 3;
            this.neuSpread1_Sheet1.RowCount = 5;
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(0, 0).BackColor = System.Drawing.Color.White;
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(0, 0).Border = bevelBorder1;
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(0, 0).ColumnSpan = 10;
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(0, 0).Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "病案回收查询打印";
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(1, 0).BackColor = System.Drawing.Color.White;
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(1, 0).Border = bevelBorder2;
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(1, 0).CellType = textCellType1;
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(1, 0).ColumnSpan = 10;
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(1, 0).ForeColor = System.Drawing.Color.Black;
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(1, 0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(2, 0).Border = lineBorder1;
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(2, 0).Value = "科室名称";
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(2, 1).Value = "病案号";
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(2, 2).Value = "住院次数";
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(2, 3).Value = "患者姓名";
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(2, 4).Value = "回收时间";
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(2, 5).Value = "回收人";
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(2, 6).Value = "入院日期";
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(2, 7).Value = "出院日期";
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(2, 8).Value = "出院日期";
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(2, 9).Value = "上架号";
            this.neuSpread1_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off;
            this.neuSpread1_Sheet1.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.White;
            this.neuSpread1_Sheet1.ColumnHeader.DefaultStyle.Border = lineBorder2;
            this.neuSpread1_Sheet1.ColumnHeader.DefaultStyle.Parent = "HeaderDefault";
            this.neuSpread1_Sheet1.ColumnHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off;
            this.neuSpread1_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off;
            this.neuSpread1_Sheet1.ColumnHeader.Rows.Get(0).Height = 50F;
            this.neuSpread1_Sheet1.ColumnHeader.Rows.Get(1).Height = 30F;
            this.neuSpread1_Sheet1.ColumnHeader.Rows.Get(2).Height = 30F;
            this.neuSpread1_Sheet1.Columns.Get(0).Border = lineBorder3;
            this.neuSpread1_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.neuSpread1_Sheet1.Columns.Get(0).Label = "科室名称";
            this.neuSpread1_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.neuSpread1_Sheet1.Columns.Get(0).Width = 176F;
            this.neuSpread1_Sheet1.Columns.Get(1).CellType = textCellType2;
            this.neuSpread1_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            this.neuSpread1_Sheet1.Columns.Get(1).Label = "病案号";
            this.neuSpread1_Sheet1.Columns.Get(1).Width = 99F;
            this.neuSpread1_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
            this.neuSpread1_Sheet1.Columns.Get(2).Label = "住院次数";
            this.neuSpread1_Sheet1.Columns.Get(2).Width = 42F;
            this.neuSpread1_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
            this.neuSpread1_Sheet1.Columns.Get(3).Label = "患者姓名";
            this.neuSpread1_Sheet1.Columns.Get(3).Width = 81F;
            this.neuSpread1_Sheet1.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            this.neuSpread1_Sheet1.Columns.Get(4).Label = "回收时间";
            this.neuSpread1_Sheet1.Columns.Get(4).Width = 148F;
            this.neuSpread1_Sheet1.Columns.Get(5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
            this.neuSpread1_Sheet1.Columns.Get(5).Label = "回收人";
            this.neuSpread1_Sheet1.Columns.Get(5).Width = 84F;
            this.neuSpread1_Sheet1.Columns.Get(6).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
            this.neuSpread1_Sheet1.Columns.Get(6).Label = "入院日期";
            this.neuSpread1_Sheet1.Columns.Get(6).Width = 95F;
            this.neuSpread1_Sheet1.Columns.Get(7).Label = "出院日期";
            this.neuSpread1_Sheet1.Columns.Get(7).Width = 104F;
            this.neuSpread1_Sheet1.Columns.Get(8).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
            this.neuSpread1_Sheet1.Columns.Get(8).Label = "出院日期";
            this.neuSpread1_Sheet1.Columns.Get(8).Visible = false;
            this.neuSpread1_Sheet1.Columns.Get(8).Width = 95F;
            this.neuSpread1_Sheet1.Columns.Get(9).Label = "上架号";
            this.neuSpread1_Sheet1.Columns.Get(9).Locked = true;
            this.neuSpread1_Sheet1.Columns.Get(9).Width = 188F;
            this.neuSpread1_Sheet1.DataAutoCellTypes = false;
            this.neuSpread1_Sheet1.DataAutoSizeColumns = false;
            this.neuSpread1_Sheet1.DefaultStyle.Border = lineBorder4;
            this.neuSpread1_Sheet1.DefaultStyle.Font = new System.Drawing.Font("宋体", 10F);
            this.neuSpread1_Sheet1.DefaultStyle.Parent = "DataAreaDefault";
            this.neuSpread1_Sheet1.GrayAreaBackColor = System.Drawing.Color.White;
            this.neuSpread1_Sheet1.RowHeader.AutoText = FarPoint.Win.Spread.HeaderAutoText.Blank;
            this.neuSpread1_Sheet1.RowHeader.Columns.Default.Resizable = true;
            this.neuSpread1_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off;
            this.neuSpread1_Sheet1.RowHeader.Columns.Get(0).Width = 21F;
            this.neuSpread1_Sheet1.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.White;
            this.neuSpread1_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefault";
            this.neuSpread1_Sheet1.RowHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off;
            this.neuSpread1_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off;
            this.neuSpread1_Sheet1.RowHeader.Visible = false;
            this.neuSpread1_Sheet1.Rows.Default.Height = 25F;
            this.neuSpread1_Sheet1.SelectionUnit = FarPoint.Win.Spread.Model.SelectionUnit.Row;
            this.neuSpread1_Sheet1.SheetCornerHorizontalGridLine = new FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None);
            this.neuSpread1_Sheet1.SheetCornerStyle.BackColor = System.Drawing.Color.White;
            this.neuSpread1_Sheet1.SheetCornerStyle.Border = lineBorder5;
            this.neuSpread1_Sheet1.SheetCornerStyle.Parent = "CornerDefault";
            this.neuSpread1_Sheet1.SheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.On;
            this.neuSpread1_Sheet1.SheetCornerVerticalGridLine = new FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None);
            this.neuSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // neuSpread2
            // 
            this.neuSpread2.About = "3.0.2004.2005";
            this.neuSpread2.AccessibleDescription = "neuSpread2, Sheet1, Row 0, Column 0, ";
            this.neuSpread2.BackColor = System.Drawing.Color.White;
            this.neuSpread2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.neuSpread2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.neuSpread2.FileName = "";
            this.neuSpread2.Font = new System.Drawing.Font("宋体", 10F);
            this.neuSpread2.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.neuSpread2.IsAutoSaveGridStatus = false;
            this.neuSpread2.IsCanCustomConfigColumn = false;
            this.neuSpread2.IsShowExport = true;
            this.neuSpread2.IsShowMenuStrip = true;
            this.neuSpread2.Location = new System.Drawing.Point(0, 70);
            this.neuSpread2.Name = "neuSpread2";
            this.neuSpread2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.neuSpread2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.neuSpread1_Sheet1});
            this.neuSpread2.Size = new System.Drawing.Size(885, 503);
            
            this.neuSpread2.TabIndex = 9;
            tipAppearance1.BackColor = System.Drawing.SystemColors.Info;
            tipAppearance1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            tipAppearance1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.neuSpread2.TextTipAppearance = tipAppearance1;
            this.neuSpread2.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            // 
            // ucMetCasReCallPrintWithNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.neuSpread2);
            this.Controls.Add(this.neuGroupBox1);
            this.Name = "ucMetCasReCallPrintWithNo";
            this.Size = new System.Drawing.Size(885, 573);
            this.neuGroupBox1.ResumeLayout(false);
            this.neuGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neuSpread1_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neuSpread2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox neuGroupBox1;
        private System.Windows.Forms.Label neuLabel3;
        private System.Windows.Forms.TextBox ntbNM;
        private NineVigor.FrameWork.WinForms.Controls.NineComboBox cmbDept;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVDateTimePicker dtpEndDate;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVDateTimePicker dtpBeginDate;
        private System.Windows.Forms.Label neuLabel2;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label neuLabel1;
        private FarPoint.Win.Spread.SheetView neuSpread1_Sheet1;
        private NineVigor.FrameWork.WinForms.Controls.NineSpread neuSpread2;
        private NineVigor.FrameWork.WinForms.Controls.NineComboBox cmbOperCode;
        private System.Windows.Forms.Label neuLabel4;
        private System.Windows.Forms.Label neuLabel5;
        private System.Windows.Forms.TextBox neuTextBox1;
    }
}
