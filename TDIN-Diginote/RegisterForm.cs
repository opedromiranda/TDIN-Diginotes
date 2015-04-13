using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDIN_Diginote.Models;

namespace TDIN_Diginote
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void computeRegisterButtonState() {
            Boolean isEnabled = false;
            if (String.IsNullOrEmpty(usernameTextBox.Text) != true && String.IsNullOrEmpty(passwordTextBox.Text) != true && String.IsNullOrEmpty(confirmPasswordTextBox.Text) != true)
            {
                if (passwordTextBox.Text.Equals(confirmPasswordTextBox.Text))
                {
                    isEnabled = true;
                }
            }
            registerButton.Enabled = isEnabled;
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            computeRegisterButtonState();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            computeRegisterButtonState();
        }

        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            computeRegisterButtonState();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            String username = usernameTextBox.Text;
            String password = passwordTextBox.Text;
            User user = new User(username, password);
        }
    }
}
