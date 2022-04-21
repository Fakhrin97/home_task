using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class User
    {
        private string _username;
        private string _pasword;
        public string getUsername
        {
            get
            {
                return _username;
            }
            set
            {                               
                if (value.Length > 6) _username = value;                             
                else Console.WriteLine("Username must be more than 6 characters");              
                               
            }
        }
        public string getPasword
        {
            get
            {
                return (_pasword);

            }
            set
            {
                int resualtnum = value.IndexOfAny(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
                int resualtetter = value.IndexOfAny(new char[] { 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'Z', 'X', 'C', 'V', 'B', 'N', 'M' });

                if (resualtetter != -1 && resualtnum != -1) _pasword = value;
                else Console.WriteLine("The password contains 1 major and 1 minor element");
                
            }
        }
        public User(string Username , string Pasword)
        {
            getUsername = Username;
            getPasword = Pasword; 

        }
        
    }
    
}
