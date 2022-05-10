using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Admin:User
    {
        public bool IsSuperAdmin;
        public string Section;
        public Admin(string username, string password, bool issuperadmin, string section) : base( username, password)
        {
           IsSuperAdmin = issuperadmin;
            Section = section;  
        }
        public void GetInfo()
        {
            Console.WriteLine($"Username:{Username} Pasword:{PassWord} Section:{Section} {(IsSuperAdmin ? "This admin is super admin" : "This admin is not super admin")}");
        }
    }
}
