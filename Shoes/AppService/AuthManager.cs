using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shoes.AppModels;
using Shoes.AppExceptions;

namespace Shoes.AppService
{
    // PKGH Авторизация и аутентификация.
    internal class AuthManager
    {
        public static void login(string login, string password) {
            User tmpUser = Program.context.User.Where(user => user.Login == login).FirstOrDefault();
            if (tmpUser == null)
            {
                throw new UnauthorizedException();
            }
            else
            {
                //ContextManager.user = tmpUser;
                ContextManager.renewFullName();
                MessageBox.Show("Вход");
            }
        }
    }
}
