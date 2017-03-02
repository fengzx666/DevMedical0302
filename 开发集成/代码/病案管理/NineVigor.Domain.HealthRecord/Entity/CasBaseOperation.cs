using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NineVigor.FrameWork.DataAccess;
using NineVigor.Domain.HealthRecord.Dto;

namespace NineVigor.Domain.HealthRecord.Entity
{
   public class CasBaseOperation: BaseEntity, ICasBaseOperation
   {
       #region 变量
       /// <summary>
       /// 病案号
       /// </summary>		
       private string inpatient_no;
       /// <summary>
       /// 发生序号
       /// </summary>		
       private decimal happen_no;
       /// <summary>
       /// 手术日期
       /// </summary>		
       private DateTime operation_date;
       /// <summary>
       /// 手术代码
       /// </summary>		
       private string operation_code;
       /// <summary>
       /// 手术名称
       /// </summary>		
       private string operation_cnname;
       /// <summary>
       /// 手术种类
       /// </summary>		
       private string operation_kind;
       /// <summary>
       /// 麻醉方式
       /// </summary>		
       private string narc_kind;
       /// <summary>
       /// 切口种类
       /// </summary>		
       private string nick_kind;
       /// <summary>
       /// 愈合种类
       /// </summary>		
       private string cica_kind;
       /// <summary>
       /// 手术医师代码
       /// </summary>		
       private string fir_docd;
       /// <summary>
       /// 手术医师名称
       /// </summary>		
       private string fir_donm;
       /// <summary>
       /// I助代码
       /// </summary>		
       private string sec_docd;
       /// <summary>
       /// I助名称
       /// </summary>		
       private string sec_donm;
       /// <summary>
       /// II助代码
       /// </summary>		
       private string thr_docd;
       /// <summary>
       /// II助名称
       /// </summary>		
       private string thr_donm;
       /// <summary>
       /// 麻醉医师代码
       /// </summary>		
       private string narc_docd;
       /// <summary>
       /// 麻醉医生名称
       /// </summary>		
       private string narc_donm;
       /// <summary>
       /// 术前_后符合
       /// </summary>		
       private string opb_opa;
       /// <summary>
       /// 术前住院天数
       /// </summary>		
       private decimal beforeoper_days;
       /// <summary>
       /// 统计标志
       /// </summary>		
       private string stat_flag;
       /// <summary>
       /// 入科日期
       /// </summary>		
       private DateTime in_date;
       /// <summary>
       /// 出院日期
       /// </summary>		
       private DateTime out_date;
       /// <summary>
       /// 死亡日期
       /// </summary>		
       private DateTime dead_date;
       /// <summary>
       /// 手术科室
       /// </summary>		
       private string operation_dept;
       /// <summary>
       /// 出院病房
       /// </summary>		
       private string out_dept;
       /// <summary>
       /// 出院主诊断ICD
       /// </summary>		
       private string out_icd;
       /// <summary>
       /// 是否合并症
       /// </summary>		
       private string synd_flag;
       /// <summary>
       /// 操作员
       /// </summary>		
       private string oper_code;
       /// <summary>
       /// 操作时间
       /// </summary>		
       private DateTime oper_date;
       /// <summary>
       /// 类别  1 医生站手术明细   2 病案室手术明细
       /// </summary>		
       private string oper_type;
       /// <summary>
       /// 手术医师代码 2
       /// </summary>		
       private string fir_dcode2;
       /// <summary>
       /// 手术医师名称 2
       /// </summary>		
       private string fir_dname2;
       /// <summary>
       /// 手术drgs排序
       /// </summary>		
       private decimal ops_sortid;
       /// <summary>
       /// 手术台次号
       /// </summary>		
       private string ops_table;
       /// <summary>
       /// 临床手术名称
       /// </summary>		
       private string ops_doc_icdname;
       /// <summary>
       /// 临床手术编码
       /// </summary>		
       private string ops_doc_icdcode;
       /// <summary>
       /// 临床手术描述
       /// </summary>		
       private string ops_icddesc;
       /// <summary>
       /// 临床扩展信息1
       /// </summary>		
       private string ops_ext1;
       /// <summary>
       /// 临床扩展信息2
       /// </summary>		
       private string ops_ext2;
       #endregion

       #region 属性
       /// <summary>
       /// 病案号
       /// </summary>		
       public string Inpatient_no
       {
           get { return inpatient_no; }
           set { inpatient_no = value; }
       }
       /// <summary>
       /// 发生序号
       /// </summary>		
       public decimal Happen_no
       {
           get { return happen_no; }
           set { happen_no = value; }
       }
       /// <summary>
       /// 手术日期
       /// </summary>		
       public DateTime Operation_date
       {
           get { return operation_date; }
           set { operation_date = value; }
       }
       /// <summary>
       /// 手术代码
       /// </summary>		
       public string Operation_code
       {
           get { return operation_code; }
           set { operation_code = value; }
       }
       /// <summary>
       /// 手术名称
       /// </summary>		
       public string Operation_cnname
       {
           get { return operation_cnname; }
           set { operation_cnname = value; }
       }
       /// <summary>
       /// 手术种类
       /// </summary>		
       public string Operation_kind
       {
           get { return operation_kind; }
           set { operation_kind = value; }
       }
       /// <summary>
       /// 麻醉方式
       /// </summary>		
       public string Narc_kind
       {
           get { return narc_kind; }
           set { narc_kind = value; }
       }
       /// <summary>
       /// 切口种类
       /// </summary>		
       public string Nick_kind
       {
           get { return nick_kind; }
           set { nick_kind = value; }
       }
       /// <summary>
       /// 愈合种类
       /// </summary>		
       public string Cica_kind
       {
           get { return cica_kind; }
           set { cica_kind = value; }
       }
       /// <summary>
       /// 手术医师代码
       /// </summary>		
       public string Fir_docd
       {
           get { return fir_docd; }
           set { fir_docd = value; }
       }
       /// <summary>
       /// 手术医师名称
       /// </summary>		
       public string Fir_donm
       {
           get { return fir_donm; }
           set { fir_donm = value; }
       }
       /// <summary>
       /// I助代码
       /// </summary>		
       public string Sec_docd
       {
           get { return sec_docd; }
           set { sec_docd = value; }
       }
       /// <summary>
       /// I助名称
       /// </summary>		
       public string Sec_donm
       {
           get { return sec_donm; }
           set { sec_donm = value; }
       }
       /// <summary>
       /// II助代码
       /// </summary>		
       public string Thr_docd
       {
           get { return thr_docd; }
           set { thr_docd = value; }
       }
       /// <summary>
       /// II助名称
       /// </summary>		
       public string Thr_donm
       {
           get { return thr_donm; }
           set { thr_donm = value; }
       }
       /// <summary>
       /// 麻醉医师代码
       /// </summary>		
       public string Narc_docd
       {
           get { return narc_docd; }
           set { narc_docd = value; }
       }
       /// <summary>
       /// 麻醉医生名称
       /// </summary>		
       public string Narc_donm
       {
           get { return narc_donm; }
           set { narc_donm = value; }
       }
       /// <summary>
       /// 术前_后符合
       /// </summary>		
       public string Opb_opa
       {
           get { return opb_opa; }
           set { opb_opa = value; }
       }
       /// <summary>
       /// 术前住院天数
       /// </summary>		
       public decimal Beforeoper_days
       {
           get { return beforeoper_days; }
           set { beforeoper_days = value; }
       }
       /// <summary>
       /// 统计标志
       /// </summary>		
       public string Stat_flag
       {
           get { return stat_flag; }
           set { stat_flag = value; }
       }
       /// <summary>
       /// 入科日期
       /// </summary>		
       public DateTime In_date
       {
           get { return in_date; }
           set { in_date = value; }
       }
       /// <summary>
       /// 出院日期
       /// </summary>		
       public DateTime Out_date
       {
           get { return out_date; }
           set { out_date = value; }
       }
       /// <summary>
       /// 死亡日期
       /// </summary>		
       public DateTime Dead_date
       {
           get { return dead_date; }
           set { dead_date = value; }
       }
       /// <summary>
       /// 手术科室
       /// </summary>		
       public string Operation_dept
       {
           get { return operation_dept; }
           set { operation_dept = value; }
       }
       /// <summary>
       /// 出院病房
       /// </summary>		
       public string Out_dept
       {
           get { return out_dept; }
           set { out_dept = value; }
       }
       /// <summary>
       /// 出院主诊断ICD
       /// </summary>		
       public string Out_icd
       {
           get { return out_icd; }
           set { out_icd = value; }
       }
       /// <summary>
       /// 是否合并症
       /// </summary>		
       public string Synd_flag
       {
           get { return synd_flag; }
           set { synd_flag = value; }
       }
       /// <summary>
       /// 操作员
       /// </summary>		
       public string Oper_code
       {
           get { return oper_code; }
           set { oper_code = value; }
       }
       /// <summary>
       /// 操作时间
       /// </summary>		
       public DateTime Oper_date
       {
           get { return oper_date; }
           set { oper_date = value; }
       }
       /// <summary>
       /// 类别  1 医生站手术明细   2 病案室手术明细
       /// </summary>		
       public string Oper_type
       {
           get { return oper_type; }
           set { oper_type = value; }
       }
       /// <summary>
       /// 手术医师代码 2
       /// </summary>		
       public string Fir_dcode2
       {
           get { return fir_dcode2; }
           set { fir_dcode2 = value; }
       }
       /// <summary>
       /// 手术医师名称 2
       /// </summary>		
       public string Fir_dname2
       {
           get { return fir_dname2; }
           set { fir_dname2 = value; }
       }
       /// <summary>
       /// 手术drgs排序
       /// </summary>		
       public decimal Ops_sortid
       {
           get { return ops_sortid; }
           set { ops_sortid = value; }
       }
       /// <summary>
       /// 手术台次号
       /// </summary>		
       public string Ops_table
       {
           get { return ops_table; }
           set { ops_table = value; }
       }
       /// <summary>
       /// 临床手术名称
       /// </summary>		
       public string Ops_doc_icdname
       {
           get { return ops_doc_icdname; }
           set { ops_doc_icdname = value; }
       }
       /// <summary>
       /// 临床手术编码
       /// </summary>		
       public string Ops_doc_icdcode
       {
           get { return ops_doc_icdcode; }
           set { ops_doc_icdcode = value; }
       }
       /// <summary>
       /// 临床手术描述
       /// </summary>		
       public string Ops_icddesc
       {
           get { return ops_icddesc; }
           set { ops_icddesc = value; }
       }
       /// <summary>
       /// 临床扩展信息1
       /// </summary>		
       public string Ops_ext1
       {
           get { return ops_ext1; }
           set { ops_ext1 = value; }
       }
       /// <summary>
       /// 临床扩展信息2
       /// </summary>		
       public string Ops_ext2
       {
           get { return ops_ext2; }
           set { ops_ext2 = value; }
       }    
       #endregion
   }
}
