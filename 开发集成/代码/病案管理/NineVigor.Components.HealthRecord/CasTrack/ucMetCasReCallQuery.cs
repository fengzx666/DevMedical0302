using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using NineVigor.FrameWork.Function;

namespace NineVigor.Components.HealthRecord.CasTrack
{
    /// <summary>
    /// 病案回收信息查询
    /// </summary>
    public partial class ucMetCasReCallQuery : NineVigor.FrameWork.WinForms.Controls.ucBaseControl
    {
        public ucMetCasReCallQuery()
        {
            InitializeComponent();
        }

        #region 变量
        #region 
        string strSQL = @"select BB.DEPT_CODE,nvl(fun_get_dept_name(BB.DEPT_CODE), '合计') 部门名称,
       sum(1) 出院总人数,
       sum(case
             when 编码状态 = 'CAS' then
              1
             else
              0
           end) 编目人数,
       sum(case
             when 回收人 is null then
              1
             else
              0
           end) 未回收人数,
       sum(case
             when 回收人 is null then
              0
             else
              1
           end) 已回收人数
  from (select AA.*,
               fun_splitstring(AA.henanadd2012, '|', 29) 编码状态,
               mcf.checkdate 回收时间,
               mcf.opercode 回收人
          from (select *
                  from Met_Cas_Base mcb
                 where mcb.case_stus in ('3', '4') and (DEPT_CODE='{2}' or 'ALL'='{2}')
                   and trunc(mcb.out_date) >=
                       to_date('{0}', 'yyyy-MM-dd')
                   and trunc(mcb.out_date) <=
                       to_date('{1}', 'yyyy-MM-dd')
                   {3}) AA
          left join met_cas_firstpagecheck mcf on AA.inpatient_no =
                                                  mcf.inpatient_no) BB
 group by rollup(BB.dept_code)
 order by to_number(fun_get_parNameBySCode(BB.DEPT_CODE, '72', '2'))";
        #endregion 

        #region 
        string strSQL2 = @"select BB.Inpatient_No,
       BB.dept_name,
       BB.PATIENT_NO,
       to_char(BB.In_Times),
       BB.Name,
       decode(BB.Sex_Code, 'F', '女', 'M', '男', '其他') 性别,
       to_Char(BB.In_Date,'yyyy-MM-dd') 入院日期,
       to_char(BB.Out_Date,'yyyy-MM-dd') 出院日期,
       BB.HOUSE_DOC_NAME 住院医师,
(select (g.tot_cost+g.balance_cost) 
          from fin_ipr_inmaininfo g
          where g.inpatient_no=BB.Inpatient_No) 费用合计
  from (select AA.*,
               fun_splitstring(AA.henanadd2012, '|', 29) 编码状态,
               mcf.checkdate 回收时间,
               mcf.opercode 回收人
          from (select *
                  from Met_Cas_Base mcb
                 where mcb.case_stus in ('3', '4')
                   and (DEPT_CODE = '{2}' or 'ALL' = '{2}')
                   and trunc(mcb.out_date) >= to_date('{0}', 'yyyy-MM-dd')
                   and trunc(mcb.out_date) <= to_date('{1}', 'yyyy-MM-dd')
                   {3}) AA
          left join met_cas_firstpagecheck mcf
            on AA.inpatient_no = mcf.inpatient_no) BB
 where BB.回收人 is null
 order by BB.Dept_Name, BB.Out_Date";      
        #endregion 

        #region
        string strSQL3 = @"select 
       BB.dept_name,
       BB.PATIENT_NO,
       to_char(BB.In_Times),
       BB.Name,
       decode(BB.Sex_Code, 'F', '女', 'M', '男', '其他') 性别,
       to_Char(BB.In_Date,'yyyy-MM-dd') 入院日期,
       to_char(BB.Out_Date,'yyyy-MM-dd') 出院日期,
       fun_get_empl_name(BB.回收人) 回收人,
       to_char(BB.回收时间,'yyyy-MM-dd HH24:mi:ss') 回收时间
       
  from (select AA.*,
               fun_splitstring(AA.henanadd2012, '|', 29) 编码状态,
               mcf.checkdate 回收时间,
               mcf.opercode 回收人
          from (select *
                  from Met_Cas_Base mcb
                 where mcb.case_stus in ('3', '4')
                   and (DEPT_CODE = '{2}' or 'ALL' = '{2}')
                   and trunc(mcb.out_date) >= to_date('{0}', 'yyyy-MM-dd')
                   and trunc(mcb.out_date) <= to_date('{1}', 'yyyy-MM-dd')
                    {3}) AA
          left join met_cas_firstpagecheck mcf
            on AA.inpatient_no = mcf.inpatient_no) BB
 where BB.回收人 is not null
 order by BB.回收时间";
        #endregion 

        DataSet ds = new DataSet();
       

        //科室
      //  Neusoft.HISFC.BizLogic.Manager.Department interManager = new Neusoft.HISFC.BizLogic.Manager.Department();

        private bool showAllDept = true;
        /// <summary>
        /// 使用科室
        /// </summary>
        [Category("设置"), Description("功能使用范围 true：全部科室 false ：当前登录科室")]
        public bool ShowAllDept
        {
            get { return showAllDept; }
            set { showAllDept = value; }
        }

        private bool showCASInfo = false;
        /// <summary>
        /// 使用科室
        /// </summary>
        [Category("设置"), Description("功能使用范围 true：电子信息编码后 false ：编码前，电子数据已经提交即可")]
        public bool ShowCASInfo
        {
            get { return showCASInfo; }
            set { showCASInfo = value; }
        }

        private string casInfoSql = @" and (fun_splitstring(mcb.henanadd2012, '|', 29) is null or
                       fun_splitstring(mcb.henanadd2012, '|', 29) != 'DOC')";
        #endregion 变量


        #region 方法
        #region 初始化
        protected override void OnLoad(EventArgs e)
        {
           
            /*
            //初始化科室下拉列表
            ArrayList al = new ArrayList();
            al = interManager.GetDeptment(Neusoft.HISFC.Models.Base.EnumDepartmentType.I);
            al.Insert(0, new Neusoft.FrameWork.Models.NeuObject("ALL", "全部", ""));
            cmbDept.AddItems(al);

            if (!showAllDept)
            {
                cmbDept.Tag = ((Neusoft.HISFC.Models.Base.Employee)interManager.Operator).Dept.ID;
                cmbDept.Enabled = false;
            }
            else
            {
                cmbDept.SelectedIndex = 0;
            }

            this.dtpBeginDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.AddMonths(-3).Month, 1);
            this.dtpEndDate.Value = DateTime.Today.AddDays(-1);
             * */
            base.OnLoad(e);
        }

        #endregion 初始化

        #region 查询
        protected override int OnQuery(object sender, object neuObject)
        {
            Query(); //查询
            return base.OnQuery(sender, neuObject);
        }

        private void SetFpStyle()
        {
            this.neuSpread1_Sheet1.Columns[2].Locked = true;
            this.neuSpread1_Sheet1.Columns[3].Locked = true;
            this.neuSpread1_Sheet1.Columns[4].Locked = true;
            this.neuSpread1_Sheet1.Columns[5].Locked = true;

            this.neuSpread1_Sheet2.Columns[0].Locked = true;
            this.neuSpread1_Sheet2.Columns[1].Locked = true;
            this.neuSpread1_Sheet2.Columns[2].Locked = false;
            this.neuSpread1_Sheet2.Columns[3].Locked = true;
            this.neuSpread1_Sheet2.Columns[4].Locked = true;
            this.neuSpread1_Sheet2.Columns[5].Locked = true;
            this.neuSpread1_Sheet2.Columns[6].Locked = true;
            this.neuSpread1_Sheet2.Columns[7].Locked = true;

            for (int i = 0; i < neuSpread1_Sheet1.Rows.Count; i++)
            {
                //总人数，和已经回收人数比较
                int unCol = NineVigor.FrameWork.Function.NConvert.ToInt32(this.neuSpread1_Sheet1.Cells[i, 2].Text);
                int havCol = NineVigor.FrameWork.Function.NConvert.ToInt32(this.neuSpread1_Sheet1.Cells[i, 5].Text);

                if (!"合计".Equals(this.neuSpread1_Sheet1.Cells[i, 5].Text))
                {
                    if (unCol == havCol)
                    {
                        neuSpread1_Sheet1.Rows[i].BackColor = Color.White;
                    }
                    else
                    {
                        neuSpread1_Sheet1.Rows[i].BackColor = Color.Red;
                    }
                }
                else
                {
                    neuSpread1_Sheet1.Rows[i].BackColor = Color.White;
                }
            }
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        protected int Query()
        {
            string tempSQL = null;
            string strErr = null;
            string strDept = null;
            string strDeptNM = null;
            DateTime dtBegin = new DateTime();
            DateTime dtEnd = new DateTime();
            DataTable dt = new DataTable();

            dtBegin = new DateTime(this.dtpBeginDate.Value.Year, this.dtpBeginDate.Value.Month, this.dtpBeginDate.Value.Day, 0, 0, 0);
            dtEnd = new DateTime(this.dtpEndDate.Value.Year, this.dtpEndDate.Value.Month, this.dtpEndDate.Value.Day, 23, 59, 59);

            strDept = cmbDept.SelectedItem.ID;
            strDeptNM = cmbDept.SelectedItem.Name;

            string caseInfo = string.Empty;
            if (showCASInfo)
            {
                caseInfo = casInfoSql;
            }
            tempSQL = string.Format(strSQL, dtBegin.ToString("yyyy-MM-dd"), dtEnd.ToString("yyyy-MM-dd"), strDept, caseInfo);
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
            dt = ds.Tables[0];

            #region
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(2, 1).Value = "查询时间：" + dtpBeginDate.Value.ToShortDateString() +
                                                                        " 至 " + dtpEndDate.Value.ToShortDateString() +
                                                                        "    科室：" + strDeptNM+
                                                                        "    共" + dt.Rows.Count.ToString() + "条记录";

            neuSpread1_Sheet1.RowCount = 0;    
            neuSpread1_Sheet1.DataSource =dt.DefaultView;
            neuTab.SelectedIndex = 0;
            SetFpStyle();
            #endregion
            return 1;

        }
       
        #endregion  查询
        #endregion 方法

        #region 打印事件
        protected override int OnPrint(object sender, object neuObject)
        {
            switch (this.neuTab.SelectedIndex)
            {
                case 0:
                    if (this.neuSpread1_Sheet1.RowCount > 0)
                    {
                        FarPoint.Win.Spread.PrintInfo pi = new FarPoint.Win.Spread.PrintInfo();
                        pi.Header = "/r /fz\"12\" 第 /p 页 共 /pc 页";// "/l第/p页共/pc页";
                        pi.ShowBorder = false;

                        float len = 0f;
                        for (int cidx = 0; cidx < this.neuSpread1_Sheet1.Columns.Count; cidx++)
                        {
                            len += this.neuSpread1_Sheet1.Columns[cidx].Width;
                        }

                        System.Drawing.Printing.PaperSize ps = new System.Drawing.Printing.PaperSize();
                        ps.Width = 1575;//px
                        ps.Height = NineVigor.FrameWork.Function.NConvert.ToInt32(945) + 134;//px
                        ps.PaperName = "sss";

                        pi.PaperSize = ps;


                        pi.Margin.Bottom = 15;
                        pi.Margin.Left = 35;
                        pi.Margin.Top = 50;
                        pi.Margin.Right = 0;

                        pi.UseMax = false;
                        this.neuSpread1_Sheet1.PrintInfo = pi;

                        this.neuSpread1.PrintSheet(this.neuSpread1.ActiveSheetIndex);
                    }
                    else
                    {
                        MessageBox.Show("没有要打印的数据");
                        return -1;
                    }
                    break;
                case 1:
                    if (this.neuSpread1_Sheet2.RowCount > 0)
                    {
                        FarPoint.Win.Spread.PrintInfo pi = new FarPoint.Win.Spread.PrintInfo();
                        pi.Header = "/r /fz\"12\" 第 /p 页 共 /pc 页";// "/l第/p页共/pc页";
                        pi.ShowBorder = false;

                        float len = 0f;
                        for (int cidx = 0; cidx < this.neuSpread1_Sheet2.Columns.Count; cidx++)
                        {
                            len += this.neuSpread1_Sheet2.Columns[cidx].Width;
                        }

                        System.Drawing.Printing.PaperSize ps = new System.Drawing.Printing.PaperSize();
                        ps.Width = 1575;//px
                        ps.Height = NineVigor.FrameWork.Function.NConvert.ToInt32(945) + 134;//px
                        ps.PaperName = "sss";

                        pi.PaperSize = ps;


                        pi.Margin.Bottom = 15;
                        pi.Margin.Left = 35;
                        pi.Margin.Top = 50;
                        pi.Margin.Right = 0;

                        pi.UseMax = false;
                        this.neuSpread1_Sheet2.PrintInfo = pi;

                        this.neuSpread2.PrintSheet(this.neuSpread2.ActiveSheetIndex);
                    }
                    else
                    {
                        MessageBox.Show("没有要打印的数据");
                        return -1;
                    }
                    break;
                case 2:
                    if (this.sheetView2.RowCount > 0)
                    {
                        FarPoint.Win.Spread.PrintInfo pi = new FarPoint.Win.Spread.PrintInfo();
                        pi.Header = "/r /fz\"12\" 第 /p 页 共 /pc 页";// "/l第/p页共/pc页";
                        pi.ShowBorder = false;

                        float len = 0f;
                        for (int cidx = 0; cidx < this.sheetView2.Columns.Count; cidx++)
                        {
                            len += this.sheetView2.Columns[cidx].Width;
                        }

                        System.Drawing.Printing.PaperSize ps = new System.Drawing.Printing.PaperSize();
                        ps.Width = 1575;//px
                        ps.Height = NineVigor.FrameWork.Function.NConvert.ToInt32(945) + 134;//px
                        ps.PaperName = "sss";

                        pi.PaperSize = ps;


                        pi.Margin.Bottom = 15;
                        pi.Margin.Left = 35;
                        pi.Margin.Top = 50;
                        pi.Margin.Right = 0;

                        pi.UseMax = false;
                        this.sheetView2.PrintInfo = pi;

                        this.neuSpread3.PrintSheet(this.neuSpread3.ActiveSheetIndex);
                    }
                    else
                    {
                        MessageBox.Show("没有要打印的数据");
                        return -1;
                    }
                    break;
                default:
                    break;
            }

            return 1;
        }
        #endregion

        #region 导出事件
        public override int Export(object sender, object neuObject)
        {
            System.Windows.Forms.SaveFileDialog dd = new SaveFileDialog();
            dd.Filter = "txt files (*.xls)|*.xls";
            if (dd.ShowDialog() == DialogResult.Cancel)
            {
                return 1;
            }
            this.neuSpread1_Sheet1.SaveHtml(dd.FileName);
            return 1;
        }

        #endregion

        /// <summary>
        /// 双击弹出患者明细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void neuSpread1_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            DateTime dtBegin = new DateTime();
            DateTime dtEnd = new DateTime();
            DataTable dt = new DataTable();
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            string tempSQL = "";
            string strErr = "";
            string strDeptNM = "";

            string strSubNM = "";

            dtBegin = new DateTime(this.dtpBeginDate.Value.Year, this.dtpBeginDate.Value.Month, this.dtpBeginDate.Value.Day, 0, 0, 0);
            dtEnd = new DateTime(this.dtpEndDate.Value.Year, this.dtpEndDate.Value.Month, this.dtpEndDate.Value.Day, 23, 59, 59);


            strSubNM = this.neuSpread1_Sheet1.Cells[e.Row, 0].Text;
            strDeptNM = this.neuSpread1_Sheet1.Cells[e.Row, 1].Text;
            string caseInfo = string.Empty;
            if (showCASInfo)
            {
                caseInfo = casInfoSql;
            }

            tempSQL = string.Format(strSQL2, dtBegin.ToString("yyyy-MM-dd"), dtEnd.ToString("yyyy-MM-dd"), strSubNM, caseInfo);
            string exeSql = string.Format(strSQL3, dtBegin.ToString("yyyy-MM-dd"), dtEnd.ToString("yyyy-MM-dd"), strSubNM, caseInfo);
            try
            {
               // interManager.ExecQuery(tempSQL, ref ds1);
                //interManager.ExecQuery(exeSql, ref ds2);
            }
            catch (Exception ex)
            {
                strErr = "查询数据失败！" + ex.Message;
                MessageBox.Show(strErr);
                neuSpread1_Sheet2.RowCount = 0;
                return  ;
            }

            if (ds2 != null && ds2.Tables.Count > 0 && ds2.Tables[0] != null)
            {
                this.sheetView2.ColumnHeader.Cells.Get(1, 0).Value = "病案已回收 查询时间：" + dtpBeginDate.Value.ToShortDateString() +
                                                                           " 至 " + dtpEndDate.Value.ToShortDateString() +
                                                                           "    科室：" + strDeptNM +
                                                                           "    共" + ds2.Tables[0].Rows.Count.ToString() + "条记录";

                sheetView2.RowCount = 0;

                sheetView2.DataSource = ds2.Tables[0].DefaultView;
            }

            if (ds1 != null && ds1.Tables.Count > 0 && ds1.Tables[0] != null)
            {
                dt = ds1.Tables[0];
                this.neuSpread1_Sheet2.ColumnHeader.Cells.Get(1, 0).Value = "病案未回收 查询时间：" + dtpBeginDate.Value.ToShortDateString() +
                                                                           " 至 " + dtpEndDate.Value.ToShortDateString() +
                                                                           "    科室：" + strDeptNM +
                                                                           "    共" + dt.Rows.Count.ToString() + "条记录";

                neuSpread1_Sheet2.RowCount = 0;

                neuSpread1_Sheet2.DataSource = dt.DefaultView;
            }
            neuTab.SelectedIndex = 1;

        }
    }
}
