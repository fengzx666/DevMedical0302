using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NineVigor.FrameWork.DataAccess;
using NineVigor.Domain.HealthRecord.Dto;

namespace NineVigor.Domain.HealthRecord.Entity
{
    public class CasBase : BaseEntity, ICasBase
    {
        #region 变量定义
        /// <summary>
        /// INPATIENT_NO
        /// </summary>		
        private string inpatient_no;
        /// <summary>
        /// 住院病历号
        /// </summary>		
        private string patient_no;
        /// <summary>
        /// 门诊号
        /// </summary>		
        private string card_no;
        /// <summary>
        /// 姓名
        /// </summary>		
        private string name;
        /// <summary>
        /// 曾用名
        /// </summary>		
        private string nomen;
        /// <summary>
        /// 性别
        /// </summary>		
        private string sex_code;
        /// <summary>
        /// 出生日期
        /// </summary>		
        private DateTime birthday;
        /// <summary>
        /// 国家
        /// </summary>		
        private string coun_code;
        /// <summary>
        /// 民族
        /// </summary>		
        private string nation_code;
        /// <summary>
        /// 职业
        /// </summary>		
        private string prof_code;
        /// <summary>
        /// 血型编码
        /// </summary>		
        private string blood_code;
        /// <summary>
        /// 婚否
        /// </summary>		
        private string mari;
        /// <summary>
        /// 年龄
        /// </summary>		
        private decimal age;
        /// <summary>
        /// 年龄单位
        /// </summary>		
        private string age_unit;
        /// <summary>
        /// 身份证号
        /// </summary>		
        private string idenno;
        /// <summary>
        /// 地区来源
        /// </summary>		
        private string in_source;
        /// <summary>
        /// 结算类别号
        /// </summary>		
        private string paykind_code;
        /// <summary>
        /// 合同代码
        /// </summary>		
        private string pact_code;
        /// <summary>
        /// 医保公费号
        /// </summary>		
        private string mcard_no;
        /// <summary>
        /// 籍贯
        /// </summary>		
        private string district;
        /// <summary>
        /// 出生地
        /// </summary>		
        private string homeplace;
        /// <summary>
        /// 家庭住址
        /// </summary>		
        private string home_add;
        /// <summary>
        /// 家庭电话
        /// </summary>		
        private string home_tel;
        /// <summary>
        /// 住址邮编
        /// </summary>		
        private string home_zip;
        /// <summary>
        /// 单位地址
        /// </summary>		
        private string work_name;
        /// <summary>
        /// 单位电话
        /// </summary>		
        private string work_tel;
        /// <summary>
        /// 单位邮编
        /// </summary>		
        private string work_zip;
        /// <summary>
        /// 联系人
        /// </summary>		
        private string linkma_name;
        /// <summary>
        /// 与患者关系
        /// </summary>		
        private string rela_code;
        /// <summary>
        /// 联系电话
        /// </summary>		
        private string linkman_tel;
        /// <summary>
        /// 联系地址
        /// </summary>		
        private string linkman_add;
        /// <summary>
        /// 门诊诊断医生
        /// </summary>		
        private string clinic_docd;
        /// <summary>
        /// 门诊诊断医生姓名
        /// </summary>		
        private string clinic_donm;
        /// <summary>
        /// 转来医院
        /// </summary>		
        private string come_from;
        /// <summary>
        /// 入院日期
        /// </summary>		
        private DateTime in_date;
        /// <summary>
        /// 住院次数
        /// </summary>		
        private decimal in_times;
        /// <summary>
        /// 入院科室代码
        /// </summary>		
        private string dept_incd;
        /// <summary>
        /// 入院科室名称
        /// </summary>		
        private string dept_innm;
        /// <summary>
        /// 入院来源
        /// </summary>		
        private string in_avenue;
        /// <summary>
        /// 入院状态
        /// </summary>		
        private string in_circs;
        /// <summary>
        /// 确诊日期
        /// </summary>		
        private DateTime diag_date;
        /// <summary>
        /// 第一主手术日期
        /// </summary>		
        private DateTime operation_date;
        /// <summary>
        /// 出院日期
        /// </summary>		
        private DateTime out_date;
        /// <summary>
        /// 出院科室代码
        /// </summary>		
        private string dept_code;
        /// <summary>
        /// 出院科室名称
        /// </summary>		
        private string dept_name;
        /// <summary>
        /// 转归代码
        /// </summary>		
        private string zg;
        /// <summary>
        /// 确诊天数
        /// </summary>		
        private decimal diag_days;
        /// <summary>
        /// 住院天数
        /// </summary>		
        private decimal pi_days;
        /// <summary>
        /// 死亡日期
        /// </summary>		
        private DateTime dead_date;
        /// <summary>
        /// 死亡原因
        /// </summary>		
        private string dead_reason;
        /// <summary>
        /// 尸检
        /// </summary>		
        private string body_check;
        /// <summary>
        /// 死亡种类
        /// </summary>		
        private string dead_kind;
        /// <summary>
        /// 尸体解剖号
        /// </summary>		
        private string body_anotomize;
        /// <summary>
        /// 乙肝表面抗原（阴性、阳性、未做）
        /// </summary>		
        private string hbsag;
        /// <summary>
        /// 丙肝病毒抗体（阴性、阳性、未做）
        /// </summary>		
        private string hcv_ab;
        /// <summary>
        /// 获得性人类免疫缺陷病毒抗体（阴性、阳性、未做）
        /// </summary>		
        private string hiv_ab;
        /// <summary>
        /// 门急_入院符合
        /// </summary>		
        private string ce_pi;
        /// <summary>
        /// 入出_院符合
        /// </summary>		
        private string pi_po;
        /// <summary>
        /// 术前_后符合
        /// </summary>		
        private string opb_opa;
        /// <summary>
        /// 临床_X光符合
        /// </summary>		
        private string cl_x;
        /// <summary>
        /// 临床_CT符合
        /// </summary>		
        private string cl_ct;
        /// <summary>
        /// 临床_MRI符合
        /// </summary>		
        private string cl_mri;
        /// <summary>
        /// 临床_病理符合
        /// </summary>		
        private string cl_pa;
        /// <summary>
        /// 放射_病理符合
        /// </summary>		
        private string fs_bl;
        /// <summary>
        /// 抢救次数
        /// </summary>		
        private decimal salv_times;
        /// <summary>
        /// 成功次数
        /// </summary>		
        private decimal succ_times;
        /// <summary>
        /// 示教科研
        /// </summary>		
        private string tech_serc;
        /// <summary>
        /// 是否随诊
        /// </summary>		
        private string visi_stat;
        /// <summary>
        /// 随访期限
        /// </summary>		
        private DateTime visi_peri;
        /// <summary>
        /// 院际会诊次数
        /// </summary>		
        private decimal incon_num;
        /// <summary>
        /// 远程会诊次数
        /// </summary>		
        private decimal outcon_num;
        /// <summary>
        /// 药物过敏
        /// </summary>		
        private string anaphy_flag;
        /// <summary>
        /// 过敏药物名称
        /// </summary>		
        private string anaphy_name1;
        /// <summary>
        /// 过敏药物名称
        /// </summary>		
        private string anaphy_name2;
        /// <summary>
        /// 更改后出院日期
        /// </summary>		
        private DateTime cout_date;
        /// <summary>
        /// 住院医师代码
        /// </summary>		
        private string house_doc_code;
        /// <summary>
        /// 住院医师姓名
        /// </summary>		
        private string house_doc_name;
        /// <summary>
        /// 主治医师代码
        /// </summary>		
        private string charge_doc_code;
        /// <summary>
        /// 主治医师姓名
        /// </summary>		
        private string charge_doc_name;
        /// <summary>
        /// 主任医师代码
        /// </summary>		
        private string chief_doc_code;
        /// <summary>
        /// 主任医师姓名
        /// </summary>		
        private string chief_doc_name;
        /// <summary>
        /// 科主任代码
        /// </summary>		
        private string dept_chief_docd;
        /// <summary>
        /// 科主任名称
        /// </summary>		
        private string dept_chief_donm;
        /// <summary>
        /// 进修医师代码
        /// </summary>		
        private string refresher_docd;
        /// <summary>
        /// 进修医生名称
        /// </summary>		
        private string refresher_donm;
        /// <summary>
        /// 研究生实习医师代码
        /// </summary>		
        private string gra_doc_code;
        /// <summary>
        /// 研究生实习医师名称
        /// </summary>		
        private string gra_doc_name;
        /// <summary>
        /// 实习医师代码
        /// </summary>		
        private string pra_doc_code;
        /// <summary>
        /// 实习医师名称
        /// </summary>		
        private string pra_doc_name;
        /// <summary>
        /// 编码员代码
        /// </summary>		
        private string coding_code;
        /// <summary>
        /// 编码员名称
        /// </summary>		
        private string coding_name;
        /// <summary>
        /// 病案质量
        /// </summary>		
        private string mr_qual;
        /// <summary>
        /// 合格病案
        /// </summary>		
        private string mr_elig;
        /// <summary>
        /// 质控医师代码
        /// </summary>		
        private string qc_docd;
        /// <summary>
        /// 质控医师名称
        /// </summary>		
        private string qc_donm;
        /// <summary>
        /// 质控护士代码
        /// </summary>		
        private string qc_nucd;
        /// <summary>
        /// 质控护士名称
        /// </summary>		
        private string qc_nunm;
        /// <summary>
        /// 检查时间
        /// </summary>		
        private DateTime check_date;
        /// <summary>
        /// 手术、操作、治疗、检查、诊断为本院第一例项目
        /// </summary>		
        private string yn_first;
        /// <summary>
        /// Rh血型(阴、阳)
        /// </summary>		
        private string rh_blood;
        /// <summary>
        /// 输血反应（有、无）
        /// </summary>		
        private string reaction_blood;
        /// <summary>
        /// 红细胞数
        /// </summary>		
        private string blood_red;
        /// <summary>
        /// 血小板数
        /// </summary>		
        private string blood_platelet;
        /// <summary>
        /// 血浆数
        /// </summary>		
        private string blood_plasma;
        /// <summary>
        /// 全血数
        /// </summary>		
        private string blood_whole;
        /// <summary>
        /// 其他输血数
        /// </summary>		
        private string blood_other;
        /// <summary>
        /// X光号
        /// </summary>		
        private string x_numb;
        /// <summary>
        /// CT号
        /// </summary>		
        private string ct_numb;
        /// <summary>
        /// MRI号
        /// </summary>		
        private string mri_numb;
        /// <summary>
        /// 病理号
        /// </summary>		
        private string path_numb;
        /// <summary>
        /// B超
        /// </summary>		
        private string dsa_numb;
        /// <summary>
        /// PET号
        /// </summary>		
        private string pet_numb;
        /// <summary>
        /// ECT号
        /// </summary>		
        private string ect_numb;
        /// <summary>
        /// X线次数
        /// </summary>		
        private decimal x_times;
        /// <summary>
        /// CT次数
        /// </summary>		
        private decimal ct_times;
        /// <summary>
        /// MR次数
        /// </summary>		
        private decimal mr_times;
        /// <summary>
        /// DSA次数
        /// </summary>		
        private decimal dsa_times;
        /// <summary>
        /// PET次数
        /// </summary>		
        private decimal pet_times;
        /// <summary>
        /// ECT次数
        /// </summary>		
        private decimal ect_times;
        /// <summary>
        /// 说明
        /// </summary>		
        private string remark;
        /// <summary>
        /// 归档条码号
        /// </summary>		
        private string bar_code;
        /// <summary>
        /// 病案借阅状态(O借出 I在架)
        /// </summary>		
        private string lend_stus;
        /// <summary>
        /// 病案状态1科室质检/2医生站登记保存/3病案室整理/4病案室质检/5无效
        /// </summary>		
        private string case_stus;
        /// <summary>
        /// 操作员
        /// </summary>		
        private string oper_code;
        /// <summary>
        /// 操作时间
        /// </summary>		
        private DateTime oper_date;
        /// <summary>
        /// 随访期限  周
        /// </summary>		
        private string visi_periweek;
        /// <summary>
        /// 随访期限  月
        /// </summary>		
        private string visi_perimonth;
        /// <summary>
        /// 随访期限  年
        /// </summary>		
        private string visi_periyear;
        /// <summary>
        /// 特殊护理(日)
        /// </summary>		
        private decimal specal_nus;
        /// <summary>
        /// I级护理时间(日)
        /// </summary>		
        private decimal i_nus;
        /// <summary>
        /// II级护理时间(日)
        /// </summary>		
        private decimal ii_nus;
        /// <summary>
        /// III级护理时间(日)
        /// </summary>		
        private decimal iii_nus;
        /// <summary>
        /// 重症监护时间( 小时)
        /// </summary>		
        private decimal strictness_nus;
        /// <summary>
        /// 特级护理时间(小时)
        /// </summary>		
        private decimal super_nus;
        /// <summary>
        /// 整理员
        /// </summary>		
        private string packup_code;
        /// <summary>
        /// 单病种
        /// </summary>		
        private string disease30_flag;
        /// <summary>
        /// 是否手工录入病案  1 是,0 否
        /// </summary>		
        private string is_handcraft;
        /// <summary>
        /// 是否有并发症 1 有 0 无
        /// </summary>		
        private string diag_syndrome;
        /// <summary>
        /// 院内感染次数
        /// </summary>		
        private decimal infection_num;
        /// <summary>
        /// 手术编码员
        /// </summary>		
        private string operation_coding;
        /// <summary>
        /// 门诊诊断 编码
        /// </summary>		
        private string clinic_diagicd;
        /// <summary>
        /// 门诊诊断 名称
        /// </summary>		
        private string clinic_diagicdname;
        /// <summary>
        /// 入院诊断 编码
        /// </summary>		
        private string inhos_diagicd;
        /// <summary>
        /// 入院诊断 名称
        /// </summary>		
        private string inhos_diagicdname;
        /// <summary>
        /// 出院主诊断 编码
        /// </summary>		
        private string main_diagicd;
        /// <summary>
        /// 出院主诊断 名称
        /// </summary>		
        private string main_diagicdname;
        /// <summary>
        /// 出院主诊断 治疗情况
        /// </summary>		
        private string main_diagstate;
        /// <summary>
        /// 出院主诊断病理符合情况
        /// </summary>		
        private string main_diagclpa;
        /// <summary>
        /// 第一主手术代码
        /// </summary>		
        private string operation_code;
        /// <summary>
        /// 第一主手术名称
        /// </summary>		
        private string operation_cnname;
        /// <summary>
        /// 第一主手术医师代码
        /// </summary>		
        private string fir_docd;
        /// <summary>
        /// 第一主手术医师名称
        /// </summary>		
        private string fir_donm;
        /// <summary>
        /// 病案号
        /// </summary>		
        private string case_no;
        /// <summary>
        /// 院内感染部位编码
        /// </summary>		
        private string infection_code;
        /// <summary>
        /// 院内感染部位名称
        /// </summary>		
        private string infection_name;
        /// <summary>
        /// 出院方式（1、常规 2、自动 3、转院）
        /// </summary>		
        private string out_type;
        /// <summary>
        /// 治疗类别（1、中      2、西      3、中西）
        /// </summary>		
        private string cure_type;
        /// <summary>
        /// 自制中药制剂（0、未知   1、有    2、无）
        /// </summary>		
        private string use_cha_med;
        /// <summary>
        /// 抢救方法（1、中     2、西       3、中西）
        /// </summary>		
        private string salv_type;
        /// <summary>
        /// 是否出现危重（１、是　　　０、否）
        /// </summary>		
        private string ever_sickintodeath;
        /// <summary>
        /// 是否出现急症（１、是　　　０、否）
        /// </summary>		
        private string ever_firstaid;
        /// <summary>
        /// 是否出现疑难情况（１、是　０、否）
        /// </summary>		
        private string ever_difficulty;
        /// <summary>
        /// 输液反应（１、有　２、无　３、未输）
        /// </summary>		
        private string reaction_liquid;
        /// <summary>
        /// 科主任
        /// </summary>		
        private string deptdirector;
        /// <summary>
        /// 形态学编码
        /// </summary>		
        private string morphologyid;
        /// <summary>
        /// 抗生素使用次数
        /// </summary>		
        private string usenumber;
        /// <summary>
        /// 抗生素使用天数
        /// </summary>		
        private string usedays;
        /// <summary>
        /// 病历卡号
        /// </summary>		
        private string medicalrecord;
        /// <summary>
        /// 肿瘤病历卡
        /// </summary>		
        private string tumorrecord;
        /// <summary>
        /// 病案合同代码CAS_PACTUNIT
        /// </summary>		
        private string case_pact_code;
        /// <summary>
        /// 回收日期
        /// </summary>		
        private DateTime recall_date;
        /// <summary>
        /// 入院病区代码(河南省医增加)
        /// </summary>		
        private string nursecell_code;
        /// <summary>
        /// 入院病区名称(河南省医增加)
        /// </summary>		
        private string nursecell_name;
        /// <summary>
        /// 出院病区代码(河南省医增加)
        /// </summary>		
        private string outnursecell_code;
        /// <summary>
        /// 出院病区名称(河南省医增加)
        /// </summary>		
        private string outnursecell_name;
        /// <summary>
        /// 病历分型（河南省医新增)
        /// </summary>		
        private string medical_type;
        /// <summary>
        /// 切口类型(河南省医新增)
        /// </summary>		
        private string mainoperationcut;
        /// <summary>
        /// 愈合等级(河南省医新增)
        /// </summary>		
        private string mainoperationscare;
        /// <summary>
        /// 损伤中毒原因
        /// </summary>		
        private string injury_cause;
        /// <summary>
        /// 传染病报告（1 已报 2 未报）
        /// </summary>		
        private string infection_report;
        /// <summary>
        /// 四病报告（1 已报 2 未报）
        /// </summary>		
        private string fourdiseases_report;
        /// <summary>
        /// CASE_INFOTXT
        /// </summary>		
        private string case_infotxt;
        /// <summary>
        /// 医疗机构代码
        /// </summary>		
        private string hos_code;
        /// <summary>
        /// 健康卡号
        /// </summary>		
        private string health_card;
        /// <summary>
        /// 新生儿出生体重
        /// </summary>		
        private string baby_weight;
        /// <summary>
        /// 新生儿入院体重
        /// </summary>		
        private string baby_in_weight;
        /// <summary>
        /// 现住址
        /// </summary>		
        private string current_address;
        /// <summary>
        /// 入院途径
        /// </summary>		
        private string in_way;
        /// <summary>
        /// 损伤中毒ICD码
        /// </summary>		
        private string injury_icd;
        /// <summary>
        /// 病理诊断ICD码
        /// </summary>		
        private string pathology_icd;
        /// <summary>
        /// 责任护士
        /// </summary>		
        private string res_nurs;
        /// <summary>
        /// 离院方式（1.医嘱离院 2.医嘱转院 3.医嘱转社区卫生服务机构/乡镇卫生院 4.非医嘱离院 5.死亡 9.其他）
        /// </summary>		
        private string leave_type;
        /// <summary>
        /// 拟接收医疗机构(当"离院方式"选择 2、3时)
        /// </summary>		
        private string receive_hos;
        /// <summary>
        /// 是否有出院31天内再住院计划（１、是　　　０、否）
        /// </summary>		
        private string proj_after_31days;
        /// <summary>
        /// 31天内再住院计划的目的（当31天内再住院计划选择"是"时）
        /// </summary>		
        private string proj_after_31days_purpose;
        /// <summary>
        /// 颅脑损伤患者昏迷时间(入院前)
        /// </summary>		
        private string brain_injury_pre;
        /// <summary>
        /// 颅脑损伤患者昏迷时间(入院后)
        /// </summary>		
        private string brain_injury_aft;
        /// <summary>
        /// 河南扩展字段内容
        /// </summary>		
        private string henanadd2012;
        /// <summary>
        /// 首次提交人
        /// </summary>		
        private string firstsubmitoper;
        /// <summary>
        /// 首次提交日期
        /// </summary>		
        private DateTime firstsubmitdate;
        #endregion

        #region 属性
        /// <summary>
        /// INPATIENT_NO
        /// </summary>		
        public string Inpatient_no
        {
            get { return inpatient_no; }
            set { inpatient_no = value; }
        }
        /// <summary>
        /// 住院病历号
        /// </summary>		
        public string Patient_no
        {
            get { return patient_no; }
            set { patient_no = value; }
        }
        /// <summary>
        /// 门诊号
        /// </summary>		
        public string Card_no
        {
            get { return card_no; }
            set { card_no = value; }
        }
        /// <summary>
        /// 姓名
        /// </summary>		
        public string PName
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// 曾用名
        /// </summary>		
        public string Nomen
        {
            get { return nomen; }
            set { nomen = value; }
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
        /// 国家
        /// </summary>		
        public string Coun_code
        {
            get { return coun_code; }
            set { coun_code = value; }
        }
        /// <summary>
        /// 民族
        /// </summary>		
        public string Nation_code
        {
            get { return nation_code; }
            set { nation_code = value; }
        }
        /// <summary>
        /// 职业
        /// </summary>		
        public string Prof_code
        {
            get { return prof_code; }
            set { prof_code = value; }
        }
        /// <summary>
        /// 血型编码
        /// </summary>		
        public string Blood_code
        {
            get { return blood_code; }
            set { blood_code = value; }
        }
        /// <summary>
        /// 婚否
        /// </summary>		
        public string Mari
        {
            get { return mari; }
            set { mari = value; }
        }
        /// <summary>
        /// 年龄
        /// </summary>		
        public decimal Age
        {
            get { return age; }
            set { age = value; }
        }
        /// <summary>
        /// 年龄单位
        /// </summary>		
        public string Age_unit
        {
            get { return age_unit; }
            set { age_unit = value; }
        }
        /// <summary>
        /// 身份证号
        /// </summary>		
        public string Idenno
        {
            get { return idenno; }
            set { idenno = value; }
        }
        /// <summary>
        /// 地区来源
        /// </summary>		
        public string In_source
        {
            get { return in_source; }
            set { in_source = value; }
        }
        /// <summary>
        /// 结算类别号
        /// </summary>		
        public string Paykind_code
        {
            get { return paykind_code; }
            set { paykind_code = value; }
        }
        /// <summary>
        /// 合同代码
        /// </summary>		
        public string Pact_code
        {
            get { return pact_code; }
            set { pact_code = value; }
        }
        /// <summary>
        /// 医保公费号
        /// </summary>		
        public string Mcard_no
        {
            get { return mcard_no; }
            set { mcard_no = value; }
        }
        /// <summary>
        /// 籍贯
        /// </summary>		
        public string District
        {
            get { return district; }
            set { district = value; }
        }
        /// <summary>
        /// 出生地
        /// </summary>		
        public string Homeplace
        {
            get { return homeplace; }
            set { homeplace = value; }
        }
        /// <summary>
        /// 家庭住址
        /// </summary>		
        public string Home_add
        {
            get { return home_add; }
            set { home_add = value; }
        }
        /// <summary>
        /// 家庭电话
        /// </summary>		
        public string Home_tel
        {
            get { return home_tel; }
            set { home_tel = value; }
        }
        /// <summary>
        /// 住址邮编
        /// </summary>		
        public string Home_zip
        {
            get { return home_zip; }
            set { home_zip = value; }
        }
        /// <summary>
        /// 单位地址
        /// </summary>		
        public string Work_name
        {
            get { return work_name; }
            set { work_name = value; }
        }
        /// <summary>
        /// 单位电话
        /// </summary>		
        public string Work_tel
        {
            get { return work_tel; }
            set { work_tel = value; }
        }
        /// <summary>
        /// 单位邮编
        /// </summary>		
        public string Work_zip
        {
            get { return work_zip; }
            set { work_zip = value; }
        }
        /// <summary>
        /// 联系人
        /// </summary>		
        public string Linkma_name
        {
            get { return linkma_name; }
            set { linkma_name = value; }
        }
        /// <summary>
        /// 与患者关系
        /// </summary>		
        public string Rela_code
        {
            get { return rela_code; }
            set { rela_code = value; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>		
        public string Linkman_tel
        {
            get { return linkman_tel; }
            set { linkman_tel = value; }
        }
        /// <summary>
        /// 联系地址
        /// </summary>		
        public string Linkman_add
        {
            get { return linkman_add; }
            set { linkman_add = value; }
        }
        /// <summary>
        /// 门诊诊断医生
        /// </summary>		
        public string Clinic_docd
        {
            get { return clinic_docd; }
            set { clinic_docd = value; }
        }
        /// <summary>
        /// 门诊诊断医生姓名
        /// </summary>		
        public string Clinic_donm
        {
            get { return clinic_donm; }
            set { clinic_donm = value; }
        }
        /// <summary>
        /// 转来医院
        /// </summary>		
        public string Come_from
        {
            get { return come_from; }
            set { come_from = value; }
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
        /// 住院次数
        /// </summary>		
        public decimal In_times
        {
            get { return in_times; }
            set { in_times = value; }
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
        /// 入院来源
        /// </summary>		
        public string In_avenue
        {
            get { return in_avenue; }
            set { in_avenue = value; }
        }
        /// <summary>
        /// 入院状态
        /// </summary>		
        public string In_circs
        {
            get { return in_circs; }
            set { in_circs = value; }
        }
        /// <summary>
        /// 确诊日期
        /// </summary>		
        public DateTime Diag_date
        {
            get { return diag_date; }
            set { diag_date = value; }
        }
        /// <summary>
        /// 第一主手术日期
        /// </summary>		
        public DateTime Operation_date
        {
            get { return operation_date; }
            set { operation_date = value; }
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
        /// 出院科室代码
        /// </summary>		
        public string Dept_code
        {
            get { return dept_code; }
            set { dept_code = value; }
        }
        /// <summary>
        /// 出院科室名称
        /// </summary>		
        public string Dept_name
        {
            get { return dept_name; }
            set { dept_name = value; }
        }
        /// <summary>
        /// 转归代码
        /// </summary>		
        public string Zg
        {
            get { return zg; }
            set { zg = value; }
        }
        /// <summary>
        /// 确诊天数
        /// </summary>		
        public decimal Diag_days
        {
            get { return diag_days; }
            set { diag_days = value; }
        }
        /// <summary>
        /// 住院天数
        /// </summary>		
        public decimal Pi_days
        {
            get { return pi_days; }
            set { pi_days = value; }
        }
        /// <summary>
        /// 死亡日期
        /// </summary>		
        public DateTime Dead_date
        {
            get { return dead_date; }
            set { dead_date = value; }
        }
        /// <summary>
        /// 死亡原因
        /// </summary>		
        public string Dead_reason
        {
            get { return dead_reason; }
            set { dead_reason = value; }
        }
        /// <summary>
        /// 尸检
        /// </summary>		
        public string Body_check
        {
            get { return body_check; }
            set { body_check = value; }
        }
        /// <summary>
        /// 死亡种类
        /// </summary>		
        public string Dead_kind
        {
            get { return dead_kind; }
            set { dead_kind = value; }
        }
        /// <summary>
        /// 尸体解剖号
        /// </summary>		
        public string Body_anotomize
        {
            get { return body_anotomize; }
            set { body_anotomize = value; }
        }
        /// <summary>
        /// 乙肝表面抗原（阴性、阳性、未做）
        /// </summary>		
        public string Hbsag
        {
            get { return hbsag; }
            set { hbsag = value; }
        }
        /// <summary>
        /// 丙肝病毒抗体（阴性、阳性、未做）
        /// </summary>		
        public string Hcv_ab
        {
            get { return hcv_ab; }
            set { hcv_ab = value; }
        }
        /// <summary>
        /// 获得性人类免疫缺陷病毒抗体（阴性、阳性、未做）
        /// </summary>		
        public string Hiv_ab
        {
            get { return hiv_ab; }
            set { hiv_ab = value; }
        }
        /// <summary>
        /// 门急_入院符合
        /// </summary>		
        public string Ce_pi
        {
            get { return ce_pi; }
            set { ce_pi = value; }
        }
        /// <summary>
        /// 入出_院符合
        /// </summary>		
        public string Pi_po
        {
            get { return pi_po; }
            set { pi_po = value; }
        }
        /// <summary>
        /// 术前_后符合
        /// </summary>		
        public string Opb_opa
        {
            get { return opb_opa; }
            set { opb_opa = value; }
        }
        /// <summary>
        /// 临床_X光符合
        /// </summary>		
        public string Cl_x
        {
            get { return cl_x; }
            set { cl_x = value; }
        }
        /// <summary>
        /// 临床_CT符合
        /// </summary>		
        public string Cl_ct
        {
            get { return cl_ct; }
            set { cl_ct = value; }
        }
        /// <summary>
        /// 临床_MRI符合
        /// </summary>		
        public string Cl_mri
        {
            get { return cl_mri; }
            set { cl_mri = value; }
        }
        /// <summary>
        /// 临床_病理符合
        /// </summary>		
        public string Cl_pa
        {
            get { return cl_pa; }
            set { cl_pa = value; }
        }
        /// <summary>
        /// 放射_病理符合
        /// </summary>		
        public string Fs_bl
        {
            get { return fs_bl; }
            set { fs_bl = value; }
        }
        /// <summary>
        /// 抢救次数
        /// </summary>		
        public decimal Salv_times
        {
            get { return salv_times; }
            set { salv_times = value; }
        }
        /// <summary>
        /// 成功次数
        /// </summary>		
        public decimal Succ_times
        {
            get { return succ_times; }
            set { succ_times = value; }
        }
        /// <summary>
        /// 示教科研
        /// </summary>		
        public string Tech_serc
        {
            get { return tech_serc; }
            set { tech_serc = value; }
        }
        /// <summary>
        /// 是否随诊
        /// </summary>		
        public string Visi_stat
        {
            get { return visi_stat; }
            set { visi_stat = value; }
        }
        /// <summary>
        /// 随访期限
        /// </summary>		
        public DateTime Visi_peri
        {
            get { return visi_peri; }
            set { visi_peri = value; }
        }
        /// <summary>
        /// 院际会诊次数
        /// </summary>		
        public decimal Incon_num
        {
            get { return incon_num; }
            set { incon_num = value; }
        }
        /// <summary>
        /// 远程会诊次数
        /// </summary>		
        public decimal Outcon_num
        {
            get { return outcon_num; }
            set { outcon_num = value; }
        }
        /// <summary>
        /// 药物过敏
        /// </summary>		
        public string Anaphy_flag
        {
            get { return anaphy_flag; }
            set { anaphy_flag = value; }
        }
        /// <summary>
        /// 过敏药物名称
        /// </summary>		
        public string Anaphy_name1
        {
            get { return anaphy_name1; }
            set { anaphy_name1 = value; }
        }
        /// <summary>
        /// 过敏药物名称
        /// </summary>		
        public string Anaphy_name2
        {
            get { return anaphy_name2; }
            set { anaphy_name2 = value; }
        }
        /// <summary>
        /// 更改后出院日期
        /// </summary>		
        public DateTime Cout_date
        {
            get { return cout_date; }
            set { cout_date = value; }
        }
        /// <summary>
        /// 住院医师代码
        /// </summary>		
        public string House_doc_code
        {
            get { return house_doc_code; }
            set { house_doc_code = value; }
        }
        /// <summary>
        /// 住院医师姓名
        /// </summary>		
        public string House_doc_name
        {
            get { return house_doc_name; }
            set { house_doc_name = value; }
        }
        /// <summary>
        /// 主治医师代码
        /// </summary>		
        public string Charge_doc_code
        {
            get { return charge_doc_code; }
            set { charge_doc_code = value; }
        }
        /// <summary>
        /// 主治医师姓名
        /// </summary>		
        public string Charge_doc_name
        {
            get { return charge_doc_name; }
            set { charge_doc_name = value; }
        }
        /// <summary>
        /// 主任医师代码
        /// </summary>		
        public string Chief_doc_code
        {
            get { return chief_doc_code; }
            set { chief_doc_code = value; }
        }
        /// <summary>
        /// 主任医师姓名
        /// </summary>		
        public string Chief_doc_name
        {
            get { return chief_doc_name; }
            set { chief_doc_name = value; }
        }
        /// <summary>
        /// 科主任代码
        /// </summary>		
        public string Dept_chief_docd
        {
            get { return dept_chief_docd; }
            set { dept_chief_docd = value; }
        }
        /// <summary>
        /// 科主任名称
        /// </summary>		
        public string Dept_chief_donm
        {
            get { return dept_chief_donm; }
            set { dept_chief_donm = value; }
        }
        /// <summary>
        /// 进修医师代码
        /// </summary>		
        public string Refresher_docd
        {
            get { return refresher_docd; }
            set { refresher_docd = value; }
        }
        /// <summary>
        /// 进修医生名称
        /// </summary>		
        public string Refresher_donm
        {
            get { return refresher_donm; }
            set { refresher_donm = value; }
        }
        /// <summary>
        /// 研究生实习医师代码
        /// </summary>		
        public string Gra_doc_code
        {
            get { return gra_doc_code; }
            set { gra_doc_code = value; }
        }
        /// <summary>
        /// 研究生实习医师名称
        /// </summary>		
        public string Gra_doc_name
        {
            get { return gra_doc_name; }
            set { gra_doc_name = value; }
        }
        /// <summary>
        /// 实习医师代码
        /// </summary>		
        public string Pra_doc_code
        {
            get { return pra_doc_code; }
            set { pra_doc_code = value; }
        }
        /// <summary>
        /// 实习医师名称
        /// </summary>		
        public string Pra_doc_name
        {
            get { return pra_doc_name; }
            set { pra_doc_name = value; }
        }
        /// <summary>
        /// 编码员代码
        /// </summary>		
        public string Coding_code
        {
            get { return coding_code; }
            set { coding_code = value; }
        }
        /// <summary>
        /// 编码员名称
        /// </summary>		
        public string Coding_name
        {
            get { return coding_name; }
            set { coding_name = value; }
        }
        /// <summary>
        /// 病案质量
        /// </summary>		
        public string Mr_qual
        {
            get { return mr_qual; }
            set { mr_qual = value; }
        }
        /// <summary>
        /// 合格病案
        /// </summary>		
        public string Mr_elig
        {
            get { return mr_elig; }
            set { mr_elig = value; }
        }
        /// <summary>
        /// 质控医师代码
        /// </summary>		
        public string Qc_docd
        {
            get { return qc_docd; }
            set { qc_docd = value; }
        }
        /// <summary>
        /// 质控医师名称
        /// </summary>		
        public string Qc_donm
        {
            get { return qc_donm; }
            set { qc_donm = value; }
        }
        /// <summary>
        /// 质控护士代码
        /// </summary>		
        public string Qc_nucd
        {
            get { return qc_nucd; }
            set { qc_nucd = value; }
        }
        /// <summary>
        /// 质控护士名称
        /// </summary>		
        public string Qc_nunm
        {
            get { return qc_nunm; }
            set { qc_nunm = value; }
        }
        /// <summary>
        /// 检查时间
        /// </summary>		
        public DateTime Check_date
        {
            get { return check_date; }
            set { check_date = value; }
        }
        /// <summary>
        /// 手术、操作、治疗、检查、诊断为本院第一例项目
        /// </summary>		
        public string Yn_first
        {
            get { return yn_first; }
            set { yn_first = value; }
        }
        /// <summary>
        /// Rh血型(阴、阳)
        /// </summary>		
        public string Rh_blood
        {
            get { return rh_blood; }
            set { rh_blood = value; }
        }
        /// <summary>
        /// 输血反应（有、无）
        /// </summary>		
        public string Reaction_blood
        {
            get { return reaction_blood; }
            set { reaction_blood = value; }
        }
        /// <summary>
        /// 红细胞数
        /// </summary>		
        public string Blood_red
        {
            get { return blood_red; }
            set { blood_red = value; }
        }
        /// <summary>
        /// 血小板数
        /// </summary>		
        public string Blood_platelet
        {
            get { return blood_platelet; }
            set { blood_platelet = value; }
        }
        /// <summary>
        /// 血浆数
        /// </summary>		
        public string Blood_plasma
        {
            get { return blood_plasma; }
            set { blood_plasma = value; }
        }
        /// <summary>
        /// 全血数
        /// </summary>		
        public string Blood_whole
        {
            get { return blood_whole; }
            set { blood_whole = value; }
        }
        /// <summary>
        /// 其他输血数
        /// </summary>		
        public string Blood_other
        {
            get { return blood_other; }
            set { blood_other = value; }
        }
        /// <summary>
        /// X光号
        /// </summary>		
        public string X_numb
        {
            get { return x_numb; }
            set { x_numb = value; }
        }
        /// <summary>
        /// CT号
        /// </summary>		
        public string Ct_numb
        {
            get { return ct_numb; }
            set { ct_numb = value; }
        }
        /// <summary>
        /// MRI号
        /// </summary>		
        public string Mri_numb
        {
            get { return mri_numb; }
            set { mri_numb = value; }
        }
        /// <summary>
        /// 病理号
        /// </summary>		
        public string Path_numb
        {
            get { return path_numb; }
            set { path_numb = value; }
        }
        /// <summary>
        /// B超
        /// </summary>		
        public string Dsa_numb
        {
            get { return dsa_numb; }
            set { dsa_numb = value; }
        }
        /// <summary>
        /// PET号
        /// </summary>		
        public string Pet_numb
        {
            get { return pet_numb; }
            set { pet_numb = value; }
        }
        /// <summary>
        /// ECT号
        /// </summary>		
        public string Ect_numb
        {
            get { return ect_numb; }
            set { ect_numb = value; }
        }
        /// <summary>
        /// X线次数
        /// </summary>		
        public decimal X_times
        {
            get { return x_times; }
            set { x_times = value; }
        }
        /// <summary>
        /// CT次数
        /// </summary>		
        public decimal Ct_times
        {
            get { return ct_times; }
            set { ct_times = value; }
        }
        /// <summary>
        /// MR次数
        /// </summary>		
        public decimal Mr_times
        {
            get { return mr_times; }
            set { mr_times = value; }
        }
        /// <summary>
        /// DSA次数
        /// </summary>		
        public decimal Dsa_times
        {
            get { return dsa_times; }
            set { dsa_times = value; }
        }
        /// <summary>
        /// PET次数
        /// </summary>		
        public decimal Pet_times
        {
            get { return pet_times; }
            set { pet_times = value; }
        }
        /// <summary>
        /// ECT次数
        /// </summary>		
        public decimal Ect_times
        {
            get { return ect_times; }
            set { ect_times = value; }
        }
        /// <summary>
        /// 说明
        /// </summary>		
        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }
        /// <summary>
        /// 归档条码号
        /// </summary>		
        public string Bar_code
        {
            get { return bar_code; }
            set { bar_code = value; }
        }
        /// <summary>
        /// 病案借阅状态(O借出 I在架)
        /// </summary>		
        public string Lend_stus
        {
            get { return lend_stus; }
            set { lend_stus = value; }
        }
        /// <summary>
        /// 病案状态1科室质检/2医生站登记保存/3病案室整理/4病案室质检/5无效
        /// </summary>		
        public string Case_stus
        {
            get { return case_stus; }
            set { case_stus = value; }
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
        /// 随访期限  周
        /// </summary>		
        public string Visi_periweek
        {
            get { return visi_periweek; }
            set { visi_periweek = value; }
        }
        /// <summary>
        /// 随访期限  月
        /// </summary>		
        public string Visi_perimonth
        {
            get { return visi_perimonth; }
            set { visi_perimonth = value; }
        }
        /// <summary>
        /// 随访期限  年
        /// </summary>		
        public string Visi_periyear
        {
            get { return visi_periyear; }
            set { visi_periyear = value; }
        }
        /// <summary>
        /// 特殊护理(日)
        /// </summary>		
        public decimal Specal_nus
        {
            get { return specal_nus; }
            set { specal_nus = value; }
        }
        /// <summary>
        /// I级护理时间(日)
        /// </summary>		
        public decimal I_nus
        {
            get { return i_nus; }
            set { i_nus = value; }
        }
        /// <summary>
        /// II级护理时间(日)
        /// </summary>		
        public decimal Ii_nus
        {
            get { return ii_nus; }
            set { ii_nus = value; }
        }
        /// <summary>
        /// III级护理时间(日)
        /// </summary>		
        public decimal Iii_nus
        {
            get { return iii_nus; }
            set { iii_nus = value; }
        }
        /// <summary>
        /// 重症监护时间( 小时)
        /// </summary>		
        public decimal Strictness_nus
        {
            get { return strictness_nus; }
            set { strictness_nus = value; }
        }
        /// <summary>
        /// 特级护理时间(小时)
        /// </summary>		
        public decimal Super_nus
        {
            get { return super_nus; }
            set { super_nus = value; }
        }
        /// <summary>
        /// 整理员
        /// </summary>		
        public string Packup_code
        {
            get { return packup_code; }
            set { packup_code = value; }
        }
        /// <summary>
        /// 单病种
        /// </summary>		
        public string Disease30_flag
        {
            get { return disease30_flag; }
            set { disease30_flag = value; }
        }
        /// <summary>
        /// 是否手工录入病案  1 是,0 否
        /// </summary>		
        public string Is_handcraft
        {
            get { return is_handcraft; }
            set { is_handcraft = value; }
        }
        /// <summary>
        /// 是否有并发症 1 有 0 无
        /// </summary>		
        public string Diag_syndrome
        {
            get { return diag_syndrome; }
            set { diag_syndrome = value; }
        }
        /// <summary>
        /// 院内感染次数
        /// </summary>		
        public decimal Infection_num
        {
            get { return infection_num; }
            set { infection_num = value; }
        }
        /// <summary>
        /// 手术编码员
        /// </summary>		
        public string Operation_coding
        {
            get { return operation_coding; }
            set { operation_coding = value; }
        }
        /// <summary>
        /// 门诊诊断 编码
        /// </summary>		
        public string Clinic_diagicd
        {
            get { return clinic_diagicd; }
            set { clinic_diagicd = value; }
        }
        /// <summary>
        /// 门诊诊断 名称
        /// </summary>		
        public string Clinic_diagicdname
        {
            get { return clinic_diagicdname; }
            set { clinic_diagicdname = value; }
        }
        /// <summary>
        /// 入院诊断 编码
        /// </summary>		
        public string Inhos_diagicd
        {
            get { return inhos_diagicd; }
            set { inhos_diagicd = value; }
        }
        /// <summary>
        /// 入院诊断 名称
        /// </summary>		
        public string Inhos_diagicdname
        {
            get { return inhos_diagicdname; }
            set { inhos_diagicdname = value; }
        }
        /// <summary>
        /// 出院主诊断 编码
        /// </summary>		
        public string Main_diagicd
        {
            get { return main_diagicd; }
            set { main_diagicd = value; }
        }
        /// <summary>
        /// 出院主诊断 名称
        /// </summary>		
        public string Main_diagicdname
        {
            get { return main_diagicdname; }
            set { main_diagicdname = value; }
        }
        /// <summary>
        /// 出院主诊断 治疗情况
        /// </summary>		
        public string Main_diagstate
        {
            get { return main_diagstate; }
            set { main_diagstate = value; }
        }
        /// <summary>
        /// 出院主诊断病理符合情况
        /// </summary>		
        public string Main_diagclpa
        {
            get { return main_diagclpa; }
            set { main_diagclpa = value; }
        }
        /// <summary>
        /// 第一主手术代码
        /// </summary>		
        public string Operation_code
        {
            get { return operation_code; }
            set { operation_code = value; }
        }
        /// <summary>
        /// 第一主手术名称
        /// </summary>		
        public string Operation_cnname
        {
            get { return operation_cnname; }
            set { operation_cnname = value; }
        }
        /// <summary>
        /// 第一主手术医师代码
        /// </summary>		
        public string Fir_docd
        {
            get { return fir_docd; }
            set { fir_docd = value; }
        }
        /// <summary>
        /// 第一主手术医师名称
        /// </summary>		
        public string Fir_donm
        {
            get { return fir_donm; }
            set { fir_donm = value; }
        }
        /// <summary>
        /// 病案号
        /// </summary>		
        public string Case_no
        {
            get { return case_no; }
            set { case_no = value; }
        }
        /// <summary>
        /// 院内感染部位编码
        /// </summary>		
        public string Infection_code
        {
            get { return infection_code; }
            set { infection_code = value; }
        }
        /// <summary>
        /// 院内感染部位名称
        /// </summary>		
        public string Infection_name
        {
            get { return infection_name; }
            set { infection_name = value; }
        }
        /// <summary>
        /// 出院方式（1、常规 2、自动 3、转院）
        /// </summary>		
        public string Out_type
        {
            get { return out_type; }
            set { out_type = value; }
        }
        /// <summary>
        /// 治疗类别（1、中      2、西      3、中西）
        /// </summary>		
        public string Cure_type
        {
            get { return cure_type; }
            set { cure_type = value; }
        }
        /// <summary>
        /// 自制中药制剂（0、未知   1、有    2、无）
        /// </summary>		
        public string Use_cha_med
        {
            get { return use_cha_med; }
            set { use_cha_med = value; }
        }
        /// <summary>
        /// 抢救方法（1、中     2、西       3、中西）
        /// </summary>		
        public string Salv_type
        {
            get { return salv_type; }
            set { salv_type = value; }
        }
        /// <summary>
        /// 是否出现危重（１、是　　　０、否）
        /// </summary>		
        public string Ever_sickintodeath
        {
            get { return ever_sickintodeath; }
            set { ever_sickintodeath = value; }
        }
        /// <summary>
        /// 是否出现急症（１、是　　　０、否）
        /// </summary>		
        public string Ever_firstaid
        {
            get { return ever_firstaid; }
            set { ever_firstaid = value; }
        }
        /// <summary>
        /// 是否出现疑难情况（１、是　０、否）
        /// </summary>		
        public string Ever_difficulty
        {
            get { return ever_difficulty; }
            set { ever_difficulty = value; }
        }
        /// <summary>
        /// 输液反应（１、有　２、无　３、未输）
        /// </summary>		
        public string Reaction_liquid
        {
            get { return reaction_liquid; }
            set { reaction_liquid = value; }
        }
        /// <summary>
        /// 科主任
        /// </summary>		
        public string Deptdirector
        {
            get { return deptdirector; }
            set { deptdirector = value; }
        }
        /// <summary>
        /// 形态学编码
        /// </summary>		
        public string Morphologyid
        {
            get { return morphologyid; }
            set { morphologyid = value; }
        }
        /// <summary>
        /// 抗生素使用次数
        /// </summary>		
        public string Usenumber
        {
            get { return usenumber; }
            set { usenumber = value; }
        }
        /// <summary>
        /// 抗生素使用天数
        /// </summary>		
        public string Usedays
        {
            get { return usedays; }
            set { usedays = value; }
        }
        /// <summary>
        /// 病历卡号
        /// </summary>		
        public string Medicalrecord
        {
            get { return medicalrecord; }
            set { medicalrecord = value; }
        }
        /// <summary>
        /// 肿瘤病历卡
        /// </summary>		
        public string Tumorrecord
        {
            get { return tumorrecord; }
            set { tumorrecord = value; }
        }
        /// <summary>
        /// 病案合同代码CAS_PACTUNIT
        /// </summary>		
        public string Case_pact_code
        {
            get { return case_pact_code; }
            set { case_pact_code = value; }
        }
        /// <summary>
        /// 回收日期
        /// </summary>		
        public DateTime Recall_date
        {
            get { return recall_date; }
            set { recall_date = value; }
        }
        /// <summary>
        /// 入院病区代码(河南省医增加)
        /// </summary>		
        public string Nursecell_code
        {
            get { return nursecell_code; }
            set { nursecell_code = value; }
        }
        /// <summary>
        /// 入院病区名称(河南省医增加)
        /// </summary>		
        public string Nursecell_name
        {
            get { return nursecell_name; }
            set { nursecell_name = value; }
        }
        /// <summary>
        /// 出院病区代码(河南省医增加)
        /// </summary>		
        public string Outnursecell_code
        {
            get { return outnursecell_code; }
            set { outnursecell_code = value; }
        }
        /// <summary>
        /// 出院病区名称(河南省医增加)
        /// </summary>		
        public string Outnursecell_name
        {
            get { return outnursecell_name; }
            set { outnursecell_name = value; }
        }
        /// <summary>
        /// 病历分型（河南省医新增)
        /// </summary>		
        public string Medical_type
        {
            get { return medical_type; }
            set { medical_type = value; }
        }
        /// <summary>
        /// 切口类型(河南省医新增)
        /// </summary>		
        public string Mainoperationcut
        {
            get { return mainoperationcut; }
            set { mainoperationcut = value; }
        }
        /// <summary>
        /// 愈合等级(河南省医新增)
        /// </summary>		
        public string Mainoperationscare
        {
            get { return mainoperationscare; }
            set { mainoperationscare = value; }
        }
        /// <summary>
        /// 损伤中毒原因
        /// </summary>		
        public string Injury_cause
        {
            get { return injury_cause; }
            set { injury_cause = value; }
        }
        /// <summary>
        /// 传染病报告（1 已报 2 未报）
        /// </summary>		
        public string Infection_report
        {
            get { return infection_report; }
            set { infection_report = value; }
        }
        /// <summary>
        /// 四病报告（1 已报 2 未报）
        /// </summary>		
        public string Fourdiseases_report
        {
            get { return fourdiseases_report; }
            set { fourdiseases_report = value; }
        }
        /// <summary>
        /// CASE_INFOTXT
        /// </summary>		
        public string Case_infotxt
        {
            get { return case_infotxt; }
            set { case_infotxt = value; }
        }
        /// <summary>
        /// 医疗机构代码
        /// </summary>		
        public string Hos_code
        {
            get { return hos_code; }
            set { hos_code = value; }
        }
        /// <summary>
        /// 健康卡号
        /// </summary>		
        public string Health_card
        {
            get { return health_card; }
            set { health_card = value; }
        }
        /// <summary>
        /// 新生儿出生体重
        /// </summary>		
        public string Baby_weight
        {
            get { return baby_weight; }
            set { baby_weight = value; }
        }
        /// <summary>
        /// 新生儿入院体重
        /// </summary>		
        public string Baby_in_weight
        {
            get { return baby_in_weight; }
            set { baby_in_weight = value; }
        }
        /// <summary>
        /// 现住址
        /// </summary>		
        public string Current_address
        {
            get { return current_address; }
            set { current_address = value; }
        }
        /// <summary>
        /// 入院途径
        /// </summary>		
        public string In_way
        {
            get { return in_way; }
            set { in_way = value; }
        }
        /// <summary>
        /// 损伤中毒ICD码
        /// </summary>		
        public string Injury_icd
        {
            get { return injury_icd; }
            set { injury_icd = value; }
        }
        /// <summary>
        /// 病理诊断ICD码
        /// </summary>		
        public string Pathology_icd
        {
            get { return pathology_icd; }
            set { pathology_icd = value; }
        }
        /// <summary>
        /// 责任护士
        /// </summary>		
        public string Res_nurs
        {
            get { return res_nurs; }
            set { res_nurs = value; }
        }
        /// <summary>
        /// 离院方式（1.医嘱离院 2.医嘱转院 3.医嘱转社区卫生服务机构/乡镇卫生院 4.非医嘱离院 5.死亡 9.其他）
        /// </summary>		
        public string Leave_type
        {
            get { return leave_type; }
            set { leave_type = value; }
        }
        /// <summary>
        /// 拟接收医疗机构(当"离院方式"选择 2、3时)
        /// </summary>		
        public string Receive_hos
        {
            get { return receive_hos; }
            set { receive_hos = value; }
        }
        /// <summary>
        /// 是否有出院31天内再住院计划（１、是　　　０、否）
        /// </summary>		
        public string Proj_after_31days
        {
            get { return proj_after_31days; }
            set { proj_after_31days = value; }
        }
        /// <summary>
        /// 31天内再住院计划的目的（当31天内再住院计划选择"是"时）
        /// </summary>		
        public string Proj_after_31days_purpose
        {
            get { return proj_after_31days_purpose; }
            set { proj_after_31days_purpose = value; }
        }
        /// <summary>
        /// 颅脑损伤患者昏迷时间(入院前)
        /// </summary>		
        public string Brain_injury_pre
        {
            get { return brain_injury_pre; }
            set { brain_injury_pre = value; }
        }
        /// <summary>
        /// 颅脑损伤患者昏迷时间(入院后)
        /// </summary>		
        public string Brain_injury_aft
        {
            get { return brain_injury_aft; }
            set { brain_injury_aft = value; }
        }
        /// <summary>
        /// 河南扩展字段内容
        /// </summary>		
        public string Henanadd2012
        {
            get { return henanadd2012; }
            set { henanadd2012 = value; }
        }
        /// <summary>
        /// 首次提交人
        /// </summary>		
        public string Firstsubmitoper
        {
            get { return firstsubmitoper; }
            set { firstsubmitoper = value; }
        }
        /// <summary>
        /// 首次提交日期
        /// </summary>		
        public DateTime Firstsubmitdate
        {
            get { return firstsubmitdate; }
            set { firstsubmitdate = value; }
        }
        #endregion
    }
}
