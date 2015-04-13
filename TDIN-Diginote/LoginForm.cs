using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDIN_Diginote
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            computeLoginButtonState();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            computeLoginButtonState();
        }

        private void computeLoginButtonState()
        {
            if (String.IsNullOrEmpty(usernameTextBox.Text) == true || String.IsNullOrEmpty(passwordTextBox.Text) == true)
            {
                loginButton.Enabled = false;
            }
            else
            {
                loginButton.Enabled = true;
            }

        }

    }
}
