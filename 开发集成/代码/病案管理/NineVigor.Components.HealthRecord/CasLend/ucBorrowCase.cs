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
    /// [功能描述: 病案借阅]
    /// [创 建 者: 冯志欣]
    /// [创建时间: 2012-03-17]
    /// <修改记录 
    ///		修改人='' 
    ///		修改时间='yyyy-mm-dd' 
    ///		修改目的=''
    ///		修改描述=''
    ///		/>
    /// </summary>
    public partial class ucBorrowCase : NineVigor.FrameWork.WinForms.Controls.ucBaseControl
    {
        public ucBorrowCase()
        {
            InitializeComponent();
        }


        #region 工具栏信息

        /// <summary>
        /// 定义工具栏服务
        /// </summary>
        protected NineVigor.FrameWork.WinForms.Forms.ToolBarService toolBarService = new NineVigor.FrameWork.WinForms.Forms.ToolBarService();
        
        #region 初始化工具栏
        /// <summary>
        /// 初始化工具栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="neuObject"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        protected override NineVigor.FrameWork.WinForms.Forms.ToolBarService OnInit(object sender, object neuObject, object param)
        {
            toolBarService.AddToolButton("借阅", "借阅", (int)NineVigor.FrameWork.WinForms.Classes.EnumImageList.J借出, true, false, null);
            toolBarService.AddToolButton("删除", "删除", (int)NineVigor.FrameWork.WinForms.Classes.EnumImageList.S删除, true, false, null);
            return toolBarService;
        }
        #endregion

        #region 工具栏增加按钮单击事件
        /// <summary>
        /// 工具栏增加按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "借阅":
                    LendCase();
                    break;
                case "删除":
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

        [Category("控件设置"), Description("是否光标跳转到工号 true 是, false 否")]
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

        #region 全局变量
        NineVigor.FrameWork.Public.ObjectHelper deptHelper = new NineVigor.FrameWork.Public.ObjectHelper();
        Hashtable ht = new Hashtable();
        private System.Data.DataTable dt = null;
        private ArrayList Caselist = null;
        
        //民族
        NineVigor.FrameWork.Public.ObjectHelper NationalHelper = new NineVigor.FrameWork.Public.ObjectHelper();
        //性别
        NineVigor.FrameWork.Public.ObjectHelper SexHelper = new NineVigor.FrameWork.Public.ObjectHelper();
        //科室
        NineVigor.FrameWork.Public.ObjectHelper DeptHelper = new NineVigor.FrameWork.Public.ObjectHelper();

        private string inpationNo = string.Empty;
        #endregion

        /// <summary>
        /// 借出
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
                MessageBox.Show("插入借阅记录失败: " + card.Err);
                return;
            }
            Neusoft.FrameWork.Management.PublicTrans.Commit();
            MessageBox.Show("借阅成功");
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
                        MessageBox.Show("请输入病案号");
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
                            if (MessageBox.Show("旧病案信息是否需要手工录入借阅信息", "病案提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                int intCount1 = idm.GetLendStatusByInpationNo("ZY01" + caseNo.Text);
                                if (intCount1 > 0)
                                {
                                    this.caseNo.SelectAll();
                                    MessageBox.Show("该病案已经借出.");
                                    return;
                                }
                                this.txName.Focus();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("无此病案信息！");
                                return;
                            }
                        }
                    }
                    //判断是否已经借出了 
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
                        MessageBox.Show("该病案已经借出.");
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
        /// 病案基本信息
        /// </summary>
        private enum Cols
        {
            caseNO,//病案号
            strName,//姓名
            sexName,//性别
            nationName,//民族
            birthday,//生日
            birthArea,//出生地
            linkPhone,//联系电话
            linkArea//联系地址
        }
        /// <summary>
        /// 病案详细信息
        /// </summary>
        private enum DetailCos
        {
            InpatientNO, //住院流水号
            patientNO,//住院号
            caseNO,//病案号
            strName,//姓名
            deptIN, //入院科室
            dateIN,//入院日期
            DeptOut,//出院科室
            dateOut //出院日期
        }
        /// <summary>
        /// 加载病案信息
        /// </summary>
        /// <param name="Caselist"></param>
        /// <returns></returns>
        private int AddCaseInfo(ArrayList Caselist)
        {
            /*
            #region 加载病案基本信息
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
                this.caseMain.Cells[0, (int)Cols.sexName].Text = SexHelper.GetName(info.PatientInfo.Sex.ID.ToString()); //性别
            }
            this.caseMain.Cells[0, (int)Cols.nationName].Text = NationalHelper.GetName(info.PatientInfo.Nationality.ID);//民族
            this.caseMain.Cells[0, (int)Cols.birthArea].Text = info.PatientInfo.AreaCode;//出生地
            this.caseMain.Cells[0, (int)Cols.birthday].Text = info.PatientInfo.Birthday.ToShortDateString(); //生日
            this.caseMain.Cells[0, (int)Cols.linkArea].Text = info.PatientInfo.Kin.RelationAddress;//联系地址
            this.caseMain.Cells[0, (int)Cols.linkPhone].Text = info.PatientInfo.Kin.RelationPhone;//联系电话
            this.caseMain.Rows[0].Tag = info;
            #endregion
             * */
            return 1;
        }
        /// <summary>
        /// 赋值
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
        /// 清空病案信息
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
            //获取人员列表
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

            #region  获取性别列表
            ArrayList listSexPart = new ArrayList();

            Neusoft.FrameWork.Models.NeuObject neuObjecSex1 = new Neusoft.FrameWork.Models.NeuObject();
            Neusoft.FrameWork.Models.NeuObject neuObjecSex2 = new Neusoft.FrameWork.Models.NeuObject();
            Neusoft.FrameWork.Models.NeuObject neuObjecSex3 = new Neusoft.FrameWork.Models.NeuObject();

            neuObjecSex1.ID = "F";
            neuObjecSex1.Name = "女";
            listSexPart.Insert(0, neuObjecSex1);
            neuObjecSex2.ID = "M";
            neuObjecSex2.Name = "男";
            listSexPart.Insert(1, neuObjecSex2);
            neuObjecSex3.ID = "U";
            neuObjecSex3.Name = "其它";
            listSexPart.Insert(2, neuObjecSex3);
            this.cl_Sex.AddItems(listSexPart);
            #endregion

            #region 设置借阅原因
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
                MessageBox.Show("请输入借阅卡号");
                return -1;
            }
            //判断是否已经借出了
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
                MessageBox.Show("该病案已经借出.");
                return -1;
            }
            if (string.IsNullOrEmpty(txName.Text))
            {
                MessageBox.Show("请输入借阅病案的病人的姓名");
                this.txName.Focus();
                return -1;
            }
            if (string.IsNullOrEmpty(cl_Sex.Text) || string.IsNullOrEmpty(cl_Sex.Tag.ToString()))
            {
                MessageBox.Show("请输入借阅病案的病人性别");
                this.cl_Sex.Focus();
                return -1;
            }
          
            if (string.IsNullOrEmpty(cListBoxResonan.Text))
            {
                MessageBox.Show("请输入借阅原因");
                this.cListBoxResonan.Focus();
                return -1;
            }

            if (string.IsNullOrEmpty(cListBempNo.Text))
            {
                MessageBox.Show("请输入借阅人工号");
                this.cListBempNo.Focus();
                return -1;
            }
             * */
            return 1;
        }
        #region 获取病案信息

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
                    MessageBox.Show("获取序号失败");
                    return null;
                }

               
                Saveinfo.CaseBase.PatientInfo.ID = tempObj.PatientInfo.ID;//住院流水号
                Saveinfo.CaseBase.CaseNO = tempObj.CaseNO;//病人住院号 
                Saveinfo.CaseBase.PatientInfo.Name = tempObj.PatientInfo.Name; //病人姓名
                Saveinfo.CaseBase.PatientInfo.Sex.ID = tempObj.PatientInfo.Sex.ID;//性别
                Saveinfo.CaseBase.PatientInfo.Birthday = tempObj.PatientInfo.Birthday;//出生日期
                Saveinfo.CaseBase.PatientInfo.PVisit.InTime = tempObj.PatientInfo.PVisit.InTime;//入院日期
                Saveinfo.CaseBase.PatientInfo.PVisit.OutTime = tempObj.PatientInfo.PVisit.OutTime;//出院日期
                Saveinfo.CaseBase.InDept.ID = tempObj.InDept.ID; //入院科室代码
                Saveinfo.CaseBase.InDept.Name = tempObj.InDept.Name; //入院科室名称
                Saveinfo.CaseBase.OutDept.ID = tempObj.OutDept.ID;  //出院科室代码
                Saveinfo.CaseBase.OutDept.Name = tempObj.OutDept.Name; //出院科室名称
                if (this.cListBempNo.Tag != null)
                {
                    Saveinfo.EmployeeInfo.ID = this.cListBempNo.Tag.ToString();//借阅人代号
                }
                Saveinfo.EmployeeInfo.Name = this.cListBempNo.Text;//借阅人姓名

                try
                {
                    Saveinfo.EmployeeDept.ID = ht[Saveinfo.EmployeeInfo.ID].ToString(); //借阅人所在科室代码
                    Saveinfo.EmployeeDept.Name = deptHelper.GetName(Saveinfo.EmployeeDept.ID); //借阅人所在科室名称
                }
                catch (Exception ex)
                {

                }
                Saveinfo.LendDate = Neusoft.FrameWork.Function.NConvert.ToDateTime(baseDml.GetSysDateTime()); //借阅日期
                Saveinfo.PrerDate = txReturnTime.Value; //预定还期

                //省医默认写死 内借
                Saveinfo.LendKind = "1"; ; //借阅性质

                Saveinfo.LendStus = "1"; ;//病历状态 1借出/2返还
                Saveinfo.ID = baseDml.Operator.ID; //操作员代号
                Saveinfo.OperInfo.OperTime = Neusoft.FrameWork.Function.NConvert.ToDateTime(baseDml.GetSysDateTime()); //操作时间
                Saveinfo.ReturnOperInfo.ID = "";   //归还操作员代号
                Saveinfo.ReturnDate = Neusoft.FrameWork.Function.NConvert.ToDateTime("3000-1-1");   //实际归还日期
                Saveinfo.CardNO = Saveinfo.EmployeeInfo.ID;//卡号
                //备注-借阅原因-电话
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
                    MessageBox.Show("获取序号失败");
                    return null;
                }
                Saveinfo.LendDate = Neusoft.FrameWork.Function.NConvert.ToDateTime(baseDml.GetSysDateTime()); //借阅日期
                Saveinfo.PrerDate = txReturnTime.Value; //预定还期
                if (this.cListBempNo.Tag != null)
                {
                    Saveinfo.EmployeeInfo.ID = this.cListBempNo.Tag.ToString();//借阅人代号
                }
                Saveinfo.EmployeeInfo.Name = this.cListBempNo.Text;//借阅人姓名
                try
                {
                    Saveinfo.EmployeeDept.ID = ht[Saveinfo.EmployeeInfo.ID].ToString(); //借阅人所在科室代码
                    Saveinfo.EmployeeDept.Name = deptHelper.GetName(Saveinfo.EmployeeDept.ID); //借阅人所在科室名称
                }
                catch (Exception ex)
                {

                }

                Saveinfo.CaseBase.CaseNO = this.caseNo.Text;
                //省医默认写死 内借
                Saveinfo.LendKind = "1"; ; //借阅性质

                Saveinfo.LendStus = "1"; ;//病历状态 1借出/2返还
                Saveinfo.ID = baseDml.Operator.ID; //操作员代号
                Saveinfo.OperInfo.OperTime = Neusoft.FrameWork.Function.NConvert.ToDateTime(baseDml.GetSysDateTime()); //操作时间
                Saveinfo.ReturnOperInfo.ID = "";   //归还操作员代号
                Saveinfo.ReturnDate = Neusoft.FrameWork.Function.NConvert.ToDateTime("3000-1-1");   //实际归还日期
                Saveinfo.CardNO = Saveinfo.EmployeeInfo.ID;//卡号
                
                if (string.IsNullOrEmpty(inpationNo))
                {
                    Saveinfo.CaseBase.PatientInfo.ID = "ZY01" + caseNo.Text.Trim();//住院流水号
                }
                else
                {
                    Saveinfo.CaseBase.PatientInfo.ID =inpationNo;//住院流水号
                }

                Saveinfo.CaseBase.PatientInfo.Name = this.txName.Text; //病人姓名
                if (this.cl_Sex.Tag != null)
                {
                    Saveinfo.CaseBase.PatientInfo.Sex.ID = this.cl_Sex.Tag.ToString();//性别
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

            #region 加载病案明细信息
            foreach (Neusoft.HISFC.Models.HealthRecord.Base obj in tempList)
            {
                this.caseDetail.Rows.Add(0, 1);
                this.caseDetail.Cells[0, (int)DetailCos.InpatientNO].Text = obj.PatientInfo.ID;//住院流水号
                this.caseDetail.Cells[0, (int)DetailCos.patientNO].Text = obj.PatientInfo.PID.PatientNO;//住院号
                this.caseDetail.Cells[0, (int)DetailCos.caseNO].Text = obj.CaseNO;//病案号
                this.caseDetail.Cells[0, (int)DetailCos.strName].Text = obj.PatientInfo.Name;
                this.caseDetail.Cells[0, (int)DetailCos.deptIN].Text = obj.InDept.Name;//入院科室
                this.caseDetail.Cells[0, (int)DetailCos.dateIN].Text = obj.PatientInfo.PVisit.InTime.ToShortDateString();//入院日期
                this.caseDetail.Cells[0, (int)DetailCos.DeptOut].Text = obj.OutDept.Name;//出院科室
                this.caseDetail.Cells[0, (int)DetailCos.dateOut].Text = obj.PatientInfo.PVisit.OutTime.ToShortDateString();//出院日期
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
