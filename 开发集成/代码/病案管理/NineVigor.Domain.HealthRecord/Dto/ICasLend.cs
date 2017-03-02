using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NineVigor.Domain.HealthRecord.Dto
{
    public interface ICasLend
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
        /// 病人姓名
        /// </summary>		
        string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>		
        string Sex_code { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>		
        DateTime Birthday { get; set; }
        /// <summary>
        /// 入院日期
        /// </summary>		
        DateTime In_date { get; set; }
        /// <summary>
        /// 出院日期
        /// </summary>		
        DateTime Out_date { get; set; }
        /// <summary>
        /// 入院科室代码
        /// </summary>		
        string Dept_incd { get; set; }
        /// <summary>
        /// 入院科室名称
        /// </summary>		
        string Dept_innm { get; set; }
        /// <summary>
        /// 出院科室代码
        /// </summary>		
        string Dept_outcd { get; set; }
        /// <summary>
        /// 出院科室名称
        /// </summary>		
        string Dept_outnm { get; set; }
        /// <summary>
        /// 借阅人代号
        /// </summary>		
        string Empl_code { get; set; }
        /// <summary>
        /// 借阅人姓名
        /// </summary>		
        string Empl_name { get; set; }
        /// <summary>
        /// 借阅人所在科室代码
        /// </summary>		
        string Dept_code { get; set; }
        /// <summary>
        /// 借阅人所在科室名称
        /// </summary>		
        string Dept_name { get; set; }
        /// <summary>
        /// 借阅日期
        /// </summary>		
        DateTime Lend_date { get; set; }
        /// <summary>
        /// 预定还期
        /// </summary>		
        DateTime Prer_date { get; set; }
        /// <summary>
        /// 借阅性质
        /// </summary>		
        string Lend_kind { get; set; }
        /// <summary>
        /// 病历状态 1借出/2返还
        /// </summary>		
        string Len_stus { get; set; }
        /// <summary>
        /// 操作员代号
        /// </summary>		
        string Oper_code { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>		
        DateTime Oper_date { get; set; }
        /// <summary>
        /// 归还操作员代号
        /// </summary>		
        string Return_opcd { get; set; }
        /// <summary>
        /// 实际归还日期
        /// </summary>		
        DateTime Return_date { get; set; }
        /// <summary>
        /// 借阅卡号
        /// </summary>		
        string Empl_cardno { get; set; }
        /// <summary>
        /// 返还情况
        /// </summary>		
        string Return_state { get; set; }
        /// <summary>
        /// 病案首页的份数
        /// </summary>		
        decimal Case_nums { get; set; }
        /// <summary>
        /// 发生序号
        /// </summary>		
        string Seq_no { get; set; }
        /// <summary>
        /// 备注
        /// </summary>		
        string Remark { get; set; }
        /// <summary>
        /// 电话
        /// </summary>		
        string Empl_tel { get; set; }
        /// <summary>
        /// 借阅原因
        /// </summary>		
        string Lend_reason { get; set; }
    }
}
