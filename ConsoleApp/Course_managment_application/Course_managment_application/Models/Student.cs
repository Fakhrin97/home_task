namespace Course_managment_application.Models
{
    internal class Student
    {
        public static byte Count;
        public byte Id;
        public string FullName;
        public bool Type;

        static Student()
        {
            Count = 0;
        }
        public Student(string fullname, bool type)
        {
            Id = ++Count;
            FullName = fullname;
            Type = type;
        }


        public override string ToString()
        {
            return $"{Id}.{FullName} {(Type ? "Guaranteed" : "Without Warranty")}";
        }
    }

}

