using Course_managment_application.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course_managment_application.Models
{
    internal class Group
    {
        public string No;
        public Categories Categories;
        public bool IsOnline;
        public byte Limit;
        public List<Student> Students;
        public static byte Count;
        static Group()
        {
            Count = 100;
        }
        public Group(bool isonline, Categories categories)
        {
            switch (categories)
            {
                case Categories.Programming:
                    No = $"P" + Count;
                    break;
                case Categories.Design:
                    No = $"D" + Count;
                    break;
                case Categories.System_Administration:
                    No = $"S" + Count;
                    break;
                default:
                    break;
            }
            Count++;
            Categories = categories;
            IsOnline = isonline;
            if (IsOnline == true)
            {
                Limit = 15;
            }
            else
            {

                Limit = 10;
            }
            Students = new List<Student>();
            

        }
        public override string ToString()
        {
            return $"Group No:{No} Limit:{Limit}";
        }

    }
}
