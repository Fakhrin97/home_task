using System;

namespace ConsoleApp1
{
    internal class Group
    {
        public string No { get; set; }
        public int Limit { get; set; }
        public string[] Students;



        public Group(string no, int limit, string[] students)
        {

            No = no;
            Limit = limit;
            Students = students;
        }
        Student student;   
        int i = 0;
       
        public void AddStudent(Student student)
        {

            Students[i] = student.fullname;
            i++;
           
        }
        
       
        public void GetStudents()
        {
            Console.WriteLine();
            Console.WriteLine("********************************************************************");
            Console.WriteLine($"Group Number:{No}");
            Console.WriteLine($"Group Limit{Limit}");
            Console.WriteLine();
            for (int i = 0; i < Limit; i++)
            {
                
                Console.WriteLine((i+1)+".Student:"+Students[i]);
            }

        }
    }

}
