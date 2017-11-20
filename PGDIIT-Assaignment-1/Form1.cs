using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        TransectionLogs tlogs = new TransectionLogs();
        TransectionService trac = new TransectionService();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tlogs.Tamount = Convert.ToDecimal(Tamount.Text);
            tlogs.date = DateTime.Now;
            trac.Deposit(tlogs);
            Amount += Convert.ToDouble(Tamount.Text);
            showAmount.Text = Cname + "  " + Amount.ToString();
            addDrid(tlogs);
        }

        private void tWithdraw_Click(object sender, EventArgs e)
        {
            tlogs.Tamount = Convert.ToDecimal(Tamount.Text);
            tlogs.date = DateTime.Now;
            trac.WithDraw(tlogs);
            Amount -= Convert.ToDouble(Tamount.Text);
            showAmount.Text =Cname+"  "+ Amount.ToString();
            addDrid(tlogs);
        }

        private void addCompany_Click(object sender, EventArgs e)
        {
            comp.Cname = Cname.Text;
            comp.Cadd = Cadd.Text;
            comp.Cmobile = Cmobile.Text;
            comp.CaccountNo = Caccount.Text;
            comserviec.addCompnay(comp);
            Cname.Enabled = Cadd.Enabled = Cmobile.Enabled = Caccount.Enabled = false;
            comp = comserviec.Get();
            Cname.Text = Cadd.Text = Cmobile.Text = Caccount.Text = null;
            Scname.Text = comp.Cname;
            Scadd.Text = comp.Cadd;
            Scmobile.Text = comp.Cmobile;
            Scaccount.Text = comp.CaccountNo;

        }

        private void ComEdit_Click(object sender, EventArgs e)
        {
            Cname.Enabled = Cadd.Enabled = Cmobile.Enabled = Caccount.Enabled = true;

        }

        private void addDrid(TransectionLogs com) {
            dataGridView1.DataSource = trac.Getlist();
          
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void exportAmount_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = trac.Getlist();

            dataGridView1.Update();
            dataGridView1.Refresh();
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("d:\\output.xls");
            // Exit from the application  
            app.Quit();
        }
    }
}
