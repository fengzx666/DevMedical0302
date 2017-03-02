using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace NineVigor.Components.HealthRecord.CasMatience.ICD
{
    /// <summary>
    /// frmICDInfo<br></br>
    /// [功能描述: 病案ICD维护信息录入]<br></br>
    /// [创 建 者: 冯志欣]<br></br>
    /// [创建时间: 2015-10-23]<br></br>
    /// <修改记录 
    ///		修改人='' 
    ///		修改时间='yyyy-mm-dd' 
    ///		修改目的=''
    ///		修改描述=''
    ///  />
    /// </summary>
    public partial class frmICDInfo : Form
    {
        public frmICDInfo()
        {
            InitializeComponent();
        }
        #region   私有变量
        //定义ICD变量 ，存储修改前ICD10信息
        private NineVigor.Domain.HealthRecord.Entity.ICDDiagnose orgICD10 = new NineVigor.Domain.HealthRecord.Entity.ICDDiagnose();

        public NineVigor.Domain.HealthRecord.Entity.ICDDiagnose OrgICD10
        {
            get { return orgICD10; }
            set { orgICD10 = value; }
        }
        //定义ICD变量 ，存储修改后ICD10信息
        private NineVigor.Domain.HealthRecord.Entity.ICDDiagnose newICD10 = new NineVigor.Domain.HealthRecord.Entity.ICDDiagnose();

        public NineVigor.Domain.HealthRecord.Entity.ICDDiagnose NewICD10
        {
            get { return newICD10; }
            set { newICD10 = value; }
        }


        public delegate void SaveInfo(NineVigor.Domain.HealthRecord.Entity.ICDDiagnose saveInfo); //定义委托
        public delegate void SaveInfoDamage(NineVigor.Domain.HealthRecord.Entity.ICDDamage saveInfo); //定义委托
        public delegate void SaveInfoOperation(NineVigor.Domain.HealthRecord.Entity.ICDOperation saveInfo); //定义委托
        public event SaveInfo SaveButtonClick; //定义事件

        private string editType = string.Empty;
        private string icdType = string.Empty;

        public string IcdType
        {
            get { return icdType; }
            set { icdType = value; }
        }

        public string EditType
        {
            get { return editType; }
            set { editType = value; }
        }
    

        #endregion

        #region	公有属性

        #endregion

        #region  窗口控件的事件

        #region 窗体的Load 事件
        private void ucICDInfo_Load(object sender, System.EventArgs e)
        {
        }
        #endregion

        #region  关闭按钮
        private void button2_Click(object sender, System.EventArgs e)
        {
            //关闭本窗口
            this.Close();
        }
        #endregion

        #region  确定按钮
        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                //判断数据的有效性
                if (!ValidCheck())
                {
                    //有的数据无效
                    return;
                }
                //获取信息
                this.GetICDinfo();

           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region 回车事件
        /// <summary>
        /// ICD id 的回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textICDid_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.textICDName.Focus();
            }
        }

        /// <summary>
        ///ICD名称 的 回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textICDName_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.innTBSpellCode.Focus();
            }

        }

        /// <summary>
        /// 拼音码 的 回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textSpellCode_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.innTBWBCode.Focus();
            }

        }
        /// <summary>
        /// 自定义  的 回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textUserCode_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtExtFuZhuICD.Focus();
            }
        }
        /// <summary>
        /// 30 中疾病 按钮 的 回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Is30Illness_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.IsInfection.Focus();
            }
        }
        /// <summary>
        /// 传染 按钮 的 回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsInfection_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.IsTumour.Focus();
            }
        }
        /// <summary>
        /// 肿瘤按钮 的 回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsTumour_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (this.IsValid.Enabled) //如果有效
                {
                    this.IsValid.Focus(); //获得焦点
                }
                else
                {
                    this.ContinueInput.Focus(); //否则 跳 到下一个控件
                }
            }
        }
        /// <summary>
        /// 有效性按钮 的 回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsValid_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.ContinueInput.Focus();
            }
        }
        /// <summary>
        /// 连续输入的回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContinueInput_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.button1.Focus();
            }

        }
        /// <summary>
        /// 序号的回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textSeqNO_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.Is30Illness.Focus();
            }
        }
        #endregion

        #endregion

        #region 自定义函数

        /// <summary>
        /// 保存信息
        /// </summary>
        /// <returns>成功返回 true 失败返回 false</returns>
        private bool Save()
        {
            

            return true;
        }
        #endregion

        #region 自定义函数
        /// <summary>
        /// 获取修改或新增的信息
        /// </summary>
        private void GetICDinfo()
        {

        }

        /// <summary>
        /// 判断输入数据的有效性
        /// </summary>
        /// <returns>数据都合乎规则 返回TRUE  否则返回false </returns>
        private bool ValidCheck()
        {
            try
            {
             
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 生成拼音码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textICDName_Leave(object sender, System.EventArgs e)
        {
            try
            {
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void WBCode_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.textUserCode.Focus();
            }
        }

    }
}