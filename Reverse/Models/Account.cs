using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse.Models
{
    class Account
    {
        public string Username;
        public string Password;

        public string Login (string username, string password)
        {
            if ((Username == username) && (Password == password))
            {
                return "Login successful";
            };
            return $"Username or password is incorrect";
        }

        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
//public string Login(string username, string password)
//{
//    if ((Username == username) && (Password ==password))
//    {
//        return "Login successful";
//    };
//    return "Username or password is incorrect";
//}