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
    public partial class ucPageCallBackCheckUnCheck : NineVigor.FrameWork.WinForms.Controls.ucBaseControl
    {
        public ucPageCallBackCheckUnCheck()
        {
            InitializeComponent();
        }

        #region 查询病案状态
        string queryCol = @"select 'FALSE',cf.patient_no 病案号,to_char(cf.in_times) 住院次数,cf.Name 患者姓名,cf.DEPT_NAME 出院科别,cf.in_date 入院日期,
cf.out_date 出院日期,to_char(cf.checkdate,'yyyy-MM-dd HH24:mi:ss') 确认时间,fun_get_empl_name(cf.opercode) 确认人,cf.inpatient_no 住院流水号
from met_cas_firstpagecheck cf where cf.patient_no='{0}' or cf.name ='{1}' or cf.inpatient_no='{0}'
order by cf.in_date desc";

        string deleteUnCol = @"delete from met_cas_firstpagecheck where patient_no='{0}' and in_times={1}";
        #endregion

        protected override int OnQuery(object sender, object neuObject)
        {
            return Query();
        }

        public override int Save(object sender, object neuObject)
        {
            button1_Click(sender, null);
            return 1;
        }

        private void SetFpStyle()
        {
            this.nineSpread1_Sheet1.Columns[0].CellType = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
            for (int i = 0; i < nineSpread1_Sheet1.Rows.Count; i++)
            {
                this.nineSpread1_Sheet1.Cells[i, 0].Value = false;
            }
            
            this.nineSpread1_Sheet1.Columns[0].Width = 40;
            this.nineSpread1_Sheet1.Columns[1].Width = 80;
            this.nineSpread1_Sheet1.Columns[2].Width = 80;
            this.nineSpread1_Sheet1.Columns[3].Width = 80;
            this.nineSpread1_Sheet1.Columns[4].Width = 80;
            this.nineSpread1_Sheet1.Columns[5].Width = 100;
            this.nineSpread1_Sheet1.Columns[6].Width = 100;
            this.nineSpread1_Sheet1.Columns[7].Width = 120;
            this.nineSpread1_Sheet1.Columns[8].Width = 100;
            this.nineSpread1_Sheet1.Columns[9].Width = 100;
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        protected int Query()
        {
            DataSet dsCol = new DataSet();

            string unExeSql = string.Empty;
            string colExeSql = string.Empty;
            string ptNo = this.txtPatientNOSearch.Text.Trim().PadLeft(10, '0');
            string tName = this.tbName.Text.Trim();

            colExeSql = string.Format(queryCol, ptNo, tName);
            try
            {
              //  interManager.ExecQuery(colExeSql, ref dsCol);
            }
            catch (Exception ex)
            {
                return -1;
            }

            #region
            if (dsCol != null && dsCol.Tables.Count > 0)
            {
                this.nineSpread1_Sheet1.DataSource = dsCol.Tables[0].DefaultView;
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
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;
            ArrayList strArr = new ArrayList();
            string operId = "";// ((Neusoft.HISFC.Models.Base.Employee)this.interManager.Operator).ID;

            for (int i = 0; i < nineSpread1_Sheet1.Rows.Count; i++)
            {
                if (this.nineSpread1_Sheet1.Cells[i, 0].Value == null || nineSpread1_Sheet1.Cells[i, 0].Value.ToString().ToUpper() != "TRUE")
                {
                    continue;
                }
                string exeSql = string.Format(deleteUnCol,
                    this.nineSpread1_Sheet1.Cells[i, 1].Text.ToString(), this.nineSpread1_Sheet1.Cells[i, 2].Text.ToString());

                strArr.Add(exeSql);
            }

            if (strArr.Count <= 0)
            {
                MessageBox.Show("没有需要保存的数据！");
                return;
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
                    return;
                }
                else
                {
                    NineVigor.FrameWork.Management.PublicTrans.Commit();
                }
            }
            MessageBox.Show("取消保存成功！");
            Query();
            this.txtPatientNOSearch.Focus();
        }
    }
}
