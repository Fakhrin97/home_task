using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            while (true)
            {
                    Console.Write("Enter Username:");
                    string Name = Console.ReadLine();
                    Console.Write("Enter Pasword:");
                    string Pasword = Console.ReadLine();

                    Admin user = new Admin(Name, Pasword,"Admin Panel");
                
                if (user.getPasword != null || user.getUsername != null)
                {
                    Console.WriteLine();
                    user.isSuperAdmin = true;
                    user.getInfo();
                    break; ;
                }
                else
                {
                    Console.WriteLine("Try Agin"); 
                }


            }




        }
    }
}
