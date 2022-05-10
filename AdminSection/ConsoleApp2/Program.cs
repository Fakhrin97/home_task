using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username;
            do
            {
                Console.Write("Enter Username:");
                username = Console.ReadLine();

            } while (username.Length <= 6);

            string password;
            do
            {
                Console.Write("Enter Parol:");
                password = Console.ReadLine();  
            } while (!CheckPasword(password));
            Console.WriteLine("Are you Super admin? y/n");
            bool resulat = false;
            char isSuper = Convert.ToChar(Console.ReadLine());

            if (isSuper=='y')
            {
                resulat = true;
            }
            Console.Write("Enter Section:");
            string section=Console.ReadLine();  


            Admin admin = new Admin( username, password,  resulat,  section);
            admin.GetInfo();

        }
        public static bool CheckPasword(string pw)
        {
            bool isDigit = false;
            bool isUpper = false;
            bool isLower = false;
            foreach (char item in pw)
            {
                if (char.IsDigit(item))
                {
                    isDigit = true;
                    continue;
                }
                else if (char.IsLower(item))
                {
                    isLower = true;
                    continue;
                }
                else if (char.IsUpper(item))
                {
                    isUpper = true;
                }
            }
            bool resualt = isDigit && isUpper && isLower;
            return resualt;
        }
    }
}
