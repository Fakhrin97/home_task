using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class User
    {
         string _Username;
         string _Password;
        public string Username { 
            get
            { 
                return _Username;
            }
            set
            {
                if (value.Length>=6)
                {
                    _Username=value;
                }
            }
            
        }
        public string PassWord { 
            get
            {
                return _Password;

            }
            set
            {
                if (!CheckPasword(value))
                {
                    _Password=value;
                }
            }
        }
        public User(string username, string password)
        {
            Username = username;
            PassWord = password;
        }
        public bool CheckPasword(string pw)
        {
            bool isDigit = false;
            bool isUpper = false;
            bool isLower=false;
            foreach (char item in pw)
            {
                if (char.IsDigit(item))
                {
                    isDigit = true;
                }
                else if (char.IsLower(item))
                {
                    isLower = true;
                }
                else if (char.IsUpper(item))
                {
                    isUpper = true;
                }
            }
            bool resualt=isDigit && isUpper && isLower; 
            return resualt;
        }
        

    }
}
