using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NineVigor.Domain.HealthRecord.Dto
{
    public interface ICasDiagOperation
    {
        /// <summary>
        /// 住院流水号
        /// </summary>		
        string Inpatient_no { get; set; }
        /// <summary>
        /// 1其他诊断疾病代码
        /// </summary>		
        string Jbdm1 { get; set; }
        /// <summary>
        /// 1其他诊断疾病描述
        /// </summary>		
        string Qtzd1 { get; set; }
        /// <summary>
        /// 1其他诊断入院病情
        /// </summary>		
        string Rybq1 { get; set; }
        /// <summary>
        /// 1其他诊断入院转归
        /// </summary>		
        string Zg1 { get; set; }
        /// <summary>
        /// 2其他诊断疾病代码
        /// </summary>		
        string Jbdm2 { get; set; }
        /// <summary>
        /// 2其他诊断疾病描述
        /// </summary>		
        string Qtzd2 { get; set; }
        /// <summary>
        /// 2其他诊断入院病情
        /// </summary>		
        string Rybq2 { get; set; }
        /// <summary>
        /// 2其他诊断入院转归
        /// </summary>		
        string Zg2 { get; set; }
        /// <summary>
        /// 3其他诊断疾病代码
        /// </summary>		
        string Jbdm3 { get; set; }
        /// <summary>
        /// 3其他诊断疾病描述
        /// </summary>		
        string Qtzd3 { get; set; }
        /// <summary>
        /// 3其他诊断入院病情
        /// </summary>		
        string Rybq3 { get; set; }
        /// <summary>
        /// 3其他诊断入院转归
        /// </summary>		
        string Zg3 { get; set; }
        /// <summary>
        /// 4其他诊断疾病代码
        /// </summary>		
        string Jbdm4 { get; set; }
        /// <summary>
        /// 4其他诊断疾病描述
        /// </summary>		
        string Qtzd4 { get; set; }
        /// <summary>
        /// 4其他诊断入院病情
        /// </summary>		
        string Rybq4 { get; set; }
        /// <summary>
        /// 4其他诊断入院转归
        /// </summary>		
        string Zg4 { get; set; }
        /// <summary>
        /// 5其他诊断疾病代码
        /// </summary>		
        string Jbdm5 { get; set; }
        /// <summary>
        /// 5其他诊断疾病描述
        /// </summary>		
        string Qtzd5 { get; set; }
        /// <summary>
        /// 5其他诊断入院病情
        /// </summary>		
        string Rybq5 { get; set; }
        /// <summary>
        /// 5其他诊断入院转归
        /// </summary>		
        string Zg5 { get; set; }
        /// <summary>
        /// 6其他诊断疾病代码
        /// </summary>		
        string Jbdm6 { get; set; }
        /// <summary>
        /// 6其他诊断疾病描述
        /// </summary>		
        string Qtzd6 { get; set; }
        /// <summary>
        /// 6其他诊断入院病情
        /// </summary>		
        string Rybq6 { get; set; }
        /// <summary>
        /// 6其他诊断入院转归
        /// </summary>		
        string Zg6 { get; set; }
        /// <summary>
        /// 7其他诊断疾病代码
        /// </summary>		
        string Jbdm7 { get; set; }
        /// <summary>
        /// 7其他诊断疾病描述
        /// </summary>		
        string Qtzd7 { get; set; }
        /// <summary>
        /// 7其他诊断入院病情
        /// </summary>		
        string Rybq7 { get; set; }
        /// <summary>
        /// 7其他诊断入院转归
        /// </summary>		
        string Zg7 { get; set; }
        /// <summary>
        /// 8其他诊断疾病代码
        /// </summary>		
        string Jbdm8 { get; set; }
        /// <summary>
        /// 8其他诊断疾病描述
        /// </summary>		
        string Qtzd8 { get; set; }
        /// <summary>
        /// 8其他诊断入院病情
        /// </summary>		
        string Rybq8 { get; set; }
        /// <summary>
        /// 8其他诊断入院转归
        /// </summary>		
        string Zg8 { get; set; }
        /// <summary>
        /// 9其他诊断疾病代码
        /// </summary>		
        string Jbdm9 { get; set; }
        /// <summary>
        /// 9其他诊断疾病描述
        /// </summary>		
        string Qtzd9 { get; set; }
        /// <summary>
        /// 9其他诊断入院病情
        /// </summary>		
        string Rybq9 { get; set; }
        /// <summary>
        /// 9其他诊断入院转归
        /// </summary>		
        string Zg9 { get; set; }
        /// <summary>
        /// 10其他诊断疾病代码
        /// </summary>		
        string Jbdm10 { get; set; }
        /// <summary>
        /// 10其他诊断疾病描述
        /// </summary>		
        string Qtzd10 { get; set; }
        /// <summary>
        /// 10其他诊断入院病情
        /// </summary>		
        string Rybq10 { get; set; }
        /// <summary>
        /// 10其他诊断入院转归
        /// </summary>		
        string Zg10 { get; set; }
        /// <summary>
        /// 11其他诊断疾病代码
        /// </summary>		
        string Jbdm11 { get; set; }
        /// <summary>
        /// 11其他诊断疾病描述
        /// </summary>		
        string Qtzd11 { get; set; }
        /// <summary>
        /// 11其他诊断入院病情
        /// </summary>		
        string Rybq11 { get; set; }
        /// <summary>
        /// 11其他诊断入院转归
        /// </summary>		
        string Zg11 { get; set; }
        /// <summary>
        /// 12其他诊断疾病代码
        /// </summary>		
        string Jbdm12 { get; set; }
        /// <summary>
        /// 12其他诊断疾病描述
        /// </summary>		
        string Qtzd12 { get; set; }
        /// <summary>
        /// 12其他诊断入院病情
        /// </summary>		
        string Rybq12 { get; set; }
        /// <summary>
        /// 12其他诊断入院转归
        /// </summary>		
        string Zg12 { get; set; }
        /// <summary>
        /// 损伤中毒编码
        /// </summary>		
        string Sszdbm { get; set; }
        /// <summary>
        /// 损伤中毒外部原因
        /// </summary>		
        string Sszdwbyy { get; set; }
        /// <summary>
        /// 病理诊断编码
        /// </summary>		
        string Blzdbm { get; set; }
        /// <summary>
        /// 病理诊断描述
        /// </summary>		
        string Blzddesc { get; set; }
        /// <summary>
        /// 1手术及操作编码
        /// </summary>		
        string Ssjczbm1 { get; set; }
        /// <summary>
        /// 1手术及操作日期
        /// </summary>		
        string Ssjczrq1 { get; set; }
        /// <summary>
        /// 1手术级别
        /// </summary>		
        string Ssjb1 { get; set; }
        /// <summary>
        /// 1手术及操作名称
        /// </summary>		
        string Ssjczmc1 { get; set; }
        /// <summary>
        /// 1术者
        /// </summary>		
        string Sz1 { get; set; }
        /// <summary>
        /// 1 I助
        /// </summary>		
        string Yz1 { get; set; }
        /// <summary>
        /// 1 EZ1
        /// </summary>		
        string Ez1 { get; set; }
        /// <summary>
        /// 1切口等级
        /// </summary>		
        string Qkdj1 { get; set; }
        /// <summary>
        /// 1切口愈合类别
        /// </summary>		
        string Qkyhlb1 { get; set; }
        /// <summary>
        /// 1麻醉方式
        /// </summary>		
        string Mzfs1 { get; set; }
        /// <summary>
        /// 1麻醉医师
        /// </summary>		
        string Mzys1 { get; set; }
        /// <summary>
        /// 2手术及操作编码
        /// </summary>		
        string Ssjczbm2 { get; set; }
        /// <summary>
        /// 2手术及操作日期
        /// </summary>		
        string Ssjczrq2 { get; set; }
        /// <summary>
        /// 2手术级别
        /// </summary>		
        string Ssjb2 { get; set; }
        /// <summary>
        /// 2手术及操作名称
        /// </summary>		
        string Ssjczmc2 { get; set; }
        /// <summary>
        /// 2术者
        /// </summary>		
        string Sz2 { get; set; }
        /// <summary>
        /// 2 I助
        /// </summary>		
        string Yz2 { get; set; }
        /// <summary>
        /// 2 EZ1
        /// </summary>		
        string Ez2 { get; set; }
        /// <summary>
        /// 2切口等级
        /// </summary>		
        string Qkdj2 { get; set; }
        /// <summary>
        /// 2切口愈合类别
        /// </summary>		
        string Qkyhlb2 { get; set; }
        /// <summary>
        /// 2麻醉方式
        /// </summary>		
        string Mzfs2 { get; set; }
        /// <summary>
        /// 2麻醉医师
        /// </summary>		
        string Mzys2 { get; set; }
        /// <summary>
        /// 3手术及操作编码
        /// </summary>		
        string Ssjczbm3 { get; set; }
        /// <summary>
        /// 3手术及操作日期
        /// </summary>		
        string Ssjczrq3 { get; set; }
        /// <summary>
        /// 3手术级别
        /// </summary>		
        string Ssjb3 { get; set; }
        /// <summary>
        /// 3手术及操作名称
        /// </summary>		
        string Ssjczmc3 { get; set; }
        /// <summary>
        /// 3术者
        /// </summary>		
        string Sz3 { get; set; }
        /// <summary>
        /// 3 I助
        /// </summary>		
        string Yz3 { get; set; }
        /// <summary>
        /// 3 EZ1
        /// </summary>		
        string Ez3 { get; set; }
        /// <summary>
        /// 3切口等级
        /// </summary>		
        string Qkdj3 { get; set; }
        /// <summary>
        /// 3切口愈合类别
        /// </summary>		
        string Qkyhlb3 { get; set; }
        /// <summary>
        /// 3麻醉方式
        /// </summary>		
        string Mzfs3 { get; set; }
        /// <summary>
        /// 3麻醉医师
        /// </summary>		
        string Mzys3 { get; set; }
        /// <summary>
        /// 4手术及操作编码
        /// </summary>		
        string Ssjczbm4 { get; set; }
        /// <summary>
        /// 4手术及操作日期
        /// </summary>		
        string Ssjczrq4 { get; set; }
        /// <summary>
        /// 4手术级别
        /// </summary>		
        string Ssjb4 { get; set; }
        /// <summary>
        /// 4手术及操作名称
        /// </summary>		
        string Ssjczmc4 { get; set; }
        /// <summary>
        /// 4术者
        /// </summary>		
        string Sz4 { get; set; }
        /// <summary>
        /// 4 I助
        /// </summary>		
        string Yz4 { get; set; }
        /// <summary>
        /// 4 EZ1
        /// </summary>		
        string Ez4 { get; set; }
        /// <summary>
        /// 4切口等级
        /// </summary>		
        string Qkdj4 { get; set; }
        /// <summary>
        /// 4切口愈合类别
        /// </summary>		
        string Qkyhlb4 { get; set; }
        /// <summary>
        /// 4麻醉方式
        /// </summary>		
        string Mzfs4 { get; set; }
        /// <summary>
        /// 4麻醉医师
        /// </summary>		
        string Mzys4 { get; set; }
        /// <summary>
        /// 5手术及操作编码
        /// </summary>		
        string Ssjczbm5 { get; set; }
        /// <summary>
        /// 5手术及操作日期
        /// </summary>		
        string Ssjczrq5 { get; set; }
        /// <summary>
        /// 5手术级别
        /// </summary>		
        string Ssjb5 { get; set; }
        /// <summary>
        /// 5手术及操作名称
        /// </summary>		
        string Ssjczmc5 { get; set; }
        /// <summary>
        /// 5术者
        /// </summary>		
        string Sz5 { get; set; }
        /// <summary>
        /// 5I助
        /// </summary>		
        string Yz5 { get; set; }
        /// <summary>
        /// 5 EZ1
        /// </summary>		
        string Ez5 { get; set; }
        /// <summary>
        /// 5切口等级
        /// </summary>		
        string Qkdj5 { get; set; }
        /// <summary>
        /// 5切口愈合类别
        /// </summary>		
        string Qkyhlb5 { get; set; }
        /// <summary>
        /// 5麻醉方式
        /// </summary>		
        string Mzfs5 { get; set; }
        /// <summary>
        /// 5麻醉医师
        /// </summary>		
        string Mzys5 { get; set; }
        /// <summary>
        /// 6手术及操作编码
        /// </summary>		
        string Ssjczbm6 { get; set; }
        /// <summary>
        /// 6手术及操作日期
        /// </summary>		
        string Ssjczrq6 { get; set; }
        /// <summary>
        /// 6手术级别
        /// </summary>		
        string Ssjb6 { get; set; }
        /// <summary>
        /// 6手术及操作名称
        /// </summary>		
        string Ssjczmc6 { get; set; }
        /// <summary>
        /// 6术者
        /// </summary>		
        string Sz6 { get; set; }
        /// <summary>
        /// 6I助
        /// </summary>		
        string Yz6 { get; set; }
        /// <summary>
        /// 6 EZ1
        /// </summary>		
        string Ez6 { get; set; }
        /// <summary>
        /// 6切口等级
        /// </summary>		
        string Qkdj6 { get; set; }
        /// <summary>
        /// 6切口愈合类别
        /// </summary>		
        string Qkyhlb6 { get; set; }
        /// <summary>
        /// 6麻醉方式
        /// </summary>		
        string Mzfs6 { get; set; }
        /// <summary>
        /// 6麻醉医师
        /// </summary>		
        string Mzys6 { get; set; }
        /// <summary>
        /// 7手术及操作编码
        /// </summary>		
        string Ssjczbm7 { get; set; }
        /// <summary>
        /// 7手术及操作日期
        /// </summary>		
        string Ssjczrq7 { get; set; }
        /// <summary>
        /// 7手术级别
        /// </summary>		
        string Ssjb7 { get; set; }
        /// <summary>
        /// 7手术及操作名称
        /// </summary>		
        string Ssjczmc7 { get; set; }
        /// <summary>
        /// 7术者
        /// </summary>		
        string Sz7 { get; set; }
        /// <summary>
        /// 7I助
        /// </summary>		
        string Yz7 { get; set; }
        /// <summary>
        /// 7 EZ1
        /// </summary>		
        string Ez7 { get; set; }
        /// <summary>
        /// 7切口等级
        /// </summary>		
        string Qkdj7 { get; set; }
        /// <summary>
        /// 7切口愈合类别
        /// </summary>		
        string Qkyhlb7 { get; set; }
        /// <summary>
        /// 7麻醉方式
        /// </summary>		
        string Mzfs7 { get; set; }
        /// <summary>
        /// 7麻醉医师
        /// </summary>		
        string Mzys7 { get; set; }
        /// <summary>
        /// 8手术及操作编码
        /// </summary>		
        string Ssjczbm8 { get; set; }
        /// <summary>
        /// 8手术及操作日期
        /// </summary>		
        string Ssjczrq8 { get; set; }
        /// <summary>
        /// 8手术级别
        /// </summary>		
        string Ssjb8 { get; set; }
        /// <summary>
        /// 8手术及操作名称
        /// </summary>		
        string Ssjczmc8 { get; set; }
        /// <summary>
        /// 8术者
        /// </summary>		
        string Sz8 { get; set; }
        /// <summary>
        /// 8I助
        /// </summary>		
        string Yz8 { get; set; }
        /// <summary>
        /// 8 EZ1
        /// </summary>		
        string Ez8 { get; set; }
        /// <summary>
        /// 8切口等级
        /// </summary>		
        string Qkdj8 { get; set; }
        /// <summary>
        /// 8切口愈合类别
        /// </summary>		
        string Qkyhlb8 { get; set; }
        /// <summary>
        /// 8麻醉方式
        /// </summary>		
        string Mzfs8 { get; set; }
        /// <summary>
        /// 8麻醉医师
        /// </summary>		
        string Mzys8 { get; set; }
    }
}
