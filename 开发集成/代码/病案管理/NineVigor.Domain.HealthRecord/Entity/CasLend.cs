using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NineVigor.FrameWork.DataAccess;
using NineVigor.Domain.HealthRecord.Dto;

namespace NineVigor.Domain.HealthRecord.Entity
{
    public class CasLend : BaseEntity, ICasLend
    {
        #region  变量
        /// <summary>
        /// 住院流水号
        /// </summary>		
        private string inpatient_no;
        /// <summary>
        /// 病案号
        /// </summary>		
        private string patient_no;
        /// <summary>
        /// 病人姓名
        /// </summary>		
        private string name;
        /// <summary>
        /// 性别
        /// </summary>		
        private string sex_code;
        /// <summary>
        /// 出生日期
        /// </summary>		
        private DateTime birthday;
        /// <summary>
        /// 入院日期
        /// </summary>		
        private DateTime in_date;
        /// <summary>
        /// 出院日期
        /// </summary>		
        private DateTime out_date;
        /// <summary>
        /// 入院科室代码
        /// </summary>		
        private string dept_incd;
        /// <summary>
        /// 入院科室名称
        /// </summary>		
        private string dept_innm;
        /// <summary>
        /// 出院科室代码
        /// </summary>		
        private string dept_outcd;
        /// <summary>
        /// 出院科室名称
        /// </summary>		
        private string dept_outnm;
        /// <summary>
        /// 借阅人代号
        /// </summary>		
        private string empl_code;
        /// <summary>
        /// 借阅人姓名
        /// </summary>		
        private string empl_name;
        /// <summary>
        /// 借阅人所在科室代码
        /// </summary>		
        private string dept_code;
        /// <summary>
        /// 借阅人所在科室名称
        /// </summary>		
        private string dept_name;
        /// <summary>
        /// 借阅日期
        /// </summary>		
        private DateTime lend_date;
        /// <summary>
        /// 预定还期
        /// </summary>		
        private DateTime prer_date;
        /// <summary>
        /// 借阅性质
        /// </summary>		
        private string lend_kind;
        /// <summary>
        /// 病历状态 1借出/2返还
        /// </summary>		
        private string len_stus;
        /// <summary>
        /// 操作员代号
        /// </summary>		
        private string oper_code;
        /// <summary>
        /// 操作时间
        /// </summary>		
        private DateTime oper_date;
        /// <summary>
        /// 归还操作员代号
        /// </summary>		
        private string return_opcd;
        /// <summary>
        /// 实际归还日期
        /// </summary>		
        private DateTime return_date;
        /// <summary>
        /// 借阅卡号
        /// </summary>		
        private string empl_cardno;
        /// <summary>
        /// 返还情况
        /// </summary>		
        private string return_state;
        /// <summary>
        /// 病案首页的份数
        /// </summary>		
        private decimal case_nums;
        /// <summary>
        /// 发生序号
        /// </summary>		
        private string seq_no;
        /// <summary>
        /// 备注
        /// </summary>		
        private string remark;
        /// <summary>
        /// 电话
        /// </summary>		
        private string empl_tel;
        /// <summary>
        /// 借阅原因
        /// </summary>		
        private string lend_reason;
        #endregion

        #region 属性
        /// <summary>
        /// 住院流水号
        /// </summary>		
        public string Inpatient_no
        {
            get { return inpatient_no; }
            set { inpatient_no = value; }
        }
        /// <summary>
        /// 病案号
        /// </summary>		
        public string Patient_no
        {
            get { return patient_no; }
            set { patient_no = value; }
        }
        /// <summary>
        /// 病人姓名
        /// </summary>		
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// 性别
        /// </summary>		
        public string Sex_code
        {
            get { return sex_code; }
            set { sex_code = value; }
        }
        /// <summary>
        /// 出生日期
        /// </summary>		
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
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
        /// 入院科室代码
        /// </summary>		
        public string Dept_incd
        {
            get { return dept_incd; }
            set { dept_incd = value; }
        }
        /// <summary>
        /// 入院科室名称
        /// </summary>		
        public string Dept_innm
        {
            get { return dept_innm; }
            set { dept_innm = value; }
        }
        /// <summary>
        /// 出院科室代码
        /// </summary>		
        public string Dept_outcd
        {
            get { return dept_outcd; }
            set { dept_outcd = value; }
        }
        /// <summary>
        /// 出院科室名称
        /// </summary>		
        public string Dept_outnm
        {
            get { return dept_outnm; }
            set { dept_outnm = value; }
        }
        /// <summary>
        /// 借阅人代号
        /// </summary>		
        public string Empl_code
        {
            get { return empl_code; }
            set { empl_code = value; }
        }
        /// <summary>
        /// 借阅人姓名
        /// </summary>		
        public string Empl_name
        {
            get { return empl_name; }
            set { empl_name = value; }
        }
        /// <summary>
        /// 借阅人所在科室代码
        /// </summary>		
        public string Dept_code
        {
            get { return dept_code; }
            set { dept_code = value; }
        }
        /// <summary>
        /// 借阅人所在科室名称
        /// </summary>		
        public string Dept_name
        {
            get { return dept_name; }
            set { dept_name = value; }
        }
        /// <summary>
        /// 借阅日期
        /// </summary>		
        public DateTime Lend_date
        {
            get { return lend_date; }
            set { lend_date = value; }
        }
        /// <summary>
        /// 预定还期
        /// </summary>		
        public DateTime Prer_date
        {
            get { return prer_date; }
            set { prer_date = value; }
        }
        /// <summary>
        /// 借阅性质
        /// </summary>		
        public string Lend_kind
        {
            get { return lend_kind; }
            set { lend_kind = value; }
        }
        /// <summary>
        /// 病历状态 1借出/2返还
        /// </summary>		
        public string Len_stus
        {
            get { return len_stus; }
            set { len_stus = value; }
        }
        /// <summary>
        /// 操作员代号
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
        /// 归还操作员代号
        /// </summary>		
        public string Return_opcd
        {
            get { return return_opcd; }
            set { return_opcd = value; }
        }
        /// <summary>
        /// 实际归还日期
        /// </summary>		
        public DateTime Return_date
        {
            get { return return_date; }
            set { return_date = value; }
        }
        /// <summary>
        /// 借阅卡号
        /// </summary>		
        public string Empl_cardno
        {
            get { return empl_cardno; }
            set { empl_cardno = value; }
        }
        /// <summary>
        /// 返还情况
        /// </summary>		
        public string Return_state
        {
            get { return return_state; }
            set { return_state = value; }
        }
        /// <summary>
        /// 病案首页的份数
        /// </summary>		
        public decimal Case_nums
        {
            get { return case_nums; }
            set { case_nums = value; }
        }
        /// <summary>
        /// 发生序号
        /// </summary>		
        public string Seq_no
        {
            get { return seq_no; }
            set { seq_no = value; }
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
        /// 电话
        /// </summary>		
        public string Empl_tel
        {
            get { return empl_tel; }
            set { empl_tel = value; }
        }
        /// <summary>
        /// 借阅原因
        /// </summary>		
        public string Lend_reason
        {
            get { return lend_reason; }
            set { lend_reason = value; }
        }
        #endregion 
    }
}
