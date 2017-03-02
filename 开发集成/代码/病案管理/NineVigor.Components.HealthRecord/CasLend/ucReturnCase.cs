using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace NineVigor.Components.HealthRecord.CasLend
{
    public partial class ucReturnCase : NineVigor.FrameWork.WinForms.Controls.ucBaseControl
    {
        public ucReturnCase()
        {
            InitializeComponent();
        }

        #region  ȫ�ֱ���
       
        private ArrayList LendList = null;
        NineVigor.FrameWork.Public.ObjectHelper SexHelper = new NineVigor.FrameWork.Public.ObjectHelper();
        #endregion

        #region ��������Ϣ

        /// <summary>
        /// ���幤��������
        /// </summary>
        protected NineVigor.FrameWork.WinForms.Forms.ToolBarService toolBarService = new NineVigor.FrameWork.WinForms.Forms.ToolBarService();

        #region ��ʼ��������
        /// <summary>
        /// ��ʼ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="neuObject"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        protected override NineVigor.FrameWork.WinForms.Forms.ToolBarService OnInit(object sender, object neuObject, object param)
        {
            toolBarService.AddToolButton("ȷ��", "ȷ��", (int)NineVigor.FrameWork.WinForms.Classes.EnumImageList.J����, true, false, null);
            return toolBarService;
        }
        #endregion

        #region ���������Ӱ�ť�����¼�
        /// <summary>
        /// ���������Ӱ�ť�����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "ȷ��":
                    ReturnCase();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #endregion

        private bool isFoucs = true;

        [Category("�ؼ�����"), Description("�Ƿ�����ת������ true ��, false ��")]
        public bool IsFoucs
        {
            get
            {
                return isFoucs;
            }
            set
            {
                isFoucs = value;
            }
        }

        private void frmReturnCase_Load(object sender, System.EventArgs e)
        {
            /*
            SexHelper.ArrayObject = Neusoft.HISFC.Models.Base.SexEnumService.List();
            this.fpSpread1_Sheet1.GrayAreaBackColor = System.Drawing.Color.White;
            LockFP();
             * */
        }

        enum Cols
        {
            Check, //ѡ�� 
            CaseNO, //������
            StrType,//����
            patientName, //����
            SexID,//�Ա�
            LentType,//��������
            OperTime,//��������
            InpatientNO, //סԺ��ˮ��
            OperNO//�����
        }
        private void LockFP()
        {
            FarPoint.Win.Spread.CellType.TextCellType txtCellType = new FarPoint.Win.Spread.CellType.TextCellType();
            txtCellType.ReadOnly = false;
            this.fpSpread1_Sheet1.Columns[(int)Cols.CaseNO].CellType = txtCellType;
            this.fpSpread1_Sheet1.Columns[(int)Cols.StrType].CellType = txtCellType;
            this.fpSpread1_Sheet1.Columns[(int)Cols.patientName].CellType = txtCellType;
            this.fpSpread1_Sheet1.Columns[(int)Cols.SexID].CellType = txtCellType;
            this.fpSpread1_Sheet1.Columns[(int)Cols.LentType].CellType = txtCellType;
            this.fpSpread1_Sheet1.Columns[(int)Cols.StrType].CellType = txtCellType;
            this.fpSpread1_Sheet1.Columns[(int)Cols.InpatientNO].CellType = txtCellType;
            this.fpSpread1_Sheet1.Columns[(int)Cols.OperTime].CellType = txtCellType;
            this.fpSpread1_Sheet1.Columns[(int)Cols.OperNO].CellType = txtCellType;
        }
        #region ������Ϣ
        /// <summary>
        /// ������Ϣ
        /// </summary>
        /// <param name="list"></param>
        private void AddDateInfo(ArrayList list)
        {
            /*
            this.fpSpread1_Sheet1.RowCount = 0;
            foreach (Neusoft.HISFC.Models.HealthRecord.Lend info in list)
            {
                this.fpSpread1_Sheet1.Rows.Add(0, 1);
                if (info.CaseBase.PatientInfo.Sex.ID != null)
                {
                    this.fpSpread1_Sheet1.Cells[0, (int)Cols.SexID].Text = SexHelper.GetName(info.CaseBase.PatientInfo.Sex.ID.ToString());
                }
                this.fpSpread1_Sheet1.Columns[0, (int)Cols.Check].CellType = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
                this.fpSpread1_Sheet1.Cells[0, (int)Cols.Check].Value = true;
                this.fpSpread1_Sheet1.Cells[0, (int)Cols.CaseNO].Text = info.CaseBase.CaseNO;
                this.fpSpread1_Sheet1.Cells[0, (int)Cols.StrType].Text = info.EmployeeInfo.Name;
                this.fpSpread1_Sheet1.Cells[0, (int)Cols.patientName].Text = info.CaseBase.PatientInfo.Name;

                this.fpSpread1_Sheet1.Cells[0, (int)Cols.LentType].Text = info.LendReason;
               
                this.fpSpread1_Sheet1.Cells[0, (int)Cols.InpatientNO].Text = info.CaseBase.PatientInfo.ID;
                this.fpSpread1_Sheet1.Cells[0, (int)Cols.OperTime].Text = info.OperInfo.OperTime.ToShortDateString();
                this.fpSpread1_Sheet1.Cells[0, (int)Cols.OperNO].Text = info.ID;
                this.fpSpread1_Sheet1.Rows[0].Tag = info;
                this.SetInfo(info);
            }
            Neusoft.HISFC.Components.Common.Classes.Function.DrawCombo(this.fpSpread1_Sheet1, (int)Cols.CaseNO, (int)Cols.StrType);
        */
              }
        #endregion

        #region ��ʾ��Ϣ
        /// <summary>
        /// ��ʾ��Ϣ
        /// </summary>
        /// <param name="obj"></param>
        private void SetInfo(NineVigor.Domain.HealthRecord.Entity.CasLend obj)
        {
            /*
            CardNO.Text = obj.CardNO;
            txName.Text = obj.EmployeeInfo.Name;��
            dtContinue.Value = NineVigor.FrameWork.Function.NConvert.ToDateTime(card.GetSysDate());
            dtReturn.Value = NineVigor.FrameWork.Function.NConvert.ToDateTime(card.GetSysDate());
            txReturn.Text = obj.Memo;
             * */
        }
        #endregion

        private bool ValidState()
        {
            /*
            DateTime nowTime = this.card.GetDateTimeFromSysDateTime();
            
            #region ����
            if (cbContinueLend.Checked)
            {
                if (dtContinue.Value <= nowTime)
                {
                    System.TimeSpan sp = nowTime - dtContinue.Value;
                    if (sp.Days > 0)
                    {
                        MessageBox.Show("�������ڲ���С�ڵ�ǰ����");

                        return false;
                    }
                } 
            }


            #endregion
             * */

            return true;
        }
        #region ����
        private void ReturnCase()
        {

            if (!ValidState())
            {
                return;
            }
            if (!NineVigor.FrameWork.Public.String.ValidMaxLengh(txReturn.Text, 100))
            {
                MessageBox.Show("�黹�������");
                return;
            }
            ArrayList list = GetInfo(); //��ȡ��Ϣ
            if (list == null)
            { 
                return;
            }
            if (list.Count == 0)
            {
                MessageBox.Show("��ѡ����Ҫ�黹�Ĳ���");
                return;
            }
            /*
            Neusoft.FrameWork.Management.PublicTrans.BeginTransaction();

            card.SetTrans(Neusoft.FrameWork.Management.PublicTrans.Trans);

            foreach (Neusoft.HISFC.Models.HealthRecord.Lend obj in list)
            {
                if (card.ReturnCase(obj) < 1)
                {
                    Neusoft.FrameWork.Management.PublicTrans.RollBack();
                    MessageBox.Show("����ʧ��: " + card.Err);
                    return;
                }
            }
            Neusoft.FrameWork.Management.PublicTrans.Commit();
            MessageBox.Show("�����ɹ�");
             * */
            this.ClearInfo();
            this.neuTextBox1.SelectAll();
            
        }
        private void ClearInfo()
        {
            this.fpSpread1_Sheet1.RowCount = 0;
            neuTextBox1.Text = string.Empty;
            this.txName.Text = "";
            CardNO.Text = "";
            txReturn.Text = "";
        }
        private ArrayList GetInfo()
        {
            
            ArrayList list = new ArrayList();
            /*
            for (int i = 0; i < this.fpSpread1_Sheet1.Rows.Count; i++)
            {
                if (this.fpSpread1_Sheet1.Cells[i, (int)Cols.Check].Value == null || fpSpread1_Sheet1.Cells[i, (int)Cols.Check].Value.ToString().ToUpper() != "TRUE")
                {
                    continue;
                }
                Neusoft.HISFC.Models.HealthRecord.Lend obj = (Neusoft.HISFC.Models.HealthRecord.Lend)fpSpread1_Sheet1.Rows[i].Tag;
                if (obj == null)
                {
                    MessageBox.Show("��ȡ������Ϣ����");
                    return null;
                }
                #region  У��
                for (int j = 0; j < this.fpSpread1_Sheet1.Rows.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (fpSpread1_Sheet1.Cells[i, (int)Cols.CaseNO].Text == fpSpread1_Sheet1.Cells[j, (int)Cols.CaseNO].Text)
                    {
                        if (this.fpSpread1_Sheet1.Cells[j, (int)Cols.Check].Value == null)
                        {
                            MessageBox.Show("��������ͬ�ı���ȫ��ѡ��");
                            return null;
                        }
                        if (this.fpSpread1_Sheet1.Cells[j, (int)Cols.Check].Value.ToString().ToUpper() != "TRUE")
                        {
                            MessageBox.Show("��������ͬ�ı���ȫ��ѡ��");
                            return null;
                        }
                    }
                }
                #endregion 
                if (cbContinueLend.Checked) //����
                {
                    obj.PrerDate = dtContinue.Value;
                    string[] aa = obj.ID.Split('-');
                    if (aa != null && aa.Length > 0)
                    {
                        obj.ID = aa[0];
                    }
                }
                else if (cbReturn.Checked) //����
                {
                    obj.ReturnDate = dtReturn.Value; //ʵ�ʷ���ʱ�� 
                    obj.ReturnOperInfo.ID = card.Operator.ID;  //��������Ա
                    obj.LendStus = "2"; //״̬ 
                    obj.Memo = this.txReturn.Text; //�Ƿ���� 
                    string[] aa = obj.ID.Split('-');
                    if (aa != null && aa.Length > 0)
                    {
                        obj.ID = aa[0];
                    }
                }
                else
                {
                    obj.LendStus = "1"; //״̬ 
                }
             
                list.Add(obj);
            }
             * * */
            return list;
        }
        #endregion

        #region �س��¼�

        private void cbReturn_CheckedChanged(object sender, System.EventArgs e)
        {
            this.dtReturn.Enabled = this.cbReturn.Checked;

            cbContinueLend.Checked = !cbReturn.Checked;
        }

        private void cbContinueLend_CheckedChanged(object sender, System.EventArgs e)
        {
            this.dtContinue.Enabled = this.cbContinueLend.Checked;
            cbReturn.Checked = !cbContinueLend.Checked;
        }
        private void CardNO_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            /*
            if (e.KeyData == Keys.Enter)
            {
                if (this.CardNO.Text == "")
                {
                    MessageBox.Show("�����뿨��");
                    return;
                }
                LendList = null;
                LendList = this.card.QueryLendInfo(this.CardNO.Text);
                if (LendList == null)
                {
                    CardNO.SelectAll();
                    MessageBox.Show("��ѯ������Ϣ����");
                    return;
                }
                if (LendList.Count == 0)
                {
                    CardNO.SelectAll();
                    MessageBox.Show("û�в鵽��δ�黹�Ľ�����Ϣ");
                    return;
                }

                AddDateInfo(LendList);
                this.cbContinueLend.Focus();
            }
             * */
        }
        private void cbContinueLend_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == e.KeyData)
            {
                if (this.cbContinueLend.Checked)
                {
                    this.dtContinue.Focus();
                }
                else
                {
                    this.dtReturn.Focus();
                }
            }
        }

        private void cbReturn_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == e.KeyData)
            {
                if (this.cbReturn.Checked)
                {
                    this.dtReturn.Focus();
                }
                else
                {
                    this.dtContinue.Focus();
                }
            }
        }

        private void dtContinue_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.txReturn.Focus();
            }
        }

        #endregion

        private void neuTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyData == Keys.Enter)
            {
                if (this.neuTextBox1.Text == "")
                {
                    MessageBox.Show("�����벡����");
                    return;
                }
                string patienNo = string.Empty;
                if (this.neuTextBox1.Text.Trim().Length > 10)
                {
                    patienNo = this.neuTextBox1.Text.Trim();
                }
                else
                {
                    patienNo = "ZY01" + this.neuTextBox1.Text.PadLeft(10, '0');
                }
                LendList = null;
                LendList = this.card.QueryLendInfoByPatientNo(patienNo);
                if (LendList == null || LendList.Count == 0)
                {
                    patienNo = "ZY01J" + this.neuTextBox1.Text.PadLeft(9, '0');
                    LendList = this.card.QueryLendInfoByPatientNo(patienNo);
                    if (LendList == null)
                    {
                        neuTextBox1.SelectAll();
                        MessageBox.Show("��ѯ������Ϣ����");
                        return;
                    }
                   
                }
                if (LendList.Count == 0)
                {
                    neuTextBox1.SelectAll();
                    MessageBox.Show("û�в鵽��δ�黹�Ľ�����Ϣ");
                    return;
                }
                this.neuTextBox1.Text = patienNo.Substring(4);
                AddDateInfo(LendList);

                if (IsFoucs)
                {
                    this.cbContinueLend.Focus();
                }
            }*/
        }
    }
}
