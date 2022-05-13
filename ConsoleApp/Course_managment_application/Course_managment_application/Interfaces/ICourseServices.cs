using Course_managment_application.Enum;
using Course_managment_application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course_managment_application.Interfaces
{
    internal interface ICourseServices
    {
        public List<Group> Groups { get; }
        string CreateGroup(bool isonline, Categories categories);
        void CreateStudent(Student student, string no);
        void DeleteStudent(string no, byte id);
        void ShowAllStudents();
        void ShowGroup();        
        void ShowStudentsInGroup(string no);     
        void UpdateGroup(string oldNo, string newNo);


    }
}
