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
    /// [��������: ����ICDά����Ϣ¼��]<br></br>
    /// [�� �� ��: ��־��]<br></br>
    /// [����ʱ��: 2015-10-23]<br></br>
    /// <�޸ļ�¼ 
    ///		�޸���='' 
    ///		�޸�ʱ��='yyyy-mm-dd' 
    ///		�޸�Ŀ��=''
    ///		�޸�����=''
    ///  />
    /// </summary>
    public partial class frmICDInfo : Form
    {
        public frmICDInfo()
        {
            InitializeComponent();
        }
        #region   ˽�б���
        //����ICD���� ���洢�޸�ǰICD10��Ϣ
        private NineVigor.Domain.HealthRecord.Entity.ICDDiagnose orgICD10 = new NineVigor.Domain.HealthRecord.Entity.ICDDiagnose();

        public NineVigor.Domain.HealthRecord.Entity.ICDDiagnose OrgICD10
        {
            get { return orgICD10; }
            set { orgICD10 = value; }
        }
        //����ICD���� ���洢�޸ĺ�ICD10��Ϣ
        private NineVigor.Domain.HealthRecord.Entity.ICDDiagnose newICD10 = new NineVigor.Domain.HealthRecord.Entity.ICDDiagnose();

        public NineVigor.Domain.HealthRecord.Entity.ICDDiagnose NewICD10
        {
            get { return newICD10; }
            set { newICD10 = value; }
        }


        public delegate void SaveInfo(NineVigor.Domain.HealthRecord.Entity.ICDDiagnose saveInfo); //����ί��
        public delegate void SaveInfoDamage(NineVigor.Domain.HealthRecord.Entity.ICDDamage saveInfo); //����ί��
        public delegate void SaveInfoOperation(NineVigor.Domain.HealthRecord.Entity.ICDOperation saveInfo); //����ί��
        public event SaveInfo SaveButtonClick; //�����¼�

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

        #region	��������

        #endregion

        #region  ���ڿؼ����¼�

        #region �����Load �¼�
        private void ucICDInfo_Load(object sender, System.EventArgs e)
        {
        }
        #endregion

        #region  �رհ�ť
        private void button2_Click(object sender, System.EventArgs e)
        {
            //�رձ�����
            this.Close();
        }
        #endregion

        #region  ȷ����ť
        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                //�ж����ݵ���Ч��
                if (!ValidCheck())
                {
                    //�е�������Ч
                    return;
                }
                //��ȡ��Ϣ
                this.GetICDinfo();

           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region �س��¼�
        /// <summary>
        /// ICD id �Ļس��¼�
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
        ///ICD���� �� �س��¼�
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
        /// ƴ���� �� �س��¼�
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
        /// �Զ���  �� �س��¼�
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
        /// 30 �м��� ��ť �� �س��¼�
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
        /// ��Ⱦ ��ť �� �س��¼�
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
        /// ������ť �� �س��¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsTumour_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (this.IsValid.Enabled) //�����Ч
                {
                    this.IsValid.Focus(); //��ý���
                }
                else
                {
                    this.ContinueInput.Focus(); //���� �� ����һ���ؼ�
                }
            }
        }
        /// <summary>
        /// ��Ч�԰�ť �� �س��¼�
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
        /// ��������Ļس��¼�
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
        /// ��ŵĻس��¼�
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

        #region �Զ��庯��

        /// <summary>
        /// ������Ϣ
        /// </summary>
        /// <returns>�ɹ����� true ʧ�ܷ��� false</returns>
        private bool Save()
        {
            

            return true;
        }
        #endregion

        #region �Զ��庯��
        /// <summary>
        /// ��ȡ�޸Ļ���������Ϣ
        /// </summary>
        private void GetICDinfo()
        {

        }

        /// <summary>
        /// �ж��������ݵ���Ч��
        /// </summary>
        /// <returns>���ݶ��Ϻ����� ����TRUE  ���򷵻�false </returns>
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
        /// ����ƴ����
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