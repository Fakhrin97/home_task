using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public Student(string name,string surname)
        {
            Name = name;
            Surname = surname;  
        }
        protected string Fullname()
        {
            string fullname = Name +" "+ Surname;
            return fullname;
        }
    }
}
