namespace ConsoleApp1
{
    internal class Student
    {
        public string Name { get; set; }


        public string Surname { get; set; }
        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        private string Fullname()
        {
            string fullname = Name + " " + Surname;
            return fullname;
        }
        public string fullname { 
            get
            {
                return Fullname();  
            } set
            {
                fullname = Fullname();
            }
        }
    }
}
