namespace NineVigor.Components.HealthRecord.CasPage
{
    partial class ucCaseMainInfo
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
            this.tabPageList = new DevExpress.XtraTab.XtraTabControl();
            this.ucBaseInfo = new DevExpress.XtraTab.XtraTabPage();
            this.ucDiagnoseInfo = new DevExpress.XtraTab.XtraTabPage();
            this.ucOperationInfo = new DevExpress.XtraTab.XtraTabPage();
            this.ucExtBaseInfo = new DevExpress.XtraTab.XtraTabPage();
            this.emrPanel3 = new NineVigor.FrameWork.WinForms.EmrControls.EmrPanel();
            this.comHosCode = new NineVigor.FrameWork.WinForms.Controls.NineComboBox(this.components);
            this.nvLabel2 = new NineVigor.FrameWork.WinForms.Controls.Common.NVLabel();
            this.hnListTextBox1 = new NineVigor.FrameWork.WinForms.Controls.HNListTextBox();
            this.nvLabel1 = new NineVigor.FrameWork.WinForms.Controls.Common.NVLabel();
            this.lblInpatientNo = new NineVigor.FrameWork.WinForms.Controls.Common.NVLabel();
            this.txtPatientNOSearch = new System.Windows.Forms.TextBox();
            this.treePatientList = new DevExpress.XtraTreeList.TreeList();
            this.emrPanel2.SuspendLayout();
            this.emrPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPageList)).BeginInit();
            this.tabPageList.SuspendLayout();
            this.emrPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treePatientList)).BeginInit();
            this.SuspendLayout();
            // 
            // emrPanel2
            // 
            this.emrPanel2.Controls.Add(this.treePatientList);
            this.emrPanel2.Size = new System.Drawing.Size(158, 397);
            // 
            // emrPanel1
            // 
            this.emrPanel1.Location = new System.Drawing.Point(158, 368);
            this.emrPanel1.Size = new System.Drawing.Size(723, 29);
            // 
            // emrPanel4
            // 
            this.emrPanel4.Controls.Add(this.tabPageList);
            this.emrPanel4.Controls.Add(this.emrPanel3);
            this.emrPanel4.Location = new System.Drawing.Point(158, 0);
            this.emrPanel4.Size = new System.Drawing.Size(723, 368);
            // 
            // tabPageList
            // 
            this.tabPageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageList.Location = new System.Drawing.Point(0, 35);
            this.tabPageList.Name = "tabPageList";
            this.tabPageList.SelectedTabPage = this.ucBaseInfo;
            this.tabPageList.Size = new System.Drawing.Size(723, 333);
            this.tabPageList.TabIndex = 1;
            this.tabPageList.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.ucBaseInfo,
            this.ucDiagnoseInfo,
            this.ucOperationInfo,
            this.ucExtBaseInfo});
            // 
            // ucBaseInfo
            // 
            this.ucBaseInfo.AllowTouchScroll = true;
            this.ucBaseInfo.AutoScroll = true;
            this.ucBaseInfo.Name = "ucBaseInfo";
            this.ucBaseInfo.ScrollBarSmallChange = 2;
            this.ucBaseInfo.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ucBaseInfo.Size = new System.Drawing.Size(717, 304);
            this.ucBaseInfo.Text = "基本信息";
            // 
            // ucDiagnoseInfo
            // 
            this.ucDiagnoseInfo.Name = "ucDiagnoseInfo";
            this.ucDiagnoseInfo.Size = new System.Drawing.Size(860, 675);
            this.ucDiagnoseInfo.Text = "诊断信息";
            // 
            // ucOperationInfo
            // 
            this.ucOperationInfo.Name = "ucOperationInfo";
            this.ucOperationInfo.Size = new System.Drawing.Size(860, 675);
            this.ucOperationInfo.Text = "手术信息";
            // 
            // ucExtBaseInfo
            // 
            this.ucExtBaseInfo.AllowTouchScroll = true;
            this.ucExtBaseInfo.AlwaysScrollActiveControlIntoView = false;
            this.ucExtBaseInfo.AutoScroll = true;
            this.ucExtBaseInfo.FireScrollEventOnMouseWheel = true;
            this.ucExtBaseInfo.Name = "ucExtBaseInfo";
            this.ucExtBaseInfo.Size = new System.Drawing.Size(717, 304);
            this.ucExtBaseInfo.Text = "首页扩展信息";
            // 
            // emrPanel3
            // 
            this.emrPanel3.Controls.Add(this.comHosCode);
            this.emrPanel3.Controls.Add(this.nvLabel2);
            this.emrPanel3.Controls.Add(this.hnListTextBox1);
            this.emrPanel3.Controls.Add(this.nvLabel1);
            this.emrPanel3.Controls.Add(this.lblInpatientNo);
            this.emrPanel3.Controls.Add(this.txtPatientNOSearch);
            this.emrPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.emrPanel3.Level = NineVigor.FrameWork.WinForms.EmrControls.EmrPanel.PanelLevel.None;
            this.emrPanel3.Location = new System.Drawing.Point(0, 0);
            this.emrPanel3.Name = "emrPanel3";
            this.emrPanel3.Size = new System.Drawing.Size(723, 35);
            this.emrPanel3.TabIndex = 3;
            // 
            // comHosCode
            // 
            this.comHosCode.ArrowBackColor = System.Drawing.SystemColors.Control;
            this.comHosCode.DropDownHeight = 424;
            this.comHosCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comHosCode.FormattingEnabled = true;
            this.comHosCode.IntegralHeight = false;
            this.comHosCode.IsEnter2Tab = false;
            this.comHosCode.IsFlat = false;
            this.comHosCode.IsLike = true;
            this.comHosCode.IsListOnly = false;
            this.comHosCode.IsPopForm = true;
            this.comHosCode.IsShowCustomerList = false;
            this.comHosCode.IsShowID = false;
            this.comHosCode.Location = new System.Drawing.Point(510, 10);
            this.comHosCode.Name = "comHosCode";
            this.comHosCode.PopForm = null;
            this.comHosCode.ShowAll = false;
            this.comHosCode.ShowCustomerList = false;
            this.comHosCode.ShowID = false;
            this.comHosCode.Size = new System.Drawing.Size(163, 20);
            this.comHosCode.Style = NineVigor.FrameWork.WinForms.Controls.StyleType.Flat;
            this.comHosCode.TabIndex = 9;
            this.comHosCode.Tag = "";
            this.comHosCode.ToolBarUse = false;
            // 
            // nvLabel2
            // 
            this.nvLabel2.Location = new System.Drawing.Point(430, 12);
            this.nvLabel2.Name = "nvLabel2";
            this.nvLabel2.Size = new System.Drawing.Size(72, 14);
            this.nvLabel2.TabIndex = 8;
            this.nvLabel2.Text = "组织机构代码";
            // 
            // hnListTextBox1
            // 
            this.hnListTextBox1.EnterVisiable = false;
            this.hnListTextBox1.IsFind = false;
            this.hnListTextBox1.ListBoxHeight = 100;
            this.hnListTextBox1.ListBoxWidth = 100;
            this.hnListTextBox1.Location = new System.Drawing.Point(264, 9);
            this.hnListTextBox1.Name = "hnListTextBox1";
            this.hnListTextBox1.OmitFilter = true;
            this.hnListTextBox1.SelectedItem = null;
            this.hnListTextBox1.SelectNone = true;
            this.hnListTextBox1.ShowID = true;
            this.hnListTextBox1.Size = new System.Drawing.Size(100, 21);
            this.hnListTextBox1.TabIndex = 7;
            // 
            // nvLabel1
            // 
            this.nvLabel1.Location = new System.Drawing.Point(204, 12);
            this.nvLabel1.Name = "nvLabel1";
            this.nvLabel1.Size = new System.Drawing.Size(48, 14);
            this.nvLabel1.TabIndex = 6;
            this.nvLabel1.Text = "入院医生";
            // 
            // lblInpatientNo
            // 
            this.lblInpatientNo.Location = new System.Drawing.Point(6, 12);
            this.lblInpatientNo.Name = "lblInpatientNo";
            this.lblInpatientNo.Size = new System.Drawing.Size(36, 14);
            this.lblInpatientNo.TabIndex = 5;
            this.lblInpatientNo.Text = "住院号";
            // 
            // txtPatientNOSearch
            // 
            this.txtPatientNOSearch.Location = new System.Drawing.Point(60, 9);
            this.txtPatientNOSearch.MaxLength = 14;
            this.txtPatientNOSearch.Name = "txtPatientNOSearch";
            this.txtPatientNOSearch.Size = new System.Drawing.Size(119, 21);
            this.txtPatientNOSearch.TabIndex = 2;
            // 
            // treePatientList
            // 
            this.treePatientList.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue;
            this.treePatientList.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue;
            this.treePatientList.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.treePatientList.Appearance.Empty.Options.UseBackColor = true;
            this.treePatientList.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen;
            this.treePatientList.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite;
            this.treePatientList.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.treePatientList.Appearance.EvenRow.Options.UseBackColor = true;
            this.treePatientList.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue;
            this.treePatientList.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.treePatientList.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.treePatientList.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.treePatientList.Appearance.FocusedRow.Options.UseBackColor = true;
            this.treePatientList.Appearance.FocusedRow.Options.UseForeColor = true;
            this.treePatientList.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange;
            this.treePatientList.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange;
            this.treePatientList.Appearance.FooterPanel.Options.UseBackColor = true;
            this.treePatientList.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.treePatientList.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat;
            this.treePatientList.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat;
            this.treePatientList.Appearance.GroupButton.Options.UseBackColor = true;
            this.treePatientList.Appearance.GroupButton.Options.UseBorderColor = true;
            this.treePatientList.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat;
            this.treePatientList.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat;
            this.treePatientList.Appearance.GroupFooter.Options.UseBackColor = true;
            this.treePatientList.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.treePatientList.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange;
            this.treePatientList.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange;
            this.treePatientList.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.treePatientList.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.treePatientList.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray;
            this.treePatientList.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.treePatientList.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan;
            this.treePatientList.Appearance.HorzLine.Options.UseBackColor = true;
            this.treePatientList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.treePatientList.Appearance.OddRow.Options.UseBackColor = true;
            this.treePatientList.Appearance.Preview.BackColor = System.Drawing.Color.Khaki;
            this.treePatientList.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk;
            this.treePatientList.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.treePatientList.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.treePatientList.Appearance.Preview.Options.UseBackColor = true;
            this.treePatientList.Appearance.Preview.Options.UseFont = true;
            this.treePatientList.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.treePatientList.Appearance.Row.Options.UseBackColor = true;
            this.treePatientList.Appearance.VertLine.BackColor = System.Drawing.Color.Tan;
            this.treePatientList.Appearance.VertLine.Options.UseBackColor = true;
            this.treePatientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treePatientList.Location = new System.Drawing.Point(0, 0);
            this.treePatientList.Name = "treePatientList";
            this.treePatientList.OptionsPrint.UsePrintStyles = true;
            this.treePatientList.OptionsView.EnableAppearanceEvenRow = true;
            this.treePatientList.OptionsView.EnableAppearanceOddRow = true;
            this.treePatientList.Size = new System.Drawing.Size(158, 397);
            this.treePatientList.TabIndex = 0;
            // 
            // ucCaseMainInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ucCaseMainInfo";
            this.Size = new System.Drawing.Size(881, 397);
            this.Load += new System.EventHandler(this.ucCaseMainInfo_Load);
            this.emrPanel2.ResumeLayout(false);
            this.emrPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPageList)).EndInit();
            this.tabPageList.ResumeLayout(false);
            this.emrPanel3.ResumeLayout(false);
            this.emrPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treePatientList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabPageList;
        private DevExpress.XtraTab.XtraTabPage ucBaseInfo;
        private DevExpress.XtraTab.XtraTabPage ucDiagnoseInfo;
        private DevExpress.XtraTab.XtraTabPage ucOperationInfo;
        private NineVigor.FrameWork.WinForms.EmrControls.EmrPanel emrPanel3;
        private System.Windows.Forms.TextBox txtPatientNOSearch;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVLabel nvLabel1;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVLabel lblInpatientNo;
        private NineVigor.FrameWork.WinForms.Controls.HNListTextBox hnListTextBox1;
        private NineVigor.FrameWork.WinForms.Controls.Common.NVLabel nvLabel2;
        private NineVigor.FrameWork.WinForms.Controls.NineComboBox comHosCode;
        private DevExpress.XtraTreeList.TreeList treePatientList;
        private DevExpress.XtraTab.XtraTabPage ucExtBaseInfo;


    }
}
