using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NineVigor.Domain.HealthRecord.Dto
{
    public interface ICasBase
    {
        /// <summary>
        /// INPATIENT_NO
        /// </summary>		
        string Inpatient_no { get; set; }
        /// <summary>
        /// 住院病历号
        /// </summary>		
        string Patient_no { get; set; }
        /// <summary>
        /// 门诊号
        /// </summary>		
        string Card_no { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>		
        string PName { get; set; }
        /// <summary>
        /// 曾用名
        /// </summary>		
        string Nomen { get; set; }
        /// <summary>
        /// 性别
        /// </summary>		
        string Sex_code { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>		
        DateTime Birthday { get; set; }
        /// <summary>
        /// 国家
        /// </summary>		
        string Coun_code { get; set; }
        /// <summary>
        /// 民族
        /// </summary>		
        string Nation_code { get; set; }
        /// <summary>
        /// 职业
        /// </summary>		
        string Prof_code { get; set; }
        /// <summary>
        /// 血型编码
        /// </summary>		
        string Blood_code { get; set; }
        /// <summary>
        /// 婚否
        /// </summary>		
        string Mari { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>		
        decimal Age { get; set; }
        /// <summary>
        /// 年龄单位
        /// </summary>		
        string Age_unit { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>		
        string Idenno { get; set; }
        /// <summary>
        /// 地区来源
        /// </summary>		
        string In_source { get; set; }
        /// <summary>
        /// 结算类别号
        /// </summary>		
        string Paykind_code { get; set; }
        /// <summary>
        /// 合同代码
        /// </summary>		
        string Pact_code { get; set; }
        /// <summary>
        /// 医保公费号
        /// </summary>		
        string Mcard_no { get; set; }
        /// <summary>
        /// 籍贯
        /// </summary>		
        string District { get; set; }
        /// <summary>
        /// 出生地
        /// </summary>		
        string Homeplace { get; set; }
        /// <summary>
        /// 家庭住址
        /// </summary>		
        string Home_add { get; set; }
        /// <summary>
        /// 家庭电话
        /// </summary>		
        string Home_tel { get; set; }
        /// <summary>
        /// 住址邮编
        /// </summary>		
        string Home_zip { get; set; }
        /// <summary>
        /// 单位地址
        /// </summary>		
        string Work_name { get; set; }
        /// <summary>
        /// 单位电话
        /// </summary>		
        string Work_tel { get; set; }
        /// <summary>
        /// 单位邮编
        /// </summary>		
        string Work_zip { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>		
        string Linkma_name { get; set; }
        /// <summary>
        /// 与患者关系
        /// </summary>		
        string Rela_code { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>		
        string Linkman_tel { get; set; }
        /// <summary>
        /// 联系地址
        /// </summary>		
        string Linkman_add { get; set; }
        /// <summary>
        /// 门诊诊断医生
        /// </summary>		
        string Clinic_docd { get; set; }
        /// <summary>
        /// 门诊诊断医生姓名
        /// </summary>		
        string Clinic_donm { get; set; }
        /// <summary>
        /// 转来医院
        /// </summary>		
        string Come_from { get; set; }
        /// <summary>
        /// 入院日期
        /// </summary>		
        DateTime In_date { get; set; }
        /// <summary>
        /// 住院次数
        /// </summary>		
        decimal In_times { get; set; }
        /// <summary>
        /// 入院科室代码
        /// </summary>		
        string Dept_incd { get; set; }
        /// <summary>
        /// 入院科室名称
        /// </summary>		
        string Dept_innm { get; set; }
        /// <summary>
        /// 入院来源
        /// </summary>		
        string In_avenue { get; set; }
        /// <summary>
        /// 入院状态
        /// </summary>		
        string In_circs { get; set; }
        /// <summary>
        /// 确诊日期
        /// </summary>		
        DateTime Diag_date { get; set; }
        /// <summary>
        /// 第一主手术日期
        /// </summary>		
        DateTime Operation_date { get; set; }
        /// <summary>
        /// 出院日期
        /// </summary>		
        DateTime Out_date { get; set; }
        /// <summary>
        /// 出院科室代码
        /// </summary>		
        string Dept_code { get; set; }
        /// <summary>
        /// 出院科室名称
        /// </summary>		
        string Dept_name { get; set; }
        /// <summary>
        /// 转归代码
        /// </summary>		
        string Zg { get; set; }
        /// <summary>
        /// 确诊天数
        /// </summary>		
        decimal Diag_days { get; set; }
        /// <summary>
        /// 住院天数
        /// </summary>		
        decimal Pi_days { get; set; }
        /// <summary>
        /// 死亡日期
        /// </summary>		
        DateTime Dead_date { get; set; }
        /// <summary>
        /// 死亡原因
        /// </summary>		
        string Dead_reason { get; set; }
        /// <summary>
        /// 尸检
        /// </summary>		
        string Body_check { get; set; }
        /// <summary>
        /// 死亡种类
        /// </summary>		
        string Dead_kind { get; set; }
        /// <summary>
        /// 尸体解剖号
        /// </summary>		
        string Body_anotomize { get; set; }
        /// <summary>
        /// 乙肝表面抗原（阴性、阳性、未做）
        /// </summary>		
        string Hbsag { get; set; }
        /// <summary>
        /// 丙肝病毒抗体（阴性、阳性、未做）
        /// </summary>		
        string Hcv_ab { get; set; }
        /// <summary>
        /// 获得性人类免疫缺陷病毒抗体（阴性、阳性、未做）
        /// </summary>		
        string Hiv_ab { get; set; }
        /// <summary>
        /// 门急_入院符合
        /// </summary>		
        string Ce_pi { get; set; }
        /// <summary>
        /// 入出_院符合
        /// </summary>		
        string Pi_po { get; set; }
        /// <summary>
        /// 术前_后符合
        /// </summary>		
        string Opb_opa { get; set; }
        /// <summary>
        /// 临床_X光符合
        /// </summary>		
        string Cl_x { get; set; }
        /// <summary>
        /// 临床_CT符合
        /// </summary>		
        string Cl_ct { get; set; }
        /// <summary>
        /// 临床_MRI符合
        /// </summary>		
        string Cl_mri { get; set; }
        /// <summary>
        /// 临床_病理符合
        /// </summary>		
        string Cl_pa { get; set; }
        /// <summary>
        /// 放射_病理符合
        /// </summary>		
        string Fs_bl { get; set; }
        /// <summary>
        /// 抢救次数
        /// </summary>		
        decimal Salv_times { get; set; }
        /// <summary>
        /// 成功次数
        /// </summary>		
        decimal Succ_times { get; set; }
        /// <summary>
        /// 示教科研
        /// </summary>		
        string Tech_serc { get; set; }
        /// <summary>
        /// 是否随诊
        /// </summary>		
        string Visi_stat { get; set; }
        /// <summary>
        /// 随访期限
        /// </summary>		
        DateTime Visi_peri { get; set; }
        /// <summary>
        /// 院际会诊次数
        /// </summary>		
        decimal Incon_num { get; set; }
        /// <summary>
        /// 远程会诊次数
        /// </summary>		
        decimal Outcon_num { get; set; }
        /// <summary>
        /// 药物过敏
        /// </summary>		
        string Anaphy_flag { get; set; }
        /// <summary>
        /// 过敏药物名称
        /// </summary>		
        string Anaphy_name1 { get; set; }
        /// <summary>
        /// 过敏药物名称
        /// </summary>		
        string Anaphy_name2 { get; set; }
        /// <summary>
        /// 更改后出院日期
        /// </summary>		
        DateTime Cout_date { get; set; }
        /// <summary>
        /// 住院医师代码
        /// </summary>		
        string House_doc_code { get; set; }
        /// <summary>
        /// 住院医师姓名
        /// </summary>		
        string House_doc_name { get; set; }
        /// <summary>
        /// 主治医师代码
        /// </summary>		
        string Charge_doc_code { get; set; }
        /// <summary>
        /// 主治医师姓名
        /// </summary>		
        string Charge_doc_name { get; set; }
        /// <summary>
        /// 主任医师代码
        /// </summary>		
        string Chief_doc_code { get; set; }
        /// <summary>
        /// 主任医师姓名
        /// </summary>		
        string Chief_doc_name { get; set; }
        /// <summary>
        /// 科主任代码
        /// </summary>		
        string Dept_chief_docd { get; set; }
        /// <summary>
        /// 科主任名称
        /// </summary>		
        string Dept_chief_donm { get; set; }
        /// <summary>
        /// 进修医师代码
        /// </summary>		
        string Refresher_docd { get; set; }
        /// <summary>
        /// 进修医生名称
        /// </summary>		
        string Refresher_donm { get; set; }
        /// <summary>
        /// 研究生实习医师代码
        /// </summary>		
        string Gra_doc_code { get; set; }
        /// <summary>
        /// 研究生实习医师名称
        /// </summary>		
        string Gra_doc_name { get; set; }
        /// <summary>
        /// 实习医师代码
        /// </summary>		
        string Pra_doc_code { get; set; }
        /// <summary>
        /// 实习医师名称
        /// </summary>		
        string Pra_doc_name { get; set; }
        /// <summary>
        /// 编码员代码
        /// </summary>		
        string Coding_code { get; set; }
        /// <summary>
        /// 编码员名称
        /// </summary>		
        string Coding_name { get; set; }
        /// <summary>
        /// 病案质量
        /// </summary>		
        string Mr_qual { get; set; }
        /// <summary>
        /// 合格病案
        /// </summary>		
        string Mr_elig { get; set; }
        /// <summary>
        /// 质控医师代码
        /// </summary>		
        string Qc_docd { get; set; }
        /// <summary>
        /// 质控医师名称
        /// </summary>		
        string Qc_donm { get; set; }
        /// <summary>
        /// 质控护士代码
        /// </summary>		
        string Qc_nucd { get; set; }
        /// <summary>
        /// 质控护士名称
        /// </summary>		
        string Qc_nunm { get; set; }
        /// <summary>
        /// 检查时间
        /// </summary>		
        DateTime Check_date { get; set; }
        /// <summary>
        /// 手术、操作、治疗、检查、诊断为本院第一例项目
        /// </summary>		
        string Yn_first { get; set; }
        /// <summary>
        /// Rh血型(阴、阳)
        /// </summary>		
        string Rh_blood { get; set; }
        /// <summary>
        /// 输血反应（有、无）
        /// </summary>		
        string Reaction_blood { get; set; }
        /// <summary>
        /// 红细胞数
        /// </summary>		
        string Blood_red { get; set; }
        /// <summary>
        /// 血小板数
        /// </summary>		
        string Blood_platelet { get; set; }
        /// <summary>
        /// 血浆数
        /// </summary>		
        string Blood_plasma { get; set; }
        /// <summary>
        /// 全血数
        /// </summary>		
        string Blood_whole { get; set; }
        /// <summary>
        /// 其他输血数
        /// </summary>		
        string Blood_other { get; set; }
        /// <summary>
        /// X光号
        /// </summary>		
        string X_numb { get; set; }
        /// <summary>
        /// CT号
        /// </summary>		
        string Ct_numb { get; set; }
        /// <summary>
        /// MRI号
        /// </summary>		
        string Mri_numb { get; set; }
        /// <summary>
        /// 病理号
        /// </summary>		
        string Path_numb { get; set; }
        /// <summary>
        /// B超
        /// </summary>		
        string Dsa_numb { get; set; }
        /// <summary>
        /// PET号
        /// </summary>		
        string Pet_numb { get; set; }
        /// <summary>
        /// ECT号
        /// </summary>		
        string Ect_numb { get; set; }
        /// <summary>
        /// X线次数
        /// </summary>		
        decimal X_times { get; set; }
        /// <summary>
        /// CT次数
        /// </summary>		
        decimal Ct_times { get; set; }
        /// <summary>
        /// MR次数
        /// </summary>		
        decimal Mr_times { get; set; }
        /// <summary>
        /// DSA次数
        /// </summary>		
        decimal Dsa_times { get; set; }
        /// <summary>
        /// PET次数
        /// </summary>		
        decimal Pet_times { get; set; }
        /// <summary>
        /// ECT次数
        /// </summary>		
        decimal Ect_times { get; set; }
        /// <summary>
        /// 说明
        /// </summary>		
        string Remark { get; set; }
        /// <summary>
        /// 归档条码号
        /// </summary>		
        string Bar_code { get; set; }
        /// <summary>
        /// 病案借阅状态(O借出 I在架)
        /// </summary>		
        string Lend_stus { get; set; }
        /// <summary>
        /// 病案状态1科室质检/2医生站登记保存/3病案室整理/4病案室质检/5无效
        /// </summary>		
        string Case_stus { get; set; }
        /// <summary>
        /// 操作员
        /// </summary>		
        string Oper_code { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>		
        DateTime Oper_date { get; set; }
        /// <summary>
        /// 随访期限  周
        /// </summary>		
        string Visi_periweek { get; set; }
        /// <summary>
        /// 随访期限  月
        /// </summary>		
        string Visi_perimonth { get; set; }
        /// <summary>
        /// 随访期限  年
        /// </summary>		
        string Visi_periyear { get; set; }
        /// <summary>
        /// 特殊护理(日)
        /// </summary>		
        decimal Specal_nus { get; set; }
        /// <summary>
        /// I级护理时间(日)
        /// </summary>		
        decimal I_nus { get; set; }
        /// <summary>
        /// II级护理时间(日)
        /// </summary>		
        decimal Ii_nus { get; set; }
        /// <summary>
        /// III级护理时间(日)
        /// </summary>		
        decimal Iii_nus { get; set; }
        /// <summary>
        /// 重症监护时间( 小时)
        /// </summary>		
        decimal Strictness_nus { get; set; }
        /// <summary>
        /// 特级护理时间(小时)
        /// </summary>		
        decimal Super_nus { get; set; }
        /// <summary>
        /// 整理员
        /// </summary>		
        string Packup_code { get; set; }
        /// <summary>
        /// 单病种
        /// </summary>		
        string Disease30_flag { get; set; }
        /// <summary>
        /// 是否手工录入病案  1 是,0 否
        /// </summary>		
        string Is_handcraft { get; set; }
        /// <summary>
        /// 是否有并发症 1 有 0 无
        /// </summary>		
        string Diag_syndrome { get; set; }
        /// <summary>
        /// 院内感染次数
        /// </summary>		
        decimal Infection_num { get; set; }
        /// <summary>
        /// 手术编码员
        /// </summary>		
        string Operation_coding { get; set; }
        /// <summary>
        /// 门诊诊断 编码
        /// </summary>		
        string Clinic_diagicd { get; set; }
        /// <summary>
        /// 门诊诊断 名称
        /// </summary>		
        string Clinic_diagicdname { get; set; }
        /// <summary>
        /// 入院诊断 编码
        /// </summary>		
        string Inhos_diagicd { get; set; }
        /// <summary>
        /// 入院诊断 名称
        /// </summary>		
        string Inhos_diagicdname { get; set; }
        /// <summary>
        /// 出院主诊断 编码
        /// </summary>		
        string Main_diagicd { get; set; }
        /// <summary>
        /// 出院主诊断 名称
        /// </summary>		
        string Main_diagicdname { get; set; }
        /// <summary>
        /// 出院主诊断 治疗情况
        /// </summary>		
        string Main_diagstate { get; set; }
        /// <summary>
        /// 出院主诊断病理符合情况
        /// </summary>		
        string Main_diagclpa { get; set; }
        /// <summary>
        /// 第一主手术代码
        /// </summary>		
        string Operation_code { get; set; }
        /// <summary>
        /// 第一主手术名称
        /// </summary>		
        string Operation_cnname { get; set; }
        /// <summary>
        /// 第一主手术医师代码
        /// </summary>		
        string Fir_docd { get; set; }
        /// <summary>
        /// 第一主手术医师名称
        /// </summary>		
        string Fir_donm { get; set; }
        /// <summary>
        /// 病案号
        /// </summary>		
        string Case_no { get; set; }
        /// <summary>
        /// 院内感染部位编码
        /// </summary>		
        string Infection_code { get; set; }
        /// <summary>
        /// 院内感染部位名称
        /// </summary>		
        string Infection_name { get; set; }
        /// <summary>
        /// 出院方式（1、常规 2、自动 3、转院）
        /// </summary>		
        string Out_type { get; set; }
        /// <summary>
        /// 治疗类别（1、中      2、西      3、中西）
        /// </summary>		
        string Cure_type { get; set; }
        /// <summary>
        /// 自制中药制剂（0、未知   1、有    2、无）
        /// </summary>		
        string Use_cha_med { get; set; }
        /// <summary>
        /// 抢救方法（1、中     2、西       3、中西）
        /// </summary>		
        string Salv_type { get; set; }
        /// <summary>
        /// 是否出现危重（１、是　　　０、否）
        /// </summary>		
        string Ever_sickintodeath { get; set; }
        /// <summary>
        /// 是否出现急症（１、是　　　０、否）
        /// </summary>		
        string Ever_firstaid { get; set; }
        /// <summary>
        /// 是否出现疑难情况（１、是　０、否）
        /// </summary>		
        string Ever_difficulty { get; set; }
        /// <summary>
        /// 输液反应（１、有　２、无　３、未输）
        /// </summary>		
        string Reaction_liquid { get; set; }
        /// <summary>
        /// 科主任
        /// </summary>		
        string Deptdirector { get; set; }
        /// <summary>
        /// 形态学编码
        /// </summary>		
        string Morphologyid { get; set; }
        /// <summary>
        /// 抗生素使用次数
        /// </summary>		
        string Usenumber { get; set; }
        /// <summary>
        /// 抗生素使用天数
        /// </summary>		
        string Usedays { get; set; }
        /// <summary>
        /// 病历卡号
        /// </summary>		
        string Medicalrecord { get; set; }
        /// <summary>
        /// 肿瘤病历卡
        /// </summary>		
        string Tumorrecord { get; set; }
        /// <summary>
        /// 病案合同代码CAS_PACTUNIT
        /// </summary>		
        string Case_pact_code { get; set; }
        /// <summary>
        /// 回收日期
        /// </summary>		
        DateTime Recall_date { get; set; }
        /// <summary>
        /// 入院病区代码(河南省医增加)
        /// </summary>		
        string Nursecell_code { get; set; }
        /// <summary>
        /// 入院病区名称(河南省医增加)
        /// </summary>		
        string Nursecell_name { get; set; }
        /// <summary>
        /// 出院病区代码(河南省医增加)
        /// </summary>		
        string Outnursecell_code { get; set; }
        /// <summary>
        /// 出院病区名称(河南省医增加)
        /// </summary>		
        string Outnursecell_name { get; set; }
        /// <summary>
        /// 病历分型（河南省医新增)
        /// </summary>		
        string Medical_type { get; set; }
        /// <summary>
        /// 切口类型(河南省医新增)
        /// </summary>		
        string Mainoperationcut { get; set; }
        /// <summary>
        /// 愈合等级(河南省医新增)
        /// </summary>		
        string Mainoperationscare { get; set; }
        /// <summary>
        /// 损伤中毒原因
        /// </summary>		
        string Injury_cause { get; set; }
        /// <summary>
        /// 传染病报告（1 已报 2 未报）
        /// </summary>		
        string Infection_report { get; set; }
        /// <summary>
        /// 四病报告（1 已报 2 未报）
        /// </summary>		
        string Fourdiseases_report { get; set; }
        /// <summary>
        /// CASE_INFOTXT
        /// </summary>		
        string Case_infotxt { get; set; }
        /// <summary>
        /// 医疗机构代码
        /// </summary>		
        string Hos_code { get; set; }
        /// <summary>
        /// 健康卡号
        /// </summary>		
        string Health_card { get; set; }
        /// <summary>
        /// 新生儿出生体重
        /// </summary>		
        string Baby_weight { get; set; }
        /// <summary>
        /// 新生儿入院体重
        /// </summary>		
        string Baby_in_weight { get; set; }
        /// <summary>
        /// 现住址
        /// </summary>		
        string Current_address { get; set; }
        /// <summary>
        /// 入院途径
        /// </summary>		
        string In_way { get; set; }
        /// <summary>
        /// 损伤中毒ICD码
        /// </summary>		
        string Injury_icd { get; set; }
        /// <summary>
        /// 病理诊断ICD码
        /// </summary>		
        string Pathology_icd { get; set; }
        /// <summary>
        /// 责任护士
        /// </summary>		
        string Res_nurs { get; set; }
        /// <summary>
        /// 离院方式（1.医嘱离院 2.医嘱转院 3.医嘱转社区卫生服务机构/乡镇卫生院 4.非医嘱离院 5.死亡 9.其他）
        /// </summary>		
        string Leave_type { get; set; }
        /// <summary>
        /// 拟接收医疗机构(当"离院方式"选择 2、3时)
        /// </summary>		
        string Receive_hos { get; set; }
        /// <summary>
        /// 是否有出院31天内再住院计划（１、是　　　０、否）
        /// </summary>		
        string Proj_after_31days { get; set; }
        /// <summary>
        /// 31天内再住院计划的目的（当31天内再住院计划选择"是"时）
        /// </summary>		
        string Proj_after_31days_purpose { get; set; }
        /// <summary>
        /// 颅脑损伤患者昏迷时间(入院前)
        /// </summary>		
        string Brain_injury_pre { get; set; }
        /// <summary>
        /// 颅脑损伤患者昏迷时间(入院后)
        /// </summary>		
        string Brain_injury_aft { get; set; }
        /// <summary>
        /// 河南扩展字段内容
        /// </summary>		
        string Henanadd2012 { get; set; }
        /// <summary>
        /// 首次提交人
        /// </summary>		
        string Firstsubmitoper { get; set; }
        /// <summary>
        /// 首次提交日期
        /// </summary>		
        DateTime Firstsubmitdate { get; set; }
		   
    }
}
