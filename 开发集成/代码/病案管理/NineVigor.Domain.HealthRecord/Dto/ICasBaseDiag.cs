using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NineVigor.Domain.HealthRecord.Dto
{
   public interface ICasBaseDiag
    {
        /// <summary>
        /// 住院流水号
        /// </summary>		
        string Inpatient_no { get; set; }
        /// <summary>
        /// 发生序号
        /// </summary>		
        decimal Happen_no { get; set; }
        /// <summary>
        /// 住院诊断类型 1 主要诊断 2 其他诊断 3 并发症 4 院内感染 5 损伤 6 病理诊断 7 过敏药 8 新生儿疾病 9 新生儿院感
        /// </summary>		
        string Diag_kind { get; set; }
        /// <summary>
        /// 诊断级别
        /// </summary>		
        string Level_code { get; set; }
        /// <summary>
        /// 诊断分期
        /// </summary>		
        string Perior_code { get; set; }
        /// <summary>
        /// 诊断ICD码
        /// </summary>		
        string Icd_code { get; set; }
        /// <summary>
        /// 诊断名称
        /// </summary>		
        string Diag_name { get; set; }
        /// <summary>
        /// 诊断日期
        /// </summary>		
        DateTime Diag_date { get; set; }
        /// <summary>
        /// 医师代号
        /// </summary>		
        string Doct_code { get; set; }
        /// <summary>
        /// 医师姓名(诊断)
        /// </summary>		
        string Doct_name { get; set; }
        /// <summary>
        /// 入院日期
        /// </summary>		
        DateTime In_date { get; set; }
        /// <summary>
        /// 出院日期
        /// </summary>		
        DateTime Out_date { get; set; }
        /// <summary>
        /// 治疗情况 0 治愈1 好转 2 未愈3 死亡 4 其他
        /// </summary>		
        string Diag_outstate { get; set; }
        /// <summary>
        /// 第二ICD
        /// </summary>		
        string Second_icd { get; set; }
        /// <summary>
        /// 并发症类别
        /// </summary>		
        string Syndrome_id { get; set; }
        /// <summary>
        /// 病理符合
        /// </summary>		
        string Cl_pa { get; set; }
        /// <summary>
        /// 是否疑诊
        /// </summary>		
        string Dubdiag_flag { get; set; }
        /// <summary>
        /// 是否主诊断
        /// </summary>		
        string Main_flag { get; set; }
        /// <summary>
        /// 备注
        /// </summary>		
        string Remark { get; set; }
        /// <summary>
        /// 操作员
        /// </summary>		
        string Oper_code { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>		
        DateTime Oper_date { get; set; }
        /// <summary>
        /// 类别 1 医生站录入诊断  2 病案室录入诊断
        /// </summary>		
        string Oper_type { get; set; }
        /// <summary>
        /// 手术标志
        /// </summary>		
        string Operation_flag { get; set; }
        /// <summary>
        /// 是否是30种疾病
        /// </summary>		
        string Is30disease { get; set; }
        /// <summary>
        /// 治疗情况 0 治愈1 好转 2 未愈3 死亡 4 其他
        /// </summary>		
        string Diag_zg { get; set; }
        /// <summary>
        /// 诊断排序drgs
        /// </summary>		
        decimal Diag_sortid { get; set; }
        /// <summary>
        /// 临床诊断名称
        /// </summary>		
        string Diag_doc_icdname { get; set; }
        /// <summary>
        /// 临床诊断编码
        /// </summary>		
        string Diag_doc_icdcode { get; set; }
        /// <summary>
        /// 临床诊断描述
        /// </summary>		
        string Diag_icddesc { get; set; }
        /// <summary>
        /// 扩展字段1
        /// </summary>		
        string Diag_ext1 { get; set; }
        /// <summary>
        /// 扩展字段2
        /// </summary>		
        string Diag_ext2 { get; set; }
		   
    }
}
