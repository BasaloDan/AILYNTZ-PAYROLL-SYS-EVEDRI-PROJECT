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
    public partial class Startup : Form
    {

        int seconds = 0;

        public Startup()
        {
            InitializeComponent();
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            seconds = 3;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LblCountHidden.Text = seconds--.ToString();
            if (seconds < 0)
            {
                timer1.Stop();
                this.Hide();
                Login form = new Login();
                form.ShowDialog();
            }
        }
    }
}
