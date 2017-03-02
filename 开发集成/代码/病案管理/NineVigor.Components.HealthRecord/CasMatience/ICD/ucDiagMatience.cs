using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NineVigor.Domain.HealthRecord.Entity;

namespace NineVigor.Components.HealthRecord.CasMatience.ICD
{
    /// <summary>
    /// 维护诊断信息
    /// </summary>
    public partial class ucDiagMatience : NineVigor.FrameWork.WinForms.Controls.ucBaseControl
    {
        #region 变量信息
        private string icdType = "ICD10";
        private string editType = string.Empty;
        #endregion


        #region 工具栏信息

        /// <summary>
        /// 定义工具栏服务
        /// </summary>
        protected NineVigor.FrameWork.WinForms.Forms.ToolBarService toolBarService = new NineVigor.FrameWork.WinForms.Forms.ToolBarService();

        #region 初始化工具栏
        /// <summary>
        /// 初始化工具栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="neuObject"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        protected override NineVigor.FrameWork.WinForms.Forms.ToolBarService OnInit(object sender, object neuObject, object param)
        {
            toolBarService.AddToolButton("增加", "增加", (int)NineVigor.FrameWork.WinForms.Classes.EnumImageList.X新建, true, false, null);
            toolBarService.AddToolButton("修改", "修改", (int)NineVigor.FrameWork.WinForms.Classes.EnumImageList.X修改, true, false, null);
            return toolBarService;
        }
        #endregion

        #region 工具栏增加按钮单击事件
        /// <summary>
        /// 工具栏增加按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "增加":
                    InsertRow();
                    break;
                case "修改":
                    ModifyInfo();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region 工具栏事件

        /// <summary>
        /// 增加一行
        /// </summary>
        private void InsertRow()
        {
            //实例化要弹出的窗口
            frmICDInfo icdInfo = new frmICDInfo();
            //赋值 ICD的类型 
            icdInfo.IcdType = icdType;
            //赋值 修改的类型
            icdInfo.EditType ="Add";
            //保存修改类型
            editType = "Add";
            //订制事件 。
            icdInfo.SaveButtonClick += new frmICDInfo.SaveInfo(icdInfo_SaveButtonClick);
            //显示窗体
            icdInfo.ShowDialog();
        }
        /// <summary>
        /// 修改ICD信息
        /// </summary>
        private void ModifyInfo()
        {
            /*
            if (this.fpSpread1_Sheet1.RowCount <= 0)
            {
                return;
            }

            int currRow = fpSpread1_Sheet1.ActiveRowIndex;//当前行
            if (currRow < 0)
            {
                return;
            }
            ArrayList alReturn = new ArrayList(); //返回的ICD信息
            string sICDCode = "";//选取的ICD编码

            //定义变量，存储要修改的信息
            Neusoft.HISFC.Models.HealthRecord.ICD orgICD = new Neusoft.HISFC.Models.HealthRecord.ICD();
           
            sICDCode = fpSpread1_Sheet1.Cells[currRow, GetColumnKey("诊断码")].Text;

            if (sICDCode == "" || sICDCode == null)
            {
                return;
            }

            alReturn = myICD.IsExistAndReturn(sICDCode, type, true);

            if (alReturn == null)
            {
                MessageBox.Show("获得ICD信息出错!" + myICD.Err);
                return;
            }
            if (alReturn.Count == 0)
            {
                alReturn = myICD.IsExistAndReturn(sICDCode, type, false);
            }
            if (alReturn.Count == 0)
            {
                MessageBox.Show("获得ICD信息出错");
                return;
            }
            try
            {
                orgICD = alReturn[0] as Neusoft.HISFC.Models.HealthRecord.ICD;
            }
            catch (Exception ex)
            {
                MessageBox.Show("获得ICD信息出错!" + ex.Message);
                return;
            }
             * */
            //实例化要弹出的窗口
            frmICDInfo icdInfo = new frmICDInfo();
            //显示待修改信息
            icdInfo.OrgICD10 = null;
            //赋值 ICD的类型 
            icdInfo.IcdType = icdType;
            //赋值 修改的类型
            icdInfo.EditType = "Mod";
            //保存修改类型
            editType = "Mod";
            //订制事件 。
            icdInfo.SaveButtonClick += new frmICDInfo.SaveInfo(icdInfo_SaveButtonClick);
            //显示窗体
            icdInfo.ShowDialog();
        }


        #endregion

        #region 保存
        /// <summary>
        /// frmICDInfo自定义事件,弹出窗口确定按钮按下后触发
        /// </summary>
        /// <param name="info"></param>
        private void icdInfo_SaveButtonClick(NineVigor.Domain.HealthRecord.Entity.ICDDiagnose info)
        {
            try
            {
                /*
                //处理事件
                if (editType == "Add")
                {
                    //定义变量
                    DataRow row = ds.Tables[0].NewRow();
                    //增加一行
                    SetRow(info, row);
                    ds.Tables[0].Rows.Add(row);
                }
                else
                {
                    object[] keys = new object[] { info.Sequence_no };
                    DataRow row = ds.Tables[0].Rows.Find(keys);
                    if (row == null)
                    {
                        MessageBox.Show("查找项目出错!");
                        return;
                    }
                    else
                    {
                        SetRow(info, row);
                    }
                }
                ds.Tables[0].AcceptChanges();
                LockFp();
              
                 */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

         /// <summary>
        /// 在dtICD中添加加一行
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="row"></param>
        private void SetRow(NineVigor.Domain.HealthRecord.Entity.ICDDiagnose obj, DataRow row)
        {
        }
        #endregion
        #endregion



        public ucDiagMatience()
        {
            InitializeComponent();
        }
        DataTable dtDiagnose = null;
        private void enableCheckTime_CheckedChanged(object sender, EventArgs e)
        {
            this.dtModifyBegin.Enabled = this.enableCheckTime.Checked;
            this.dtModifyEnd.Enabled = this.enableCheckTime.Checked;
        }

        private void ucDiagMatience_Load(object sender, EventArgs e)
        {
            ICDDiagnose icdDiagnose = new ICDDiagnose();
             dtDiagnose = icdDiagnose.Query();
             if (dtDiagnose != null)
            {
                this.nineSpread1_Sheet1.DataSource = dtDiagnose.DefaultView;
                
            }
             LockSp();
        }

        private void nvfilterCode_EditValueChanged(object sender, EventArgs e)
        {
            Filter();
        }

        /// <summary>
        /// 过滤
        /// </summary>
        /// <returns></returns>
        private int Filter()
        {

           String strContent = NineVigor.FrameWork.Public.String.TakeOffSpecialChar(this.nvfilterCode.Text.Trim());
            if (string.IsNullOrEmpty(strContent))
            {
                dtDiagnose.DefaultView.RowFilter = " 1=1 ";
            }

         
            try
            {
                dtDiagnose.DefaultView.RowFilter = "(ICD_CODE like '%" + strContent + "%') or (ICD_NAME like  '%"
                    + strContent + "%') or (INN_icdcode like  '%" + strContent + "%') or (INN_icdname like  '%" +
                    strContent + "%')  or (spell_code like  '%" + strContent + "%') or (inn_spell_code like  '%" + strContent + "%')";
            }
            catch (Exception ex)
            {
                MessageBox.Show("过滤检索查询失败！" + ex.Message);
                return -1;
            }


            LockSp();
            return 1;

        }

        private void LockSp()
        {
            this.nineSpread1_Sheet1.ColumnHeader.Rows[0].Height = 30;
            nineSpread1_Sheet1.Columns[1].Width = 65;
            nineSpread1_Sheet1.Columns[2].Width = 240;
            nineSpread1_Sheet1.Columns[3].Width = 65;
            nineSpread1_Sheet1.Columns[4].Width = 160;
            nineSpread1_Sheet1.Columns[5].Width = 40;
            nineSpread1_Sheet1.Columns[6].Width = 40;//诊断标记
            nineSpread1_Sheet1.Columns[7].Width = 60;
            nineSpread1_Sheet1.Columns[8].Width = 60;
            nineSpread1_Sheet1.Columns[9].Width = 40;
            nineSpread1_Sheet1.Columns[10].Width = 60;
            nineSpread1_Sheet1.Columns[11].Width = 60;
            nineSpread1_Sheet1.Columns[12].Width = 120;//操作时间
            nineSpread1_Sheet1.Columns[13].Width = 60;
            nineSpread1_Sheet1.Columns[14].Width = 60;
            nineSpread1_Sheet1.Columns[15].Width = 60;//操作时间
            nineSpread1_Sheet1.Columns[16].Width = 60;
            nineSpread1_Sheet1.Columns[17].Width = 60;
            nineSpread1_Sheet1.Columns[18].Width = 60;//操作时间
            nineSpread1_Sheet1.Columns[19].Width = 60;
        }

        private void cbValid_CheckedChanged(object sender, EventArgs e)
        {
            string validState = this.cbValid.Checked ? "0" : "1";
            dtDiagnose.DefaultView.RowFilter = "VALID_STATE ='" + validState + "'";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            bool validState = this.checkBox2.Checked;
            if (validState)
            {
                dtDiagnose.DefaultView.RowFilter = "sicd_code like '%*'";
            }
            else
            {
                dtDiagnose.DefaultView.RowFilter = "1=1";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool validState = this.checkBox1.Checked;
            if (validState)
            {
                dtDiagnose.DefaultView.RowFilter = "inn_icdcode is not null";
            }
            else
            {
                dtDiagnose.DefaultView.RowFilter = "1=1";
            }
        }
    }
}
