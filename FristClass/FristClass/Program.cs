using System;

namespace FristClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Fakihrin","Aliyev","P324",99,true );
            Student student1 = new Student("Alim", "Qasimov", "P324", 70, true);
            Student student2 = new Student("Uzeir", "Mehdizade", "P324", 89, false);
            Student student3 = new Student("Bill", "Gates", "P324", 68, false);

            Console.WriteLine(student.getInfo());
            Console.WriteLine(student1.getInfo());
            Console.WriteLine(student2.getInfo());
            Console.WriteLine(student3.getInfo());

        }
    }
    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool IsGraduent;

        public Student(string name , string suranme , string group , byte point , bool isGraduent)
        {
            Name = name;
            Surname = suranme;
            Group = group;
            Point= point;
            IsGraduent = isGraduent;

        }

        public string getInfo()
        {

            if (IsGraduent==true)
            {
                Console.WriteLine("This student is graduet");
                
            }
            else if (Point>80)
            {
                Console.WriteLine("This student is not graduet");
                Console.WriteLine("You can take the second exam");
            }
            else
            {
                Console.WriteLine("This student is not graduet");
                Console.WriteLine("You can not take the second exam");
            }  
            
            
            return $"Name: {Name} Surname: {Surname} Group: {Group} Point: {Point} \n";
        }
            
            
        
    }
}
