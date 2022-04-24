using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Set a Limit:");
            int limit = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[limit];
            Console.Write("Enter group name:");
            string groupname = Console.ReadLine();
            string name;
            string surname;
            int count = 0;
            Group group = new Group(groupname, limit, arr);
            do
            {
                Console.Write("Enter name:");
                name = Console.ReadLine();
                Console.Write("Enter surname:");
                surname = Console.ReadLine();
                Student student = new Student(name,surname);
                group.AddStudent(student);
                count++;
            } while (count < limit);

            group.GetStudents();



        }
    }
}
