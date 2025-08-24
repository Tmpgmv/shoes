using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shoes.AppModels;
using Shoes.AppExceptions;
using Shoes.AppForms;

namespace Shoes.AppService
{
    // PKGH Авторизация и аутентификация.
    internal class AuthManager
    {
        public static void login(string login, string password, LoginForm loginForm) {
            User tmpUser = Program.context.User.Where(user => user.Login == login).FirstOrDefault();
            if (tmpUser == null)
            {
                throw new UnauthorizedException();
            }
            else
            {
                ContextManager.user = tmpUser;

                ProductForm productForm = new ProductForm();
                productForm.Show();

                ContextManager.parentForm.setFullName();
                ContextManager.parentForm.setTitle("Товары");

                ContextManager.loginForm = loginForm;

                ContextManager.parentForm.showLogoutButton();

                loginForm.Hide();
            }
        }

        public static void logout(ParentForm form)
        {
            ContextManager.user = null;
            form.Hide();
            ContextManager.loginForm.Show();
        }
    }
}
