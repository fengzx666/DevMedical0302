using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NineVigor.Domain.Authentication.Entity;
using DevExpress.XtraCharts;
using DevExpress.Utils;

namespace NineVigor.Components.Analysis.InMain
{
    public partial class ucInMainProvinceArea : NineVigor.FrameWork.WinForms.Controls.ucBaseControl
    {
        public ucInMainProvinceArea()
        {
            InitializeComponent();
        }

        private Series seriesCommon = null;

        private void ucInMainProvinceArea_Load(object sender, EventArgs e)
        {
            Group group = new Group();
            group.Dept_Type = "I";
            List<Group> depts = group.GetDeptInfoByDeptType();

            Group groupALL = new Group();
            groupALL.ID = "ALL";
            groupALL.Name = "全部";
            groupALL.SpellCode = "QB";
            depts.Insert(0,groupALL);
            this.nineCBSmallDept.IsListOnly = true;
            this.nineCBSmallDept.AddListItems(depts);//填充所属科室ComboBox
            this.dtBeginDate.Value = DateTime.Now.AddDays(-7);
            this.dtEnd.Value = DateTime.Now.AddDays(-6);

            this.nineCBSmallDept.SelectedIndex = 0;

            seriesCommon = this.chartControl1.Series[0];
            this.chartControl1.Series.Clear();
        }


        private List<String> condions = new List<string>();
        private DataTable dt = null;
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


            dt = finBiz.GetAreaProvinceInCityData("ALL", this.dtBeginDate.Value.ToString("yyyy-MM-dd"), this.dtEnd.Value.ToString("yyyy-MM-dd"));
            
            return dt;
        }

        protected override int OnQuery(object sender, object neuObject)
        {
             dt = CreateData();
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

            if (dt == null)
                return;

            foreach (DataRow drItem in dt.Rows)
            {
                Series series1 = CreateSeries(drItem[0].ToString(), ViewType.Pie, dt, iCount);
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

            chartTitle.Text = "省内地市住院人次分析（单位：人次） 分析记录数:" + dt.Rows[0][0].ToString();
            chartControl1.Titles.Add(chartTitle);

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
            Series series = seriesCommon;
            series.Points.Clear();
            int curMonth = System.DateTime.Now.Month;
            int curYear = System.DateTime.Now.Year;
            //  int dataYear = int.Parse(caption);
            if (dt == null)
                return null;

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateChart(dt);
        }
    }
}
