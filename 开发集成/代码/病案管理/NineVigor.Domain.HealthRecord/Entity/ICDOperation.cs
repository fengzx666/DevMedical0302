using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NineVigor.FrameWork.DataAccess;
using NineVigor.Domain.HealthRecord.Dto;

namespace NineVigor.Domain.HealthRecord.Entity
{
    public class ICDOperation : BaseEntity, IICDOperation
    {
        #region  变量
        /// <summary>
        /// 主键序列号
        /// </summary>		
        private string sequence_no;
        /// <summary>
        /// ICD手术主诊断码标准诊断
        /// </summary>		
        private string icd_code;
        /// <summary>
        /// 中文疾病名称
        /// </summary>		
        private string icd_name;
        /// <summary>
        /// 拼音码
        /// </summary>		
        private string spell_code;
        /// <summary>
        /// 五笔
        /// </summary>		
        private string wb_code;
        /// <summary>
        /// 院内诊断编码
        /// </summary>		
        private string inn_icdcode;
        /// <summary>
        /// 疾病名称2
        /// </summary>		
        private string inn_icdname;
        /// <summary>
        /// 拼音码
        /// </summary>		
        private string inn_spell_code;
        /// <summary>
        /// 五笔
        /// </summary>		
        private string inn_wb_code;
        /// <summary>
        /// 统计代码
        /// </summary>		
        private string stat_code;
        /// <summary>
        /// 疾病名称1
        /// </summary>		
        private string icd_name1;
        /// <summary>
        /// 疾病死亡原因
        /// </summary>		
        private string die_reason;
        /// <summary>
        /// 疾病分类码
        /// </summary>		
        private string disease_code;
        /// <summary>
        /// 标准住院日
        /// </summary>		
        private decimal standard_date;
        /// <summary>
        /// 30种疾病标志 0 假 1 真
        /// </summary>		
        private string disease30_flag;
        /// <summary>
        /// 传染病标志 0 假 1 真
        /// </summary>		
        private string infect_flag;
        /// <summary>
        /// 肿瘤标志 0 假 1 真
        /// </summary>		
        private string cancer_flag;
        /// <summary>
        /// 对照标准编码
        /// </summary>		
        private string map_icd;
        /// <summary>
        /// 有效性标志0无效 1有效
        /// </summary>		
        private string valid_state;
        /// <summary>
        /// 序号
        /// </summary>		
        private decimal sort_id;
        /// <summary>
        /// 操作员
        /// </summary>		
        private string oper_code;
        /// <summary>
        /// 操作时间
        /// </summary>		
        private DateTime oper_date;
        /// <summary>
        /// icd手术 诊断码 星键互查
        /// </summary>		
        private string sicd_code;
        /// <summary>
        /// 适用性别    A 适用于所有性别  M 只 适用于男性 F 只适用于女性
        /// </summary>		
        private string sextype;
        /// <summary>
        /// 诊断标记N标准诊断标记  I院内诊断标记
        /// </summary>		
        private string diagflag;
        /// <summary>
        /// 自定义编码
        /// </summary>		
        private string input_code;
        #endregion

        #region 属性
        /// <summary>
        /// 主键序列号
        /// </summary>		
        public string Sequence_no
        {
            get { return sequence_no; }
            set { sequence_no = value; }
        }
        /// <summary>
        /// ICD手术主诊断码标准诊断
        /// </summary>		
        public string Icd_code
        {
            get { return icd_code; }
            set { icd_code = value; }
        }
        /// <summary>
        /// 中文疾病名称
        /// </summary>		
        public string Icd_name
        {
            get { return icd_name; }
            set { icd_name = value; }
        }
        /// <summary>
        /// 拼音码
        /// </summary>		
        public string Spell_code
        {
            get { return spell_code; }
            set { spell_code = value; }
        }
        /// <summary>
        /// 五笔
        /// </summary>		
        public string Wb_code
        {
            get { return wb_code; }
            set { wb_code = value; }
        }
        /// <summary>
        /// 院内诊断编码
        /// </summary>		
        public string Inn_icdcode
        {
            get { return inn_icdcode; }
            set { inn_icdcode = value; }
        }
        /// <summary>
        /// 疾病名称2
        /// </summary>		
        public string Inn_icdname
        {
            get { return inn_icdname; }
            set { inn_icdname = value; }
        }
        /// <summary>
        /// 拼音码
        /// </summary>		
        public string Inn_spell_code
        {
            get { return inn_spell_code; }
            set { inn_spell_code = value; }
        }
        /// <summary>
        /// 五笔
        /// </summary>		
        public string Inn_wb_code
        {
            get { return inn_wb_code; }
            set { inn_wb_code = value; }
        }
        /// <summary>
        /// 统计代码
        /// </summary>		
        public string Stat_code
        {
            get { return stat_code; }
            set { stat_code = value; }
        }
        /// <summary>
        /// 疾病名称1
        /// </summary>		
        public string Icd_name1
        {
            get { return icd_name1; }
            set { icd_name1 = value; }
        }
        /// <summary>
        /// 疾病死亡原因
        /// </summary>		
        public string Die_reason
        {
            get { return die_reason; }
            set { die_reason = value; }
        }
        /// <summary>
        /// 疾病分类码
        /// </summary>		
        public string Disease_code
        {
            get { return disease_code; }
            set { disease_code = value; }
        }
        /// <summary>
        /// 标准住院日
        /// </summary>		
        public decimal Standard_date
        {
            get { return standard_date; }
            set { standard_date = value; }
        }
        /// <summary>
        /// 30种疾病标志 0 假 1 真
        /// </summary>		
        public string Disease30_flag
        {
            get { return disease30_flag; }
            set { disease30_flag = value; }
        }
        /// <summary>
        /// 传染病标志 0 假 1 真
        /// </summary>		
        public string Infect_flag
        {
            get { return infect_flag; }
            set { infect_flag = value; }
        }
        /// <summary>
        /// 肿瘤标志 0 假 1 真
        /// </summary>		
        public string Cancer_flag
        {
            get { return cancer_flag; }
            set { cancer_flag = value; }
        }
        /// <summary>
        /// 对照标准编码
        /// </summary>		
        public string Map_icd
        {
            get { return map_icd; }
            set { map_icd = value; }
        }
        /// <summary>
        /// 有效性标志0无效 1有效
        /// </summary>		
        public string Valid_state
        {
            get { return valid_state; }
            set { valid_state = value; }
        }
        /// <summary>
        /// 序号
        /// </summary>		
        public decimal Sort_id
        {
            get { return sort_id; }
            set { sort_id = value; }
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
        /// icd手术 诊断码 星键互查
        /// </summary>		
        public string Sicd_code
        {
            get { return sicd_code; }
            set { sicd_code = value; }
        }
        /// <summary>
        /// 适用性别    A 适用于所有性别  M 只 适用于男性 F 只适用于女性
        /// </summary>		
        public string Sextype
        {
            get { return sextype; }
            set { sextype = value; }
        }
        /// <summary>
        /// 诊断标记N标准诊断标记  I院内诊断标记
        /// </summary>		
        public string Diagflag
        {
            get { return diagflag; }
            set { diagflag = value; }
        }
        /// <summary>
        /// 自定义编码
        /// </summary>		
        public string Input_code
        {
            get { return input_code; }
            set { input_code = value; }
        }
        #endregion  
    }
}
