namespace NineVigor.Components.HealthRecord.CasTrack
{
    partial class ucMetCasReCallPrintPanel
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
            this.PicBoxBarCode = new System.Windows.Forms.PictureBox();
            this.lblZYH = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOutDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBarCode)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicBoxBarCode
            // 
            this.PicBoxBarCode.Location = new System.Drawing.Point(11, 83);
            this.PicBoxBarCode.Name = "PicBoxBarCode";
            this.PicBoxBarCode.Size = new System.Drawing.Size(165, 64);
          
            this.PicBoxBarCode.TabIndex = 18;
            this.PicBoxBarCode.TabStop = false;
            // 
            // lblZYH
            // 
            this.lblZYH.AutoSize = true;
            this.lblZYH.Font = new System.Drawing.Font("宋体", 48F, System.Drawing.FontStyle.Bold);
            this.lblZYH.Location = new System.Drawing.Point(1, 8);
            this.lblZYH.Name = "lblZYH";
            this.lblZYH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblZYH.Size = new System.Drawing.Size(358, 64);
            this.lblZYH.TabIndex = 19;
            this.lblZYH.Text = "0001234567";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.lblDept.Location = new System.Drawing.Point(150, 154);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(198, 24);
            this.lblDept.TabIndex = 20;
            this.lblDept.Text = "呼吸与重症二科2";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(179, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(180, 33);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "张三之大宝";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblOutDate);
            this.panel1.Controls.Add(this.lblDept);
            this.panel1.Controls.Add(this.lblZYH);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.PicBoxBarCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 202);
            this.panel1.TabIndex = 22;
            // 
            // lblOutDate
            // 
            this.lblOutDate.AutoSize = true;
            this.lblOutDate.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.lblOutDate.Location = new System.Drawing.Point(13, 154);
            this.lblOutDate.Name = "lblOutDate";
            this.lblOutDate.Size = new System.Drawing.Size(140, 24);
            this.lblOutDate.TabIndex = 22;
            this.lblOutDate.Text = "2013-12-24";
            // 
            // ucMetCasReCallPrintPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucMetCasReCallPrintPanel";
            this.Size = new System.Drawing.Size(364, 202);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBarCode)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxBarCode;
        private System.Windows.Forms.Label lblZYH;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOutDate;
    }
}
