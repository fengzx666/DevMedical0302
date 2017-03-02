using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NineVigor.FrameWork.DataAccess;
using NineVigor.Domain.HealthRecord.Dto;

namespace NineVigor.Domain.HealthRecord.Entity
{
   public class CasDayReportDetail : BaseEntity, ICasDayReportDetail
    {
        #region  变量
        /// <summary>
        /// 统计日期
        /// </summary>		
        private DateTime stat_date;
        /// <summary>
        /// 病房代码
        /// </summary>		
        private string dept_code;
        /// <summary>
        /// 护士站代码
        /// </summary>		
        private string nurse_cell_code;
        /// <summary>
        /// 住院流水号
        /// </summary>		
        private string inpatient_no;
        /// <summary>
        /// 床号
        /// </summary>		
        private string bed_no;
        /// <summary>
        /// 统计类型
        /// </summary>		
        private string stat_type;
        /// <summary>
        /// 操作人
        /// </summary>		
        private string oper_code;
        /// <summary>
        /// 操作日期
        /// </summary>		
        private DateTime oper_date;
        /// <summary>
        /// 备注
        /// </summary>		
        private string mark;
        /// <summary>
        /// 是否有效(0有效,1无效)
        /// </summary>		
        private string valid_state;
        /// <summary>
        /// 对于出院患者表示转归
        /// </summary>		
        private string extend;
        /// <summary>
        /// 明细上报标志 0未提交 1提交未审核 2打回 3已审核
        /// </summary>		
        private string upflag;
        /// <summary>
        /// 取消操作人
        /// </summary>		
        private string cancel_oper_code;
        /// <summary>
        /// 取消操作日期
        /// </summary>		
        private DateTime cancel_oper_date;
        #endregion

        #region 属性
        /// <summary>
        /// 统计日期
        /// </summary>		
        public DateTime Stat_date
        {
            get { return stat_date; }
            set { stat_date = value; }
        }
        /// <summary>
        /// 病房代码
        /// </summary>		
        public string Dept_code
        {
            get { return dept_code; }
            set { dept_code = value; }
        }
        /// <summary>
        /// 护士站代码
        /// </summary>		
        public string Nurse_cell_code
        {
            get { return nurse_cell_code; }
            set { nurse_cell_code = value; }
        }
        /// <summary>
        /// 住院流水号
        /// </summary>		
        public string Inpatient_no
        {
            get { return inpatient_no; }
            set { inpatient_no = value; }
        }
        /// <summary>
        /// 床号
        /// </summary>		
        public string Bed_no
        {
            get { return bed_no; }
            set { bed_no = value; }
        }
        /// <summary>
        /// 统计类型
        /// </summary>		
        public string Stat_type
        {
            get { return stat_type; }
            set { stat_type = value; }
        }
        /// <summary>
        /// 操作人
        /// </summary>		
        public string Oper_code
        {
            get { return oper_code; }
            set { oper_code = value; }
        }
        /// <summary>
        /// 操作日期
        /// </summary>		
        public DateTime Oper_date
        {
            get { return oper_date; }
            set { oper_date = value; }
        }
        /// <summary>
        /// 备注
        /// </summary>		
        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }
        /// <summary>
        /// 是否有效(0有效,1无效)
        /// </summary>		
        public string Valid_state
        {
            get { return valid_state; }
            set { valid_state = value; }
        }
        /// <summary>
        /// 对于出院患者表示转归
        /// </summary>		
        public string Extend
        {
            get { return extend; }
            set { extend = value; }
        }
        /// <summary>
        /// 明细上报标志 0未提交 1提交未审核 2打回 3已审核
        /// </summary>		
        public string Upflag
        {
            get { return upflag; }
            set { upflag = value; }
        }
        /// <summary>
        /// 取消操作人
        /// </summary>		
        public string Cancel_oper_code
        {
            get { return cancel_oper_code; }
            set { cancel_oper_code = value; }
        }
        /// <summary>
        /// 取消操作日期
        /// </summary>		
        public DateTime Cancel_oper_date
        {
            get { return cancel_oper_date; }
            set { cancel_oper_date = value; }
        }
        #endregion
    }
}
