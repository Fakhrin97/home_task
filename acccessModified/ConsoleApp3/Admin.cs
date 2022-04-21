using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Admin : User
    {
        
        
        public string Section;
        public bool isSuperAdmin;
        public Admin(string username, string pasword, string section) :base(username, pasword)
        {                   
             Section = section;
        }
        public void getInfo()
        {
            Console.WriteLine($"Username:{getUsername} Pasword:{getPasword} SuperAdmin:{isSuperAdmin} Section:{Section} ");
        }

    }
}
