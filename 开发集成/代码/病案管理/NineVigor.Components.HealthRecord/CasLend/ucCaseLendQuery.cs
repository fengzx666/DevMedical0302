using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace NineVigor.Components.HealthRecord.CasLend
{
    /// <summary>
    /// ucCaseLendQuery<br></br>
    /// <Font color='#FF1111'>[功能描述: 病案借阅查询]</Font><br></br>
    /// [创 建 者: 耿晓雷]<br></br>
    /// [创建时间: 2010-10-3]<br></br>
    /// <修改记录 
    ///		修改人='' 
    ///		修改时间='yyyy-mm-dd' 
    ///		修改目的=''
    ///		修改描述=''
    ///		/>
    /// </summary>
    public partial class ucCaseLendQuery : NineVigor.FrameWork.WinForms.Controls.ucBaseControl
    {
        #region 构造函数
        public ucCaseLendQuery()
        {
            InitializeComponent();
        }
        #endregion

        #region 变量

      
        private DataTable dt = null;

        #endregion

        #region 属性

        private bool IsLendDateEnable
        {
            set
            {
                this.chkLendDate.Checked = value;
                this.dtpLendBeginDate.Enabled = value;
                this.dtpLendEndDate.Enabled = value;
            }
            get
            {
                return this.chkLendDate.Checked;
            }
        }

        private bool IsPreReDateEnable
        {
            set
            {
                this.chkPreReDate.Checked = value;
                this.dtpPreReBeginDate.Enabled = value;
                this.dtpPreReEndDate.Enabled = value;
            }
            get
            {
                return this.chkPreReDate.Checked;
            }
        }

        private bool IsReturnDateEnable
        {
            set
            {
                this.chkReturnDate.Checked = value;
                this.dtpReturnBeginDate.Enabled = value;
                this.dtpReturnEndDate.Enabled = value;
                //如果选中归还时间则状态自动选为“已归还”
                this.cmbState.Tag = value ? "2" : "1";
            }
            get
            {
                return this.chkReturnDate.Checked;
            }
        }

        #endregion

        #region 方法

        /// <summary>
        /// 初始化下拉列表
        /// </summary>
        private void InitCmb()
        {
            /*
            ArrayList alEmp = this.interManager.QueryEmployeeAll();

            Neusoft.HISFC.BizLogic.Manager.Person person = new Neusoft.HISFC.BizLogic.Manager.Person();
            Neusoft.HISFC.BizProcess.Integrate.Manager managerMgr = new Neusoft.HISFC.BizProcess.Integrate.Manager();
            Neusoft.FrameWork.Public.ObjectHelper deptHelper = new Neusoft.FrameWork.Public.ObjectHelper();
            //获取人员列表
            IComparer myComparer = new NorthChina.HealthRecord.Components.CaseFirstPageNew.EmplCompareReverse();
            ArrayList DoctorList = person.GetEmployeeAll();
            DoctorList.Sort(myComparer);
            Neusoft.HISFC.BizLogic.Manager.Department dep = new Neusoft.HISFC.BizLogic.Manager.Department();
            deptHelper.ArrayObject = dep.GetDeptmentAll();



            ArrayList tepArr = new ArrayList();
            foreach (Neusoft.HISFC.Models.Base.Employee item in DoctorList)
            {
                item.Memo = deptHelper.GetName(item.Dept.ID);
                tepArr.Add(item);
            }
            cListBempNo.AddItems(DoctorList);

            ArrayList alDept = this.interManager.GetDepartment();
            if (alDept != null)
            {
                alDept.Insert(0, new NeuObject("ALL", "全部", ""));
                this.cmbBorrowDept.AddItems(alDept);
            }
            ArrayList alState = new ArrayList();
            alState.Add(new NeuObject("ALL", "全部", ""));
            alState.Add(new NeuObject("1", "借出", ""));
            alState.Add(new NeuObject("2", "返还", ""));
            this.cmbState.AddItems(alState);
             * */
        }

        /// <summary>
        /// 初始化数据表
        /// </summary>
        private void InitDataTable()
        {
            this.dt = new DataTable();
            this.dt.Columns.AddRange(new DataColumn[] { 
                new DataColumn("病案号",typeof(string)),
                new DataColumn("患者姓名",typeof(string)),
                new DataColumn("借阅人工号",typeof(string)),
                new DataColumn("借阅人姓名",typeof(string)),
                new DataColumn("借阅人科室",typeof(string)),
                new DataColumn("借阅人电话",typeof(string)),
                new DataColumn("借阅日期",typeof(string)),
                new DataColumn("预定还期",typeof(string)),
                new DataColumn("借阅状态",typeof(string)),
                new DataColumn("归还日期",typeof(string)),
                new DataColumn("借出人",typeof(string)),
                new DataColumn("借阅原因",typeof(string)),
                new DataColumn("备注",typeof(string))
            });
            this.neuSpread1_Sheet1.DataSource = this.dt;
        }

        private void SetFpStyle()
        {
            /*
            this.neuSpread1_Sheet1.Columns[0].Width = 70;
            this.neuSpread1_Sheet1.Columns[1].Width = 70;
            this.neuSpread1_Sheet1.Columns[2].Width = 70;
            this.neuSpread1_Sheet1.Columns[3].Width = 80;
            this.neuSpread1_Sheet1.Columns[4].Width = 150;
            this.neuSpread1_Sheet1.Columns[5].Width = 100;
            this.neuSpread1_Sheet1.Columns[6].Width = 150;
            this.neuSpread1_Sheet1.Columns[7].Width = 70;
            this.neuSpread1_Sheet1.Columns[8].Width = 70;
            this.neuSpread1_Sheet1.Columns[9].Width = 70;
            this.neuSpread1_Sheet1.Columns[10].Width = 85;
            this.neuSpread1_Sheet1.Columns[11].Width = 70;
            this.neuSpread1_Sheet1.Columns[12].Width = 150;

            for (int iTemp = 0; iTemp < this.neuSpread1_Sheet1.RowCount; iTemp++)
            {
                string status = this.neuSpread1_Sheet1.Cells[iTemp, 8].Text;
                DateTime rDate = Neusoft.FrameWork.Function.NConvert.ToDateTime(this.neuSpread1_Sheet1.Cells[iTemp, 7].Text);

                if (status.Equals("借出")&&rDate.AddDays(-1).CompareTo(caseCardManager.GetDateTimeFromSysDateTime()) <= 0)
                {
                    neuSpread1_Sheet1.Rows[iTemp].BackColor = Color.PaleVioletRed;
                }
                else
                {
                    neuSpread1_Sheet1.Rows[iTemp].BackColor = Color.White;
                }
            }
             * */
        }

        private void SetDefaultCondition()
        {
            this.txtCaseNo.Text = "";
            this.cmbBorrowDept.Tag = "ALL";
            this.cmbState.Tag = "1";
            this.IsLendDateEnable = true;
            this.IsPreReDateEnable = false;
            this.IsReturnDateEnable = false;
            this.dtpLendBeginDate.Value = DateTime.Now.AddMonths(-1);
            this.dtpLendEndDate.Value = DateTime.Now.Date.AddDays(1).AddSeconds(-1);
        }

        private int GetColIndex(string lable)
        {
            for (int i = 0; i < this.neuSpread1_Sheet1.Columns.Count; i++)
            {
                if (this.neuSpread1_Sheet1.Columns[i].Label == lable)
                {
                    return i;
                }
            }
            return -2;
        }

        private void QueryData()
        {
            /*
            this.dt.Clear();
            string strWhere = "";
            if (this.GetWhereString(ref strWhere) < 0)
            {
                return;
            }
            ArrayList alData = this.caseCardManager.QueryLendInfoByWhereString(strWhere);
            if (alData == null)
            {
                MessageBox.Show("查询出错：" + this.caseCardManager.Err);
                return;
            }
            this.AddDataToTable(alData);
            SetFpStyle();*/
        }

        private void AddDataToTable(ArrayList alData)
        {
            /*
            foreach (Neusoft.HISFC.Models.HealthRecord.Lend info in alData)
            {
                DataRow dr = this.dt.NewRow();
                this.dt.Rows.Add(dr);
                dr["病案号"] = info.CaseBase.CaseNO;
                dr["患者姓名"] = info.CaseBase.PatientInfo.Name;
                dr["借阅人工号"] = info.EmployeeInfo.ID;
                dr["借阅人姓名"] = info.EmployeeInfo.Name;info.CaseBase.PatientInfo.PVisit.InTime.ToString("yyyy-MM-dd");
                dr["借阅人科室"] = info.EmployeeDept.Name;info.CaseBase.PatientInfo.PVisit.OutTime.ToString("yyyy-MM-dd");
                dr["借阅人电话"] = info.EmplTel;
                dr["借阅日期"] =info.LendDate.ToString("yyyy-MM-dd HH:mm:ss") ;
                dr["预定还期"] = info.PrerDate.ToString("yyyy-MM-dd");
                dr["借阅状态"] = (info.LendStus == "1") ? "借出" : "返还";
                dr["归还日期"] = info.ReturnDate.ToString("yyyy-MM-dd");
                dr["借出人"] = info.ID;
                dr["借阅原因"] = info.LendReason;
                dr["备注"] = info.Remark;
            }
            this.dt.AcceptChanges();
            this.SetFpStyle();
             * */
        }

        private int GetWhereString(ref string strWhere)
        {
            strWhere = " where 1 = 1 ";
            if (!string.IsNullOrEmpty(this.txtCaseNo.Text.Trim()))
            {
                string patientNoNew = string.Empty;
                string patientNoOld = string.Empty;
                if (this.txtCaseNo.Text.Trim().Length <= 10)
                {
                    patientNoNew = "ZY01" + this.txtCaseNo.Text.Trim().PadLeft(10, '0');
                    patientNoOld = "ZY01J" + this.txtCaseNo.Text.Trim().PadLeft(9, '0');
                }
                else
                {
                    patientNoNew = this.txtCaseNo.Text.Trim();
                    patientNoOld = this.txtCaseNo.Text.Trim();
                }
                strWhere += " and inpatient_no in( '" + patientNoNew + "','" + patientNoOld + "') ";
            }
            if (this.cListBempNo.Tag != null &&!string.IsNullOrEmpty(this.cListBempNo.Text))
            {
                strWhere += " and EMPL_CODE = '" + this.cListBempNo.Tag.ToString() + "' ";
            }
            if (this.cmbBorrowDept.Tag != null && this.cmbBorrowDept.Tag.ToString() != "ALL")
            {
                strWhere += " and DEPT_CODE = '" + this.cmbBorrowDept.Tag.ToString() + "' ";
            }
            if (this.cmbState.Tag != null && this.cmbState.Tag.ToString() != "ALL")
            {
                strWhere += " and LEN_STUS = '" + this.cmbState.Tag.ToString() + "'";
            }
            if (this.IsLendDateEnable)
            {
                strWhere += " and (LEND_DATE >= to_date('" + this.dtpLendBeginDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-mm-dd hh24:mi:ss') and LEND_DATE <= to_date('" + this.dtpLendEndDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-mm-dd hh24:mi:ss')) ";
            }
            if (this.IsPreReDateEnable)
            {
                strWhere += " and (PRER_DATE >= to_date('" + this.dtpPreReBeginDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-mm-dd hh24:mi:ss') and PRER_DATE <= to_date('" + this.dtpPreReEndDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-mm-dd hh24:mi:ss')) ";
            }
            if (this.IsReturnDateEnable)
            {
                strWhere += " and (RETURN_DATE >= to_date('" + this.dtpReturnBeginDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-mm-dd hh24:mi:ss') and RETURN_DATE <= to_date('" + this.dtpReturnEndDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-mm-dd hh24:mi:ss')) ";
            }
            return 1;
        }
        #endregion

        #region 事件
        private void ucCaseLendQuery_Load(object sender, EventArgs e)
        {
            this.InitCmb();
            this.InitDataTable();
            this.SetFpStyle();
            this.SetDefaultCondition();
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            this.SetDefaultCondition();
        }

        protected override int OnQuery(object sender, object neuObject)
        {
            this.QueryData();
            return 1;
        }

        private void txtCaseNo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCaseNo.Text.Trim()))
            {
                return;
            }
        }

        private void chkLendDate_CheckedChanged(object sender, EventArgs e)
        {
            this.IsLendDateEnable = this.chkLendDate.Checked;
        }

        private void chkPreReDate_CheckedChanged(object sender, EventArgs e)
        {
            this.IsPreReDateEnable = this.chkPreReDate.Checked;
        }

        private void chkReturnDate_CheckedChanged(object sender, EventArgs e)
        {
            this.IsReturnDateEnable = this.chkReturnDate.Checked;
        }

        #endregion

        private void txtCaseNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.QueryData();
            }
        }

    }
}
