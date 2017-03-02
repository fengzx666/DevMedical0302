using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NineVigor.Components.HealthRecord.Common;

namespace NineVigor.Components.HealthRecord.CasPage
{
    public partial class ucCaseMainInfo : NineVigor.FrameWork.WinForms.LayoutControls.Layout18
    {
        public ucCaseMainInfo()
        {
            InitializeComponent();
            this.emrPanel1.Visible =false;
           // this.emrPanel3.BackColor = Color.FromArgb(249, 255, 251);
         //   this.emrPanel4.BackColor = Color.FromArgb(208, 229, 223);

        }

        #region 冯志欣 判断住院医生是否是必须录入选项

        private bool showLeftTree = false;

        [Category("控件设置"), Description("是否显示左边患者树列表")]
        public bool ShowLeftTree
        {
            get
            {
                return showLeftTree;
            }
            set
            {
                showLeftTree = value;
            }
        }
        #endregion

        #region 方法事件
        private void ucCaseMainInfo_Load(object sender, EventArgs e)
        {
            InitLoadParam();
            InitControlInfo();
        }
        #endregion
        #region 私有方法事件

        private void InitLoadParam()
        {
            this.emrPanel2.Visible = ShowLeftTree;
        }

        private void InitControlInfo()
        {
            ucMrsBaseInfo mrsBaseInfo = new ucMrsBaseInfo();
           // mrsBaseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageList.TabPages[0].Controls.Add(mrsBaseInfo);
            ucDiagnose mrsDiagnoseInfo = new ucDiagnose();
            mrsDiagnoseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageList.TabPages[1].Controls.Add(mrsDiagnoseInfo);
            ucOperation mrsOpsInfo = new ucOperation();
            mrsOpsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageList.TabPages[2].Controls.Add(mrsOpsInfo);
            ucMrsExtBaseInfo mrsExtBaseInfo = new ucMrsExtBaseInfo();
           // mrsExtBaseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageList.TabPages[3].Controls.Add(mrsExtBaseInfo);
        }
        #endregion
    }
}
