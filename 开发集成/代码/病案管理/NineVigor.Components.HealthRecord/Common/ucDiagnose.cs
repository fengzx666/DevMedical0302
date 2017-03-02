using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FarPoint.Win.Spread;
using System.Collections;

namespace NineVigor.Components.HealthRecord.Common
{
    public partial class ucDiagnose : UserControl
    {
        public ucDiagnose()
        {
            InitializeComponent();
        }
        #region 变量定义
        //定义诊断内容
        ucDiagNoseSelect ucDiag1 = new ucDiagNoseSelect();
        #endregion

        #region Load 初始化内容

        /// <summary>
        /// 初始化farpoint,屏蔽一些热键
        /// </summary>
        private void InitFp()
        {
            InputMap im;
            im = this.neuSpreadDiagnose.GetInputMap(InputMapMode.WhenAncestorOfFocused);
            im.Put(new Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.None);

            im = neuSpreadDiagnose.GetInputMap(InputMapMode.WhenAncestorOfFocused);
            im.Put(new Keystroke(Keys.Down, Keys.None), FarPoint.Win.Spread.SpreadActions.None);

            im = neuSpreadDiagnose.GetInputMap(InputMapMode.WhenAncestorOfFocused);
            im.Put(new Keystroke(Keys.Up, Keys.None), FarPoint.Win.Spread.SpreadActions.None);

            im = neuSpreadDiagnose.GetInputMap(InputMapMode.WhenAncestorOfFocused);
            im.Put(new Keystroke(Keys.Escape, Keys.None), FarPoint.Win.Spread.SpreadActions.None);
        }
        #endregion

        #region Farpoint的 诊断录入回车事件
        /// <summary>
        /// 处理neuSpreadDiagnose_Sheet1,诊断的回车
        /// </summary>
        /// <returns></returns>
        private int ProcessDiagEnter()
        {
            if (!this.neuSpreadDiagnose.ContainsFocus)
            {
                return -1;
            }
            try
            {
                int addCount = 1;
                int curRow = neuSpreadDiagnose_Sheet1.ActiveRowIndex;
                int curColumn = neuSpreadDiagnose_Sheet1.ActiveColumnIndex;

                if (curRow < 0) return 0;
                switch (curColumn)
                {
                    case 1:
                        
                        SetActiveCellFouce(curRow, curColumn + 1);
                        break;
                    case 2:
                        SetActiveCellFouce(curRow, curColumn + 1);
                        break;
                    case 3:
                        SetActiveCellFouce(curRow + 1, 1);
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }
            }
            catch
            {

            }
            return 1;
        }
        /// <summary>
        /// 回车光标事件内容
        /// </summary>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                switch (keyData)
                {
                    case Keys.Enter:
                        ProcessDiagEnter();
                        break;
                    default:
                        break;

                }
            }
            catch
            { }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// 设置Farpoint的焦点
        /// </summary>
        /// <param name="row"></param>
        /// <param name="cols"></param>
        private void SetActiveCellFouce(int row, int cols)
        {
            this.neuSpreadDiagnose.Focus();
            //先将以前可以选中的全部变为系统色
            for (int i = 0; i < neuSpreadDiagnose_Sheet1.Rows.Count; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    this.neuSpreadDiagnose_Sheet1.Cells[i, j].BackColor = Color.White;
                }
            }
            this.neuSpreadDiagnose_Sheet1.SetActiveCell(row, cols, true);
            this.neuSpreadDiagnose_Sheet1.Cells[row, cols].BackColor = Color.LightSkyBlue;
        }
        #endregion
        #region 系统事件
        private void neuSpreadDiagnose_LeaveCell(object sender, FarPoint.Win.Spread.LeaveCellEventArgs e)
        {
            this.neuSpreadDiagnose_Sheet1.Cells[neuSpreadDiagnose_Sheet1.ActiveRowIndex, neuSpreadDiagnose_Sheet1.ActiveColumnIndex].BackColor = Color.White;
        }
        private void neuSpreadDiagnose_EditModeOff(object sender, EventArgs e)
        {
            this.neuSpreadDiagnose_Sheet1.Cells[neuSpreadDiagnose_Sheet1.ActiveRowIndex, neuSpreadDiagnose_Sheet1.ActiveColumnIndex].BackColor = Color.White;
        }

        private void ucDiagnose2013_Load(object sender, EventArgs e)
        {
            InitFp();

            if (ucDiag1.Visible)
            {
                ucDiag1.Visible = false;
                ucDiag1.RelatedControl = null;
            }
          
        }

        private void DiagInit()
        {
            ArrayList al = new ArrayList();

          //  Neusoft.HISFC.BizLogic.HealthRecord.ICD icdMgr = new Neusoft.HISFC.BizLogic.HealthRecord.ICD();

           // al = icdMgr.Query(Neusoft.HISFC.Models.HealthRecord.EnumServer.ICDTypes.ICD10, Neusoft.HISFC.Models.HealthRecord.EnumServer.QueryTypes.Valid);

            ucDiag1.InitData(al);

            ucDiag1.Visible = false;
            ucDiag1.RelatedControl = null;
            this.Controls.Add(ucDiag1);
        }


        #endregion

        private void neuSpreadDiagnose_EnterCell(object sender, EnterCellEventArgs e)
        {

        }

        private void neuSpreadDiagnose_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void neuSpreadDiagnose_TextChanged(object sender, EventArgs e)
        {

        }

        private void neuSpreadDiagnose_EditModeOn(object sender, EventArgs e)
        {
            int intCol = this.neuSpreadDiagnose_Sheet1.ActiveColumnIndex;
            if (intCol != 1)
            {
                ucDiag1.Visible = false;
            }
            else
            {
                ucDiag1.Visible = true;
            }
        }
    }
}
