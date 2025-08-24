using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shoes.AppModels;
using Shoes.AppService;

namespace Shoes
{
    public partial class ParentForm : Form
    {        
        
        public ParentForm()
        {   
            InitializeComponent();            
            ContextManager.parentForm = this;
            hideLogoutButton();
        }

        public void setFullName() {
            this.fullNameLabel.Text = ContextManager.user.FullName;
            this.roleLabel.Text = ContextManager.user.Role.RoleName;
        }

        public void setTitle(string title)
        {
            string tmpTitle = "ООО \"Обувь\": " + title;
            this.Text = tmpTitle;
            this.titleLabel.Text = title;
        }

        public void showLogoutButton() {
            logoutButton.Visible = true;            
        }

        public void hideLogoutButton()
        {
            logoutButton.Visible = false;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            AuthManager.logout((ParentForm)((Button)sender).Parent.Parent);            
        }
    }
}
