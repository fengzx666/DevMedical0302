using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NineVigor.Domain.HealthRecord.Dto
{
   public interface ICasDayReport
    {
        /// <summary>
        /// 统计日期
        /// </summary>		
        DateTime Date_stat { get; set; }
        /// <summary>
        /// 病房代码
        /// </summary>		
        string Dept_code { get; set; }
        /// <summary>
        /// 护士站代码
        /// </summary>		
        string Nurse_cell_code { get; set; }
        /// <summary>
        /// 编制内病床数
        /// </summary>		
        decimal Bed_stand { get; set; }
        /// <summary>
        /// 加床数
        /// </summary>		
        decimal Bed_add { get; set; }
        /// <summary>
        /// 空床数
        /// </summary>		
        decimal Bed_free { get; set; }
        /// <summary>
        /// 期初病人数
        /// </summary>		
        decimal Beginning_num { get; set; }
        /// <summary>
        /// 常规入院数
        /// </summary>		
        decimal In_normal { get; set; }
        /// <summary>
        /// 急诊入院数
        /// </summary>		
        decimal In_emergency { get; set; }
        /// <summary>
        /// 其他科转入数
        /// </summary>		
        decimal In_transfer { get; set; }
        /// <summary>
        /// 招回入院人数
        /// </summary>		
        decimal In_return { get; set; }
        /// <summary>
        /// 常规出院数
        /// </summary>		
        decimal Out_normal { get; set; }
        /// <summary>
        /// 转出其他科数
        /// </summary>		
        decimal Out_transfer { get; set; }
        /// <summary>
        /// 退院人数
        /// </summary>		
        decimal Out_withdrawal { get; set; }
        /// <summary>
        /// 期末病人数
        /// </summary>		
        decimal End_num { get; set; }
        /// <summary>
        /// 24小时内死亡数
        /// </summary>		
        decimal Dead_in24 { get; set; }
        /// <summary>
        /// 24小时外死亡数
        /// </summary>		
        decimal Dead_out24 { get; set; }
        /// <summary>
        /// 床位使用率
        /// </summary>		
        decimal Bed_rate { get; set; }
        /// <summary>
        /// 其他1数量
        /// </summary>		
        decimal Other1_num { get; set; }
        /// <summary>
        /// 其他2数量
        /// </summary>		
        decimal Other2_num { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>		
        string Oper_code { get; set; }
        /// <summary>
        /// 整理日期
        /// </summary>		
        DateTime Oper_date { get; set; }
        /// <summary>
        /// 备注
        /// </summary>		
        string Mark { get; set; }
        /// <summary>
        /// 其他科转入数(内部转入)
        /// </summary>		
        decimal In_transfer_inner { get; set; }
        /// <summary>
        /// 转出其他科数(内部转入)
        /// </summary>		
        decimal Out_transfer_inner { get; set; }
        /// <summary>
        /// 出院治愈人数
        /// </summary>		
        decimal Out_cure { get; set; }
        /// <summary>
        /// 出院未愈人数
        /// </summary>		
        decimal Out_uncure { get; set; }
        /// <summary>
        /// 出院好转人数
        /// </summary>		
        decimal Out_better { get; set; }
        /// <summary>
        /// 出院死亡人数
        /// </summary>		
        decimal Out_death { get; set; }
        /// <summary>
        /// 出院其他人数
        /// </summary>		
        decimal Out_other { get; set; }
        /// <summary>
        /// 出院患者占用总床日数
        /// </summary>		
        decimal Out_beduseday { get; set; }
        /// <summary>
        /// 实际占用总床日数(就等于每天的期末病人数)
        /// </summary>		
        decimal All_beduseday { get; set; }
        /// <summary>
        /// 状态 0 未提交 1提交未审核 2 打回 3已审核
        /// </summary>		
        string State { get; set; }
        /// <summary>
        /// 病危患者数
        /// </summary>		
        decimal Danger_num { get; set; }
        /// <summary>
        /// 病重患者数
        /// </summary>		
        decimal Heavy_num { get; set; }
        /// <summary>
        /// 抢救人次数
        /// </summary>		
        decimal Salve_num { get; set; }
        /// <summary>
        /// 陪护人数
        /// </summary>		
        decimal Attent_num { get; set; }
        /// <summary>
        /// 输液人次
        /// </summary>		
        decimal Transfusion_num { get; set; }
        /// <summary>
        /// 输液反应人次
        /// </summary>		
        decimal Transfusion_active { get; set; }
        /// <summary>
        /// 输血人次
        /// </summary>		
        decimal Blood_num { get; set; }
        /// <summary>
        /// 输血反应人次
        /// </summary>		
        decimal Blood_active { get; set; }
        /// <summary>
        /// 成功次数
        /// </summary>		
        decimal Succ_num { get; set; }
        /// <summary>
        /// 死亡人数
        /// </summary>		
        decimal Dead_num { get; set; }
        /// <summary>
        /// 是否抢救提交
        /// </summary>		
        string Salve_state { get; set; }
        /// <summary>
        /// I级护理次数
        /// </summary>		
        decimal Onelvcarenum { get; set; }
        /// <summary>
        /// 气管切开次数
        /// </summary>		
        decimal Qiguanqiekainum { get; set; }
        /// <summary>
        /// 气管插管次数
        /// </summary>		
        decimal Qiguanchaguannum { get; set; }
        /// <summary>
        /// 呼吸机辅助呼吸次数
        /// </summary>		
        decimal Huxifuzhunum { get; set; }
        /// <summary>
        /// 二级护理人次数
        /// </summary>		
        decimal Twolvlcarenum { get; set; }
		   
    }
}
