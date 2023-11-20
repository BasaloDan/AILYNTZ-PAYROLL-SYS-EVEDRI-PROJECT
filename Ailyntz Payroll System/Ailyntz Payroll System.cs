using System;
using System.Drawing;
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
        readonly double FullTime = 18000;
        readonly double PartTime = 9600;
        double Overtime = 45;
        double Hours = 0;

        //PRIOR DEDUCTIONS
        double PHILHEALTH = 0;
        double PAGIBIG = 0;
        double SSS = 0;

        private void BtnPrint_Click(object sender, EventArgs e)
        {          
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

            Account view = new Account();
            this.Close();
            view.Show();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            btnPrint.Hide();
            timer1.Enabled = true;
        }

        private void RadioFULLTIME_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Clear();
            txtPreview.Clear();
            boxOvertime.Show();
            txtOvertime.Show();
            lblOvertime.Show();
        }

        private void RadioPARTTIME_CheckedChanged(object sender, EventArgs e)
        {
            btnPrint.Hide();
            txtTotal.Clear();
            txtPreview.Clear();
            boxOvertime.Hide();
            txtOvertime.Hide();
            lblOvertime.Hide();
        }

        private void BoxOvertime_CheckedChanged_1(object sender, EventArgs e)
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

        private void BoxPHILHEALTH_CheckedChanged(object sender, EventArgs e)
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

        private void BoxPAGIBIG_CheckedChanged(object sender, EventArgs e)
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

        private void BoxSSS_CheckedChanged(object sender, EventArgs e)
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

        private void BtnCompute_Click(object sender, EventArgs e)
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

            if (radioFULLTIME.Checked == true)
            {
                FirstValue = (Hours * Overtime) + FullTime;
                SecondValue = FirstValue * 0.10;
                ThirdValue = SecondValue + PHILHEALTH + PAGIBIG + SSS;

                txtTotal.Text = Convert.ToString(FirstValue - ThirdValue);
            }

            if (radioPARTTIME.Checked == true)
            {

                FirstValue = PartTime;
                SecondValue = FirstValue * 0.10;
                ThirdValue = SecondValue + PHILHEALTH + PAGIBIG + SSS;

                txtTotal.Text = Convert.ToString(FirstValue - ThirdValue);
            }

            if (boxOvertime.Checked == true)
            {
                FirstValue = (Hours * Overtime) + FullTime;
                SecondValue = FirstValue * 0.10;
                ThirdValue = SecondValue + PHILHEALTH + PAGIBIG + SSS;

                txtTotal.Text = Convert.ToString(FirstValue - ThirdValue);
            }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtPreview.Text, new Font("Microsoft Sans Serif", 15, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            btnPrint.Show();
            txtPreview.Clear();
            txtPreview.Text += "\n";
            txtPreview.Text += "                                                     [  Ailyntz Payroll System  ]\n";
            txtPreview.Text += "                                                      Beta Version 11-28-2022\n";
            txtPreview.Text += "                                       05 ACT Laboratory, PH 21-2001557, PHP \n";
            txtPreview.Text += "                                              VAT Registered: 0101-0010-1111\n";
            txtPreview.Text += "\n\n\t\t\t         PAYMENT RECEIPT\n";
            txtPreview.Text += "______________________________________________________________________\n";
            txtPreview.Text += "\nDate Received:" + DateTime.Now + "\t" + "Salary Releasal: 11/28/2022 8:30:00 AM";
            txtPreview.Text += "\n______________________________________________________________________\n";
            txtPreview.Text += "\n\tParticulars:                                                      Amount: ";
            txtPreview.Text += "\n_______________________________________________________________________\n";
            txtPreview.Text += "\n\t<Apprehended deductions for Government-Initiated Social Benefits>\n\n";


            if (boxPHILHEALTH.Checked == true)
            {

                txtPreview.Text += "PHILHEALTH           :                                                 300 PHP\n";
            }

            if (boxPAGIBIG.Checked == true)
            {
                txtPreview.Text += "PAGIBIG                   :                                                 200 PHP\n";
            }
            if (boxSSS.Checked == true)
            {
                txtPreview.Text += "SSS                            :                                                100 PHP\n";
            }
            txtPreview.Text += "TAX                            :                                                10%\n\n";

            txtPreview.Text += "Total Overall Salary Deduction:                                ";

            if (radioFULLTIME.Checked == true)
            {
                FirstValue = FullTime;
                SecondValue = FirstValue * 0.10;
                ThirdValue = SecondValue + PHILHEALTH + PAGIBIG + SSS;

                txtPreview.Text += Convert.ToString(FirstValue + ThirdValue - 18000) + " PHP";
            }

            else if (boxOvertime.Checked == true)
            {
                FirstValue = FullTime;
                SecondValue = FirstValue * 0.10;
                ThirdValue = SecondValue + PHILHEALTH + PAGIBIG + SSS;

                txtPreview.Text = Convert.ToString(FirstValue + ThirdValue - 180000 + " PHP");
            }

            if (radioPARTTIME.Checked == true)
            {

                FirstValue = PartTime;
                SecondValue = FirstValue * 0.10;
                ThirdValue = SecondValue + PHILHEALTH + PAGIBIG + SSS;

                txtPreview.Text += Convert.ToString(FirstValue + ThirdValue - 9600) + " PHP";
            }

            txtPreview.Text += "\nOverall Salary without Deduction:                            ";

            if (radioFULLTIME.Checked == true)
            {
                txtPreview.Text += "18000 PHP\n";
            }

            if (radioPARTTIME.Checked == true)
            {
                txtPreview.Text += "9600 PHP\n";
            }

            txtPreview.Text += "Overtime additions for full time:                                ";

            if (boxOvertime.Checked == true)
            {
                FirstValue = (Hours * Overtime);

                txtPreview.Text += FirstValue + " PHP";
            }
            else
            {
                txtPreview.Text += "0 PHP";
            }

            txtPreview.Text += "\n_____________________________________________________________________\n";
            txtPreview.Text += "\n\tNET PAY:                                                     " + txtTotal.Text + " PHP\n";
            txtPreview.Text += "_______________________________________________________________________\n";
            txtPreview.Text += "\n\n\t\t\t    This is your salary invoice.\n\n";
            txtPreview.Text += "\t\tThis receipt is not valid unless signed by the cashier.\n\n\n";
            txtPreview.Text += "                                                                                     _________________________\n";
            txtPreview.Text += "                                                                                              Dr. Gravines, Ph.D \n";
            txtPreview.Text += "                                                                                                    Cashier \n\n";
            txtPreview.Text += "\n                                                        All rights reserved\n";
            txtPreview.Text += "                                                               2022-2023";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("MMMM dd, yyyy \n       hh:mm:ss tt");
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login exit = new Login();
            exit.ShowDialog();
            this.Close();
        }
    }
}