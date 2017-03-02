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
    public partial class ucMetCasReCallPrintWithNo : NineVigor.FrameWork.WinForms.Controls.ucBaseControl
    {
        public ucMetCasReCallPrintWithNo()
        {
            InitializeComponent();
        }

        #region 变量
        string strSQL = @" 
select AA.*,B.INPATIENT_SEQNO 上架号
  from (select cg.dept_name 科室名称,
               cg.patient_no 病案号,
               to_Char(cg.in_times) 住院次数,
               cg.name 患者姓名,
               cg.checkdate 回收时间,
               fun_get_empl_name(cg.opercode) 回收人,
               to_Char(cg.in_Date, 'yyyy-MM-dd') 入院日期,
               to_Char(cg.out_Date, 'yyyy-MM-dd') 出院日期,
               cg.inpatient_no 住院流水号
          from met_cas_firstpagecheck cg
         where cg.checkdate >= to_date('{0}', 'yyyy-MM-dd HH24:mi:ss')
           and cg.checkdate <= to_date('{1}', 'yyyy-MM-dd HH24:mi:ss')
           and (cg.dept_Code = '{2}' or 'ALL' = '{2}')
           and (cg.opercode = '{3}' or 'ALL' = '{3}') {4}
         order by checkDate asc) AA
  left join met_cas_firstpage_print b
    on AA.住院流水号 = b.inpatient_no";

        string insertSql = @"insert into Met_Cas_Firstpage_print
  (INPATIENT_NO,
   PATIENT_NO,
   IN_TIMES,
   INPATIENT_SEQNO,
   PLANTNO,
   SBIGLOC,
   SLVLLOC,
   SLOCATION,
   LOCYEARMONTHDD,
   OUTYEARMONTHDD,
   SEQNO)
values
  ('{0}',
   '{1}',
   '{2}',
   '{3}',
   '{4}',
   '{5}',
   '{6}',
   '{7}',
   '{8}',
   '{9}',
   '{10}')";
        DataSet ds = new DataSet();

        //科室
      //  Neusoft.HISFC.BizLogic.Manager.Department interManager = new Neusoft.HISFC.BizLogic.Manager.Department();
        //NorthChina.HealthRecord.Common.ConstVariable constVar = new NorthChina.HealthRecord.Common.ConstVariable();
        #endregion 变量
        #region 方法
        #region 初始化
        protected override void OnLoad(EventArgs e)
        {
            /*
            this.neuSpread1_Sheet1.PrintInfo.UseMax = false;
            //初始化查询人员
            //cmbOperCode
            Neusoft.HISFC.BizLogic.Manager.Person person = new Neusoft.HISFC.BizLogic.Manager.Person();
            ArrayList operList = person.GetEmployeeByZhu(((Neusoft.HISFC.Models.Base.Employee)person.Operator).Dept.ID);
            operList.Insert(0, new Neusoft.FrameWork.Models.NeuObject("ALL", "全部", ""));
            cmbOperCode.AddItems(operList);
            cmbOperCode.SelectedIndex = 0;
            //初始化科室下拉列表
            ArrayList al = new ArrayList();
            al = interManager.GetDeptment(Neusoft.HISFC.Models.Base.EnumDepartmentType.I);
            al.Insert(0, new Neusoft.FrameWork.Models.NeuObject("ALL", "全部", ""));
            cmbDept.AddItems(al);
            cmbDept.SelectedIndex = 0;
             * */
        }

        private int printWidth = 0;

        public int PrintWidth
        {
            get { return printWidth; }
            set { printWidth = value; }
        }
        private int printHeight = 0;

        public int PrintHeight
        {
            get { return printHeight; }
            set { printHeight = value; }
        }

        #endregion 初始化

        #region 查询
        protected override int OnQuery(object sender, object neuObject)
        {
            return Query();
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

            dtBegin = this.dtpBeginDate.Value;
            dtEnd = this.dtpEndDate.Value;

            strDept = cmbDept.SelectedItem.ID;
            strDeptNM = cmbDept.SelectedItem.Name;

           string strOperCode = this.cmbOperCode.SelectedItem.ID;
            string patientNo = string.Empty;

            if (!string.IsNullOrEmpty(ntbNM.Text.Trim()))
            {
                patientNo = " and (cg.patient_no like '%"+ntbNM.Text.Trim()+"' ) ";
            }

            tempSQL = string.Format(strSQL, dtBegin, dtEnd, strDept, strOperCode, patientNo);
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
            this.neuSpread1_Sheet1.ColumnHeader.Cells.Get(1, 0).Value = "查询时间：" + dtpBeginDate.Value +
                                                                        " 至 " + dtpEndDate.Value +
                                                                        "     查询科室：" + strDeptNM +
                                                                        "     共" + dt.Rows.Count.ToString() + "条记录";


            neuSpread1_Sheet1.DataSource = dt.DefaultView;
            #endregion

            return 1;

        }
        #endregion  查询
        #endregion 方法

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
            toolBarService.AddToolButton("打印A4", "打印A4", (int)NineVigor.FrameWork.WinForms.Classes.EnumImageList.C查询, true, false, null);

            toolBarService.AddToolButton("打印A4+", "打印A4+", (int)NineVigor.FrameWork.WinForms.Classes.EnumImageList.D打印, true, false, null);
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
                case "打印A4":
                    OnPrintA4();
                    break;

                case "打印A4+":
                    OnPrintA4Record();
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region 事件

        #region 过滤事件
        /// <summary>
        /// 过滤
        /// </summary>
        /// <returns></returns>
        protected int Filter()
        {

            if (ds.Tables.Count <= 0)
            {
                return -1;
            }


            string strPID = null;
            string strNM = null;

            strPID = "";
            strNM = NineVigor.FrameWork.Public.String.TakeOffSpecialChar(this.ntbNM.Text.Trim());
            try
            {

                ds.Tables[0].DefaultView.RowFilter = "住院号 like '%" + strPID + "%' AND 姓名 like  '%" + strNM + "%'";



            }
            catch (Exception ex)
            {
                MessageBox.Show("查询失败！" + ex.Message);
                return -1;
            }



            return 1;

        }

        private void ntbPatientID_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }
        #endregion 过滤事件

        #region 打印事件

        private void OnPrintA4Record()
        {
            int seqNoStart=1;
            string dataPre = GetSeqNo(ref seqNoStart);
            string dataMM = dataPre.Substring(0, 4);
            //查询出最大的号
            if (this.neuSpread1_Sheet1.RowCount > 0)
            {
                for (int i = 0; i < this.neuSpread1_Sheet1.RowCount; i++)
                {
                    string oldSqlNo = this.neuSpread1_Sheet1.Cells[i, 9].Text;

                    string inSeqNo = dataMM + seqNoStart.ToString().PadLeft(5, '0') + "-" + dataPre;
                    if (!string.IsNullOrEmpty(oldSqlNo))
                    {
                        inSeqNo = oldSqlNo;
                    }
                    else
                    {
                        //住院号，
                        string exeExcSql = string.Format(insertSql,
                            this.neuSpread1_Sheet1.Cells[i, 8].Text,
                            this.neuSpread1_Sheet1.Cells[i, 1].Text,
                            this.neuSpread1_Sheet1.Cells[i, 2].Text,
                            inSeqNo,
                        "", "", "", "",
                        dataPre,
                        "",
                        seqNoStart.ToString());

                        NineVigor.FrameWork.Management.PublicTrans.BeginTransaction();
                        int result = 1;// interManager.ExecNoQuery(exeExcSql);
                        if (result < 0)
                        {
                            NineVigor.FrameWork.Management.PublicTrans.RollBack();
                            MessageBox.Show("病案号:" + this.neuSpread1_Sheet1.Cells[i, 1].Text + " 生成打印货架号出错。");
                            return;
                        }
                        NineVigor.FrameWork.Management.PublicTrans.Commit();
                    }

                    ucMetCasReCallPrintPanel2 pp = new ucMetCasReCallPrintPanel2();
                    string[] arrs = new string[] { this.neuSpread1_Sheet1.Cells[i, 1].Text, 
                        this.neuSpread1_Sheet1.Cells[i, 3].Text,
                        this.neuSpread1_Sheet1.Cells[i, 0].Text, 
                        this.neuSpread1_Sheet1.Cells[i, 8].Text,
                    this.neuSpread1_Sheet1.Cells[i, 7].Text,
                    inSeqNo
                    };
                    pp.PrintWidth = PrintWidth;
                    pp.PrintHeight = PrintHeight;

                    pp.SetControlValue(arrs);
                    pp.Print();

                    if (string.IsNullOrEmpty(oldSqlNo))
                    {
                        seqNoStart = seqNoStart + 1;
                    }
                }

            }
            else
            {
                MessageBox.Show("没有要打印的数据");
            }

        }

        private void OnPrintA4()
        {
            if (this.neuSpread1_Sheet1.RowCount > 0)
            {
                FarPoint.Win.Spread.PrintInfo pi = new FarPoint.Win.Spread.PrintInfo();

                //pi.Header = "/r /fz\"12\" 第 /p 页 共 /pc 页";// "/l第/p页共/pc页";
                pi.ShowBorder = false;

                float len = 0f;
                for (int cidx = 0; cidx < this.neuSpread1_Sheet1.Columns.Count; cidx++)
                {
                    len += this.neuSpread1_Sheet1.Columns[cidx].Width;
                }


                //pi.Orientation = FarPoint.Win.Spread.PrintOrientation.Landscape;
                pi.Centering = FarPoint.Win.Spread.Centering.Horizontal;

                pi.UseMax = false;
                this.neuSpread1_Sheet1.PrintInfo = pi;
                this.neuSpread1_Sheet1.PrintInfo.ShowPrintDialog = true;
                this.neuSpread2.PrintSheet(this.neuSpread2.ActiveSheetIndex);

            }
            else
            {
                MessageBox.Show("没有要打印的数据");
            }
        
        }

        protected override int OnPrint(object sender, object neuObject)
        {
            if (this.neuSpread1_Sheet1.RowCount > 0)
            {
                for (int i = 0; i < this.neuSpread1_Sheet1.RowCount; i++)
                {
                    ucMetCasReCallPrintPanel pp = new ucMetCasReCallPrintPanel();
                    string[] arrs = new string[] { this.neuSpread1_Sheet1.Cells[i, 1].Text, 
                        this.neuSpread1_Sheet1.Cells[i, 3].Text,
                        this.neuSpread1_Sheet1.Cells[i, 0].Text, 
                        this.neuSpread1_Sheet1.Cells[i, 8].Text,
                    this.neuSpread1_Sheet1.Cells[i, 7].Text};
                    pp.PrintWidth = PrintWidth;
                    pp.PrintHeight = PrintHeight;

                    pp.SetControlValue(arrs);
                    pp.Print();
                }
            }
            else
            {
                MessageBox.Show("没有要打印的数据");
                return -1;
            }
            return 1;
        }
        #endregion

        #region 导出事件
        public override int Export(object sender, object neuObject)
        {
            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xls";
            saveDialog.Filter = "Excel|*.xls";
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.Cancel)
            {
                return 0;
            }
            saveFileName = saveDialog.FileName;
            string errMsg = "";
            /*
            if (NorthChina.HealthRecord.Common.ExcelExport.Export(saveFileName, "", this.ds, ref errMsg) < 0)
            {
                MessageBox.Show(errMsg);
                return -1;
            }
             * */
            return 1;
        }

        #endregion


        private string GetSeqNo(ref int seqNo)
        {
            DateTime dtNow = DateTime.Now;// interManager.GetDateTimeFromSysDateTime();
            string dataPre = dtNow.ToString("yyMMdd");

            string exeSql = @"select nvl(max(g.seqno)+1,1) 序号 from Met_Cas_Firstpage_print g
   where substr(g.locyearmonthdd,1,4)='{0}'";

            exeSql = string.Format(exeSql, dataPre.Substring(0, 4));

          //  seqNo = Neusoft.FrameWork.Function.NConvert.ToInt32(interManager.ExecSqlReturnOne(exeSql));

            return dataPre;
        }
        #endregion 事件
    }
}
