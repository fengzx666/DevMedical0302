using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NineVigor.Domain.HealthRecord.Dto
{
    public interface ICasCallBack
    {
        /// <summary>
        /// 住院流水号
        /// </summary>		
        string Inpatient_no { get; set; }
        /// <summary>
        /// 病案号
        /// </summary>		
        string Patient_no { get; set; }
        /// <summary>
        /// 住院次数
        /// </summary>		
        decimal In_times { get; set; }
        /// <summary>
        /// 患者姓名
        /// </summary>		
        string Name { get; set; }
        /// <summary>
        /// 入院日期
        /// </summary>		
        DateTime In_date { get; set; }
        /// <summary>
        /// 出院日期
        /// </summary>		
        DateTime Out_date { get; set; }
        /// <summary>
        /// 出院科别名称
        /// </summary>		
        string Dept_name { get; set; }
        /// <summary>
        /// 出院科别编码
        /// </summary>		
        string Dept_code { get; set; }
        /// <summary>
        /// 审核时间
        /// </summary>		
        DateTime Checkdate { get; set; }
        /// <summary>
        /// 回收人姓名
        /// </summary>		
        string Opercode { get; set; }
    }
}
