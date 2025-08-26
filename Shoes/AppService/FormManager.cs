using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.AppService
{
    internal class FormManager
    {
        public static void prepareForm(string title, bool showLogout=true) {
            ContextManager.parentForm.setFullName();
            ContextManager.parentForm.setTitle(title);
            if (showLogout) {
                ContextManager.parentForm.showLogoutButton();
            }
            
        }
    }
}
