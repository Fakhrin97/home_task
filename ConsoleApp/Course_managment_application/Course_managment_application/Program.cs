using Course_managment_application.Services;
using System;

namespace Course_managment_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcomde Our Course ");

            byte selection;
            bool result = false;

            do
            {
                
                Menu();
                Console.Write("Choose One:");
                result = byte.TryParse(Console.ReadLine(), out selection);
                Console.Clear();

                switch (selection)
                {
                    case 1:
                        MenuServices.CreateGroupMenu();
                        break;
                    case 2:
                        MenuServices.ShowGroupMenu();
                        break;
                    case 3:
                        MenuServices.UpdateGroupMenu();
                        break;
                    case 4:
                        MenuServices.ShowStudentsInGroupMenu(); 
                        break;
                    case 5:
                        MenuServices.ShowAllStudentsMenu();
                        break;
                    case 6:
                        MenuServices.CreateStudentMenu();
                        break;
                    case 7:
                        MenuServices.DeleteStudentMenu();
                        break;
                    case 0:
                        Console.WriteLine("Code Academini Secdiyiniz Uzub Size Teshekkur Edirik!");
                        break;


                    default:
                        Console.WriteLine("Something went wrong");
                        break;
                }
              


            } while (selection != 0 || result == false);


        }
        public static void Menu()
        {
            Console.WriteLine("*******************");
            Console.WriteLine("1.Create a Group");
            Console.WriteLine("2.Show Groups List");
            Console.WriteLine("3.UpDate A Group ");
            Console.WriteLine("4.Show a Student  in Group No");
            Console.WriteLine("5.Show All Student In Course");
            Console.WriteLine("6.Create a Student");
            Console.WriteLine("7.Delete a Student");
            Console.WriteLine("0.Exit ConsoleApp");
        }
    }
}
