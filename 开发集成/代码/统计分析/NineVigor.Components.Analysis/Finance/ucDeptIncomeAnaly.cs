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

namespace NineVigor.Components.Analysis.Finance
{
    public partial class ucDeptIncomeAnaly : NineVigor.FrameWork.WinForms.Controls.ucBaseControl
    {
        public ucDeptIncomeAnaly()
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
            NineVigor.BizLogic.Analysis.FinanceBiz finBiz = new NineVigor.BizLogic.Analysis.FinanceBiz();
            List<String> condions = new List<string>();
            condions.Clear();
            int beginYear = this.dtBeginDate.Value.Year;
            int endYear = this.dtEndDate.Value.Year;

            for (int i = beginYear; i <= endYear; i++)
            {
                condions.Add(i.ToString());
            }

            DataTable dt = finBiz.GetRegYearData(condions);
         
            return dt;
        }

        protected override int OnQuery(object sender, object neuObject)
        {
            DataTable dt = CreateData();
            if (dt != null)
            {
                this.nineSpreadUserInfo_Sheet1.DataSource = dt.DefaultView;
                CreateChart(dt);
            }
            return 1;
        }
        private void CreateChart(DataTable dt)
        {
            #region 内容
            List<string> conds = new List<string>();

            int beginYear = this.dtBeginDate.Value.Year;
            int endYear = this.dtEndDate.Value.Year;

            for (int i = beginYear; i <= endYear; i++)
            {
                conds.Add(i.ToString());
            }
            #endregion

            #region Series
            List<Series> list = new List<Series>();
            int iCount=0;
            list.Clear();
            foreach (String itemStr in conds)
            {
                Series series1=CreateSeries(itemStr, ViewType.Spline, dt, iCount);
                
                iCount=iCount+1;
                list.Add(series1);
            }
            #endregion
            chartControl1.Series.Clear();
            chartControl1.Series.AddRange(list.ToArray());
           
            chartControl1.Legend.Visible = true;
            chartControl1.SeriesTemplate.LabelsVisibility = DefaultBoolean.True;

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
            int curYear=System.DateTime.Now.Year;
            int dataYear=int.Parse(caption);

            for (int i = 1; i < dt.Columns.Count; i++)
            {
                if (dataYear == curYear && i >= curMonth)
                {
                }
                else
                {

                    string argument = dt.Columns[i].ColumnName;//参数名称
                    decimal value = (decimal)dt.Rows[rowIndex][i];//参数值
                    series.Points.Add(new SeriesPoint(argument, value));
                   
                }
            }

            //必须设置ArgumentScaleType的类型，否则显示会转换为日期格式，导致不是希望的格式显示
            //也就是说，显示字符串的参数，必须设置类型为ScaleType.Qualitative
            series.ArgumentScaleType = ScaleType.Qualitative;
            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;//显示标注标签

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

        private void ucDeptIncomeAnaly_Load(object sender, EventArgs e)
        {
            DataTable dt = CreateData();
            if (dt != null)
            {
                CreateChart(dt);
                this.nineSpreadUserInfo_Sheet1.DataSource = dt.DefaultView;
               
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.nineSpreadUserInfo.Visible = !this.nineSpreadUserInfo.Visible;
        }
    }
}
