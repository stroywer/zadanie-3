using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class LoginServise
    {
        public static string Login(string login,string password)
        {
            if (!(login == "admin"))
                return "Неверный логин"; 
             if(!(password == "admin"))
                return "Неверный пароль";

            return "Вход выполнен" ;
        }
    }
}
