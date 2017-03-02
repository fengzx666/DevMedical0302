using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using System.Collections.Specialized;

namespace NineVigor.BizLogic.Analysis
{
    /// <summary>
    /// 财务数据分析财务数据类
    /// </summary>
    public class FinanceBiz : NineVigor.FrameWork.Management.Database
    {
        /// <summary>
        /// 获取挂号年度数据分析
        /// </summary>
        /// <param name="listStr"></param>
        /// <returns></returns>
        public DataTable GetRegYearData(List<string> listStr)
        {
            string condition = string.Empty;

            foreach (string itemStr in listStr)
            {
                condition += "'" + itemStr + "',";
            }
            if (condition.Length > 0)
            {
                condition = condition.TrimEnd(',');
            }
            else
            {
                return null;
            }

            string exeSql = string.Empty;
            DataSet ds = new DataSet();

            if (this.Sql.GetSql("Etl.Fin.OpbReg.GetYearNumber", ref exeSql) < 0)
            {
            }
            exeSql = string.Format(exeSql, condition);
            this.ExecQuery(exeSql, ref ds);
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deptCode"></param>
        /// <param name="year"></param>
        /// <param name="beginWeek"></param>
        /// <param name="endWeek"></param>
        /// <returns></returns>
        public DataTable GetRegDeptWeekData(string deptCode,int year,int beginWeek,int endWeek)
        {
            string exeSql = string.Empty;
            DataSet ds = new DataSet();

            if (this.Sql.GetSql("Etl.Fin.OpbReg.GetDeptWeekNumber", ref exeSql) < 0)
            {
            }
            exeSql = string.Format(exeSql, year.ToString(),beginWeek.ToString(),endWeek.ToString(),deptCode);
            this.ExecQuery(exeSql, ref ds);
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取挂号数据往期分析对比
        /// </summary>
        /// <param name="deptCode"></param>
        /// <param name="yearStr"></param>
        /// <param name="beginWeek"></param>
        /// <returns></returns>
        public DataTable GetRegDeptWeekBeforeData(string deptCode, List<string> yearStr, int beginWeek)
        {
            string condition = string.Empty;

            foreach (string itemStr in yearStr)
            {
                condition += "'" + itemStr + "',";
            }
            if (condition.Length > 0)
            {
                condition = condition.TrimEnd(',');
            }
            else
            {
                return null;
            }
            string exeSql = string.Empty;
            DataSet ds = new DataSet();

            if (this.Sql.GetSql("Etl.Fin.OpbReg.GetDeptWeekNumberBefore", ref exeSql) < 0)
            {
                return null;
            }
            exeSql = string.Format(exeSql, condition, beginWeek.ToString(), deptCode);
            this.ExecQuery(exeSql, ref ds);
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }


        #region 费用信息查询SQL内容
        /// <summary>
        /// 获取科室
        /// </summary>
        /// <param name="deptCondition"></param>
        /// <param name="yearStr"></param>
        /// <param name="feeType"></param>
        /// <param name="feeDeptType"></param>
        /// <returns></returns>
        public DataTable GetFeeDeptYearData(string deptCondition, string yearStr, string feeType, string feeDeptType)
        {
            string condition = string.Empty;

      
            string exeSql = string.Empty;
            DataSet ds = new DataSet();

            if (this.Sql.GetSql("Etl.Fin.Fee.GetYearFeeCost", ref exeSql) < 0)
            {
                return null;
            }
            exeSql = string.Format(exeSql, yearStr, feeType, feeDeptType, deptCondition);
            this.ExecQuery(exeSql, ref ds);
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }
        #endregion


        #region 住院信息查询SQL内容
        /// <summary>
        /// 获取科室
        /// </summary>
        /// <param name="deptCondition"></param>
        /// <param name="yearStr"></param>
        /// <param name="feeType"></param>
        /// <param name="feeDeptType"></param>
        /// <returns></returns>
        public DataTable GetProofData(string deptCondition, string beginStr, string endStr)
        {
            string exeSql = string.Empty;
            DataSet ds = new DataSet();

            if (this.Sql.GetSql("Etl.Fin.OpbReg.Proof.Info", ref exeSql) < 0)
            {
            }
            exeSql = string.Format(exeSql, beginStr, endStr, deptCondition);
            this.ExecQuery(exeSql, ref ds);
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="deptCondition"></param>
        /// <param name="beginStr"></param>
        /// <param name="endStr"></param>
        /// <returns></returns>
        public DataTable GetProofMinusData(string deptCondition, string beginStr, string endStr)
        {
            string exeSql = string.Empty;
            DataSet ds = new DataSet();

            if (this.Sql.GetSql("Etl.Fin.OpbReg.Proof.MinusData.Info", ref exeSql) < 0)
            {
            }
            exeSql = string.Format(exeSql, beginStr, endStr, deptCondition);
            this.ExecQuery(exeSql, ref ds);
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deptCondition"></param>
        /// <param name="beginStr"></param>
        /// <param name="endStr"></param>
        /// <returns></returns>
        public DataTable GetAreaProvinceOutInData(string deptCondition, string beginStr, string endStr)
        {
            string exeSql = string.Empty;
            DataSet ds = new DataSet();

            if (this.Sql.GetSql("Etl.Fin.InMain.Area.ProvinceOutInfo", ref exeSql) < 0)
            {
            }
            exeSql = string.Format(exeSql, beginStr, endStr, deptCondition);
            this.ExecQuery(exeSql, ref ds);
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deptCondition"></param>
        /// <param name="beginStr"></param>
        /// <param name="endStr"></param>
        /// <returns></returns>
        public DataTable GetAreaProvinceInCityData(string deptCondition, string beginStr, string endStr)
        {
            string exeSql = string.Empty;
            DataSet ds = new DataSet();

            if (this.Sql.GetSql("Etl.Fin.InMain.Area.ProvinceInData.Info", ref exeSql) < 0)
            {
            }
            exeSql = string.Format(exeSql, beginStr, endStr, deptCondition);
            this.ExecQuery(exeSql, ref ds);
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deptCondition"></param>
        /// <param name="beginStr"></param>
        /// <param name="endStr"></param>
        /// <returns></returns>
        public DataTable GetAreaProvinceOutCityData(string deptCondition, string beginStr, string endStr)
        {
            string exeSql = string.Empty;
            DataSet ds = new DataSet();

            if (this.Sql.GetSql("Etl.Fin.InMain.Area.ProvinceOut.CityInfo", ref exeSql) < 0)
            {
            }
            exeSql = string.Format(exeSql, beginStr, endStr, deptCondition);
            this.ExecQuery(exeSql, ref ds);
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="deptCondition"></param>
        /// <param name="beginStr"></param>
        /// <param name="endStr"></param>
        /// <returns></returns>
        public DataTable GetInMainFeeData(string deptCondition, string beginStr, string endStr)
        {
            string exeSql = string.Empty;
            DataSet ds = new DataSet();

            if (this.Sql.GetSql("Etl.Fin.InMain.Patient.Fee.1", ref exeSql) < 0)
            {
            }
            exeSql = string.Format(exeSql, beginStr, endStr, deptCondition);
            this.ExecQuery(exeSql, ref ds);
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deptCondition"></param>
        /// <param name="beginStr"></param>
        /// <param name="endStr"></param>
        /// <returns></returns>
        public DataTable GetInMainFeeData2(string deptCondition, string beginStr, string endStr)
        {
            string exeSql = string.Empty;
            DataSet ds = new DataSet();

            if (this.Sql.GetSql("Etl.Fin.InMain.Patient.Fee.2", ref exeSql) < 0)
            {
            }
            exeSql = string.Format(exeSql, beginStr, endStr, deptCondition);
            this.ExecQuery(exeSql, ref ds);
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deptCondition"></param>
        /// <param name="beginStr"></param>
        /// <param name="endStr"></param>
        /// <returns></returns>
        public DataTable GetInMainFeeData3(string deptCondition, string beginStr, string endStr)
        {
            string exeSql = string.Empty;
            DataSet ds = new DataSet();

            if (this.Sql.GetSql("Etl.Fin.InMain.Patient.Fee.3", ref exeSql) < 0)
            {
            }
            exeSql = string.Format(exeSql, beginStr, endStr, deptCondition);
            this.ExecQuery(exeSql, ref ds);
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }
        
        #endregion
    }
}
