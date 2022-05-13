using Course_managment_application.Enum;
using Course_managment_application.Models;
using System;

namespace Course_managment_application.Services
{
    internal static class MenuServices
    {
        public static CourseServices courseServices = new CourseServices();
        public static void CreateGroupMenu()
        {
            Console.WriteLine("Your Course Online or Ofline? T/F");
            string online;
            bool isOnline = false;
            do
            {
                Console.WriteLine("Choose one => T or F");
                online = Console.ReadLine().ToUpper();

            } while (online != "F" && online != "T");

            if (online == "F") isOnline = false;
            if (online == "T") isOnline = true;


            foreach (var item in System.Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine($"{(int)item}.{item}");
            }

            object categories;
            Console.Write("Choose Categoties:");
            bool isCategory = System.Enum.TryParse(typeof(Categories), Console.ReadLine(), out categories);
            Console.WriteLine(isCategory);

            courseServices.CreateGroup(isOnline, (Categories)categories);
        }
        public static void ShowGroupMenu()
        {
            courseServices.ShowGroup();
        }
        public static void UpdateGroupMenu()
        {
            Console.WriteLine("Enter old No");
            string oldNo = Console.ReadLine();

            Console.WriteLine("Enter New No");
            string newNo = Console.ReadLine();

            courseServices.UpdateGroup(oldNo, newNo);


        }
        public static void ShowStudentsInGroupMenu()
        {
            Console.WriteLine("Enter Group No");
            string groupNo = Console.ReadLine();

            courseServices.ShowStudentsInGroup(groupNo);
        }
        public static void ShowAllStudentsMenu()
        {
            courseServices.ShowAllStudents();
        }
        public static void CreateStudentMenu()
        {
            Console.Write("Enter Student Full Name:");
            string fullname = Console.ReadLine();

            Console.WriteLine("Student is Guaranteed or Without Warranty");
            string online;
            bool isOnline = false;
            do
            {
                Console.WriteLine("Choose one => G or W");
                online = Console.ReadLine().ToUpper();

            } while (online != "G" && online != "W");

            if (online == "G") isOnline = true;
            if (online == "W") isOnline = false;

            Student student = new Student(fullname, isOnline);

            Console.Write("Enter Group No:");
            string groupno = Console.ReadLine();

            courseServices.CreateStudent(student, groupno);



        }
        public static void DeleteStudentMenu()
        {
            Console.Write("Enter Group No:");
            string groupNo = Console.ReadLine();

            
            byte iD;
            bool idResult=false;

            do
            {
                Console.Write("Enter Student Id Int Format:");
                idResult = byte.TryParse(Console.ReadLine(), out iD);

            } while (!idResult);



            courseServices.DeleteStudent(groupNo, iD);
        }
    }
}
