using Course_managment_application.Enum;
using Course_managment_application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course_managment_application.Services
{
    internal static class MenuServices
    {
        public static CourseServices courseServices = new CourseServices();
        public static void CreateGroupMenu()
        {
            Console.WriteLine("Your Course Online or Ofline? T/F");
            char online;
            bool isOnline = false;
            do
            {
                online = Convert.ToChar(Console.ReadLine());
                if (online == 'T')
                {
                    isOnline = true;
                }

            } while (!isOnline && online == 'T' && online == 'F');


            foreach (var item in System.Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine($"{(int)item}.{item}");
            }
            object categories;
            bool isCategory = System.Enum.TryParse(typeof(Categories), Console.ReadLine(), out categories);
            
            courseServices.CreateGroup(isOnline, (Categories)categories);
        }
        public static void ShowGroupMenu()
        {
            courseServices.ShowGroup();
        }
        public static void UpdateGroupMenu()
        {
            Console.WriteLine("Enter old No");
            string oldNo =Console.ReadLine();

            Console.WriteLine("Enter New No");
            string newNo = Console.ReadLine();

            courseServices.UpdateGroup(oldNo, newNo);   


        }
        public static void ShowStudentsInGroupMenu()
        {
            Console.WriteLine("Enter Group No");
            string groupNo=Console.ReadLine();
             
            courseServices.ShowStudentsInGroup(groupNo);
        }
        public static void ShowAllStudentsMenu()
        {
            courseServices.ShowAllStudents();
        }
        public static void CreateStudentMenu()
        {
            Console.Write("Enter Student Full Name:");
            string fullname =Console.ReadLine();
            bool result = true;

            Student student = new Student(fullname,result);

            Console.Write("Enter Group No:");
            string groupno=Console.ReadLine();  

            courseServices.CreateStudent(student, groupno);



        }
        public static void DeleteStudentMenu()
        {
            Console.Write("Enter Group No:");
            string groupNo = Console.ReadLine();

            Console.Write("Enter Student Id:");
            byte id=Convert.ToByte(Console.ReadLine());

            courseServices.DeleteStudent(groupNo, id);
        }
    }
}
