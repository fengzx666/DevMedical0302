using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using NineVigor.Domain.HealthRecord.Entity;

namespace NineVigor.Components.HealthRecord.Common
{
    /// <summary>
    /// 诊断列表
    /// </summary>
    public partial class ucDiagNoseSelect : NineVigor.FrameWork.WinForms.Controls.ucBaseControl
    {
        public ucDiagNoseSelect()
        {
            InitializeComponent();
        }

        #region 变量
        private DataSet dsICD = new DataSet();

        private DataTable dtICD = null;

        private DataView dvICD = null;

        private int selectedRowIndex = 0;

        private int firstRowIndex = 0;

        private int displayRowCount = 0;
        private Hashtable diagExtInfo = new Hashtable();

        private Control relatedControl = null ;
        public Control RelatedControl
        {
            set
            {
                relatedControl = value;
            }
        }
        /// <summary>
        /// 定义委托
        /// </summary>
        /// <param name="str"></param>
        public delegate void myKeyDownEvent(Control sender, KeyEventArgs e);

        /// <summary> 
        /// 定义委托实体
        /// </summary>
        public event myKeyDownEvent MyDiagEnterEvent;
        #endregion 

        /// <summary>
        /// 初始化
        /// </summary>
        private void InitDataSet()
        {
            dtICD = new DataTable();

            Type strType = Type.GetType("System.String");
            dtICD.Columns.AddRange(new DataColumn[]{
                new DataColumn("编码",strType),
                new DataColumn("名称",strType),
                new DataColumn("拼音码",strType),
                new DataColumn("五笔码",strType),
                new DataColumn("适用性别", strType)
            });
        }

        /// <summary>
        /// 初始化列表
        /// </summary>
        public void InitData(ArrayList diagnose)
        {
            if (diagnose == null || diagnose.Count <= 0)
            {
                return;
            }
           
           // IComparer myComparer = new ICDCompareReverse();
          //  diagnose.Sort(myComparer);

            if (dtICD == null)
            {
                InitDataSet();
            }
            foreach (NineVigor.Domain.HealthRecord.Entity.ICDDiagnose icd in diagnose)
            {
                DataRow dr = dtICD.NewRow();

                dr["编码"] = icd.ID;
                dr["名称"] = icd.Name;
                dr["拼音码"] = icd.SpellCode;
                dr["五笔码"] = icd.WBCode;

                switch (icd.Sextype)
                { 
                    case "M":
                        dr["适用性别"] = "男";
                        break;
                    case "F":
                        dr["适用性别"] = "女";
                        break;
                    default:
                    
                        dr["适用性别"] = "所有";
                        break;
                }
                dtICD.Rows.Add(dr);
            }

            dvICD = new DataView(dtICD);

            this.dataGridICD.DataSource = dvICD;
            this.dataGridICD.AllowUserToAddRows = false;
            this.dataGridICD.AllowUserToDeleteRows = false;
            this.dataGridICD.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridICD.AllowUserToResizeColumns = true;
            this.dataGridICD.AllowUserToResizeRows = false;
            this.dataGridICD.AutoSize = false;
            this.dataGridICD.Columns[0].Width = 60;
            
            this.dataGridICD.Columns[2].Width = 30;
            this.dataGridICD.Columns[3].Width = 30;
            this.dataGridICD.Columns[4].Width = 80;
            
            this.dataGridICD.Columns[2].Visible = false;
            this.dataGridICD.Columns[3].Visible = false;
            this.dataGridICD.Columns[1].Width = 330;

            this.neuLblDesc.Text = string.Empty;
            this.neuLblThreeDesc.Text = string.Empty;
            this.neuLblFourDesc.Text = string.Empty;

            try
            {
              /*  NorthChina.HealthRecord.Bizlogic.CaseBaseExtBiz cbz = new NorthChina.HealthRecord.Bizlogic.CaseBaseExtBiz();
                ArrayList alExt = cbz.GetDiagnoseExtInfo();
                foreach (NineVigor.FrameWork.Models.NineObject itemObj in alExt)
                {
                    if (!diagExtInfo.Contains(itemObj.User01))
                    {
                        diagExtInfo.Add(itemObj.User01, itemObj);
                    }
                }*/

            }
            catch
            {
                
            }
        }

        /// <summary>
        /// 过滤
        /// </summary>
        /// <param name="filterStr"></param>
        public void Filter(string filterStr)
        {

            if (string.IsNullOrEmpty(filterStr))
            {
                this.dvICD.RowFilter = "拼音码 like '%%'";
            }
            else
            {
                if (cbFuzzy.Checked)
                {
                    this.dvICD.RowFilter = "拼音码 like '%" + filterStr.Trim().Replace('[', ' ').Replace(']', ' ') + "%' or 名称 like '%" + filterStr.Trim().Replace('[', ' ').Replace(']', ' ') + "%' or 编码 like '%" + filterStr.Trim().Replace('[', ' ').Replace(']', ' ') + "%'";
                }
                else
                {
                    this.dvICD.RowFilter = "拼音码 like '" + filterStr.Trim().Replace('[', ' ').Replace(']', ' ') + "%' or 名称 like '" + filterStr.Trim().Replace('[', ' ').Replace(']', ' ') + "%' or 编码 like '" + filterStr.Trim().Replace('[', ' ').Replace(']', ' ') + "%'";
                }
            }

            selectedRowIndex = 0;
            firstRowIndex = 0;
            if (this.dataGridICD.Rows.Count > 0)
            {
                this.dataGridICD.Rows[0].Selected = true;
                SetShowICDExtInfo(dataGridICD.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                SetShowICDExtInfo("");
            }
        }

        /// <summary>
        /// 获取选择的行
        /// </summary>
        /// <returns></returns>
        public ICDDiagnose GetSelectedICD()
        {
            if (dataGridICD.SelectedRows == null || dataGridICD.SelectedRows.Count <= 0)
            {
                return null;
            }

            NineVigor.Domain.HealthRecord.Entity.ICDDiagnose icd = new NineVigor.Domain.HealthRecord.Entity.ICDDiagnose();

            if (dataGridICD.SelectedRows == null | dataGridICD.SelectedRows.Count <= 0)
            {
                return null;
            }
            DataGridViewRow dr = dataGridICD.SelectedRows[0];

            icd.WBCode = dr.Cells[3].Value.ToString();
            icd.ID = dr.Cells[0].Value.ToString();
            icd.Name =dr.Cells[1].Value.ToString();
            icd.SpellCode = dr.Cells[2].Value.ToString();


            this.dataGridICD.Rows[selectedRowIndex].Selected = false;
            return icd;
        }

        private void SetShowICDExtInfo(string icdCode)
        {
            if (icdCode.Length >= 5)
            {
                string strIcd = icdCode.Substring(0, 5);
                NineVigor.FrameWork.Models.NineObject obj = diagExtInfo[strIcd] as NineVigor.FrameWork.Models.NineObject;
                this.neuLblDesc.Text = string.Empty;
                this.neuLblThreeDesc.Text = string.Empty;
                this.neuLblFourDesc.Text = string.Empty;

                if (obj != null)
                {
                    this.neuLblDesc.Text = obj.Memo;
                    this.neuLblThreeDesc.Text = obj.Name;
                    this.neuLblFourDesc.Text = obj.User02;
                }
            }
            else
            {
                this.neuLblDesc.Text = string.Empty;
                this.neuLblThreeDesc.Text = string.Empty;
                this.neuLblFourDesc.Text = string.Empty;
            }
        }

        /// <summary>
        ///  上一行
        /// </summary>
        public void PriorRow()
        {
            if (selectedRowIndex > 0)
            {
                if (selectedRowIndex <= firstRowIndex)
                {
                    firstRowIndex--;
                }
                this.dataGridICD.FirstDisplayedScrollingRowIndex = firstRowIndex;
                this.dataGridICD.Rows[selectedRowIndex].Selected = false;
                selectedRowIndex--;
                this.dataGridICD.Rows[selectedRowIndex].Selected = true;
                SetShowICDExtInfo(dataGridICD.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        /// <summary>
        /// 下一行
        /// </summary>
        public void NextRow()
        {
            if (selectedRowIndex < this.dataGridICD.Rows.Count - 1)
            {
                if (selectedRowIndex > firstRowIndex + 5)
                {
                    firstRowIndex++;
                }
                this.dataGridICD.FirstDisplayedScrollingRowIndex = firstRowIndex;
                this.dataGridICD.Rows[selectedRowIndex].Selected = false;

                selectedRowIndex++;
                this.dataGridICD.Rows[selectedRowIndex].Selected = true;

                SetShowICDExtInfo(dataGridICD.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        /// <summary>
        /// 滚动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridICD_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void dataGridICD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            KeyEventArgs key = new KeyEventArgs(Keys.Enter);
            
            MyDiagEnterEvent(relatedControl, key);
        }

      
        private void dataGridICD_Enter(object sender, EventArgs e)
        {
        }

        private void dataGridICD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KeyEventArgs key = new KeyEventArgs(Keys.Enter);
                MyDiagEnterEvent(relatedControl, key);
            }
            else if (e.KeyData == Keys.Up)
            {
                if (this != null && this.Visible)
                {
                    PriorRow();
                }
            }
            else if (e.KeyData == Keys.Down)
            {
                if (this != null && this.Visible)
                {
                    NextRow();
                }
            }

        }
    }

}
