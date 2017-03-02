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
    
    /// <summary>
    /// ucBorrowCase
    /// [��������: ��������]
    /// [�� �� ��: ��־��]
    /// [����ʱ��: 2012-03-17]
    /// <�޸ļ�¼ 
    ///		�޸���='' 
    ///		�޸�ʱ��='yyyy-mm-dd' 
    ///		�޸�Ŀ��=''
    ///		�޸�����=''
    ///		/>
    /// </summary>
    public partial class ucBorrowCase : NineVigor.FrameWork.WinForms.Controls.ucBaseControl
    {
        public ucBorrowCase()
        {
            InitializeComponent();
        }


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
            toolBarService.AddToolButton("����", "����", (int)NineVigor.FrameWork.WinForms.Classes.EnumImageList.J���, true, false, null);
            toolBarService.AddToolButton("ɾ��", "ɾ��", (int)NineVigor.FrameWork.WinForms.Classes.EnumImageList.Sɾ��, true, false, null);
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
                case "����":
                    LendCase();
                    break;
                case "ɾ��":
                    {
                        DeleteLend();
                        break;
                    }
                default:
                    break;
            }
        }
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

        #endregion

        #region ȫ�ֱ���
        NineVigor.FrameWork.Public.ObjectHelper deptHelper = new NineVigor.FrameWork.Public.ObjectHelper();
        Hashtable ht = new Hashtable();
        private System.Data.DataTable dt = null;
        private ArrayList Caselist = null;
        
        //����
        NineVigor.FrameWork.Public.ObjectHelper NationalHelper = new NineVigor.FrameWork.Public.ObjectHelper();
        //�Ա�
        NineVigor.FrameWork.Public.ObjectHelper SexHelper = new NineVigor.FrameWork.Public.ObjectHelper();
        //����
        NineVigor.FrameWork.Public.ObjectHelper DeptHelper = new NineVigor.FrameWork.Public.ObjectHelper();

        private string inpationNo = string.Empty;
        #endregion

        /// <summary>
        /// ���
        /// </summary>
        private void LendCase()
        {
            /*
            Neusoft.HISFC.Models.HealthRecord.Lend obj = GetLendInfo();
            Neusoft.FrameWork.Management.PublicTrans.BeginTransaction();
            card.SetTrans(Neusoft.FrameWork.Management.PublicTrans.Trans);

            if (obj == null)
            {
                return;
            }
            if (ValidState(obj) == -1)
            {
                return;
            }
            if (card.LendCase(obj) < 1)
            {
                Neusoft.FrameWork.Management.PublicTrans.RollBack();
                MessageBox.Show("������ļ�¼ʧ��: " + card.Err);
                return;
            }
            Neusoft.FrameWork.Management.PublicTrans.Commit();
            MessageBox.Show("���ĳɹ�");
            */
            this.ClearCase();
            Query();
           // this.caseNo.Focus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void caseNo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                /*
                try
                {
                    string temIp = caseNo.Text;
                    if (this.caseNo.Text == "")
                    {
                        this.caseNo.Focus();
                        MessageBox.Show("�����벡����");
                        return;
                    }
                    if (caseNo.Text.Trim().Length > 10)
                    {
                        caseNo.Text = temIp.Substring(4);
                        inpationNo = temIp;
                    }
                    else
                    {
                        caseNo.Text = temIp.PadLeft(10, '0');
                        inpationNo = string.Empty;
                    }
                    Caselist = null;
                    Caselist = baseDml.QueryCaseBaseInfoByCaseNO(this.caseNo.Text);
                    if (Caselist == null || Caselist.Count == 0)
                    {
                        if (temIp.Length < 10)
                        {
                            caseNo.Text = "J" + temIp.PadLeft(9, '0');
                        }
                        Caselist = baseDml.QueryCaseBaseInfoByCaseNO(this.caseNo.Text);
                        if (Caselist == null || Caselist.Count == 0)
                        {
                            if (MessageBox.Show("�ɲ�����Ϣ�Ƿ���Ҫ�ֹ�¼�������Ϣ", "������ʾ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                int intCount1 = idm.GetLendStatusByInpationNo("ZY01" + caseNo.Text);
                                if (intCount1 > 0)
                                {
                                    this.caseNo.SelectAll();
                                    MessageBox.Show("�ò����Ѿ����.");
                                    return;
                                }
                                this.txName.Focus();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("�޴˲�����Ϣ��");
                                return;
                            }
                        }
                    }
                    //�ж��Ƿ��Ѿ������ 
                    int intCount = 0;
                    if (string.IsNullOrEmpty(inpationNo))
                    {
                        intCount = idm.GetLendStatusByInpationNo("ZY01" + caseNo.Text);
                    }
                    else
                    {
                        intCount = idm.GetLendStatusByInpationNo(inpationNo);
                    }
                    if (intCount > 0)
                    {
                        this.caseNo.SelectAll();
                        MessageBox.Show("�ò����Ѿ����.");
                        return;
                    }

                    SetLoadInfo();
                    // this.AddCaseInfo(Caselist);
                    if (IsFoucs)
                    {
                        this.cListBempNo.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }*/
            }
        }
        /// <summary>
        /// ����������Ϣ
        /// </summary>
        private enum Cols
        {
            caseNO,//������
            strName,//����
            sexName,//�Ա�
            nationName,//����
            birthday,//����
            birthArea,//������
            linkPhone,//��ϵ�绰
            linkArea//��ϵ��ַ
        }
        /// <summary>
        /// ������ϸ��Ϣ
        /// </summary>
        private enum DetailCos
        {
            InpatientNO, //סԺ��ˮ��
            patientNO,//סԺ��
            caseNO,//������
            strName,//����
            deptIN, //��Ժ����
            dateIN,//��Ժ����
            DeptOut,//��Ժ����
            dateOut //��Ժ����
        }
        /// <summary>
        /// ���ز�����Ϣ
        /// </summary>
        /// <param name="Caselist"></param>
        /// <returns></returns>
        private int AddCaseInfo(ArrayList Caselist)
        {
            /*
            #region ���ز���������Ϣ
            Neusoft.HISFC.Models.HealthRecord.Base info = (Neusoft.HISFC.Models.HealthRecord.Base)Caselist[0];
            for (int i = 0; i < this.caseMain.RowCount; i++)
            {
                if (caseMain.Cells[i, (int)Cols.caseNO].Text == info.CaseNO)
                {
                    return 1;
                }
            }
            txName.Text = info.PatientInfo.Name;

            this.caseMain.Rows.Add(0, 1);
            this.caseMain.Cells[0, (int)Cols.caseNO].Text = info.CaseNO;
            this.caseMain.Cells[0, (int)Cols.strName].Text = info.PatientInfo.Name;
            if (info.PatientInfo.Sex.ID != null)
            {
                this.cl_Sex.Tag = info.PatientInfo.Sex.ID;
                this.caseMain.Cells[0, (int)Cols.sexName].Text = SexHelper.GetName(info.PatientInfo.Sex.ID.ToString()); //�Ա�
            }
            this.caseMain.Cells[0, (int)Cols.nationName].Text = NationalHelper.GetName(info.PatientInfo.Nationality.ID);//����
            this.caseMain.Cells[0, (int)Cols.birthArea].Text = info.PatientInfo.AreaCode;//������
            this.caseMain.Cells[0, (int)Cols.birthday].Text = info.PatientInfo.Birthday.ToShortDateString(); //����
            this.caseMain.Cells[0, (int)Cols.linkArea].Text = info.PatientInfo.Kin.RelationAddress;//��ϵ��ַ
            this.caseMain.Cells[0, (int)Cols.linkPhone].Text = info.PatientInfo.Kin.RelationPhone;//��ϵ�绰
            this.caseMain.Rows[0].Tag = info;
            #endregion
             * */
            return 1;
        }
        /// <summary>
        /// ��ֵ
        /// </summary>
        /// <param name="info"></param>
        private void SetInfo(NineVigor.Domain.HealthRecord.Entity.CasBase info)
        {
            /*
            if (info.PatientInfo.Sex.ID != null)
            {
                cl_Sex.Tag = info.PatientInfo.Sex.ID;//
            }
            caseNo.Text = info.CaseNO;
            txName.Text = info.PatientInfo.Name;

            txDeptIn.Text = info.InDept.Name;
            txDeptOut.Text = info.OutDept.ID;
            dtInDate.Text = info.PatientInfo.PVisit.InTime.ToString();
            dtOutDate.Text = info.PatientInfo.PVisit.OutTime.ToString();
            dtBirthDate.Text = info.PatientInfo.Birthday.ToString();
             * */
        }
        /// <summary>
        /// ��ղ�����Ϣ
        /// </summary>
        private void ClearCase()
        {
            /*
            caseNo.Text = "";
            txName.Text = "";
            this.cl_Sex.Text = "";
            txDeptIn.Text = "";
            txDeptOut.Text = "";
            dtInDate.Text = "";
            dtOutDate.Text = "";
            dtBirthDate.Text = "";
             * */
            if (dt != null)
            {
                dt.Clear();
            }
        }
        private void frmLendCard_Load(object sender, System.EventArgs e)
        {
            /*
            LockFp();
            Neusoft.HISFC.BizLogic.Manager.Person person = new Neusoft.HISFC.BizLogic.Manager.Person();
            Neusoft.HISFC.BizProcess.Integrate.Manager managerMgr = new Neusoft.HISFC.BizProcess.Integrate.Manager();
            //��ȡ��Ա�б�
            IComparer myComparer = new NorthChina.HealthRecord.Components.CaseFirstPageNew.EmplCompareReverse();
            ArrayList DoctorList = person.GetEmployeeAll();
            DoctorList.Sort(myComparer);
            Neusoft.HISFC.BizLogic.Manager.Department dep = new Neusoft.HISFC.BizLogic.Manager.Department();
            deptHelper.ArrayObject = dep.GetDeptmentAll();

            

            ArrayList tepArr = new ArrayList();
            foreach (Neusoft.HISFC.Models.Base.Employee item in DoctorList)
            {
                ht.Add(item.ID, item.Dept.ID);
                item.Memo = deptHelper.GetName(item.Dept.ID);
                tepArr.Add(item);
            }
            cListBempNo.AddItems(DoctorList);

            #region  ��ȡ�Ա��б�
            ArrayList listSexPart = new ArrayList();

            Neusoft.FrameWork.Models.NeuObject neuObjecSex1 = new Neusoft.FrameWork.Models.NeuObject();
            Neusoft.FrameWork.Models.NeuObject neuObjecSex2 = new Neusoft.FrameWork.Models.NeuObject();
            Neusoft.FrameWork.Models.NeuObject neuObjecSex3 = new Neusoft.FrameWork.Models.NeuObject();

            neuObjecSex1.ID = "F";
            neuObjecSex1.Name = "Ů";
            listSexPart.Insert(0, neuObjecSex1);
            neuObjecSex2.ID = "M";
            neuObjecSex2.Name = "��";
            listSexPart.Insert(1, neuObjecSex2);
            neuObjecSex3.ID = "U";
            neuObjecSex3.Name = "����";
            listSexPart.Insert(2, neuObjecSex3);
            this.cl_Sex.AddItems(listSexPart);
            #endregion

            #region ���ý���ԭ��
            ArrayList lendReason = con.GetList("Lend_Reason");
            cListBoxResonan.AddItems(lendReason);
            #endregion
            Query();
             * */
        }
        /// <summary>
        /// 
        /// </summary>
        private void LockFp()
        {
            FarPoint.Win.Spread.CellType.TextCellType txtCellType = new FarPoint.Win.Spread.CellType.TextCellType();
           
            this.caseDetail.GrayAreaBackColor = System.Drawing.Color.White;
            this.caseDetail.Columns[0].CellType = txtCellType;
            this.caseDetail.Columns[1].CellType = txtCellType;
            this.caseDetail.Columns[2].CellType = txtCellType;
            this.caseDetail.Columns[3].CellType = txtCellType;
            this.caseDetail.Columns[4].CellType = txtCellType;
            this.caseDetail.Columns[5].CellType = txtCellType;
            this.caseDetail.Columns[6].CellType = txtCellType;
            this.caseDetail.Columns[7].CellType = txtCellType;
            this.caseDetail.Columns[8].CellType = txtCellType;
            this.caseDetail.Columns[9].CellType = txtCellType;
            this.caseDetail.Columns[10].CellType = txtCellType;
            this.caseDetail.Columns[11].CellType = txtCellType;



            this.caseDetail.Columns[0].Width = 100;
            this.caseDetail.Columns[1].Width = 80;
            this.caseDetail.Columns[2].Width = 50;
            this.caseDetail.Columns[3].Width = 50;
            this.caseDetail.Columns[4].Width = 150;
            this.caseDetail.Columns[5].Width = 100;
            this.caseDetail.Columns[6].Width = 70;
            this.caseDetail.Columns[7].Width =70;
            this.caseDetail.Columns[8].Width = 50;
            this.caseDetail.Columns[9].Width = 70;
            this.caseDetail.Columns[10].Width = 150;
            this.caseDetail.Columns[11].Width = 150;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private int ValidState(NineVigor.Domain.HealthRecord.Entity.CasLend obj)
        {
            /*
            if (string.IsNullOrEmpty(caseNo.Text))
            {
                MessageBox.Show("��������Ŀ���");
                return -1;
            }
            //�ж��Ƿ��Ѿ������
            int intCount = 0;
            if (string.IsNullOrEmpty(inpationNo))
            {
                intCount = idm.GetLendStatusByInpationNo("ZY01" + caseNo.Text);
            }
            else
            {
                intCount = idm.GetLendStatusByInpationNo(inpationNo);
            }
            if (intCount > 0)
            {
                this.caseNo.SelectAll();
                MessageBox.Show("�ò����Ѿ����.");
                return -1;
            }
            if (string.IsNullOrEmpty(txName.Text))
            {
                MessageBox.Show("��������Ĳ����Ĳ��˵�����");
                this.txName.Focus();
                return -1;
            }
            if (string.IsNullOrEmpty(cl_Sex.Text) || string.IsNullOrEmpty(cl_Sex.Tag.ToString()))
            {
                MessageBox.Show("��������Ĳ����Ĳ����Ա�");
                this.cl_Sex.Focus();
                return -1;
            }
          
            if (string.IsNullOrEmpty(cListBoxResonan.Text))
            {
                MessageBox.Show("���������ԭ��");
                this.cListBoxResonan.Focus();
                return -1;
            }

            if (string.IsNullOrEmpty(cListBempNo.Text))
            {
                MessageBox.Show("����������˹���");
                this.cListBempNo.Focus();
                return -1;
            }
             * */
            return 1;
        }
        #region ��ȡ������Ϣ

        /// <summary>
        /// 
        /// </summary>
        private void SetLoadInfo()
        {
            /*
            string inpatientOldNo = string.Empty;
            string inpatientNewNo = string.Empty;
            if (string.IsNullOrEmpty(inpationNo))
            {
                inpatientOldNo = "ZY01" + "J" + this.caseNo.Text.PadLeft(9, '0');
                inpatientNewNo = "ZY01" + this.caseNo.Text.PadLeft(10, '0');
            }
            else
            {
                inpatientNewNo = inpationNo;
            }
            Neusoft.HISFC.Models.HealthRecord.Base tempObj = new Neusoft.HISFC.Models.HealthRecord.Base();
            Neusoft.HISFC.Models.HealthRecord.Base tempObj1 = this.baseDml.GetCaseBaseInfo(inpatientNewNo);
            Neusoft.HISFC.Models.HealthRecord.Base tempObj2 = this.baseDml.GetCaseBaseInfo(inpatientOldNo);

            if (tempObj1 != null)
                tempObj = tempObj1;
            else
                tempObj = tempObj2;

            if (tempObj != null)
            {
                SetInfo(tempObj);
            }
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private NineVigor.Domain.HealthRecord.Entity.CasLend GetLendInfo()
        {
            NineVigor.Domain.HealthRecord.Entity.CasLend saveinfo = new NineVigor.Domain.HealthRecord.Entity.CasLend();
            /*
            string inpatientOldNo = string.Empty;
            string inpatientNewNo = string.Empty;
            if (string.IsNullOrEmpty(inpationNo))
            {
                inpatientOldNo = "ZY01" + "J" + this.caseNo.Text.PadLeft(9, '0');
                inpatientNewNo = "ZY01" + this.caseNo.Text.PadLeft(10, '0');
            }
            else
            {
                inpatientNewNo = inpationNo;
            }


            Neusoft.HISFC.Models.HealthRecord.Base tempObj = new Neusoft.HISFC.Models.HealthRecord.Base();
            Neusoft.HISFC.Models.HealthRecord.Base tempObj1 = this.baseDml.GetCaseBaseInfo(inpatientNewNo);
            Neusoft.HISFC.Models.HealthRecord.Base tempObj2 = this.baseDml.GetCaseBaseInfo(inpatientOldNo);
            Neusoft.HISFC.Models.HealthRecord.Lend Saveinfo = new Neusoft.HISFC.Models.HealthRecord.Lend();
            if (!string.IsNullOrEmpty(tempObj1.PatientInfo.ID))
                tempObj = tempObj1;
            else
                tempObj = tempObj2;

            if (!string.IsNullOrEmpty(tempObj.PatientInfo.ID))
            {
                Saveinfo.SeqNO = this.card.GetSequence("Case.CaseCard.LendCase.Seq");
                if (Saveinfo.SeqNO == null || Saveinfo.SeqNO == "")
                {
                    MessageBox.Show("��ȡ���ʧ��");
                    return null;
                }

               
                Saveinfo.CaseBase.PatientInfo.ID = tempObj.PatientInfo.ID;//סԺ��ˮ��
                Saveinfo.CaseBase.CaseNO = tempObj.CaseNO;//����סԺ�� 
                Saveinfo.CaseBase.PatientInfo.Name = tempObj.PatientInfo.Name; //��������
                Saveinfo.CaseBase.PatientInfo.Sex.ID = tempObj.PatientInfo.Sex.ID;//�Ա�
                Saveinfo.CaseBase.PatientInfo.Birthday = tempObj.PatientInfo.Birthday;//��������
                Saveinfo.CaseBase.PatientInfo.PVisit.InTime = tempObj.PatientInfo.PVisit.InTime;//��Ժ����
                Saveinfo.CaseBase.PatientInfo.PVisit.OutTime = tempObj.PatientInfo.PVisit.OutTime;//��Ժ����
                Saveinfo.CaseBase.InDept.ID = tempObj.InDept.ID; //��Ժ���Ҵ���
                Saveinfo.CaseBase.InDept.Name = tempObj.InDept.Name; //��Ժ��������
                Saveinfo.CaseBase.OutDept.ID = tempObj.OutDept.ID;  //��Ժ���Ҵ���
                Saveinfo.CaseBase.OutDept.Name = tempObj.OutDept.Name; //��Ժ��������
                if (this.cListBempNo.Tag != null)
                {
                    Saveinfo.EmployeeInfo.ID = this.cListBempNo.Tag.ToString();//�����˴���
                }
                Saveinfo.EmployeeInfo.Name = this.cListBempNo.Text;//����������

                try
                {
                    Saveinfo.EmployeeDept.ID = ht[Saveinfo.EmployeeInfo.ID].ToString(); //���������ڿ��Ҵ���
                    Saveinfo.EmployeeDept.Name = deptHelper.GetName(Saveinfo.EmployeeDept.ID); //���������ڿ�������
                }
                catch (Exception ex)
                {

                }
                Saveinfo.LendDate = Neusoft.FrameWork.Function.NConvert.ToDateTime(baseDml.GetSysDateTime()); //��������
                Saveinfo.PrerDate = txReturnTime.Value; //Ԥ������

                //ʡҽĬ��д�� �ڽ�
                Saveinfo.LendKind = "1"; ; //��������

                Saveinfo.LendStus = "1"; ;//����״̬ 1���/2����
                Saveinfo.ID = baseDml.Operator.ID; //����Ա����
                Saveinfo.OperInfo.OperTime = Neusoft.FrameWork.Function.NConvert.ToDateTime(baseDml.GetSysDateTime()); //����ʱ��
                Saveinfo.ReturnOperInfo.ID = "";   //�黹����Ա����
                Saveinfo.ReturnDate = Neusoft.FrameWork.Function.NConvert.ToDateTime("3000-1-1");   //ʵ�ʹ黹����
                Saveinfo.CardNO = Saveinfo.EmployeeInfo.ID;//����
                //��ע-����ԭ��-�绰
                Saveinfo.Remark = this.neuTextBox1.Text;
                if (cListBoxResonan.Tag != null)
                {
                    Saveinfo.LendReason = cListBoxResonan.Tag.ToString();
                }
                Saveinfo.EmplTel = this.neuTxbTelphone.Text;
            }
            else
            {
                Saveinfo.SeqNO = this.card.GetSequence("Case.CaseCard.LendCase.Seq");
                if (Saveinfo.SeqNO == null || Saveinfo.SeqNO == "")
                {
                    MessageBox.Show("��ȡ���ʧ��");
                    return null;
                }
                Saveinfo.LendDate = Neusoft.FrameWork.Function.NConvert.ToDateTime(baseDml.GetSysDateTime()); //��������
                Saveinfo.PrerDate = txReturnTime.Value; //Ԥ������
                if (this.cListBempNo.Tag != null)
                {
                    Saveinfo.EmployeeInfo.ID = this.cListBempNo.Tag.ToString();//�����˴���
                }
                Saveinfo.EmployeeInfo.Name = this.cListBempNo.Text;//����������
                try
                {
                    Saveinfo.EmployeeDept.ID = ht[Saveinfo.EmployeeInfo.ID].ToString(); //���������ڿ��Ҵ���
                    Saveinfo.EmployeeDept.Name = deptHelper.GetName(Saveinfo.EmployeeDept.ID); //���������ڿ�������
                }
                catch (Exception ex)
                {

                }

                Saveinfo.CaseBase.CaseNO = this.caseNo.Text;
                //ʡҽĬ��д�� �ڽ�
                Saveinfo.LendKind = "1"; ; //��������

                Saveinfo.LendStus = "1"; ;//����״̬ 1���/2����
                Saveinfo.ID = baseDml.Operator.ID; //����Ա����
                Saveinfo.OperInfo.OperTime = Neusoft.FrameWork.Function.NConvert.ToDateTime(baseDml.GetSysDateTime()); //����ʱ��
                Saveinfo.ReturnOperInfo.ID = "";   //�黹����Ա����
                Saveinfo.ReturnDate = Neusoft.FrameWork.Function.NConvert.ToDateTime("3000-1-1");   //ʵ�ʹ黹����
                Saveinfo.CardNO = Saveinfo.EmployeeInfo.ID;//����
                
                if (string.IsNullOrEmpty(inpationNo))
                {
                    Saveinfo.CaseBase.PatientInfo.ID = "ZY01" + caseNo.Text.Trim();//סԺ��ˮ��
                }
                else
                {
                    Saveinfo.CaseBase.PatientInfo.ID =inpationNo;//סԺ��ˮ��
                }

                Saveinfo.CaseBase.PatientInfo.Name = this.txName.Text; //��������
                if (this.cl_Sex.Tag != null)
                {
                    Saveinfo.CaseBase.PatientInfo.Sex.ID = this.cl_Sex.Tag.ToString();//�Ա�
                }

                Saveinfo.Remark = this.neuTextBox1.Text;
                if (cListBoxResonan.Tag != null)
                {
                    Saveinfo.LendReason = cListBoxResonan.Tag.ToString();
                }
                Saveinfo.EmplTel = this.neuTxbTelphone.Text;
            }
             * */
            return saveinfo;
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comType_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.txReturnTime.Focus();
            }
        }

        private void Query()
        { 
            /*
            DataTable dt=idm.GetLendInfo();
            caseDetail.DataSource = dt.DefaultView;
            LockFp();*/
        }
        private void caseNo_Enter(object sender, EventArgs e)
        {
           // this.caseNo.SelectAll();
        }


        private void fpSpread2_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            /*
            this.caseDetail.RowCount = 0;
            if (this.caseMain.Rows.Count == 0)
            {
                return;
            }
            Neusoft.HISFC.Models.HealthRecord.Base PatientCaseInfo = (Neusoft.HISFC.Models.HealthRecord.Base)this.caseMain.Rows[this.caseMain.ActiveRowIndex].Tag;
            SetInfo(PatientCaseInfo);
            ArrayList tempList = this.baseDml.QueryCaseBaseInfoByCaseNO(PatientCaseInfo.CaseNO);

            #region ���ز�����ϸ��Ϣ
            foreach (Neusoft.HISFC.Models.HealthRecord.Base obj in tempList)
            {
                this.caseDetail.Rows.Add(0, 1);
                this.caseDetail.Cells[0, (int)DetailCos.InpatientNO].Text = obj.PatientInfo.ID;//סԺ��ˮ��
                this.caseDetail.Cells[0, (int)DetailCos.patientNO].Text = obj.PatientInfo.PID.PatientNO;//סԺ��
                this.caseDetail.Cells[0, (int)DetailCos.caseNO].Text = obj.CaseNO;//������
                this.caseDetail.Cells[0, (int)DetailCos.strName].Text = obj.PatientInfo.Name;
                this.caseDetail.Cells[0, (int)DetailCos.deptIN].Text = obj.InDept.Name;//��Ժ����
                this.caseDetail.Cells[0, (int)DetailCos.dateIN].Text = obj.PatientInfo.PVisit.InTime.ToShortDateString();//��Ժ����
                this.caseDetail.Cells[0, (int)DetailCos.DeptOut].Text = obj.OutDept.Name;//��Ժ����
                this.caseDetail.Cells[0, (int)DetailCos.dateOut].Text = obj.PatientInfo.PVisit.OutTime.ToShortDateString();//��Ժ����
                this.caseDetail.Rows[0].Tag = obj;
            }
            #endregion
            */
            
        }

        private void DeleteLend()
        {
            /*
            if (this.caseMain.Rows.Count > 0)
            {
                this.caseMain.Rows.Remove(this.caseMain.ActiveRowIndex, 1);
            }
             * */
        }

        private void txName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
               // cl_Sex.Focus();
               // cl_Sex.SelectAll();
            }
        }

        private void cListBempNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txReturnTime.Focus();
            }
        }

        private void cl_Sex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cListBempNo.Focus();
                cListBempNo.SelectAll();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txReturnTime_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                neuTxbTelphone.Focus();
                neuTxbTelphone.SelectAll();
            }
        }
        private void neuTxbTelphone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cListBoxResonan.Focus();
                cListBoxResonan.SelectAll();
            }

        }

        private void cListBoxResonan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                neuTextBox1.Focus();
                neuTextBox1.SelectAll();
            }
        }
    }
}
