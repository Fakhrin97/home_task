using System;

namespace ConsoleApp1
{
    internal class Group : Student
    {
        public string No;
        public int Limit;
        public string[] Student;

       

        public Group(string name, string surname, string no, int limit, string[] student) : base(name, surname)
        {
            No = no;
            Limit = limit;
            Student = student;
        }
        
        public string[] AddStudent()
        {

            string[] students = new string[Limit];
            for (int i = 0; i < Limit; i++)
            {
                students[i] = Fullname();
            }
            return students;


        }
        
       
        public void GetStudents()
        {
            string[] arr = AddStudent();
            for (int i = 0; i < Limit; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }

}
