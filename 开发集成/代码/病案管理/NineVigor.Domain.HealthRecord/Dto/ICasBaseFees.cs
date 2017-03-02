using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NineVigor.Domain.HealthRecord.Dto
{
   public interface ICasBaseFees
    {
        /// <summary>
        /// 住院流水号
        /// </summary>		
        string Inpatient_no { get; set; }
        /// <summary>
        /// 科室号
        /// </summary>		
        string Dept_code { get; set; }
        /// <summary>
        /// 费用大类代码
        /// </summary>		
        string Fee_id { get; set; }
        /// <summary>
        /// 费用大类名称
        /// </summary>		
        string Fee_name { get; set; }
        /// <summary>
        /// 费用金额
        /// </summary>		
        decimal Tot_cost { get; set; }
        /// <summary>
        /// 出院日期
        /// </summary>		
        DateTime Cout_date { get; set; }
        /// <summary>
        /// 出院诊断
        /// </summary>		
        string Icd_code { get; set; }
        /// <summary>
        /// 操作员
        /// </summary>		
        string Oper_code { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>		
        DateTime Oper_date { get; set; }
    }
}
