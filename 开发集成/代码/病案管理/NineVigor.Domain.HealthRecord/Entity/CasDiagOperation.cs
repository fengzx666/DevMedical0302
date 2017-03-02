using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NineVigor.FrameWork.DataAccess;
using NineVigor.Domain.HealthRecord.Dto;

namespace NineVigor.Domain.HealthRecord.Entity
{
    public class CasDiagOperation : BaseEntity, ICasDiagOperation
    {
        #region  变量
        /// <summary>
        /// 住院流水号
        /// </summary>		
        private string inpatient_no;
        /// <summary>
        /// 1其他诊断疾病代码
        /// </summary>		
        private string jbdm1;
        /// <summary>
        /// 1其他诊断疾病描述
        /// </summary>		
        private string qtzd1;
        /// <summary>
        /// 1其他诊断入院病情
        /// </summary>		
        private string rybq1;
        /// <summary>
        /// 1其他诊断入院转归
        /// </summary>		
        private string zg1;
        /// <summary>
        /// 2其他诊断疾病代码
        /// </summary>		
        private string jbdm2;
        /// <summary>
        /// 2其他诊断疾病描述
        /// </summary>		
        private string qtzd2;
        /// <summary>
        /// 2其他诊断入院病情
        /// </summary>		
        private string rybq2;
        /// <summary>
        /// 2其他诊断入院转归
        /// </summary>		
        private string zg2;
        /// <summary>
        /// 3其他诊断疾病代码
        /// </summary>		
        private string jbdm3;
        /// <summary>
        /// 3其他诊断疾病描述
        /// </summary>		
        private string qtzd3;
        /// <summary>
        /// 3其他诊断入院病情
        /// </summary>		
        private string rybq3;
        /// <summary>
        /// 3其他诊断入院转归
        /// </summary>		
        private string zg3;
        /// <summary>
        /// 4其他诊断疾病代码
        /// </summary>		
        private string jbdm4;
        /// <summary>
        /// 4其他诊断疾病描述
        /// </summary>		
        private string qtzd4;
        /// <summary>
        /// 4其他诊断入院病情
        /// </summary>		
        private string rybq4;
        /// <summary>
        /// 4其他诊断入院转归
        /// </summary>		
        private string zg4;
        /// <summary>
        /// 5其他诊断疾病代码
        /// </summary>		
        private string jbdm5;
        /// <summary>
        /// 5其他诊断疾病描述
        /// </summary>		
        private string qtzd5;
        /// <summary>
        /// 5其他诊断入院病情
        /// </summary>		
        private string rybq5;
        /// <summary>
        /// 5其他诊断入院转归
        /// </summary>		
        private string zg5;
        /// <summary>
        /// 6其他诊断疾病代码
        /// </summary>		
        private string jbdm6;
        /// <summary>
        /// 6其他诊断疾病描述
        /// </summary>		
        private string qtzd6;
        /// <summary>
        /// 6其他诊断入院病情
        /// </summary>		
        private string rybq6;
        /// <summary>
        /// 6其他诊断入院转归
        /// </summary>		
        private string zg6;
        /// <summary>
        /// 7其他诊断疾病代码
        /// </summary>		
        private string jbdm7;
        /// <summary>
        /// 7其他诊断疾病描述
        /// </summary>		
        private string qtzd7;
        /// <summary>
        /// 7其他诊断入院病情
        /// </summary>		
        private string rybq7;
        /// <summary>
        /// 7其他诊断入院转归
        /// </summary>		
        private string zg7;
        /// <summary>
        /// 8其他诊断疾病代码
        /// </summary>		
        private string jbdm8;
        /// <summary>
        /// 8其他诊断疾病描述
        /// </summary>		
        private string qtzd8;
        /// <summary>
        /// 8其他诊断入院病情
        /// </summary>		
        private string rybq8;
        /// <summary>
        /// 8其他诊断入院转归
        /// </summary>		
        private string zg8;
        /// <summary>
        /// 9其他诊断疾病代码
        /// </summary>		
        private string jbdm9;
        /// <summary>
        /// 9其他诊断疾病描述
        /// </summary>		
        private string qtzd9;
        /// <summary>
        /// 9其他诊断入院病情
        /// </summary>		
        private string rybq9;
        /// <summary>
        /// 9其他诊断入院转归
        /// </summary>		
        private string zg9;
        /// <summary>
        /// 10其他诊断疾病代码
        /// </summary>		
        private string jbdm10;
        /// <summary>
        /// 10其他诊断疾病描述
        /// </summary>		
        private string qtzd10;
        /// <summary>
        /// 10其他诊断入院病情
        /// </summary>		
        private string rybq10;
        /// <summary>
        /// 10其他诊断入院转归
        /// </summary>		
        private string zg10;
        /// <summary>
        /// 11其他诊断疾病代码
        /// </summary>		
        private string jbdm11;
        /// <summary>
        /// 11其他诊断疾病描述
        /// </summary>		
        private string qtzd11;
        /// <summary>
        /// 11其他诊断入院病情
        /// </summary>		
        private string rybq11;
        /// <summary>
        /// 11其他诊断入院转归
        /// </summary>		
        private string zg11;
        /// <summary>
        /// 12其他诊断疾病代码
        /// </summary>		
        private string jbdm12;
        /// <summary>
        /// 12其他诊断疾病描述
        /// </summary>		
        private string qtzd12;
        /// <summary>
        /// 12其他诊断入院病情
        /// </summary>		
        private string rybq12;
        /// <summary>
        /// 12其他诊断入院转归
        /// </summary>		
        private string zg12;
        /// <summary>
        /// 损伤中毒编码
        /// </summary>		
        private string sszdbm;
        /// <summary>
        /// 损伤中毒外部原因
        /// </summary>		
        private string sszdwbyy;
        /// <summary>
        /// 病理诊断编码
        /// </summary>		
        private string blzdbm;
        /// <summary>
        /// 病理诊断描述
        /// </summary>		
        private string blzddesc;
        /// <summary>
        /// 1手术及操作编码
        /// </summary>		
        private string ssjczbm1;
        /// <summary>
        /// 1手术及操作日期
        /// </summary>		
        private string ssjczrq1;
        /// <summary>
        /// 1手术级别
        /// </summary>		
        private string ssjb1;
        /// <summary>
        /// 1手术及操作名称
        /// </summary>		
        private string ssjczmc1;
        /// <summary>
        /// 1术者
        /// </summary>		
        private string sz1;
        /// <summary>
        /// 1 I助
        /// </summary>		
        private string yz1;
        /// <summary>
        /// 1 EZ1
        /// </summary>		
        private string ez1;
        /// <summary>
        /// 1切口等级
        /// </summary>		
        private string qkdj1;
        /// <summary>
        /// 1切口愈合类别
        /// </summary>		
        private string qkyhlb1;
        /// <summary>
        /// 1麻醉方式
        /// </summary>		
        private string mzfs1;
        /// <summary>
        /// 1麻醉医师
        /// </summary>		
        private string mzys1;
        /// <summary>
        /// 2手术及操作编码
        /// </summary>		
        private string ssjczbm2;
        /// <summary>
        /// 2手术及操作日期
        /// </summary>		
        private string ssjczrq2;
        /// <summary>
        /// 2手术级别
        /// </summary>		
        private string ssjb2;
        /// <summary>
        /// 2手术及操作名称
        /// </summary>		
        private string ssjczmc2;
        /// <summary>
        /// 2术者
        /// </summary>		
        private string sz2;
        /// <summary>
        /// 2 I助
        /// </summary>		
        private string yz2;
        /// <summary>
        /// 2 EZ1
        /// </summary>		
        private string ez2;
        /// <summary>
        /// 2切口等级
        /// </summary>		
        private string qkdj2;
        /// <summary>
        /// 2切口愈合类别
        /// </summary>		
        private string qkyhlb2;
        /// <summary>
        /// 2麻醉方式
        /// </summary>		
        private string mzfs2;
        /// <summary>
        /// 2麻醉医师
        /// </summary>		
        private string mzys2;
        /// <summary>
        /// 3手术及操作编码
        /// </summary>		
        private string ssjczbm3;
        /// <summary>
        /// 3手术及操作日期
        /// </summary>		
        private string ssjczrq3;
        /// <summary>
        /// 3手术级别
        /// </summary>		
        private string ssjb3;
        /// <summary>
        /// 3手术及操作名称
        /// </summary>		
        private string ssjczmc3;
        /// <summary>
        /// 3术者
        /// </summary>		
        private string sz3;
        /// <summary>
        /// 3 I助
        /// </summary>		
        private string yz3;
        /// <summary>
        /// 3 EZ1
        /// </summary>		
        private string ez3;
        /// <summary>
        /// 3切口等级
        /// </summary>		
        private string qkdj3;
        /// <summary>
        /// 3切口愈合类别
        /// </summary>		
        private string qkyhlb3;
        /// <summary>
        /// 3麻醉方式
        /// </summary>		
        private string mzfs3;
        /// <summary>
        /// 3麻醉医师
        /// </summary>		
        private string mzys3;
        /// <summary>
        /// 4手术及操作编码
        /// </summary>		
        private string ssjczbm4;
        /// <summary>
        /// 4手术及操作日期
        /// </summary>		
        private string ssjczrq4;
        /// <summary>
        /// 4手术级别
        /// </summary>		
        private string ssjb4;
        /// <summary>
        /// 4手术及操作名称
        /// </summary>		
        private string ssjczmc4;
        /// <summary>
        /// 4术者
        /// </summary>		
        private string sz4;
        /// <summary>
        /// 4 I助
        /// </summary>		
        private string yz4;
        /// <summary>
        /// 4 EZ1
        /// </summary>		
        private string ez4;
        /// <summary>
        /// 4切口等级
        /// </summary>		
        private string qkdj4;
        /// <summary>
        /// 4切口愈合类别
        /// </summary>		
        private string qkyhlb4;
        /// <summary>
        /// 4麻醉方式
        /// </summary>		
        private string mzfs4;
        /// <summary>
        /// 4麻醉医师
        /// </summary>		
        private string mzys4;
        /// <summary>
        /// 5手术及操作编码
        /// </summary>		
        private string ssjczbm5;
        /// <summary>
        /// 5手术及操作日期
        /// </summary>		
        private string ssjczrq5;
        /// <summary>
        /// 5手术级别
        /// </summary>		
        private string ssjb5;
        /// <summary>
        /// 5手术及操作名称
        /// </summary>		
        private string ssjczmc5;
        /// <summary>
        /// 5术者
        /// </summary>		
        private string sz5;
        /// <summary>
        /// 5I助
        /// </summary>		
        private string yz5;
        /// <summary>
        /// 5 EZ1
        /// </summary>		
        private string ez5;
        /// <summary>
        /// 5切口等级
        /// </summary>		
        private string qkdj5;
        /// <summary>
        /// 5切口愈合类别
        /// </summary>		
        private string qkyhlb5;
        /// <summary>
        /// 5麻醉方式
        /// </summary>		
        private string mzfs5;
        /// <summary>
        /// 5麻醉医师
        /// </summary>		
        private string mzys5;
        /// <summary>
        /// 6手术及操作编码
        /// </summary>		
        private string ssjczbm6;
        /// <summary>
        /// 6手术及操作日期
        /// </summary>		
        private string ssjczrq6;
        /// <summary>
        /// 6手术级别
        /// </summary>		
        private string ssjb6;
        /// <summary>
        /// 6手术及操作名称
        /// </summary>		
        private string ssjczmc6;
        /// <summary>
        /// 6术者
        /// </summary>		
        private string sz6;
        /// <summary>
        /// 6I助
        /// </summary>		
        private string yz6;
        /// <summary>
        /// 6 EZ1
        /// </summary>		
        private string ez6;
        /// <summary>
        /// 6切口等级
        /// </summary>		
        private string qkdj6;
        /// <summary>
        /// 6切口愈合类别
        /// </summary>		
        private string qkyhlb6;
        /// <summary>
        /// 6麻醉方式
        /// </summary>		
        private string mzfs6;
        /// <summary>
        /// 6麻醉医师
        /// </summary>		
        private string mzys6;
        /// <summary>
        /// 7手术及操作编码
        /// </summary>		
        private string ssjczbm7;
        /// <summary>
        /// 7手术及操作日期
        /// </summary>		
        private string ssjczrq7;
        /// <summary>
        /// 7手术级别
        /// </summary>		
        private string ssjb7;
        /// <summary>
        /// 7手术及操作名称
        /// </summary>		
        private string ssjczmc7;
        /// <summary>
        /// 7术者
        /// </summary>		
        private string sz7;
        /// <summary>
        /// 7I助
        /// </summary>		
        private string yz7;
        /// <summary>
        /// 7 EZ1
        /// </summary>		
        private string ez7;
        /// <summary>
        /// 7切口等级
        /// </summary>		
        private string qkdj7;
        /// <summary>
        /// 7切口愈合类别
        /// </summary>		
        private string qkyhlb7;
        /// <summary>
        /// 7麻醉方式
        /// </summary>		
        private string mzfs7;
        /// <summary>
        /// 7麻醉医师
        /// </summary>		
        private string mzys7;
        /// <summary>
        /// 8手术及操作编码
        /// </summary>		
        private string ssjczbm8;
        /// <summary>
        /// 8手术及操作日期
        /// </summary>		
        private string ssjczrq8;
        /// <summary>
        /// 8手术级别
        /// </summary>		
        private string ssjb8;
        /// <summary>
        /// 8手术及操作名称
        /// </summary>		
        private string ssjczmc8;
        /// <summary>
        /// 8术者
        /// </summary>		
        private string sz8;
        /// <summary>
        /// 8I助
        /// </summary>		
        private string yz8;
        /// <summary>
        /// 8 EZ1
        /// </summary>		
        private string ez8;
        /// <summary>
        /// 8切口等级
        /// </summary>		
        private string qkdj8;
        /// <summary>
        /// 8切口愈合类别
        /// </summary>		
        private string qkyhlb8;
        /// <summary>
        /// 8麻醉方式
        /// </summary>		
        private string mzfs8;
        /// <summary>
        /// 8麻醉医师
        /// </summary>		
        private string mzys8;
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
        /// 1其他诊断疾病代码
        /// </summary>		
        public string Jbdm1
        {
            get { return jbdm1; }
            set { jbdm1 = value; }
        }
        /// <summary>
        /// 1其他诊断疾病描述
        /// </summary>		
        public string Qtzd1
        {
            get { return qtzd1; }
            set { qtzd1 = value; }
        }
        /// <summary>
        /// 1其他诊断入院病情
        /// </summary>		
        public string Rybq1
        {
            get { return rybq1; }
            set { rybq1 = value; }
        }
        /// <summary>
        /// 1其他诊断入院转归
        /// </summary>		
        public string Zg1
        {
            get { return zg1; }
            set { zg1 = value; }
        }
        /// <summary>
        /// 2其他诊断疾病代码
        /// </summary>		
        public string Jbdm2
        {
            get { return jbdm2; }
            set { jbdm2 = value; }
        }
        /// <summary>
        /// 2其他诊断疾病描述
        /// </summary>		
        public string Qtzd2
        {
            get { return qtzd2; }
            set { qtzd2 = value; }
        }
        /// <summary>
        /// 2其他诊断入院病情
        /// </summary>		
        public string Rybq2
        {
            get { return rybq2; }
            set { rybq2 = value; }
        }
        /// <summary>
        /// 2其他诊断入院转归
        /// </summary>		
        public string Zg2
        {
            get { return zg2; }
            set { zg2 = value; }
        }
        /// <summary>
        /// 3其他诊断疾病代码
        /// </summary>		
        public string Jbdm3
        {
            get { return jbdm3; }
            set { jbdm3 = value; }
        }
        /// <summary>
        /// 3其他诊断疾病描述
        /// </summary>		
        public string Qtzd3
        {
            get { return qtzd3; }
            set { qtzd3 = value; }
        }
        /// <summary>
        /// 3其他诊断入院病情
        /// </summary>		
        public string Rybq3
        {
            get { return rybq3; }
            set { rybq3 = value; }
        }
        /// <summary>
        /// 3其他诊断入院转归
        /// </summary>		
        public string Zg3
        {
            get { return zg3; }
            set { zg3 = value; }
        }
        /// <summary>
        /// 4其他诊断疾病代码
        /// </summary>		
        public string Jbdm4
        {
            get { return jbdm4; }
            set { jbdm4 = value; }
        }
        /// <summary>
        /// 4其他诊断疾病描述
        /// </summary>		
        public string Qtzd4
        {
            get { return qtzd4; }
            set { qtzd4 = value; }
        }
        /// <summary>
        /// 4其他诊断入院病情
        /// </summary>		
        public string Rybq4
        {
            get { return rybq4; }
            set { rybq4 = value; }
        }
        /// <summary>
        /// 4其他诊断入院转归
        /// </summary>		
        public string Zg4
        {
            get { return zg4; }
            set { zg4 = value; }
        }
        /// <summary>
        /// 5其他诊断疾病代码
        /// </summary>		
        public string Jbdm5
        {
            get { return jbdm5; }
            set { jbdm5 = value; }
        }
        /// <summary>
        /// 5其他诊断疾病描述
        /// </summary>		
        public string Qtzd5
        {
            get { return qtzd5; }
            set { qtzd5 = value; }
        }
        /// <summary>
        /// 5其他诊断入院病情
        /// </summary>		
        public string Rybq5
        {
            get { return rybq5; }
            set { rybq5 = value; }
        }
        /// <summary>
        /// 5其他诊断入院转归
        /// </summary>		
        public string Zg5
        {
            get { return zg5; }
            set { zg5 = value; }
        }
        /// <summary>
        /// 6其他诊断疾病代码
        /// </summary>		
        public string Jbdm6
        {
            get { return jbdm6; }
            set { jbdm6 = value; }
        }
        /// <summary>
        /// 6其他诊断疾病描述
        /// </summary>		
        public string Qtzd6
        {
            get { return qtzd6; }
            set { qtzd6 = value; }
        }
        /// <summary>
        /// 6其他诊断入院病情
        /// </summary>		
        public string Rybq6
        {
            get { return rybq6; }
            set { rybq6 = value; }
        }
        /// <summary>
        /// 6其他诊断入院转归
        /// </summary>		
        public string Zg6
        {
            get { return zg6; }
            set { zg6 = value; }
        }
        /// <summary>
        /// 7其他诊断疾病代码
        /// </summary>		
        public string Jbdm7
        {
            get { return jbdm7; }
            set { jbdm7 = value; }
        }
        /// <summary>
        /// 7其他诊断疾病描述
        /// </summary>		
        public string Qtzd7
        {
            get { return qtzd7; }
            set { qtzd7 = value; }
        }
        /// <summary>
        /// 7其他诊断入院病情
        /// </summary>		
        public string Rybq7
        {
            get { return rybq7; }
            set { rybq7 = value; }
        }
        /// <summary>
        /// 7其他诊断入院转归
        /// </summary>		
        public string Zg7
        {
            get { return zg7; }
            set { zg7 = value; }
        }
        /// <summary>
        /// 8其他诊断疾病代码
        /// </summary>		
        public string Jbdm8
        {
            get { return jbdm8; }
            set { jbdm8 = value; }
        }
        /// <summary>
        /// 8其他诊断疾病描述
        /// </summary>		
        public string Qtzd8
        {
            get { return qtzd8; }
            set { qtzd8 = value; }
        }
        /// <summary>
        /// 8其他诊断入院病情
        /// </summary>		
        public string Rybq8
        {
            get { return rybq8; }
            set { rybq8 = value; }
        }
        /// <summary>
        /// 8其他诊断入院转归
        /// </summary>		
        public string Zg8
        {
            get { return zg8; }
            set { zg8 = value; }
        }
        /// <summary>
        /// 9其他诊断疾病代码
        /// </summary>		
        public string Jbdm9
        {
            get { return jbdm9; }
            set { jbdm9 = value; }
        }
        /// <summary>
        /// 9其他诊断疾病描述
        /// </summary>		
        public string Qtzd9
        {
            get { return qtzd9; }
            set { qtzd9 = value; }
        }
        /// <summary>
        /// 9其他诊断入院病情
        /// </summary>		
        public string Rybq9
        {
            get { return rybq9; }
            set { rybq9 = value; }
        }
        /// <summary>
        /// 9其他诊断入院转归
        /// </summary>		
        public string Zg9
        {
            get { return zg9; }
            set { zg9 = value; }
        }
        /// <summary>
        /// 10其他诊断疾病代码
        /// </summary>		
        public string Jbdm10
        {
            get { return jbdm10; }
            set { jbdm10 = value; }
        }
        /// <summary>
        /// 10其他诊断疾病描述
        /// </summary>		
        public string Qtzd10
        {
            get { return qtzd10; }
            set { qtzd10 = value; }
        }
        /// <summary>
        /// 10其他诊断入院病情
        /// </summary>		
        public string Rybq10
        {
            get { return rybq10; }
            set { rybq10 = value; }
        }
        /// <summary>
        /// 10其他诊断入院转归
        /// </summary>		
        public string Zg10
        {
            get { return zg10; }
            set { zg10 = value; }
        }
        /// <summary>
        /// 11其他诊断疾病代码
        /// </summary>		
        public string Jbdm11
        {
            get { return jbdm11; }
            set { jbdm11 = value; }
        }
        /// <summary>
        /// 11其他诊断疾病描述
        /// </summary>		
        public string Qtzd11
        {
            get { return qtzd11; }
            set { qtzd11 = value; }
        }
        /// <summary>
        /// 11其他诊断入院病情
        /// </summary>		
        public string Rybq11
        {
            get { return rybq11; }
            set { rybq11 = value; }
        }
        /// <summary>
        /// 11其他诊断入院转归
        /// </summary>		
        public string Zg11
        {
            get { return zg11; }
            set { zg11 = value; }
        }
        /// <summary>
        /// 12其他诊断疾病代码
        /// </summary>		
        public string Jbdm12
        {
            get { return jbdm12; }
            set { jbdm12 = value; }
        }
        /// <summary>
        /// 12其他诊断疾病描述
        /// </summary>		
        public string Qtzd12
        {
            get { return qtzd12; }
            set { qtzd12 = value; }
        }
        /// <summary>
        /// 12其他诊断入院病情
        /// </summary>		
        public string Rybq12
        {
            get { return rybq12; }
            set { rybq12 = value; }
        }
        /// <summary>
        /// 12其他诊断入院转归
        /// </summary>		
        public string Zg12
        {
            get { return zg12; }
            set { zg12 = value; }
        }
        /// <summary>
        /// 损伤中毒编码
        /// </summary>		
        public string Sszdbm
        {
            get { return sszdbm; }
            set { sszdbm = value; }
        }
        /// <summary>
        /// 损伤中毒外部原因
        /// </summary>		
        public string Sszdwbyy
        {
            get { return sszdwbyy; }
            set { sszdwbyy = value; }
        }
        /// <summary>
        /// 病理诊断编码
        /// </summary>		
        public string Blzdbm
        {
            get { return blzdbm; }
            set { blzdbm = value; }
        }
        /// <summary>
        /// 病理诊断描述
        /// </summary>		
        public string Blzddesc
        {
            get { return blzddesc; }
            set { blzddesc = value; }
        }
        /// <summary>
        /// 1手术及操作编码
        /// </summary>		
        public string Ssjczbm1
        {
            get { return ssjczbm1; }
            set { ssjczbm1 = value; }
        }
        /// <summary>
        /// 1手术及操作日期
        /// </summary>		
        public string Ssjczrq1
        {
            get { return ssjczrq1; }
            set { ssjczrq1 = value; }
        }
        /// <summary>
        /// 1手术级别
        /// </summary>		
        public string Ssjb1
        {
            get { return ssjb1; }
            set { ssjb1 = value; }
        }
        /// <summary>
        /// 1手术及操作名称
        /// </summary>		
        public string Ssjczmc1
        {
            get { return ssjczmc1; }
            set { ssjczmc1 = value; }
        }
        /// <summary>
        /// 1术者
        /// </summary>		
        public string Sz1
        {
            get { return sz1; }
            set { sz1 = value; }
        }
        /// <summary>
        /// 1 I助
        /// </summary>		
        public string Yz1
        {
            get { return yz1; }
            set { yz1 = value; }
        }
        /// <summary>
        /// 1 EZ1
        /// </summary>		
        public string Ez1
        {
            get { return ez1; }
            set { ez1 = value; }
        }
        /// <summary>
        /// 1切口等级
        /// </summary>		
        public string Qkdj1
        {
            get { return qkdj1; }
            set { qkdj1 = value; }
        }
        /// <summary>
        /// 1切口愈合类别
        /// </summary>		
        public string Qkyhlb1
        {
            get { return qkyhlb1; }
            set { qkyhlb1 = value; }
        }
        /// <summary>
        /// 1麻醉方式
        /// </summary>		
        public string Mzfs1
        {
            get { return mzfs1; }
            set { mzfs1 = value; }
        }
        /// <summary>
        /// 1麻醉医师
        /// </summary>		
        public string Mzys1
        {
            get { return mzys1; }
            set { mzys1 = value; }
        }
        /// <summary>
        /// 2手术及操作编码
        /// </summary>		
        public string Ssjczbm2
        {
            get { return ssjczbm2; }
            set { ssjczbm2 = value; }
        }
        /// <summary>
        /// 2手术及操作日期
        /// </summary>		
        public string Ssjczrq2
        {
            get { return ssjczrq2; }
            set { ssjczrq2 = value; }
        }
        /// <summary>
        /// 2手术级别
        /// </summary>		
        public string Ssjb2
        {
            get { return ssjb2; }
            set { ssjb2 = value; }
        }
        /// <summary>
        /// 2手术及操作名称
        /// </summary>		
        public string Ssjczmc2
        {
            get { return ssjczmc2; }
            set { ssjczmc2 = value; }
        }
        /// <summary>
        /// 2术者
        /// </summary>		
        public string Sz2
        {
            get { return sz2; }
            set { sz2 = value; }
        }
        /// <summary>
        /// 2 I助
        /// </summary>		
        public string Yz2
        {
            get { return yz2; }
            set { yz2 = value; }
        }
        /// <summary>
        /// 2 EZ1
        /// </summary>		
        public string Ez2
        {
            get { return ez2; }
            set { ez2 = value; }
        }
        /// <summary>
        /// 2切口等级
        /// </summary>		
        public string Qkdj2
        {
            get { return qkdj2; }
            set { qkdj2 = value; }
        }
        /// <summary>
        /// 2切口愈合类别
        /// </summary>		
        public string Qkyhlb2
        {
            get { return qkyhlb2; }
            set { qkyhlb2 = value; }
        }
        /// <summary>
        /// 2麻醉方式
        /// </summary>		
        public string Mzfs2
        {
            get { return mzfs2; }
            set { mzfs2 = value; }
        }
        /// <summary>
        /// 2麻醉医师
        /// </summary>		
        public string Mzys2
        {
            get { return mzys2; }
            set { mzys2 = value; }
        }
        /// <summary>
        /// 3手术及操作编码
        /// </summary>		
        public string Ssjczbm3
        {
            get { return ssjczbm3; }
            set { ssjczbm3 = value; }
        }
        /// <summary>
        /// 3手术及操作日期
        /// </summary>		
        public string Ssjczrq3
        {
            get { return ssjczrq3; }
            set { ssjczrq3 = value; }
        }
        /// <summary>
        /// 3手术级别
        /// </summary>		
        public string Ssjb3
        {
            get { return ssjb3; }
            set { ssjb3 = value; }
        }
        /// <summary>
        /// 3手术及操作名称
        /// </summary>		
        public string Ssjczmc3
        {
            get { return ssjczmc3; }
            set { ssjczmc3 = value; }
        }
        /// <summary>
        /// 3术者
        /// </summary>		
        public string Sz3
        {
            get { return sz3; }
            set { sz3 = value; }
        }
        /// <summary>
        /// 3 I助
        /// </summary>		
        public string Yz3
        {
            get { return yz3; }
            set { yz3 = value; }
        }
        /// <summary>
        /// 3 EZ1
        /// </summary>		
        public string Ez3
        {
            get { return ez3; }
            set { ez3 = value; }
        }
        /// <summary>
        /// 3切口等级
        /// </summary>		
        public string Qkdj3
        {
            get { return qkdj3; }
            set { qkdj3 = value; }
        }
        /// <summary>
        /// 3切口愈合类别
        /// </summary>		
        public string Qkyhlb3
        {
            get { return qkyhlb3; }
            set { qkyhlb3 = value; }
        }
        /// <summary>
        /// 3麻醉方式
        /// </summary>		
        public string Mzfs3
        {
            get { return mzfs3; }
            set { mzfs3 = value; }
        }
        /// <summary>
        /// 3麻醉医师
        /// </summary>		
        public string Mzys3
        {
            get { return mzys3; }
            set { mzys3 = value; }
        }
        /// <summary>
        /// 4手术及操作编码
        /// </summary>		
        public string Ssjczbm4
        {
            get { return ssjczbm4; }
            set { ssjczbm4 = value; }
        }
        /// <summary>
        /// 4手术及操作日期
        /// </summary>		
        public string Ssjczrq4
        {
            get { return ssjczrq4; }
            set { ssjczrq4 = value; }
        }
        /// <summary>
        /// 4手术级别
        /// </summary>		
        public string Ssjb4
        {
            get { return ssjb4; }
            set { ssjb4 = value; }
        }
        /// <summary>
        /// 4手术及操作名称
        /// </summary>		
        public string Ssjczmc4
        {
            get { return ssjczmc4; }
            set { ssjczmc4 = value; }
        }
        /// <summary>
        /// 4术者
        /// </summary>		
        public string Sz4
        {
            get { return sz4; }
            set { sz4 = value; }
        }
        /// <summary>
        /// 4 I助
        /// </summary>		
        public string Yz4
        {
            get { return yz4; }
            set { yz4 = value; }
        }
        /// <summary>
        /// 4 EZ1
        /// </summary>		
        public string Ez4
        {
            get { return ez4; }
            set { ez4 = value; }
        }
        /// <summary>
        /// 4切口等级
        /// </summary>		
        public string Qkdj4
        {
            get { return qkdj4; }
            set { qkdj4 = value; }
        }
        /// <summary>
        /// 4切口愈合类别
        /// </summary>		
        public string Qkyhlb4
        {
            get { return qkyhlb4; }
            set { qkyhlb4 = value; }
        }
        /// <summary>
        /// 4麻醉方式
        /// </summary>		
        public string Mzfs4
        {
            get { return mzfs4; }
            set { mzfs4 = value; }
        }
        /// <summary>
        /// 4麻醉医师
        /// </summary>		
        public string Mzys4
        {
            get { return mzys4; }
            set { mzys4 = value; }
        }
        /// <summary>
        /// 5手术及操作编码
        /// </summary>		
        public string Ssjczbm5
        {
            get { return ssjczbm5; }
            set { ssjczbm5 = value; }
        }
        /// <summary>
        /// 5手术及操作日期
        /// </summary>		
        public string Ssjczrq5
        {
            get { return ssjczrq5; }
            set { ssjczrq5 = value; }
        }
        /// <summary>
        /// 5手术级别
        /// </summary>		
        public string Ssjb5
        {
            get { return ssjb5; }
            set { ssjb5 = value; }
        }
        /// <summary>
        /// 5手术及操作名称
        /// </summary>		
        public string Ssjczmc5
        {
            get { return ssjczmc5; }
            set { ssjczmc5 = value; }
        }
        /// <summary>
        /// 5术者
        /// </summary>		
        public string Sz5
        {
            get { return sz5; }
            set { sz5 = value; }
        }
        /// <summary>
        /// 5I助
        /// </summary>		
        public string Yz5
        {
            get { return yz5; }
            set { yz5 = value; }
        }
        /// <summary>
        /// 5 EZ1
        /// </summary>		
        public string Ez5
        {
            get { return ez5; }
            set { ez5 = value; }
        }
        /// <summary>
        /// 5切口等级
        /// </summary>		
        public string Qkdj5
        {
            get { return qkdj5; }
            set { qkdj5 = value; }
        }
        /// <summary>
        /// 5切口愈合类别
        /// </summary>		
        public string Qkyhlb5
        {
            get { return qkyhlb5; }
            set { qkyhlb5 = value; }
        }
        /// <summary>
        /// 5麻醉方式
        /// </summary>		
        public string Mzfs5
        {
            get { return mzfs5; }
            set { mzfs5 = value; }
        }
        /// <summary>
        /// 5麻醉医师
        /// </summary>		
        public string Mzys5
        {
            get { return mzys5; }
            set { mzys5 = value; }
        }
        /// <summary>
        /// 6手术及操作编码
        /// </summary>		
        public string Ssjczbm6
        {
            get { return ssjczbm6; }
            set { ssjczbm6 = value; }
        }
        /// <summary>
        /// 6手术及操作日期
        /// </summary>		
        public string Ssjczrq6
        {
            get { return ssjczrq6; }
            set { ssjczrq6 = value; }
        }
        /// <summary>
        /// 6手术级别
        /// </summary>		
        public string Ssjb6
        {
            get { return ssjb6; }
            set { ssjb6 = value; }
        }
        /// <summary>
        /// 6手术及操作名称
        /// </summary>		
        public string Ssjczmc6
        {
            get { return ssjczmc6; }
            set { ssjczmc6 = value; }
        }
        /// <summary>
        /// 6术者
        /// </summary>		
        public string Sz6
        {
            get { return sz6; }
            set { sz6 = value; }
        }
        /// <summary>
        /// 6I助
        /// </summary>		
        public string Yz6
        {
            get { return yz6; }
            set { yz6 = value; }
        }
        /// <summary>
        /// 6 EZ1
        /// </summary>		
        public string Ez6
        {
            get { return ez6; }
            set { ez6 = value; }
        }
        /// <summary>
        /// 6切口等级
        /// </summary>		
        public string Qkdj6
        {
            get { return qkdj6; }
            set { qkdj6 = value; }
        }
        /// <summary>
        /// 6切口愈合类别
        /// </summary>		
        public string Qkyhlb6
        {
            get { return qkyhlb6; }
            set { qkyhlb6 = value; }
        }
        /// <summary>
        /// 6麻醉方式
        /// </summary>		
        public string Mzfs6
        {
            get { return mzfs6; }
            set { mzfs6 = value; }
        }
        /// <summary>
        /// 6麻醉医师
        /// </summary>		
        public string Mzys6
        {
            get { return mzys6; }
            set { mzys6 = value; }
        }
        /// <summary>
        /// 7手术及操作编码
        /// </summary>		
        public string Ssjczbm7
        {
            get { return ssjczbm7; }
            set { ssjczbm7 = value; }
        }
        /// <summary>
        /// 7手术及操作日期
        /// </summary>		
        public string Ssjczrq7
        {
            get { return ssjczrq7; }
            set { ssjczrq7 = value; }
        }
        /// <summary>
        /// 7手术级别
        /// </summary>		
        public string Ssjb7
        {
            get { return ssjb7; }
            set { ssjb7 = value; }
        }
        /// <summary>
        /// 7手术及操作名称
        /// </summary>		
        public string Ssjczmc7
        {
            get { return ssjczmc7; }
            set { ssjczmc7 = value; }
        }
        /// <summary>
        /// 7术者
        /// </summary>		
        public string Sz7
        {
            get { return sz7; }
            set { sz7 = value; }
        }
        /// <summary>
        /// 7I助
        /// </summary>		
        public string Yz7
        {
            get { return yz7; }
            set { yz7 = value; }
        }
        /// <summary>
        /// 7 EZ1
        /// </summary>		
        public string Ez7
        {
            get { return ez7; }
            set { ez7 = value; }
        }
        /// <summary>
        /// 7切口等级
        /// </summary>		
        public string Qkdj7
        {
            get { return qkdj7; }
            set { qkdj7 = value; }
        }
        /// <summary>
        /// 7切口愈合类别
        /// </summary>		
        public string Qkyhlb7
        {
            get { return qkyhlb7; }
            set { qkyhlb7 = value; }
        }
        /// <summary>
        /// 7麻醉方式
        /// </summary>		
        public string Mzfs7
        {
            get { return mzfs7; }
            set { mzfs7 = value; }
        }
        /// <summary>
        /// 7麻醉医师
        /// </summary>		
        public string Mzys7
        {
            get { return mzys7; }
            set { mzys7 = value; }
        }
        /// <summary>
        /// 8手术及操作编码
        /// </summary>		
        public string Ssjczbm8
        {
            get { return ssjczbm8; }
            set { ssjczbm8 = value; }
        }
        /// <summary>
        /// 8手术及操作日期
        /// </summary>		
        public string Ssjczrq8
        {
            get { return ssjczrq8; }
            set { ssjczrq8 = value; }
        }
        /// <summary>
        /// 8手术级别
        /// </summary>		
        public string Ssjb8
        {
            get { return ssjb8; }
            set { ssjb8 = value; }
        }
        /// <summary>
        /// 8手术及操作名称
        /// </summary>		
        public string Ssjczmc8
        {
            get { return ssjczmc8; }
            set { ssjczmc8 = value; }
        }
        /// <summary>
        /// 8术者
        /// </summary>		
        public string Sz8
        {
            get { return sz8; }
            set { sz8 = value; }
        }
        /// <summary>
        /// 8I助
        /// </summary>		
        public string Yz8
        {
            get { return yz8; }
            set { yz8 = value; }
        }
        /// <summary>
        /// 8 EZ1
        /// </summary>		
        public string Ez8
        {
            get { return ez8; }
            set { ez8 = value; }
        }
        /// <summary>
        /// 8切口等级
        /// </summary>		
        public string Qkdj8
        {
            get { return qkdj8; }
            set { qkdj8 = value; }
        }
        /// <summary>
        /// 8切口愈合类别
        /// </summary>		
        public string Qkyhlb8
        {
            get { return qkyhlb8; }
            set { qkyhlb8 = value; }
        }
        /// <summary>
        /// 8麻醉方式
        /// </summary>		
        public string Mzfs8
        {
            get { return mzfs8; }
            set { mzfs8 = value; }
        }
        /// <summary>
        /// 8麻醉医师
        /// </summary>		
        public string Mzys8
        {
            get { return mzys8; }
            set { mzys8 = value; }
        }
        #endregion   
    }
}
