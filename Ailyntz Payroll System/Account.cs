using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ailyntz_Payroll_System
{
    public partial class Account : Form
    {
        public static Account data;
        public Account()
        {
            InitializeComponent();
            data = this;
        }

        //COMPUTATION EQUATIONS (for total salary)
        double FirstValue = 0;
        double SecondValue = 0;
        double ThirdValue = 0;

        //WORK TIME (payment)
        double FullTime = 18000;
        double PartTime = 9600;
        double Overtime = 45;
        double Hours = 0;

        //PRIOR DEDUCTIONS
        double PHILHEALTH = 0;
        double PAGIBIG = 0;
        double SSS = 0;
        double TAX = 0;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            
            Account view = new Account();
            this.Close();
            view.Show();
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void radioFULLTIME_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Clear();
            boxOvertime.Show();
            txtOvertime.Show();
            lblOvertime.Show();
        }

        private void radioPARTTIME_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Clear();
            boxOvertime.Hide();
            txtOvertime.Hide();
            lblOvertime.Hide();
        }

        private void boxOvertime_CheckedChanged(object sender, EventArgs e)
        {
            if (boxOvertime.Checked) 
            {
                txtTotal.Clear();
                txtOvertime.Show();
                txtOvertime.Clear();
            }
            else
            {
                txtTotal.Clear();
                txtOvertime.Hide();
                lblOvertime.Hide();
                txtOvertime.Clear();
            }

            if (Overtime == 0)
            {
                Overtime = 45;
            }
            else
            {
                Overtime = 0;
            }
        }

        private void boxPHILHEALTH_CheckedChanged(object sender, EventArgs e)
        {
            if (PHILHEALTH == 0)
            {
                PHILHEALTH = 300;
            }
            else
            {
                PHILHEALTH = 0;
            }
        }

        private void boxPAGIBIG_CheckedChanged(object sender, EventArgs e)
        {
            if (PAGIBIG == 0)
            {
                PAGIBIG = 200;
            }
            else
            {
                PAGIBIG = 0;
            }
        }

        private void boxSSS_CheckedChanged(object sender, EventArgs e)
        {
            if (SSS == 0)
            {
                SSS = 100;
            }
            else
            {
                SSS = 0;
            }
        }

        private void boxTAX_CheckedChanged(object sender, EventArgs e)
        {
            if (TAX == 0)
            {
                TAX = 0.10;
            }
            else
            {
                TAX = 0;
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {

            if (radioPARTTIME.Checked)
            {
                boxOvertime.Checked = false;               
                txtTotal.Clear();
                txtOvertime.Clear();
            }           

            if (txtOvertime.Text == "")
            {
                Hours = 0;
            }
            else
            {
                Hours = Convert.ToDouble(txtOvertime.Text);
            }

            if (radioFULLTIME.Checked == true) //For the fulltime 
            {
                FirstValue = (Hours * Overtime) + FullTime;
                SecondValue = FirstValue * TAX;
                ThirdValue = SecondValue + PHILHEALTH + PAGIBIG + SSS;

                txtTotal.Text = Convert.ToString(FirstValue - ThirdValue);

            }

            if (radioPARTTIME.Checked == true) //For the fulltime 
            {

                FirstValue = PartTime;
                SecondValue = FirstValue * TAX;
                ThirdValue = SecondValue + PHILHEALTH + PAGIBIG + SSS;

                txtTotal.Text = Convert.ToString(FirstValue - ThirdValue);
            }

            if (boxOvertime.Checked == true) //For the fulltime 
            {
                FirstValue = (Hours * Overtime) + FullTime;
                SecondValue = FirstValue * TAX;
                ThirdValue = SecondValue + PHILHEALTH + PAGIBIG + SSS;

                txtTotal.Text = Convert.ToString(FirstValue - ThirdValue);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtPreview.Text, new Font("Microsoft Sans Serif", 15, FontStyle.Bold), Brushes.Black, new Point(10, 10));            
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            txtPreview.Clear();
            txtPreview.Text += "___________________________________________________________________\n";
            txtPreview.Text += "\n";
            txtPreview.Text += "                                                     [Ailyntz Payroll System]\n";
            txtPreview.Text += "                                                  Beta Version 1.7.34.798.02\n";
            txtPreview.Text += "___________________________________________________________________\n";
            txtPreview.Text += "\nPAYMENT RECEIPT\n\n\n";
            txtPreview.Text += "Releasal of Salary:                                               Retrieval Location:\n";
            txtPreview.Text += "01/12/2022 8:30:00 am                                     20 Cooper Square, NY 10003, USA\n";
            txtPreview.Text += "\nDate Received: \n" + DateTime.Now + "\n";
            txtPreview.Text += "___________________________________________________________________\n";
            txtPreview.Text += "\n<Apprehended by deductions for Government-Initiated Social Benefits>\n\n";
            txtPreview.Text += "\nAmount to be Received: " + txtTotal.Text + "\n";
            txtPreview.Text += "Received from: Dr. Gravines, Ph.D\n";
            txtPreview.Text += "___________________________________________________________________\n";
            txtPreview.Text += "\nRepublic Act 10344 \n(Risk Reduction and Preparedness Equipment Protection Act of 2012)\n\n";
            txtPreview.Text += "the unauthorized taking, stealing, keeping or tampering of government risk \nreduction and preparedness equipment, accessories and similar facilities\n\n";
            txtPreview.Text += "___________________________________________________________________\n";
            txtPreview.Text += "\n                                                                                                         All rights reserved\n";
            txtPreview.Text += "                                                                                                                2022-2023";
        }
    }
}