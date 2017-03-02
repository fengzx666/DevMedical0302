using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NineVigor.Domain.HealthRecord.Dto
{
    public interface IICDDiagnose
    {
        /// <summary>
        /// 主键
        /// </summary>		
        string Sequence_no { get; set; }
        /// <summary>
        /// ICD诊断码标准诊断
        /// </summary>		
        string Icd_code { get; set; }
        /// <summary>
        /// 中文疾病名称
        /// </summary>		
        string Icd_name { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>		
        string Spell_code { get; set; }
        /// <summary>
        /// 五笔
        /// </summary>		
        string Wb_code { get; set; }
        /// <summary>
        /// 院内诊断编码
        /// </summary>		
        string Inn_icdcode { get; set; }
        /// <summary>
        /// 院内诊断编码疾病名称
        /// </summary>		
        string Inn_icdname { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>		
        string Inn_spell_code { get; set; }
        /// <summary>
        /// 五笔
        /// </summary>		
        string Inn_wb_code { get; set; }
        /// <summary>
        /// 统计代码
        /// </summary>		
        string Stat_code { get; set; }
        /// <summary>
        /// 疾病名称1
        /// </summary>		
        string Icd_name1 { get; set; }
        /// <summary>
        /// 疾病死亡原因
        /// </summary>		
        string Die_reason { get; set; }
        /// <summary>
        /// 疾病分类码
        /// </summary>		
        string Disease_code { get; set; }
        /// <summary>
        /// 标准住院日
        /// </summary>		
        decimal Standard_date { get; set; }
        /// <summary>
        /// 30种疾病标志 0 假 1 真
        /// </summary>		
        string Disease30_flag { get; set; }
        /// <summary>
        /// 传染病标志 0 假 1 真
        /// </summary>		
        string Infect_flag { get; set; }
        /// <summary>
        /// 肿瘤标志 0 假 1 真
        /// </summary>		
        string Cancer_flag { get; set; }
        /// <summary>
        /// 对照标准编码
        /// </summary>		
        string Map_icd { get; set; }
        /// <summary>
        /// 有效性标志0无效 1有效
        /// </summary>		
        string Valid_state { get; set; }
        /// <summary>
        /// 序号
        /// </summary>		
        decimal Sort_id { get; set; }
        /// <summary>
        /// 操作员
        /// </summary>		
        string Oper_code { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>		
        DateTime Oper_date { get; set; }
        /// <summary>
        /// icd手术 诊断码 星键互查
        /// </summary>		
        string Sicd_code { get; set; }
        /// <summary>
        /// 适用性别    A 适用于所有性别  M 只 适用于男性 F 只适用于女性
        /// </summary>		
        string Sextype { get; set; }
        /// <summary>
        /// 自定义ICD编码标记N标准编码 I院内自定义码
        /// </summary>		
        string Diagflag { get; set; }
        /// <summary>
        /// 自定义编码
        /// </summary>		
        string Input_code { get; set; }
    }
}
