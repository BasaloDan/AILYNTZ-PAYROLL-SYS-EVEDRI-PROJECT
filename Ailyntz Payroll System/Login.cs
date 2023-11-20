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
    public partial class Login : Form
    {
        public int loginAttempt = 0;

        public Login()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //Account: HR
            if (txtUsername.Text == "Danica" && txtPassword.Text == "Basalo")
            {
                this.Hide();
                MessageBox.Show("Greetings to you, our beloved HR (Human Resources). \n\n This system requires utmost security, be wary. \n Fair warning, our company does not resolve unrelated cases. \n\n Thank you and stay safe.", "Ailyntz Payroll System [Security Breach]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Initializing view = new Initializing();
                this.Hide();
                view.Show();
            }
            //Account: Admin
            else if (txtUsername.Text == "Aiessa" && txtPassword.Text == "Cruz")
            {
                this.Hide();
                MessageBox.Show("Greetings to you, our beloved Admin. \n\n This system requires utmost security, be wary. \n Fair warning, our company does not resolve unrelated cases. \n\n Thank you and stay safe.", "Ailyntz Payroll System [Security Breach]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Initializing view = new Initializing();
                this.Hide();
                view.Show();
            }
            //Account: Employee
            else if (txtUsername.Text == "Harlyn" && txtPassword.Text == "Reyes")
            {
                this.Hide();
                MessageBox.Show("Greetings to you, our beloved Employee. \n\n This system requires utmost security, be wary. \n Fair warning, our company does not resolve unrelated cases. \n\n Thank you and stay safe.", "Ailyntz Payroll System [Security Breach]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Initializing view = new Initializing();
                this.Hide();
                view.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password, try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
                txtUsername.Focus();

                loginAttempt += 1;

                if (loginAttempt == 3)
                {
                    MessageBox.Show("You have exceeeded the maximum number of login attempts.\n\nAilyntz Payroll System is blocking you for more attempts.\nPlease refrain force, strict measures will be taken.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Enabled = false;
                    txtPassword.Enabled = false;
                    btnLogin.Enabled = false;
                }
            }         
        }   

        private void TxtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnLogin_Click(sender, e);

            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnLogin_Click(sender, e);

            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void BtnLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}