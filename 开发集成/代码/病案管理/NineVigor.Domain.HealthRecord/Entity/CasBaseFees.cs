using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NineVigor.FrameWork.DataAccess;
using NineVigor.Domain.HealthRecord.Dto;

namespace NineVigor.Domain.HealthRecord.Entity
{
   public class CasBaseFees:BaseEntity, ICasBaseFees
   {
       #region 变量
       /// <summary>
       /// 住院流水号
       /// </summary>		
       private string inpatient_no;
       /// <summary>
       /// 科室号
       /// </summary>		
       private string dept_code;
       /// <summary>
       /// 费用大类代码
       /// </summary>		
       private string fee_id;
       /// <summary>
       /// 费用大类名称
       /// </summary>		
       private string fee_name;
       /// <summary>
       /// 费用金额
       /// </summary>		
       private decimal tot_cost;
       /// <summary>
       /// 出院日期
       /// </summary>		
       private DateTime cout_date;
       /// <summary>
       /// 出院诊断
       /// </summary>		
       private string icd_code;
       /// <summary>
       /// 操作员
       /// </summary>		
       private string oper_code;
       /// <summary>
       /// 操作时间
       /// </summary>		
       private DateTime oper_date;
       #endregion

       #region 属性
       	/// <summary>
		/// 住院流水号
        /// </summary>		
        public string Inpatient_no
        {
            get{ return inpatient_no; }
            set{ inpatient_no = value; }
        }        
		/// <summary>
		/// 科室号
        /// </summary>		
        public string Dept_code
        {
            get{ return dept_code; }
            set{ dept_code = value; }
        }        
		/// <summary>
		/// 费用大类代码
        /// </summary>		
        public string Fee_id
        {
            get{ return fee_id; }
            set{ fee_id = value; }
        }        
		/// <summary>
		/// 费用大类名称
        /// </summary>		
        public string Fee_name
        {
            get{ return fee_name; }
            set{ fee_name = value; }
        }        
		/// <summary>
		/// 费用金额
        /// </summary>		
        public decimal Tot_cost
        {
            get{ return tot_cost; }
            set{ tot_cost = value; }
        }        
		/// <summary>
		/// 出院日期
        /// </summary>		
        public DateTime Cout_date
        {
            get{ return cout_date; }
            set{ cout_date = value; }
        }        
		/// <summary>
		/// 出院诊断
        /// </summary>		
        public string Icd_code
        {
            get{ return icd_code; }
            set{ icd_code = value; }
        }        
		/// <summary>
		/// 操作员
        /// </summary>		
        public string Oper_code
        {
            get{ return oper_code; }
            set{ oper_code = value; }
        }        
		/// <summary>
		/// 操作时间
        /// </summary>		
        public DateTime Oper_date
        {
            get{ return oper_date; }
            set{ oper_date = value; }
        }     
       #endregion
   }
}
