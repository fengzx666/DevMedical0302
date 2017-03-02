using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NineVigor.FrameWork.DataAccess;
using NineVigor.Domain.HealthRecord.Dto;

namespace NineVigor.Domain.HealthRecord.Entity
{
    /// <summary>
    /// 
    /// </summary>
    public class CasBaseDiag : BaseEntity, ICasBaseDiag
    {
        #region 变量
        /// <summary>
        /// 住院流水号
        /// </summary>		
        private string inpatient_no;
        /// <summary>
        /// 发生序号
        /// </summary>		
        private decimal happen_no;
        /// <summary>
        /// 住院诊断类型 1 主要诊断 2 其他诊断 3 并发症 4 院内感染 5 损伤 6 病理诊断 7 过敏药 8 新生儿疾病 9 新生儿院感
        /// </summary>		
        private string diag_kind;
        /// <summary>
        /// 诊断级别
        /// </summary>		
        private string level_code;
        /// <summary>
        /// 诊断分期
        /// </summary>		
        private string perior_code;
        /// <summary>
        /// 诊断ICD码
        /// </summary>		
        private string icd_code;
        /// <summary>
        /// 诊断名称
        /// </summary>		
        private string diag_name;
        /// <summary>
        /// 诊断日期
        /// </summary>		
        private DateTime diag_date;
        /// <summary>
        /// 医师代号
        /// </summary>		
        private string doct_code;
        /// <summary>
        /// 医师姓名(诊断)
        /// </summary>		
        private string doct_name;
        /// <summary>
        /// 入院日期
        /// </summary>		
        private DateTime in_date;
        /// <summary>
        /// 出院日期
        /// </summary>		
        private DateTime out_date;
        /// <summary>
        /// 治疗情况 0 治愈1 好转 2 未愈3 死亡 4 其他
        /// </summary>		
        private string diag_outstate;
        /// <summary>
        /// 第二ICD
        /// </summary>		
        private string second_icd;
        /// <summary>
        /// 并发症类别
        /// </summary>		
        private string syndrome_id;
        /// <summary>
        /// 病理符合
        /// </summary>		
        private string cl_pa;
        /// <summary>
        /// 是否疑诊
        /// </summary>		
        private string dubdiag_flag;
        /// <summary>
        /// 是否主诊断
        /// </summary>		
        private string main_flag;
        /// <summary>
        /// 备注
        /// </summary>		
        private string remark;
        /// <summary>
        /// 操作员
        /// </summary>		
        private string oper_code;
        /// <summary>
        /// 操作时间
        /// </summary>		
        private DateTime oper_date;
        /// <summary>
        /// 类别 1 医生站录入诊断  2 病案室录入诊断
        /// </summary>		
        private string oper_type;
        /// <summary>
        /// 手术标志
        /// </summary>		
        private string operation_flag;
        /// <summary>
        /// 是否是30种疾病
        /// </summary>		
        private string is30disease;
        /// <summary>
        /// 治疗情况 0 治愈1 好转 2 未愈3 死亡 4 其他
        /// </summary>		
        private string diag_zg;
        /// <summary>
        /// 诊断排序drgs
        /// </summary>		
        private decimal diag_sortid;
        /// <summary>
        /// 临床诊断名称
        /// </summary>		
        private string diag_doc_icdname;
        /// <summary>
        /// 临床诊断编码
        /// </summary>		
        private string diag_doc_icdcode;
        /// <summary>
        /// 临床诊断描述
        /// </summary>		
        private string diag_icddesc;
        /// <summary>
        /// 扩展字段1
        /// </summary>		
        private string diag_ext1;
        /// <summary>
        /// 扩展字段2
        /// </summary>		
        private string diag_ext2;
        #endregion

        #region 属性定义
        /// <summary>
        /// 住院流水号
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
        /// 住院诊断类型 1 主要诊断 2 其他诊断 3 并发症 4 院内感染 5 损伤 6 病理诊断 7 过敏药 8 新生儿疾病 9 新生儿院感
        /// </summary>		
        public string Diag_kind
        {
            get { return diag_kind; }
            set { diag_kind = value; }
        }
        /// <summary>
        /// 诊断级别
        /// </summary>		
        public string Level_code
        {
            get { return level_code; }
            set { level_code = value; }
        }
        /// <summary>
        /// 诊断分期
        /// </summary>		
        public string Perior_code
        {
            get { return perior_code; }
            set { perior_code = value; }
        }
        /// <summary>
        /// 诊断ICD码
        /// </summary>		
        public string Icd_code
        {
            get { return icd_code; }
            set { icd_code = value; }
        }
        /// <summary>
        /// 诊断名称
        /// </summary>		
        public string Diag_name
        {
            get { return diag_name; }
            set { diag_name = value; }
        }
        /// <summary>
        /// 诊断日期
        /// </summary>		
        public DateTime Diag_date
        {
            get { return diag_date; }
            set { diag_date = value; }
        }
        /// <summary>
        /// 医师代号
        /// </summary>		
        public string Doct_code
        {
            get { return doct_code; }
            set { doct_code = value; }
        }
        /// <summary>
        /// 医师姓名(诊断)
        /// </summary>		
        public string Doct_name
        {
            get { return doct_name; }
            set { doct_name = value; }
        }
        /// <summary>
        /// 入院日期
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
        /// 治疗情况 0 治愈1 好转 2 未愈3 死亡 4 其他
        /// </summary>		
        public string Diag_outstate
        {
            get { return diag_outstate; }
            set { diag_outstate = value; }
        }
        /// <summary>
        /// 第二ICD
        /// </summary>		
        public string Second_icd
        {
            get { return second_icd; }
            set { second_icd = value; }
        }
        /// <summary>
        /// 并发症类别
        /// </summary>		
        public string Syndrome_id
        {
            get { return syndrome_id; }
            set { syndrome_id = value; }
        }
        /// <summary>
        /// 病理符合
        /// </summary>		
        public string Cl_pa
        {
            get { return cl_pa; }
            set { cl_pa = value; }
        }
        /// <summary>
        /// 是否疑诊
        /// </summary>		
        public string Dubdiag_flag
        {
            get { return dubdiag_flag; }
            set { dubdiag_flag = value; }
        }
        /// <summary>
        /// 是否主诊断
        /// </summary>		
        public string Main_flag
        {
            get { return main_flag; }
            set { main_flag = value; }
        }
        /// <summary>
        /// 备注
        /// </summary>		
        public string Remark
        {
            get { return remark; }
            set { remark = value; }
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
        /// 类别 1 医生站录入诊断  2 病案室录入诊断
        /// </summary>		
        public string Oper_type
        {
            get { return oper_type; }
            set { oper_type = value; }
        }
        /// <summary>
        /// 手术标志
        /// </summary>		
        public string Operation_flag
        {
            get { return operation_flag; }
            set { operation_flag = value; }
        }
        /// <summary>
        /// 是否是30种疾病
        /// </summary>		
        public string Is30disease
        {
            get { return is30disease; }
            set { is30disease = value; }
        }
        /// <summary>
        /// 治疗情况 0 治愈1 好转 2 未愈3 死亡 4 其他
        /// </summary>		
        public string Diag_zg
        {
            get { return diag_zg; }
            set { diag_zg = value; }
        }
        /// <summary>
        /// 诊断排序drgs
        /// </summary>		
        public decimal Diag_sortid
        {
            get { return diag_sortid; }
            set { diag_sortid = value; }
        }
        /// <summary>
        /// 临床诊断名称
        /// </summary>		
        public string Diag_doc_icdname
        {
            get { return diag_doc_icdname; }
            set { diag_doc_icdname = value; }
        }
        /// <summary>
        /// 临床诊断编码
        /// </summary>		
        public string Diag_doc_icdcode
        {
            get { return diag_doc_icdcode; }
            set { diag_doc_icdcode = value; }
        }
        /// <summary>
        /// 临床诊断描述
        /// </summary>		
        public string Diag_icddesc
        {
            get { return diag_icddesc; }
            set { diag_icddesc = value; }
        }
        /// <summary>
        /// 扩展字段1
        /// </summary>		
        public string Diag_ext1
        {
            get { return diag_ext1; }
            set { diag_ext1 = value; }
        }
        /// <summary>
        /// 扩展字段2
        /// </summary>		
        public string Diag_ext2
        {
            get { return diag_ext2; }
            set { diag_ext2 = value; }
        }   
        #endregion
    }
}
