using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Set a Limit");
            int limit = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[limit];
            Console.WriteLine("Enter group name:");
            string groupname = Console.ReadLine();
            string name;
            string surname;
            int count = 0;

            do
            {
                Console.WriteLine("Enter name");
                name = Console.ReadLine();
                Console.WriteLine("Enter surname");
                surname = Console.ReadLine();
                count++;
            } while (count < limit);
            Group group = new Group(name, surname, groupname, limit, arr);
            group.GetStudents();



        }
    }
}
