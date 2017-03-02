namespace NineVigor.Components.HealthRecord.Common
{
    partial class ucDiagNoseSelect
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
            this.dataGridICD = new System.Windows.Forms.DataGridView();
            this.cbFuzzy = new System.Windows.Forms.CheckBox();
            this.PanelMain = new  System.Windows.Forms.Panel();
            this.neuLblDesc = new System.Windows.Forms.Label();
            this.neuLabel3 = new System.Windows.Forms.Label();
            this.neuLblFourDesc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.neuLblThreeDesc = new System.Windows.Forms.Label();
            this.neuLabel1 = new System.Windows.Forms.Label();
            this.neuLabel2 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lblSet = new System.Windows.Forms.LinkLabel();
            this.lblTip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridICD)).BeginInit();
            this.PanelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridICD
            // 
            this.dataGridICD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridICD.Location = new System.Drawing.Point(0, 0);
            this.dataGridICD.MultiSelect = false;
            this.dataGridICD.Name = "dataGridICD";
            this.dataGridICD.ReadOnly = true;
            this.dataGridICD.RowHeadersVisible = false;
            this.dataGridICD.RowTemplate.Height = 23;
            this.dataGridICD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridICD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridICD.Size = new System.Drawing.Size(456, 178);
            this.dataGridICD.TabIndex = 0;
            this.dataGridICD.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridICD_Scroll);
            this.dataGridICD.Enter += new System.EventHandler(this.dataGridICD_Enter);
            this.dataGridICD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridICD_CellDoubleClick);
            this.dataGridICD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridICD_KeyDown);
            // 
            // cbFuzzy
            // 
            this.cbFuzzy.AutoSize = true;
            this.cbFuzzy.Location = new System.Drawing.Point(537, 9);
            this.cbFuzzy.Name = "cbFuzzy";
            this.cbFuzzy.Size = new System.Drawing.Size(72, 16);
            
            this.cbFuzzy.TabIndex = 0;
            this.cbFuzzy.Text = "模糊查询";
            this.cbFuzzy.UseVisualStyleBackColor = true;
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.neuLblDesc);
            this.PanelMain.Controls.Add(this.neuLabel3);
            this.PanelMain.Controls.Add(this.neuLblFourDesc);
            this.PanelMain.Controls.Add(this.panel2);
            this.PanelMain.Controls.Add(this.neuLblThreeDesc);
            this.PanelMain.Controls.Add(this.neuLabel1);
            this.PanelMain.Controls.Add(this.neuLabel2);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 27);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(663, 178);
            
            this.PanelMain.TabIndex = 5;
            // 
            // neuLblDesc
            // 
            this.neuLblDesc.ForeColor = System.Drawing.Color.Red;
            this.neuLblDesc.Location = new System.Drawing.Point(496, 99);
            this.neuLblDesc.Name = "neuLblDesc";
            this.neuLblDesc.Size = new System.Drawing.Size(165, 59);
            
            this.neuLblDesc.TabIndex = 7;
            this.neuLblDesc.Text = "XXXX";
            // 
            // neuLabel3
            // 
            this.neuLabel3.AutoSize = true;
            this.neuLabel3.ForeColor = System.Drawing.Color.Black;
            this.neuLabel3.Location = new System.Drawing.Point(456, 99);
            this.neuLabel3.Name = "neuLabel3";
            this.neuLabel3.Size = new System.Drawing.Size(41, 12);
            
            this.neuLabel3.TabIndex = 6;
            this.neuLabel3.Text = "描述：";
            // 
            // neuLblFourDesc
            // 
            this.neuLblFourDesc.ForeColor = System.Drawing.Color.Red;
            this.neuLblFourDesc.Location = new System.Drawing.Point(514, 51);
            this.neuLblFourDesc.Name = "neuLblFourDesc";
            this.neuLblFourDesc.Size = new System.Drawing.Size(150, 41);
            
            this.neuLblFourDesc.TabIndex = 9;
            this.neuLblFourDesc.Text = "XXXX";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridICD);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 178);
            this.panel2.TabIndex = 1;
            // 
            // neuLblThreeDesc
            // 
            this.neuLblThreeDesc.ForeColor = System.Drawing.Color.Red;
            this.neuLblThreeDesc.Location = new System.Drawing.Point(513, 3);
            this.neuLblThreeDesc.Name = "neuLblThreeDesc";
            this.neuLblThreeDesc.Size = new System.Drawing.Size(151, 44);
            
            this.neuLblThreeDesc.TabIndex = 8;
            this.neuLblThreeDesc.Text = "XXXX";
            // 
            // neuLabel1
            // 
            this.neuLabel1.AutoSize = true;
            this.neuLabel1.ForeColor = System.Drawing.Color.Black;
            this.neuLabel1.Location = new System.Drawing.Point(458, 8);
            this.neuLabel1.Name = "neuLabel1";
            this.neuLabel1.Size = new System.Drawing.Size(53, 12);
            
            this.neuLabel1.TabIndex = 4;
            this.neuLabel1.Text = "三位类目";
            // 
            // neuLabel2
            // 
            this.neuLabel2.AutoSize = true;
            this.neuLabel2.ForeColor = System.Drawing.Color.Black;
            this.neuLabel2.Location = new System.Drawing.Point(458, 50);
            this.neuLabel2.Name = "neuLabel2";
            this.neuLabel2.Size = new System.Drawing.Size(53, 12);
           
            this.neuLabel2.TabIndex = 5;
            this.neuLabel2.Text = "四位亚目";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Honeydew;
            this.Panel1.Controls.Add(this.cbFuzzy);
            this.Panel1.Controls.Add(this.lblSet);
            this.Panel1.Controls.Add(this.lblTip);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(663, 27);
           
            this.Panel1.TabIndex = 3;
            // 
            // lblSet
            // 
            this.lblSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSet.AutoSize = true;
            this.lblSet.Location = new System.Drawing.Point(610, 12);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(29, 12);
            
            this.lblSet.TabIndex = 3;
            this.lblSet.TabStop = true;
            this.lblSet.Text = "设置";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTip.Location = new System.Drawing.Point(7, 9);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(29, 12);
           
            this.lblTip.TabIndex = 0;
            this.lblTip.Text = "提示";
            // 
            // ucDiagNoseSelect2013
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.Panel1);
            this.Name = "ucDiagNoseSelect2013";
            this.Size = new System.Drawing.Size(663, 205);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridICD)).EndInit();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridICD;
        private System.Windows.Forms.CheckBox cbFuzzy;
        private System.Windows.Forms.Panel PanelMain;
        protected System.Windows.Forms.Panel Panel1;
        protected System.Windows.Forms.LinkLabel lblSet;
        protected System.Windows.Forms.Label lblTip;
        protected System.Windows.Forms.Label neuLabel1;
        protected System.Windows.Forms.Label neuLabel3;
        protected System.Windows.Forms.Label neuLabel2;
        protected System.Windows.Forms.Label neuLblDesc;
        protected System.Windows.Forms.Label neuLblFourDesc;
        protected System.Windows.Forms.Label neuLblThreeDesc;
        private System.Windows.Forms.Panel panel2;
    }
}
