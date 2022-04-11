using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABTASK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(textBox_username.Text, "Successfully Logged in", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox_username_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_username.Text))
            {
                e.Cancel = true;
                textBox_username.Focus();
                errorProvider_username.SetError(textBox_username, "Please Enter your User Name !");
            }
            else
            {
                //e.Cancel = true;
                errorProvider_username.SetError(textBox_username, null);
            }
        }

        private void textBox_password_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_password.Text))
            {
                e.Cancel = true;
                textBox_password.Focus();
                errorProvider_password.SetError(textBox_password, "Please Enter your Password !");
            }
            else
            {
                //e.Cancel = true;
                errorProvider_password.SetError(textBox_password, null);
            }
        }
    }
}
