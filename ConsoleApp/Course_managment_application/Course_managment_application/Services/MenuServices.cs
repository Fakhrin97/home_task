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
            Console.WriteLine(" Your Course Online or Ofline? T/F");

            string online;
            bool isOnline = false;
          
            do
            {
                Console.WriteLine("Choose one => T or F");
                online = Console.ReadLine().ToUpper();

            } while (online != "F" && online != "T");

            if (online == "F") isOnline = false;
            if (online == "T") isOnline = true;

            object categories;
            bool isExistCategory;

            do
            {
                foreach (var item in System.Enum.GetValues(typeof(Categories)))
                {
                    Console.WriteLine($"{(int)item}.{item}");
                }

                Console.Write("\n Choose Categories:");

                int.TryParse(Console.ReadLine(), out int categoryId);
                System.Enum.TryParse(typeof(Categories), categoryId.ToString(), out categories);
                isExistCategory = System.Enum.IsDefined(typeof(Categories), categoryId);
                Console.WriteLine();

                if (isExistCategory)
                {
                    courseServices.CreateGroup(isOnline, (Categories)categories);
                }
                else
                {
                    Console.WriteLine("Please Enter Correct Variant \n");
                }
            } while (!isExistCategory);
        }
        public static void ShowGroupMenu()
        {
            courseServices.ShowGroup();
        }
        public static void UpdateGroupMenu()
        {           
            
            if (courseServices.Groups.Count > 0)
            {
                Console.WriteLine("Groups in Course");

                ShowGroupMenu();

                string oldNo;
                do
                {
                    Console.WriteLine("Enter old No");
                    oldNo = Console.ReadLine();

                } while (string.IsNullOrEmpty(oldNo) && string.IsNullOrWhiteSpace(oldNo));

                string newNo;
                do
                {
                    
                    Console.WriteLine("Enter New No");
                    newNo = Console.ReadLine();

                } while (string.IsNullOrEmpty(newNo) && string.IsNullOrWhiteSpace(newNo));

                courseServices.UpdateGroup(oldNo, newNo);   

            }
            else
            {
                Console.WriteLine("Group do not Created Yet");
            }



        }
        public static void ShowStudentsInGroupMenu()
        {
            if (Student.Count>0)
            {                          
                courseServices.ShowGroup();

                Console.WriteLine("Enter Group No");
                string groupNo = Console.ReadLine();

                courseServices.ShowStudentsInGroup(groupNo);
            }
            else
            {
                Console.WriteLine("Noy Yet Added Strudent");
            }
        }
        public static void ShowAllStudentsMenu()
        {
            courseServices.ShowAllStudents();
        }
        public static void CreateStudentMenu()
        {
            if (courseServices.Groups.Count > 0)
            {
                string fullname;
                do
                {
                    Console.Write("Enter Student Full Name:");
                     fullname = Console.ReadLine();
                } while (string.IsNullOrEmpty(fullname) || string.IsNullOrWhiteSpace(fullname));

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

                ShowGroupMenu();

                Console.Write("Enter Group No:");
                string groupno = Console.ReadLine();

                courseServices.CreateStudent(student, groupno);
            }
            else
            {
                Console.WriteLine("Not Yet Created Group");
            }



        }
        public static void DeleteStudentMenu()
        {
            if (Student.Count>0)
            {
                ShowAllStudentsMenu();

                Console.Write("Enter Group No:");
                string groupNo = Console.ReadLine();

                byte iD;
                bool idResult = false;

                do
                {
                    Console.Write("Enter Student Id Int Format:");
                    idResult = byte.TryParse(Console.ReadLine(), out iD);

                } while (!idResult);

                courseServices.DeleteStudent(groupNo, iD);
            }
            else
            {
                Console.WriteLine("Not Yet Added Strudent");
            }
        }
    }
}
