using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.Utils;
using NineVigor.Domain.Authentication.Entity;

namespace NineVigor.Components.Analysis.Finance
{
    public partial class ucDeptWeekAnaly : NineVigor.FrameWork.WinForms.Controls.ucBaseControl
    {
        public ucDeptWeekAnaly()
        {
            InitializeComponent();
        }

        private List<String> condions = new List<string>();
        /// <summary>
        /// 准备数据内容
        /// </summary>
        /// <returns></returns>
        private DataTable CreateData()
        {

            if (this.nineCBSmallDept.SelectedItem == null || string.IsNullOrEmpty(this.nineCBSmallDept.SelectedItem.ID))
            {
                MessageBox.Show("请选择需要分析的统计科室。");
                return null;
            }
           
                NineVigor.BizLogic.Analysis.FinanceBiz finBiz = new NineVigor.BizLogic.Analysis.FinanceBiz();
            DataTable dt = null;

            int year = this.dtBeginDate.Value.Year;
            int weekNum = NineVigor.FrameWork.Common.CommonBiz.GetWeekOfYear(this.dtBeginDate.Value);

            int begWeekNum = 0;

            if (this.rbCurCheck.Checked)
            {
                if (string.IsNullOrEmpty(nvTextEdit1.Text.Trim()))
                {
                    MessageBox.Show("请填写需要对比分析的周数。");
                    nvTextEdit1.Focus();
                    return null;
                }
                int numZQ = 0;
                int.TryParse(nvTextEdit1.Text, out numZQ);
                if (weekNum - numZQ > 0)
                {
                    begWeekNum = weekNum - numZQ;
                    weekNum = weekNum + 1;
                }
                else
                {
                    begWeekNum = 0;
                    weekNum = weekNum + 1;
                }
            }
            else if (rbBeforeCheck.Checked)
            {
                condions.Clear();
                if (string.IsNullOrEmpty(nvTextEdit2.Text.Trim()))
                {
                    MessageBox.Show("请填写往期年度数。");
                    nvTextEdit2.Focus();
                    return null;
                }

                DateTime dtNow = this.dtBeginDate.Value;
                try
                {
                    int yearNum = 0;
                    int.TryParse(nvTextEdit2.Text, out yearNum);


                    for (int i = 0; i <= yearNum; i++)
                    {
                        condions.Add(dtNow.AddYears(0 - i).Year.ToString());
                    }
                }
                catch
                {
                    condions.Add(dtNow.Year.ToString());
                }
            }

            if (this.rbCurCheck.Checked)
            {
                if (this.nineCBSmallDept.SelectedItem != null && !string.IsNullOrEmpty(this.nineCBSmallDept.SelectedItem.ID))
                {
                    dt = finBiz.GetRegDeptWeekData(this.nineCBSmallDept.SelectedItem.ID, year, begWeekNum, weekNum);
                }
            }
            else if (this.rbBeforeCheck.Checked)
            {
                if (this.nineCBSmallDept.SelectedItem != null && !string.IsNullOrEmpty(this.nineCBSmallDept.SelectedItem.ID))
                {
                    dt = finBiz.GetRegDeptWeekBeforeData(this.nineCBSmallDept.SelectedItem.ID, condions, weekNum);
                }
            }
            return dt;
        }

        protected override int OnQuery(object sender, object neuObject)
        {
            DataTable dt = CreateData();
            if (dt != null)
            {
                CreateChart(dt);
            }
            return 1;
        }
        private void CreateChart(DataTable dt)
        {
            #region Series
            List<Series> list = new List<Series>();
            int iCount = 0;
            list.Clear();
            foreach (DataRow drItem in dt.Rows)
            {
                Series series1 = CreateSeries(drItem[0].ToString(), ViewType.Bar, dt, iCount);
                iCount = iCount + 1;
                list.Add(series1);

            }

            #endregion
            chartControl1.Series.Clear();
            chartControl1.Titles.Clear();
            chartControl1.Series.AddRange(list.ToArray());
            
            chartControl1.Legend.Visible = true;
            chartControl1.SeriesTemplate.LabelsVisibility = DefaultBoolean.True;
            ChartTitle chartTitle = new ChartTitle();
            string titleStr = string.Empty;
            if (this.rbBeforeCheck.Checked)
            {
                titleStr = "往期";
            }
            else
            {
                titleStr = "同期";
            }
            chartTitle.Text = this.nineCBSmallDept.SelectedItem.Name + titleStr + "挂号人数分析";
            chartControl1.Titles.Add(chartTitle);
            for (int i = 0; i < list.Count; i++)
            {
                //  list[i].View.Color = colorList[i];

                // CreateAxisY(list[i]);
            }
        }

        /// <summary>
        /// 根据数据创建一个图形展现
        /// </summary>
        /// <param name="caption">图形标题</param>
        /// <param name="viewType">图形类型</param>
        /// <param name="dt">数据DataTable</param>
        /// <param name="rowIndex">图形数据的行序号</param>
        /// <returns></returns>
        private Series CreateSeries(string caption, ViewType viewType, DataTable dt, int rowIndex)
        {
            Series series = new Series(caption, viewType);

            int curMonth = System.DateTime.Now.Month;
            int curYear = System.DateTime.Now.Year;
            //  int dataYear = int.Parse(caption);

            for (int i = 1; i < dt.Columns.Count; i++)
            {
                string argument = dt.Columns[i].ColumnName;//参数名称
                decimal value = (decimal)dt.Rows[rowIndex][i];//参数值
                series.Points.Add(new SeriesPoint(argument, value));
            }

            //必须设置ArgumentScaleType的类型，否则显示会转换为日期格式，导致不是希望的格式显示
            //也就是说，显示字符串的参数，必须设置类型为ScaleType.Qualitative
            series.ArgumentScaleType = ScaleType.Qualitative;
            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;//显示标注标签

            return series;
        }
        /// <summary>
        /// 创建图表的第二坐标系
        /// </summary>
        /// <param name="series">Series对象</param>
        /// <returns></returns>
        private SecondaryAxisY CreateAxisY(Series series)
        {
            SecondaryAxisY myAxis = new SecondaryAxisY(series.Name);
            ((XYDiagram)chartControl1.Diagram).SecondaryAxesY.Add(myAxis);
            ((LineSeriesView)series.View).AxisY = myAxis;
            myAxis.Title.Text = series.Name;
            myAxis.Title.Alignment = StringAlignment.Far; //顶部对齐
            myAxis.Title.Visible = true; //显示标题
            myAxis.Title.Font = new Font("宋体", 9.0f);

            Color color = series.View.Color;//设置坐标的颜色和图表线条颜色一致

            myAxis.Title.TextColor = color;
            myAxis.Label.TextColor = color;
            myAxis.Color = color;

            return myAxis;
        }

        private void ucDeptWeekAnaly_Load(object sender, EventArgs e)
        {
            Group group = new Group();
            group.Dept_Type = "C";
            List<Group> depts = group.GetDeptInfoByDeptType();
            this.nineCBSmallDept.IsListOnly = true;
            this.nineCBSmallDept.AddListItems(depts);//填充所属科室ComboBox
            this.dtBeginDate.Value = DateTime.Now.AddDays(-7);
        }

        private void rbBeforeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbBeforeCheck.Checked)
            {
                nvTextEdit1.Text = "";
                if (string.IsNullOrEmpty(nvTextEdit2.Text))
                {
                    nvTextEdit2.Text = "1";
                }
            }
            else
            {
                nvTextEdit2.Text = "";
                if (string.IsNullOrEmpty(nvTextEdit1.Text))
                {
                    nvTextEdit1.Text = "1";
                }
            }
        }

        private void rbCurCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbBeforeCheck.Checked)
            {
                nvTextEdit1.Text = "";
                if (string.IsNullOrEmpty(nvTextEdit2.Text))
                {
                    nvTextEdit2.Text = "1";
                }
            }
            else
            {
                nvTextEdit2.Text = "";
                if (string.IsNullOrEmpty(nvTextEdit1.Text))
                {
                    nvTextEdit1.Text = "1";
                }
            }
        }
    }
}
