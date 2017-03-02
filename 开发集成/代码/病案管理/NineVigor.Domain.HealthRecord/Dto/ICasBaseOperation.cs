using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NineVigor.Domain.HealthRecord.Dto
{
    public interface ICasBaseOperation
    {
        /// <summary>
        /// 病案号
        /// </summary>		
        string Inpatient_no { get; set; }
        /// <summary>
        /// 发生序号
        /// </summary>		
        decimal Happen_no { get; set; }
        /// <summary>
        /// 手术日期
        /// </summary>		
        DateTime Operation_date { get; set; }
        /// <summary>
        /// 手术代码
        /// </summary>		
        string Operation_code { get; set; }
        /// <summary>
        /// 手术名称
        /// </summary>		
        string Operation_cnname { get; set; }
        /// <summary>
        /// 手术种类
        /// </summary>		
        string Operation_kind { get; set; }
        /// <summary>
        /// 麻醉方式
        /// </summary>		
        string Narc_kind { get; set; }
        /// <summary>
        /// 切口种类
        /// </summary>		
        string Nick_kind { get; set; }
        /// <summary>
        /// 愈合种类
        /// </summary>		
        string Cica_kind { get; set; }
        /// <summary>
        /// 手术医师代码
        /// </summary>		
        string Fir_docd { get; set; }
        /// <summary>
        /// 手术医师名称
        /// </summary>		
        string Fir_donm { get; set; }
        /// <summary>
        /// I助代码
        /// </summary>		
        string Sec_docd { get; set; }
        /// <summary>
        /// I助名称
        /// </summary>		
        string Sec_donm { get; set; }
        /// <summary>
        /// II助代码
        /// </summary>		
        string Thr_docd { get; set; }
        /// <summary>
        /// II助名称
        /// </summary>		
        string Thr_donm { get; set; }
        /// <summary>
        /// 麻醉医师代码
        /// </summary>		
        string Narc_docd { get; set; }
        /// <summary>
        /// 麻醉医生名称
        /// </summary>		
        string Narc_donm { get; set; }
        /// <summary>
        /// 术前_后符合
        /// </summary>		
        string Opb_opa { get; set; }
        /// <summary>
        /// 术前住院天数
        /// </summary>		
        decimal Beforeoper_days { get; set; }
        /// <summary>
        /// 统计标志
        /// </summary>		
        string Stat_flag { get; set; }
        /// <summary>
        /// 入科日期
        /// </summary>		
        DateTime In_date { get; set; }
        /// <summary>
        /// 出院日期
        /// </summary>		
        DateTime Out_date { get; set; }
        /// <summary>
        /// 死亡日期
        /// </summary>		
        DateTime Dead_date { get; set; }
        /// <summary>
        /// 手术科室
        /// </summary>		
        string Operation_dept { get; set; }
        /// <summary>
        /// 出院病房
        /// </summary>		
        string Out_dept { get; set; }
        /// <summary>
        /// 出院主诊断ICD
        /// </summary>		
        string Out_icd { get; set; }
        /// <summary>
        /// 是否合并症
        /// </summary>		
        string Synd_flag { get; set; }
        /// <summary>
        /// 操作员
        /// </summary>		
        string Oper_code { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>		
        DateTime Oper_date { get; set; }
        /// <summary>
        /// 类别  1 医生站手术明细   2 病案室手术明细
        /// </summary>		
        string Oper_type { get; set; }
        /// <summary>
        /// 手术医师代码 2
        /// </summary>		
        string Fir_dcode2 { get; set; }
        /// <summary>
        /// 手术医师名称 2
        /// </summary>		
        string Fir_dname2 { get; set; }
        /// <summary>
        /// 手术drgs排序
        /// </summary>		
        decimal Ops_sortid { get; set; }
        /// <summary>
        /// 手术台次号
        /// </summary>		
        string Ops_table { get; set; }
        /// <summary>
        /// 临床手术名称
        /// </summary>		
        string Ops_doc_icdname { get; set; }
        /// <summary>
        /// 临床手术编码
        /// </summary>		
        string Ops_doc_icdcode { get; set; }
        /// <summary>
        /// 临床手术描述
        /// </summary>		
        string Ops_icddesc { get; set; }
        /// <summary>
        /// 临床扩展信息1
        /// </summary>		
        string Ops_ext1 { get; set; }
        /// <summary>
        /// 临床扩展信息2
        /// </summary>		
        string Ops_ext2 { get; set; }
    }
}
