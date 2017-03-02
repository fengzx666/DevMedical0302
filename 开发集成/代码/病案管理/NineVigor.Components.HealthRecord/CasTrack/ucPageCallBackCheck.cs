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
    public partial class ucPageCallBackCheck : NineVigor.FrameWork.WinForms.Controls.ucBaseControl
    {
        public ucPageCallBackCheck()
        {
            InitializeComponent();
        }

        #region 查询病案状态
        string queryUnCol = @"select 'FALSE',g.patient_no 病案号,to_char(g.in_times) 住院次数,g.name 患者姓名,fun_get_dept_name(g.dept_code) 出院科别,g.in_date 入院日期,g.out_date 出院日期,
decode(g.in_state,'B','出院登记','O','出院结算','其它') 状态,g.inpatient_no 住院流水号,DEPT_CODE 科别编码  from fin_ipr_inmaininfo g
where g.in_state in('B','O') and g.out_date>=trunc(to_date('2012-06-09','yyyy-MM-dd')) and (g.inpatient_no='{0}' or g.patient_no='{0}' or g.name='{1}')
and g.inpatient_no not in(
select cf.inpatient_no from met_cas_firstpagecheck cf where (cf.patient_no='{0}' or cf.name='{1}' or cf.inpatient_no='{0}'))";

        string queryCol = @"select cf.patient_no 病案号,to_char(cf.in_times) 住院次数,cf.Name 患者姓名,cf.DEPT_NAME 出院科别,cf.in_date 入院日期,
cf.out_date 出院日期,to_char(cf.checkdate,'yyyy-MM-dd HH24:mi:ss') 确认时间,fun_get_empl_name(cf.opercode) 确认人,cf.inpatient_no 住院流水号
from met_cas_firstpagecheck cf where cf.patient_no='{0}' or cf.name ='{1}' or cf.inpatient_no='{0}'
order by cf.in_date desc";

        string insertUnCol = @"insert into met_cas_firstpagecheck(INPATIENT_NO,PATIENT_NO,IN_TIMES,CHECKDATE,OPERCODE,IN_DATE,OUT_DATE,NAME,DEPT_NAME,DEPT_CODE) 
values('{0}','{1}',{2},sysdate,'{3}',to_date('{4}','yyyy-MM-dd HH24:mi:ss'),to_date('{5}','yyyy-MM-dd HH24:mi:ss'),'{6}','{7}','{8}')";
        #endregion

        private bool defaultSelect = false;

        [Category("控件设置"), Description("默认是否全部选中 true 是, false 否")]
        public bool DefaultSelect
        {
            get
            {
                return defaultSelect;
            }
            set
            {
                defaultSelect = value;
            }
        }

        private bool defaultFirstSelect = false;

        [Category("控件设置"), Description("默认是否只有一条时选中 true 是, false 否")]
        public bool DefaultFirstSelect
        {
            get
            {
                return defaultFirstSelect;
            }
            set
            {
                defaultFirstSelect = value;
            }
        }


        private bool defaultSave = false;

        [Category("控件设置"), Description("针对一条记录是否自动选中自动保存 true 是, false 否")]
        public bool DefaultSave
        {
            get
            {
                return defaultSave;
            }
            set
            {
                defaultSave = value;
            }
        }

        protected override int OnQuery(object sender, object neuObject)
        {
          
            return Query();
        }

        public override int Save(object sender, object neuObject)
        {
            int result = 0;
            ArrayList strArr = new ArrayList();
            string operId = "";//((Neusoft.HISFC.Models.Base.Employee)this.interManager.Operator).ID;

            for (int i = 0; i < neuSpread1_Sheet1.Rows.Count; i++)
            {
                if (this.neuSpread1_Sheet1.Cells[i, 0].Value == null || neuSpread1_Sheet1.Cells[i, 0].Value.ToString().ToUpper() != "TRUE")
                {
                    continue;
                }
                string exeSql = string.Format(insertUnCol,
                    this.neuSpread1_Sheet1.Cells[i, 8].Text.ToString(), this.neuSpread1_Sheet1.Cells[i, 1].Text.ToString(),
                    this.neuSpread1_Sheet1.Cells[i, 2].Value, operId, this.neuSpread1_Sheet1.Cells[i, 5].Text.ToString(),
                    this.neuSpread1_Sheet1.Cells[i, 6].Text.ToString(),this.neuSpread1_Sheet1.Cells[i, 3].Text.ToString(),
                    this.neuSpread1_Sheet1.Cells[i, 4].Text.ToString(), this.neuSpread1_Sheet1.Cells[i, 9].Text.ToString());

                strArr.Add(exeSql);
            }

            if (strArr.Count <= 0)
            {
                MessageBox.Show("没有需要保存的数据！");
                return -1;
            }
            else
            {
                NineVigor.FrameWork.Management.PublicTrans.BeginTransaction();
                foreach (string item in strArr)
                {
                    result = 1;// interManager.ExecNoQuery(item);
                    if (result == -1)
                    {
                        break;
                    }

                }
                if (result == -1)
                {
                    NineVigor.FrameWork.Management.PublicTrans.RollBack();
                    return -1;
                }
                else
                {
                    NineVigor.FrameWork.Management.PublicTrans.Commit();
                }
            }
            if (!DefaultSave)
            {
                MessageBox.Show("保存成功！");
            }
            Query();
            
            this.txtPatientNOSearch.Focus();
            this.txtPatientNOSearch.Text = "";
            //重新设定下格式内容，主要是不选择未回收病历内容
            SetFpStyle();
            return 1;
        }

        private void SetFpStyle()
        {
            this.neuSpread1_Sheet1.Columns[0].CellType = new FarPoint.Win.Spread.CellType.CheckBoxCellType();

            for (int i = 0; i < neuSpread1_Sheet1.Rows.Count; i++)
            {
                if (defaultSelect)
                {
                    if (defaultFirstSelect)
                    {
                        if (neuSpread1_Sheet1.Rows.Count == 1 && !string.IsNullOrEmpty(this.txtPatientNOSearch.Text.Trim()))
                        {
                            this.neuSpread1_Sheet1.Cells[0, 0].Value = true;
                        }
                        else
                        {
                            this.neuSpread1_Sheet1.Cells[0, 0].Value = false;
                        }
                    }
                    else
                    {
                        this.neuSpread1_Sheet1.Cells[i, 0].Value = true;
                    }
                }
                else
                {
                    this.neuSpread1_Sheet1.Cells[i, 0].Value = false;
                }
            }

            
            
            this.neuSpread1_Sheet1.Columns[0].Width = 40;
            this.neuSpread1_Sheet1.Columns[1].Width = 80;
            this.neuSpread1_Sheet1.Columns[2].Width = 80;
            this.neuSpread1_Sheet1.Columns[3].Width = 80;
            this.neuSpread1_Sheet1.Columns[4].Width = 80;
            this.neuSpread1_Sheet1.Columns[5].Width = 100;
            this.neuSpread1_Sheet1.Columns[6].Width = 100;
            this.neuSpread1_Sheet1.Columns[7].Width = 100;
            this.neuSpread1_Sheet1.Columns[8].Width = 100;
            this.neuSpread1_Sheet1.Columns[9].Width = 70;


            this.sheetView1.Columns[0].Width = 120;
            this.sheetView1.Columns[1].Width = 100;
            this.sheetView1.Columns[2].Width = 100;
            this.sheetView1.Columns[3].Width = 160;
            this.sheetView1.Columns[4].Width = 120;
            this.sheetView1.Columns[5].Width = 120;
            this.sheetView1.Columns[6].Width = 210;
            this.sheetView1.Columns[7].Width = 120;

            for (int i = 0; i < this.sheetView1.Rows.Count; i++)
            {
                this.sheetView1.Rows.Get(i).Height = 25F;
            }

        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        protected int Query()
        {
            DataSet dsUnCol = new DataSet();
            DataSet dsCol = new DataSet();

            string unExeSql = string.Empty;
            string colExeSql = string.Empty;
            string ptNo = string.Empty;
            if (this.txtPatientNOSearch.Text.Length <= 10)
            {
                ptNo = this.txtPatientNOSearch.Text.Trim().PadLeft(10, '0');
            }
            else
            {
                ptNo = this.txtPatientNOSearch.Text.Trim();
            }
            string tName = this.tbName.Text.Trim();

            unExeSql = string.Format(queryUnCol, ptNo, tName);
            colExeSql = string.Format(queryCol, ptNo, tName);
            try
            {
               // interManager.ExecQuery(unExeSql, ref dsUnCol);
               // interManager.ExecQuery(colExeSql, ref dsCol);
            }
            catch (Exception ex)
            {
                return -1;
            }

            #region
            if (dsUnCol != null && dsUnCol.Tables.Count > 0)
            {
                this.neuSpread1_Sheet1.DataSource = dsUnCol.Tables[0].DefaultView;

                
            }
            if (dsCol != null && dsCol.Tables.Count > 0)
            {
                this.sheetView1.DataSource = dsCol.Tables[0].DefaultView;
            }
            SetFpStyle();
            #endregion
            return 1;

        }

        private void txtPatientNOSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(this.txtPatientNOSearch.Text.Trim()))
                {
                    Query();
                    if (DefaultSave)
                    {
                        Save(null, null);
                    }
                }
            }
        }

        private void UcMetCasFirstPageCheck_Load(object sender, EventArgs e)
        {
            SetFpStyle();
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(this.tbName.Text.Trim()))
                {
                    Query();
                    if (DefaultSave)
                    {
                        Save(null, null);
                    }
                }
            }
        }

        private void btnHisQuery_Click(object sender, EventArgs e)
        {
            ucPageCallBackCheckHistory checkHistory = new ucPageCallBackCheckHistory();
            checkHistory.ShowDialog();
        }
    }
}
