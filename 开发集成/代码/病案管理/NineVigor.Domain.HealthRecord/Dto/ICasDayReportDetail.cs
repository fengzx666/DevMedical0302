using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NineVigor.Domain.HealthRecord.Dto
{
   public interface ICasDayReportDetail
    {
        /// <summary>
        /// 统计日期
        /// </summary>		
        DateTime Stat_date { get; set; }
        /// <summary>
        /// 病房代码
        /// </summary>		
        string Dept_code { get; set; }
        /// <summary>
        /// 护士站代码
        /// </summary>		
        string Nurse_cell_code { get; set; }
        /// <summary>
        /// 住院流水号
        /// </summary>		
        string Inpatient_no { get; set; }
        /// <summary>
        /// 床号
        /// </summary>		
        string Bed_no { get; set; }
        /// <summary>
        /// 统计类型
        /// </summary>		
        string Stat_type { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>		
        string Oper_code { get; set; }
        /// <summary>
        /// 操作日期
        /// </summary>		
        DateTime Oper_date { get; set; }
        /// <summary>
        /// 备注
        /// </summary>		
        string Mark { get; set; }
        /// <summary>
        /// 是否有效(0有效,1无效)
        /// </summary>		
        string Valid_state { get; set; }
        /// <summary>
        /// 对于出院患者表示转归
        /// </summary>		
        string Extend { get; set; }
        /// <summary>
        /// 明细上报标志 0未提交 1提交未审核 2打回 3已审核
        /// </summary>		
        string Upflag { get; set; }
        /// <summary>
        /// 取消操作人
        /// </summary>		
        string Cancel_oper_code { get; set; }
        /// <summary>
        /// 取消操作日期
        /// </summary>		
        DateTime Cancel_oper_date { get; set; }
    }
}
