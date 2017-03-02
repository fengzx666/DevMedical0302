using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace NineVigor.Components.HealthRecord.CasTrack
{
    /// <summary>
    /// ucFirstPageCheck
    /// [功能描述: 出院患者未回收病历信息查询]
    /// [创 建 者: 冯志欣]
    /// [创建时间: 2012-06-17]
    /// <修改记录 
    ///		修改人='' 
    ///		修改时间='yyyy-mm-dd' 
    ///		修改目的=''
    ///		修改描述=''
    ///		/>
    /// </summary>
    public partial class ucPageCallBackStateQuery : NineVigor.FrameWork.WinForms.Controls.ucBaseControl
    {
        public ucPageCallBackStateQuery()
        {
            InitializeComponent();
        }

        #region 出院患者未回收病历信息查询语句
        string strSQL = @"select  a.dept_name 科室,
decode((select count(1) from MET_CAS_FIRSTPAGECHECK mcf where MCF.INPATIENT_NO=A.INPATIENT_NO),0,'未回收','已回收') 回收状态,
  (select fun_get_empl_name(MCF.Opercode) from MET_CAS_FIRSTPAGECHECK mcf where MCF.INPATIENT_NO=A.INPATIENT_NO) 回收人,
  (select MCF.CHECKDATE from MET_CAS_FIRSTPAGECHECK mcf where MCF.INPATIENT_NO=A.INPATIENT_NO) 回收时间,
                                   (select FUN_GET_EMPL_NAME(MCF.OPER_CODE) from MET_CAS_Base mcf where MCF.INPATIENT_NO=A.INPATIENT_NO) 录入人,
                                    (select MCF.OPER_DATE from MET_CAS_Base mcf where MCF.INPATIENT_NO=A.INPATIENT_NO) 录入时间,
                                   a.patient_no 住院号,
                                   A.IN_TIMES,
                                   a.name 姓名,
                                   decode(a.sex_code,'F','女','M','男','不详') 性别,
                                   fun_get_age(a.birthday) 年龄,
                                   to_char(a.in_date,'yyyy-mm-dd') 入院日期,
                                     to_char(a.out_date,'yyyy-mm-dd') 出院日期,
                                   decode(a.in_state,'O','出院结算','R','住院登记','I','接诊','出院登记') 状态,
                                   (trunc(a.out_date) - trunc(a.in_date)) 住院天数,
                                 
                                 decode((select count(1) from met_cas_base mcf where MCF.INPATIENT_NO=A.INPATIENT_NO),0,'未录入','已录入') 录入状态,
                                 A.INPATIENT_NO 住院流水号
                                   from FIN_IPR_INMAININFO a
                                   where (A.PATIENT_NO='{0}' or a.name like'%{1}%') and a.IN_STATE in ('B','O','P')
                                   order by A.PATIENT_NO,A.IN_TIMES desc";

        #endregion

        #region 变量
        DataSet ds = new DataSet();
       // Neusoft.HISFC.BizLogic.Manager.Department interManager = new Neusoft.HISFC.BizLogic.Manager.Department();
        #endregion

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            txtPatientNo.Focus();
        }

        protected override int OnQuery(object sender, object neuObject)
        {
           Query();
           return 1;
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        protected int Query()
        {
            string tempSQL = null;
            string strErr = null;
            string thirdName = string.Empty;
            if (string.IsNullOrEmpty(this.txtPatientNo.Text.Trim()))
            {
                return -1;
            }
            if (this.txtPatientNo.Text.Trim().Length > 10)
            {
                this.txtPatientNo.Text = this.txtPatientNo.Text.Substring(4);
            }
            thirdName = this.txtPatientNo.Text.Trim().PadLeft(10, '0');
            tempSQL = string.Format(strSQL, thirdName, this.txtPatientNo.Text.Trim());
            try
            {
               // interManager.ExecQuery(tempSQL, ref ds);
            }
            catch (Exception ex)
            {
                strErr = "查询数据失败！" + ex.Message;
                MessageBox.Show(strErr);
                return -1;
            }
            if (ds.Tables.Count > 0 || ds.Tables[0] != null)
            {
                nineSpread1_Sheet1.DataSource = ds.Tables[0].DefaultView;
            }
            this.nineSpread1_Sheet1.ColumnHeader.Cells.Get(1, 0).Value =                         
                            "   共：" + ds.Tables[0].Rows.Count.ToString() + "条记录 ";
            return 1;

        }
        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="neuObject"></param>
        /// <returns></returns>
        protected override int OnPrint(object sender, object neuObject)
        {

            if (this.nineSpread1_Sheet1.RowCount > 0)
            {
                FarPoint.Win.Spread.PrintInfo pi = new FarPoint.Win.Spread.PrintInfo();

                pi.Header = "/r /fz\"12\" 第 /p 页 共 /pc 页";
                pi.ShowBorder = false;

                float len = 0f;
                for (int cidx = 0; cidx < this.nineSpread1_Sheet1.Columns.Count; cidx++)
                {
                    len += this.nineSpread1_Sheet1.Columns[cidx].Width;
                }

                System.Drawing.Printing.PaperSize ps = new System.Drawing.Printing.PaperSize();
                ps.Width = 1575;//px
                ps.Height = NineVigor.FrameWork.Function.NConvert.ToInt32(945) + 134;//px
                ps.PaperName = "sss";

                pi.PaperSize = ps;


                pi.Margin.Bottom = 64;
                pi.Margin.Left = 60;
                pi.Margin.Top = 0;
                pi.Margin.Right = 0;

                pi.UseMax = false;
                this.nineSpread1_Sheet1.PrintInfo = pi;

                this.nineSpread1.PrintSheet(this.nineSpread1.ActiveSheetIndex);

                return 1;

            }
            else
            {
                MessageBox.Show("没有要打印的数据");
                return -1;
            }
        }

        /// <summary>
        /// 过滤数据内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void neutbBoxFileter_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        /// <summary>
        /// 过滤
        /// </summary>
        /// <returns></returns>
        protected int Filter()
        {
            if (ds == null || ds.Tables.Count <= 0)
            {
                return -1;
            }
            string strPID = null;

            strPID = NineVigor.FrameWork.Public.String.TakeOffSpecialChar(this.txtFilter.Text.Trim());

            try
            {
                ds.Tables[0].DefaultView.RowFilter = " (住院号 like '%" + strPID + "%') or (姓名 like '%" + strPID + "%')";
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询失败！" + ex.Message);
                return -1;
            }
            return 1;
        }

        private void neuTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(this.txtPatientNo.Text))
                {
                    Query();
                }
            }

        }
    }
}
