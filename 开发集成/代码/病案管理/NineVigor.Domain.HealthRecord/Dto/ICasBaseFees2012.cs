using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NineVigor.Domain.HealthRecord.Dto
{
   public interface ICasBaseFees2012
    {
        /// <summary>
        /// 病案号
        /// </summary>		
        string Patient_id { get; set; }
        /// <summary>
        /// 住院流水号
        /// </summary>		
        string Inpatient_no { get; set; }
        /// <summary>
        /// 住院次数
        /// </summary>		
        decimal Visit_id { get; set; }
        /// <summary>
        /// 总费用
        /// </summary>		
        decimal Cost_total { get; set; }
        /// <summary>
        /// 自付金额
        /// </summary>		
        decimal Cost_ownpay { get; set; }
        /// <summary>
        /// 一般医疗服务费
        /// </summary>		
        decimal Cost_zh_ybyl { get; set; }
        /// <summary>
        /// 一般治疗操作费
        /// </summary>		
        decimal Cost_zh_ybzl { get; set; }
        /// <summary>
        /// 护理住院费
        /// </summary>		
        decimal Cost_zh_hl { get; set; }
        /// <summary>
        /// 综合治疗类其他费用
        /// </summary>		
        decimal Cost_zh_other { get; set; }
        /// <summary>
        /// 病理诊断费
        /// </summary>		
        decimal Cost_zd_bl { get; set; }
        /// <summary>
        /// 实验室诊断费
        /// </summary>		
        decimal Cost_zd_sys { get; set; }
        /// <summary>
        /// 影像学诊断费
        /// </summary>		
        decimal Cost_zd_yxx { get; set; }
        /// <summary>
        /// 临床诊断项目费
        /// </summary>		
        decimal Cost_zd_lcxm { get; set; }
        /// <summary>
        /// 非手术治疗项目费
        /// </summary>		
        decimal Cost_zl_fsszlxm { get; set; }
        /// <summary>
        /// 临床物理治疗费
        /// </summary>		
        decimal Cost_zl_lcwlzl { get; set; }
        /// <summary>
        /// 手术治疗费
        /// </summary>		
        decimal Cost_zl_sszl { get; set; }
        /// <summary>
        /// 麻醉费
        /// </summary>		
        decimal Cost_zl_mz { get; set; }
        /// <summary>
        /// 手术费
        /// </summary>		
        decimal Cost_zl_ss { get; set; }
        /// <summary>
        /// 康复费
        /// </summary>		
        decimal Cost_kf_kf { get; set; }
        /// <summary>
        /// 中医治疗费
        /// </summary>		
        decimal Cost_zy_zyzl { get; set; }
        /// <summary>
        /// 西药费
        /// </summary>		
        decimal Cost_xy_xy { get; set; }
        /// <summary>
        /// 抗菌药物费
        /// </summary>		
        decimal Cost_xy_kjyw { get; set; }
        /// <summary>
        /// 中成药费
        /// </summary>		
        decimal Cost_zy_zchy { get; set; }
        /// <summary>
        /// 中草药费
        /// </summary>		
        decimal Cost_zy_zaoy { get; set; }
        /// <summary>
        /// 血费
        /// </summary>		
        decimal Cost_xy_xf { get; set; }
        /// <summary>
        /// 白蛋白制品费
        /// </summary>		
        decimal Cost_xy { get; set; }
        /// <summary>
        /// 球蛋白类制品费
        /// </summary>		
        decimal Cost_xy_qdb { get; set; }
        /// <summary>
        /// 凝血因子类制品费
        /// </summary>		
        decimal Cost_xy_nxyz { get; set; }
        /// <summary>
        /// 细胞因子类制品费
        /// </summary>		
        decimal Cost_xy_xbyz { get; set; }
        /// <summary>
        /// 检查用一次性医用材料费
        /// </summary>		
        decimal Cost_hc_jc { get; set; }
        /// <summary>
        /// 治疗用一次性医用材料费
        /// </summary>		
        decimal Cost_hc_zl { get; set; }
        /// <summary>
        /// 手术用一次性医用材料费
        /// </summary>		
        decimal Cost_hc_ss { get; set; }
        /// <summary>
        /// 其他费
        /// </summary>		
        decimal Cost_other { get; set; }
        /// <summary>
        /// 操作人id
        /// </summary>		
        string Oper_code { get; set; }
        /// <summary>
        /// 操作人姓名
        /// </summary>		
        string Oper_name { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>		
        DateTime Oper_date { get; set; }
    }
}
