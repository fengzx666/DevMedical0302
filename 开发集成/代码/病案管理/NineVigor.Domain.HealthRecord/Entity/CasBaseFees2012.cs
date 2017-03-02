using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NineVigor.FrameWork.DataAccess;
using NineVigor.Domain.HealthRecord.Dto;

namespace NineVigor.Domain.HealthRecord.Entity
{
    public class CasBaseFees2012 : BaseEntity, ICasBaseFees2012
    {
        #region  变量
        /// <summary>
        /// 病案号
        /// </summary>		
        private string patient_id;
        /// <summary>
        /// 住院流水号
        /// </summary>		
        private string inpatient_no;
        /// <summary>
        /// 住院次数
        /// </summary>		
        private decimal visit_id;
        /// <summary>
        /// 总费用
        /// </summary>		
        private decimal cost_total;
        /// <summary>
        /// 自付金额
        /// </summary>		
        private decimal cost_ownpay;
        /// <summary>
        /// 一般医疗服务费
        /// </summary>		
        private decimal cost_zh_ybyl;
        /// <summary>
        /// 一般治疗操作费
        /// </summary>		
        private decimal cost_zh_ybzl;
        /// <summary>
        /// 护理住院费
        /// </summary>		
        private decimal cost_zh_hl;
        /// <summary>
        /// 综合治疗类其他费用
        /// </summary>		
        private decimal cost_zh_other;
        /// <summary>
        /// 病理诊断费
        /// </summary>		
        private decimal cost_zd_bl;
        /// <summary>
        /// 实验室诊断费
        /// </summary>		
        private decimal cost_zd_sys;
        /// <summary>
        /// 影像学诊断费
        /// </summary>		
        private decimal cost_zd_yxx;
        /// <summary>
        /// 临床诊断项目费
        /// </summary>		
        private decimal cost_zd_lcxm;
        /// <summary>
        /// 非手术治疗项目费
        /// </summary>		
        private decimal cost_zl_fsszlxm;
        /// <summary>
        /// 临床物理治疗费
        /// </summary>		
        private decimal cost_zl_lcwlzl;
        /// <summary>
        /// 手术治疗费
        /// </summary>		
        private decimal cost_zl_sszl;
        /// <summary>
        /// 麻醉费
        /// </summary>		
        private decimal cost_zl_mz;
        /// <summary>
        /// 手术费
        /// </summary>		
        private decimal cost_zl_ss;
        /// <summary>
        /// 康复费
        /// </summary>		
        private decimal cost_kf_kf;
        /// <summary>
        /// 中医治疗费
        /// </summary>		
        private decimal cost_zy_zyzl;
        /// <summary>
        /// 西药费
        /// </summary>		
        private decimal cost_xy_xy;
        /// <summary>
        /// 抗菌药物费
        /// </summary>		
        private decimal cost_xy_kjyw;
        /// <summary>
        /// 中成药费
        /// </summary>		
        private decimal cost_zy_zchy;
        /// <summary>
        /// 中草药费
        /// </summary>		
        private decimal cost_zy_zaoy;
        /// <summary>
        /// 血费
        /// </summary>		
        private decimal cost_xy_xf;
        /// <summary>
        /// 白蛋白制品费
        /// </summary>		
        private decimal cost_xy;
        /// <summary>
        /// 球蛋白类制品费
        /// </summary>		
        private decimal cost_xy_qdb;
        /// <summary>
        /// 凝血因子类制品费
        /// </summary>		
        private decimal cost_xy_nxyz;
        /// <summary>
        /// 细胞因子类制品费
        /// </summary>		
        private decimal cost_xy_xbyz;
        /// <summary>
        /// 检查用一次性医用材料费
        /// </summary>		
        private decimal cost_hc_jc;
        /// <summary>
        /// 治疗用一次性医用材料费
        /// </summary>		
        private decimal cost_hc_zl;
        /// <summary>
        /// 手术用一次性医用材料费
        /// </summary>		
        private decimal cost_hc_ss;
        /// <summary>
        /// 其他费
        /// </summary>		
        private decimal cost_other;
        /// <summary>
        /// 操作人id
        /// </summary>		
        private string oper_code;
        /// <summary>
        /// 操作人姓名
        /// </summary>		
        private string oper_name;
        /// <summary>
        /// 操作时间
        /// </summary>		
        private DateTime oper_date;
        #endregion

        #region 属性
        /// <summary>
        /// 病案号
        /// </summary>		
        public string Patient_id
        {
            get { return patient_id; }
            set { patient_id = value; }
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
        /// 住院次数
        /// </summary>		
        public decimal Visit_id
        {
            get { return visit_id; }
            set { visit_id = value; }
        }
        /// <summary>
        /// 总费用
        /// </summary>		
        public decimal Cost_total
        {
            get { return cost_total; }
            set { cost_total = value; }
        }
        /// <summary>
        /// 自付金额
        /// </summary>		
        public decimal Cost_ownpay
        {
            get { return cost_ownpay; }
            set { cost_ownpay = value; }
        }
        /// <summary>
        /// 一般医疗服务费
        /// </summary>		
        public decimal Cost_zh_ybyl
        {
            get { return cost_zh_ybyl; }
            set { cost_zh_ybyl = value; }
        }
        /// <summary>
        /// 一般治疗操作费
        /// </summary>		
        public decimal Cost_zh_ybzl
        {
            get { return cost_zh_ybzl; }
            set { cost_zh_ybzl = value; }
        }
        /// <summary>
        /// 护理住院费
        /// </summary>		
        public decimal Cost_zh_hl
        {
            get { return cost_zh_hl; }
            set { cost_zh_hl = value; }
        }
        /// <summary>
        /// 综合治疗类其他费用
        /// </summary>		
        public decimal Cost_zh_other
        {
            get { return cost_zh_other; }
            set { cost_zh_other = value; }
        }
        /// <summary>
        /// 病理诊断费
        /// </summary>		
        public decimal Cost_zd_bl
        {
            get { return cost_zd_bl; }
            set { cost_zd_bl = value; }
        }
        /// <summary>
        /// 实验室诊断费
        /// </summary>		
        public decimal Cost_zd_sys
        {
            get { return cost_zd_sys; }
            set { cost_zd_sys = value; }
        }
        /// <summary>
        /// 影像学诊断费
        /// </summary>		
        public decimal Cost_zd_yxx
        {
            get { return cost_zd_yxx; }
            set { cost_zd_yxx = value; }
        }
        /// <summary>
        /// 临床诊断项目费
        /// </summary>		
        public decimal Cost_zd_lcxm
        {
            get { return cost_zd_lcxm; }
            set { cost_zd_lcxm = value; }
        }
        /// <summary>
        /// 非手术治疗项目费
        /// </summary>		
        public decimal Cost_zl_fsszlxm
        {
            get { return cost_zl_fsszlxm; }
            set { cost_zl_fsszlxm = value; }
        }
        /// <summary>
        /// 临床物理治疗费
        /// </summary>		
        public decimal Cost_zl_lcwlzl
        {
            get { return cost_zl_lcwlzl; }
            set { cost_zl_lcwlzl = value; }
        }
        /// <summary>
        /// 手术治疗费
        /// </summary>		
        public decimal Cost_zl_sszl
        {
            get { return cost_zl_sszl; }
            set { cost_zl_sszl = value; }
        }
        /// <summary>
        /// 麻醉费
        /// </summary>		
        public decimal Cost_zl_mz
        {
            get { return cost_zl_mz; }
            set { cost_zl_mz = value; }
        }
        /// <summary>
        /// 手术费
        /// </summary>		
        public decimal Cost_zl_ss
        {
            get { return cost_zl_ss; }
            set { cost_zl_ss = value; }
        }
        /// <summary>
        /// 康复费
        /// </summary>		
        public decimal Cost_kf_kf
        {
            get { return cost_kf_kf; }
            set { cost_kf_kf = value; }
        }
        /// <summary>
        /// 中医治疗费
        /// </summary>		
        public decimal Cost_zy_zyzl
        {
            get { return cost_zy_zyzl; }
            set { cost_zy_zyzl = value; }
        }
        /// <summary>
        /// 西药费
        /// </summary>		
        public decimal Cost_xy_xy
        {
            get { return cost_xy_xy; }
            set { cost_xy_xy = value; }
        }
        /// <summary>
        /// 抗菌药物费
        /// </summary>		
        public decimal Cost_xy_kjyw
        {
            get { return cost_xy_kjyw; }
            set { cost_xy_kjyw = value; }
        }
        /// <summary>
        /// 中成药费
        /// </summary>		
        public decimal Cost_zy_zchy
        {
            get { return cost_zy_zchy; }
            set { cost_zy_zchy = value; }
        }
        /// <summary>
        /// 中草药费
        /// </summary>		
        public decimal Cost_zy_zaoy
        {
            get { return cost_zy_zaoy; }
            set { cost_zy_zaoy = value; }
        }
        /// <summary>
        /// 血费
        /// </summary>		
        public decimal Cost_xy_xf
        {
            get { return cost_xy_xf; }
            set { cost_xy_xf = value; }
        }
        /// <summary>
        /// 白蛋白制品费
        /// </summary>		
        public decimal Cost_xy
        {
            get { return cost_xy; }
            set { cost_xy = value; }
        }
        /// <summary>
        /// 球蛋白类制品费
        /// </summary>		
        public decimal Cost_xy_qdb
        {
            get { return cost_xy_qdb; }
            set { cost_xy_qdb = value; }
        }
        /// <summary>
        /// 凝血因子类制品费
        /// </summary>		
        public decimal Cost_xy_nxyz
        {
            get { return cost_xy_nxyz; }
            set { cost_xy_nxyz = value; }
        }
        /// <summary>
        /// 细胞因子类制品费
        /// </summary>		
        public decimal Cost_xy_xbyz
        {
            get { return cost_xy_xbyz; }
            set { cost_xy_xbyz = value; }
        }
        /// <summary>
        /// 检查用一次性医用材料费
        /// </summary>		
        public decimal Cost_hc_jc
        {
            get { return cost_hc_jc; }
            set { cost_hc_jc = value; }
        }
        /// <summary>
        /// 治疗用一次性医用材料费
        /// </summary>		
        public decimal Cost_hc_zl
        {
            get { return cost_hc_zl; }
            set { cost_hc_zl = value; }
        }
        /// <summary>
        /// 手术用一次性医用材料费
        /// </summary>		
        public decimal Cost_hc_ss
        {
            get { return cost_hc_ss; }
            set { cost_hc_ss = value; }
        }
        /// <summary>
        /// 其他费
        /// </summary>		
        public decimal Cost_other
        {
            get { return cost_other; }
            set { cost_other = value; }
        }
        /// <summary>
        /// 操作人id
        /// </summary>		
        public string Oper_code
        {
            get { return oper_code; }
            set { oper_code = value; }
        }
        /// <summary>
        /// 操作人姓名
        /// </summary>		
        public string Oper_name
        {
            get { return oper_name; }
            set { oper_name = value; }
        }
        /// <summary>
        /// 操作时间
        /// </summary>		
        public DateTime Oper_date
        {
            get { return oper_date; }
            set { oper_date = value; }
        }
        #endregion
    }
}
