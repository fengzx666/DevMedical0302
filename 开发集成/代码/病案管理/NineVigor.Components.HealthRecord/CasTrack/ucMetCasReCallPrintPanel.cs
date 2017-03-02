using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace NineVigor.Components.HealthRecord.CasTrack
{
    public partial class ucMetCasReCallPrintPanel : UserControl
    {
        public ucMetCasReCallPrintPanel()
        {
            InitializeComponent();
        }

        private int printWidth = 0;

        public int PrintWidth
        {
            get { return printWidth; }
            set { printWidth = value; }
        }
        private int printHeight = 0;

        public int PrintHeight
        {
            get { return printHeight; }
            set { printHeight = value; }
        }
        NineVigor.FrameWork.WinForms.Classes.Print p = new NineVigor.FrameWork.WinForms.Classes.Print();
        PaperSize ps = new PaperSize();
        public void SetControlValue(string[] arrsValue)
        {
            try
            {
                this.lblZYH.Text = string.Empty;
                this.lblName.Text = string.Empty;
                this.lblDept.Text = string.Empty;

                this.lblZYH.Text = arrsValue[0].TrimStart('0');
                this.lblName.Text = arrsValue[1];
                this.lblDept.Text = arrsValue[2];
                string barCodeValue = arrsValue[3];
                this.lblOutDate.Text = arrsValue[4];

                BarcodeLib.Barcode barCode = new BarcodeLib.Barcode();
                barCode.IncludeLabel = false;
                
                this.PicBoxBarCode.Image = barCode.Encode(BarcodeLib.TYPE.CODE128, barCodeValue, Color.Black, Color.White, barCode.Width, barCode.Height);
                p.IsResetPage = true;

                ps.Height = PrintHeight;
                ps.Width = PrintWidth;  
            }
            catch
            {
                this.lblZYH.Text = string.Empty;
                this.lblName.Text = string.Empty;
                this.lblDept.Text = string.Empty;
                PicBoxBarCode.Image = null;
            }
        }


        public void Print()
        {
            //System.Drawing.pag
            p.SetPageSize(ps);
            p.PrintPage(0, 0, this.panel1);
        }
    }
}
