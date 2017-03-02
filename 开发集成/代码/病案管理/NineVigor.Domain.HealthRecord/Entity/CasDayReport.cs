using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NineVigor.FrameWork.DataAccess;
using NineVigor.Domain.HealthRecord.Dto;

namespace NineVigor.Domain.HealthRecord.Entity
{
    public class CasDayReport : BaseEntity, ICasDayReport
    {
        #region  变量
        /// <summary>
        /// 统计日期
        /// </summary>		
        private DateTime date_stat;
        /// <summary>
        /// 病房代码
        /// </summary>		
        private string dept_code;
        /// <summary>
        /// 护士站代码
        /// </summary>		
        private string nurse_cell_code;
        /// <summary>
        /// 编制内病床数
        /// </summary>		
        private decimal bed_stand;
        /// <summary>
        /// 加床数
        /// </summary>		
        private decimal bed_add;
        /// <summary>
        /// 空床数
        /// </summary>		
        private decimal bed_free;
        /// <summary>
        /// 期初病人数
        /// </summary>		
        private decimal beginning_num;
        /// <summary>
        /// 常规入院数
        /// </summary>		
        private decimal in_normal;
        /// <summary>
        /// 急诊入院数
        /// </summary>		
        private decimal in_emergency;
        /// <summary>
        /// 其他科转入数
        /// </summary>		
        private decimal in_transfer;
        /// <summary>
        /// 招回入院人数
        /// </summary>		
        private decimal in_return;
        /// <summary>
        /// 常规出院数
        /// </summary>		
        private decimal out_normal;
        /// <summary>
        /// 转出其他科数
        /// </summary>		
        private decimal out_transfer;
        /// <summary>
        /// 退院人数
        /// </summary>		
        private decimal out_withdrawal;
        /// <summary>
        /// 期末病人数
        /// </summary>		
        private decimal end_num;
        /// <summary>
        /// 24小时内死亡数
        /// </summary>		
        private decimal dead_in24;
        /// <summary>
        /// 24小时外死亡数
        /// </summary>		
        private decimal dead_out24;
        /// <summary>
        /// 床位使用率
        /// </summary>		
        private decimal bed_rate;
        /// <summary>
        /// 其他1数量
        /// </summary>		
        private decimal other1_num;
        /// <summary>
        /// 其他2数量
        /// </summary>		
        private decimal other2_num;
        /// <summary>
        /// 操作人
        /// </summary>		
        private string oper_code;
        /// <summary>
        /// 整理日期
        /// </summary>		
        private DateTime oper_date;
        /// <summary>
        /// 备注
        /// </summary>		
        private string mark;
        /// <summary>
        /// 其他科转入数(内部转入)
        /// </summary>		
        private decimal in_transfer_inner;
        /// <summary>
        /// 转出其他科数(内部转入)
        /// </summary>		
        private decimal out_transfer_inner;
        /// <summary>
        /// 出院治愈人数
        /// </summary>		
        private decimal out_cure;
        /// <summary>
        /// 出院未愈人数
        /// </summary>		
        private decimal out_uncure;
        /// <summary>
        /// 出院好转人数
        /// </summary>		
        private decimal out_better;
        /// <summary>
        /// 出院死亡人数
        /// </summary>		
        private decimal out_death;
        /// <summary>
        /// 出院其他人数
        /// </summary>		
        private decimal out_other;
        /// <summary>
        /// 出院患者占用总床日数
        /// </summary>		
        private decimal out_beduseday;
        /// <summary>
        /// 实际占用总床日数(就等于每天的期末病人数)
        /// </summary>		
        private decimal all_beduseday;
        /// <summary>
        /// 状态 0 未提交 1提交未审核 2 打回 3已审核
        /// </summary>		
        private string state;
        /// <summary>
        /// 病危患者数
        /// </summary>		
        private decimal danger_num;
        /// <summary>
        /// 病重患者数
        /// </summary>		
        private decimal heavy_num;
        /// <summary>
        /// 抢救人次数
        /// </summary>		
        private decimal salve_num;
        /// <summary>
        /// 陪护人数
        /// </summary>		
        private decimal attent_num;
        /// <summary>
        /// 输液人次
        /// </summary>		
        private decimal transfusion_num;
        /// <summary>
        /// 输液反应人次
        /// </summary>		
        private decimal transfusion_active;
        /// <summary>
        /// 输血人次
        /// </summary>		
        private decimal blood_num;
        /// <summary>
        /// 输血反应人次
        /// </summary>		
        private decimal blood_active;
        /// <summary>
        /// 成功次数
        /// </summary>		
        private decimal succ_num;
        /// <summary>
        /// 死亡人数
        /// </summary>		
        private decimal dead_num;
        /// <summary>
        /// 是否抢救提交
        /// </summary>		
        private string salve_state;
        /// <summary>
        /// I级护理次数
        /// </summary>		
        private decimal onelvcarenum;
        /// <summary>
        /// 气管切开次数
        /// </summary>		
        private decimal qiguanqiekainum;
        /// <summary>
        /// 气管插管次数
        /// </summary>		
        private decimal qiguanchaguannum;
        /// <summary>
        /// 呼吸机辅助呼吸次数
        /// </summary>		
        private decimal huxifuzhunum;
        /// <summary>
        /// 二级护理人次数
        /// </summary>		
        private decimal twolvlcarenum;
        #endregion

        #region 属性
        /// <summary>
        /// 统计日期
        /// </summary>		
        public DateTime Date_stat
        {
            get { return date_stat; }
            set { date_stat = value; }
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
        /// 编制内病床数
        /// </summary>		
        public decimal Bed_stand
        {
            get { return bed_stand; }
            set { bed_stand = value; }
        }
        /// <summary>
        /// 加床数
        /// </summary>		
        public decimal Bed_add
        {
            get { return bed_add; }
            set { bed_add = value; }
        }
        /// <summary>
        /// 空床数
        /// </summary>		
        public decimal Bed_free
        {
            get { return bed_free; }
            set { bed_free = value; }
        }
        /// <summary>
        /// 期初病人数
        /// </summary>		
        public decimal Beginning_num
        {
            get { return beginning_num; }
            set { beginning_num = value; }
        }
        /// <summary>
        /// 常规入院数
        /// </summary>		
        public decimal In_normal
        {
            get { return in_normal; }
            set { in_normal = value; }
        }
        /// <summary>
        /// 急诊入院数
        /// </summary>		
        public decimal In_emergency
        {
            get { return in_emergency; }
            set { in_emergency = value; }
        }
        /// <summary>
        /// 其他科转入数
        /// </summary>		
        public decimal In_transfer
        {
            get { return in_transfer; }
            set { in_transfer = value; }
        }
        /// <summary>
        /// 招回入院人数
        /// </summary>		
        public decimal In_return
        {
            get { return in_return; }
            set { in_return = value; }
        }
        /// <summary>
        /// 常规出院数
        /// </summary>		
        public decimal Out_normal
        {
            get { return out_normal; }
            set { out_normal = value; }
        }
        /// <summary>
        /// 转出其他科数
        /// </summary>		
        public decimal Out_transfer
        {
            get { return out_transfer; }
            set { out_transfer = value; }
        }
        /// <summary>
        /// 退院人数
        /// </summary>		
        public decimal Out_withdrawal
        {
            get { return out_withdrawal; }
            set { out_withdrawal = value; }
        }
        /// <summary>
        /// 期末病人数
        /// </summary>		
        public decimal End_num
        {
            get { return end_num; }
            set { end_num = value; }
        }
        /// <summary>
        /// 24小时内死亡数
        /// </summary>		
        public decimal Dead_in24
        {
            get { return dead_in24; }
            set { dead_in24 = value; }
        }
        /// <summary>
        /// 24小时外死亡数
        /// </summary>		
        public decimal Dead_out24
        {
            get { return dead_out24; }
            set { dead_out24 = value; }
        }
        /// <summary>
        /// 床位使用率
        /// </summary>		
        public decimal Bed_rate
        {
            get { return bed_rate; }
            set { bed_rate = value; }
        }
        /// <summary>
        /// 其他1数量
        /// </summary>		
        public decimal Other1_num
        {
            get { return other1_num; }
            set { other1_num = value; }
        }
        /// <summary>
        /// 其他2数量
        /// </summary>		
        public decimal Other2_num
        {
            get { return other2_num; }
            set { other2_num = value; }
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
        /// 整理日期
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
        /// 其他科转入数(内部转入)
        /// </summary>		
        public decimal In_transfer_inner
        {
            get { return in_transfer_inner; }
            set { in_transfer_inner = value; }
        }
        /// <summary>
        /// 转出其他科数(内部转入)
        /// </summary>		
        public decimal Out_transfer_inner
        {
            get { return out_transfer_inner; }
            set { out_transfer_inner = value; }
        }
        /// <summary>
        /// 出院治愈人数
        /// </summary>		
        public decimal Out_cure
        {
            get { return out_cure; }
            set { out_cure = value; }
        }
        /// <summary>
        /// 出院未愈人数
        /// </summary>		
        public decimal Out_uncure
        {
            get { return out_uncure; }
            set { out_uncure = value; }
        }
        /// <summary>
        /// 出院好转人数
        /// </summary>		
        public decimal Out_better
        {
            get { return out_better; }
            set { out_better = value; }
        }
        /// <summary>
        /// 出院死亡人数
        /// </summary>		
        public decimal Out_death
        {
            get { return out_death; }
            set { out_death = value; }
        }
        /// <summary>
        /// 出院其他人数
        /// </summary>		
        public decimal Out_other
        {
            get { return out_other; }
            set { out_other = value; }
        }
        /// <summary>
        /// 出院患者占用总床日数
        /// </summary>		
        public decimal Out_beduseday
        {
            get { return out_beduseday; }
            set { out_beduseday = value; }
        }
        /// <summary>
        /// 实际占用总床日数(就等于每天的期末病人数)
        /// </summary>		
        public decimal All_beduseday
        {
            get { return all_beduseday; }
            set { all_beduseday = value; }
        }
        /// <summary>
        /// 状态 0 未提交 1提交未审核 2 打回 3已审核
        /// </summary>		
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        /// <summary>
        /// 病危患者数
        /// </summary>		
        public decimal Danger_num
        {
            get { return danger_num; }
            set { danger_num = value; }
        }
        /// <summary>
        /// 病重患者数
        /// </summary>		
        public decimal Heavy_num
        {
            get { return heavy_num; }
            set { heavy_num = value; }
        }
        /// <summary>
        /// 抢救人次数
        /// </summary>		
        public decimal Salve_num
        {
            get { return salve_num; }
            set { salve_num = value; }
        }
        /// <summary>
        /// 陪护人数
        /// </summary>		
        public decimal Attent_num
        {
            get { return attent_num; }
            set { attent_num = value; }
        }
        /// <summary>
        /// 输液人次
        /// </summary>		
        public decimal Transfusion_num
        {
            get { return transfusion_num; }
            set { transfusion_num = value; }
        }
        /// <summary>
        /// 输液反应人次
        /// </summary>		
        public decimal Transfusion_active
        {
            get { return transfusion_active; }
            set { transfusion_active = value; }
        }
        /// <summary>
        /// 输血人次
        /// </summary>		
        public decimal Blood_num
        {
            get { return blood_num; }
            set { blood_num = value; }
        }
        /// <summary>
        /// 输血反应人次
        /// </summary>		
        public decimal Blood_active
        {
            get { return blood_active; }
            set { blood_active = value; }
        }
        /// <summary>
        /// 成功次数
        /// </summary>		
        public decimal Succ_num
        {
            get { return succ_num; }
            set { succ_num = value; }
        }
        /// <summary>
        /// 死亡人数
        /// </summary>		
        public decimal Dead_num
        {
            get { return dead_num; }
            set { dead_num = value; }
        }
        /// <summary>
        /// 是否抢救提交
        /// </summary>		
        public string Salve_state
        {
            get { return salve_state; }
            set { salve_state = value; }
        }
        /// <summary>
        /// I级护理次数
        /// </summary>		
        public decimal Onelvcarenum
        {
            get { return onelvcarenum; }
            set { onelvcarenum = value; }
        }
        /// <summary>
        /// 气管切开次数
        /// </summary>		
        public decimal Qiguanqiekainum
        {
            get { return qiguanqiekainum; }
            set { qiguanqiekainum = value; }
        }
        /// <summary>
        /// 气管插管次数
        /// </summary>		
        public decimal Qiguanchaguannum
        {
            get { return qiguanchaguannum; }
            set { qiguanchaguannum = value; }
        }
        /// <summary>
        /// 呼吸机辅助呼吸次数
        /// </summary>		
        public decimal Huxifuzhunum
        {
            get { return huxifuzhunum; }
            set { huxifuzhunum = value; }
        }
        /// <summary>
        /// 二级护理人次数
        /// </summary>		
        public decimal Twolvlcarenum
        {
            get { return twolvlcarenum; }
            set { twolvlcarenum = value; }
        }
        #endregion   
    }
}
