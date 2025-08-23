using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.AppExceptions
{
    internal class UnauthorizedException : Exception
    {
        public UnauthorizedException() : base("Логин или пароль неверны") { }
    }
}
