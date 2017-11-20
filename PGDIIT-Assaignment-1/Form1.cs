using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGDIIT_Assaignment_1
{
    public partial class Form1 : Form
    {
        private double Amount;
        CompanyInfo comp = new CompanyInfo();
        CompanyService comserviec = new CompanyService();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Amount += Convert.ToDouble(Tamount.Text);
            showAmount.Text = Cname + "  " + Amount.ToString();
        }

        private void tWithdraw_Click(object sender, EventArgs e)
        {
            Amount -= Convert.ToDouble(Tamount.Text);
            showAmount.Text =Cname+"  "+ Amount.ToString();
        }

        private void exportAmount_Click(object sender, EventArgs e)
        {
            ExcelPackage pck = new ExcelPackage();
            byte[] bfr = pck.GetAsByteArray();
        }

        private void addCompany_Click(object sender, EventArgs e)
        {
            comp.Cname = Cname.Text;
            comp.Cadd = Cadd.Text;
            comp.Cmobile = Cmobile.Text;
            comp.CaccountNo = Caccount.Text;
            comserviec.addCompnay(comp);
            comp = comserviec.Get();
            Cname.Text = Cadd.Text = Cmobile.Text = Caccount.Text = null;
            Scname.Text = comp.Cname;
            Scadd.Text = comp.Cadd;
            Scmobile.Text = comp.Cmobile;
            Scaccount.Text = comp.CaccountNo;

        }
    }
}
