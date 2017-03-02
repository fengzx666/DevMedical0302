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
    public partial class ucPageCallBackCheckHistory : NineVigor.FrameWork.WinForms.Forms.BaseForm
    {
        public ucPageCallBackCheckHistory()
        {
            InitializeComponent();
        }

        #region 查询病案状态
        string queryCol = @"select to_char(rownum) 序号, AA.*
  from (select cf.patient_no 病案号,
               to_char(cf.in_times) 住院次数,
               cf.Name 患者姓名,
               cf.DEPT_NAME 出院科别,
               cf.in_date 入院日期,
               cf.out_date 出院日期,
               to_char(cf.checkdate, 'yyyy-MM-dd HH24:mi:ss') 确认时间,
               fun_get_empl_name(cf.opercode) 确认人,
               cf.inpatient_no 住院流水号
          from met_cas_firstpagecheck cf
         where cf.opercode = '{0}'
           and (cf.checkdate >= to_Date('{1}', 'yyyy-MM-dd HH24:mi:ss') and
               cf.checkdate <= to_Date('{2}', 'yyyy-MM-dd HH24:mi:ss'))
         order by cf.checkdate desc) AA";

             #endregion
        private void SetFpStyle()
        {
            int count = 1;
            this.nineSpread3_Sheet1.Columns[-1 + count].Width = 55;
            this.nineSpread3_Sheet1.Columns[0 + count].Width = 120;
            this.nineSpread3_Sheet1.Columns[1 + count].Width = 100;
            this.nineSpread3_Sheet1.Columns[2 + count].Width = 100;
            this.nineSpread3_Sheet1.Columns[3 + count].Width = 160;
            this.nineSpread3_Sheet1.Columns[4 + count].Width = 120;
            this.nineSpread3_Sheet1.Columns[5 + count].Width = 120;
            this.nineSpread3_Sheet1.Columns[6 + count].Width = 220;
            this.nineSpread3_Sheet1.Columns[7 + count].Width = 120;

            for (int i = 0; i < this.nineSpread3_Sheet1.Rows.Count; i++)
            {
                this.nineSpread3_Sheet1.Rows.Get(i).Height = 25F;
            }

        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        protected int Query()
        {
     
            DataSet dsCol = new DataSet();
            string colExeSql = string.Empty;

            string dtBegin=this.dateTimeBegin.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string dtEnd = this.dateTimeEnd.Value.ToString("yyyy-MM-dd HH:mm:ss");

            string operNo = "";// interManager.Operator.ID;

            colExeSql = string.Format(queryCol, operNo, dtBegin, dtEnd);
            try
            {
               // interManager.ExecQuery(colExeSql, ref dsCol);
            }
            catch (Exception ex)
            {
                return -1;
            }

            #region
            if (dsCol != null && dsCol.Tables.Count > 0)
            {
                this.nineSpread3_Sheet1.DataSource = dsCol.Tables[0].DefaultView;
            }
            SetFpStyle();
            #endregion
            return 1;

        }

        private void btnQry_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void UcMetCasFirstPageCheckHistory_Load(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;// interManager.GetDateTimeFromSysDateTime();
            dtNow = dtNow.AddMinutes(-10);
            this.dateTimeBegin.Value = dtNow;
            this.dateTimeEnd.Value = new DateTime(dtNow.Year, dtNow.Month, dtNow.Day, 23, 59, 59);
            Query();
        }
    }
}
