using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NineVigor.FrameWork.DataAccess;
using NineVigor.Domain.HealthRecord.Dto;

namespace NineVigor.Domain.HealthRecord.Entity
{
    public class CasCallBack : BaseEntity, ICasCallBack
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
        /// 住院次数
        /// </summary>		
        private decimal in_times;
        /// <summary>
        /// 患者姓名
        /// </summary>		
        private string name;
        /// <summary>
        /// 入院日期
        /// </summary>		
        private DateTime in_date;
        /// <summary>
        /// 出院日期
        /// </summary>		
        private DateTime out_date;
        /// <summary>
        /// 出院科别名称
        /// </summary>		
        private string dept_name;
        /// <summary>
        /// 出院科别编码
        /// </summary>		
        private string dept_code;
        /// <summary>
        /// 审核时间
        /// </summary>		
        private DateTime checkdate;
        /// <summary>
        /// 回收人姓名
        /// </summary>		
        private string opercode;
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
        /// 住院次数
        /// </summary>		
        public decimal In_times
        {
            get { return in_times; }
            set { in_times = value; }
        }
        /// <summary>
        /// 患者姓名
        /// </summary>		
        public string Name
        {
            get { return name; }
            set { name = value; }
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
        /// 出院科别名称
        /// </summary>		
        public string Dept_name
        {
            get { return dept_name; }
            set { dept_name = value; }
        }
        /// <summary>
        /// 出院科别编码
        /// </summary>		
        public string Dept_code
        {
            get { return dept_code; }
            set { dept_code = value; }
        }
        /// <summary>
        /// 审核时间
        /// </summary>		
        public DateTime Checkdate
        {
            get { return checkdate; }
            set { checkdate = value; }
        }
        /// <summary>
        /// 回收人姓名
        /// </summary>		
        public string Opercode
        {
            get { return opercode; }
            set { opercode = value; }
        }
        #endregion   
    }
}
