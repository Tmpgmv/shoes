using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shoes.AppExceptions;
using Shoes.AppService;

namespace Shoes.AppForms
{
    public partial class LoginForm : ParentForm
    {
        public LoginForm()
        {
            InitializeComponent();
            ContextManager.parentForm.setTitle("Вход");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try {
                AuthManager.login(loginTextBox.Text, passwordTextBox.Text, this);
            }
            catch (UnauthorizedException ex) {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            AuthManager.login("guest", "guest", this);            
        }
    }
}
