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
    public partial class Initializing : Form
    {
        public Initializing()
        {
            InitializeComponent();
        }

        private void Initializing_Load(object sender, EventArgs e)
        {
            timer1.Start();
            btnProceed.Hide();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                lblLoad.Text = "Processing " + progressBar1.Value.ToString() + "%";
            }

            else
            {
                timer1.Stop();
                btnProceed.Show();
            }
        }

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            Account view = new Account();
            this.Hide();
            view.ShowDialog();
        }
    }
}
