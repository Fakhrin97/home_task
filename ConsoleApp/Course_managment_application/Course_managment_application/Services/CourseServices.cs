using Course_managment_application.Enum;
using Course_managment_application.Interfaces;
using Course_managment_application.Models;
using System;
using System.Collections.Generic;

namespace Course_managment_application.Services
{
    internal class CourseServices : ICourseServices
    {
        List<Group> _groups = new List<Group>();
        public List<Group> Groups => _groups;

        public void CreateGroup(bool isonline, Categories categories)
        {
            Group group = new Group(isonline, categories);
            bool result = false;

            if (Groups.Count == 0)
            {
                _groups.Add(group);
                Console.WriteLine($"Created New Group {group.No.ToUpper().Trim()} Limit:{group.Limit}");
                result = true;
                return;
            }
            else
            {
                foreach (Group item in Groups)
                {
                    if (group.No.ToUpper().Trim() != item.No.ToUpper().Trim()) 
                    {
                        _groups.Add(group);
                        Console.WriteLine($"Created New Group {group.No.ToUpper().Trim()} Limit:{group.Limit} \n");
                        result = true;  
                        return;
                    }
                }

            }
            if (result == false) Console.WriteLine("Such a Group AllReady Exists");                   

        }
        public Group Find(string no)
        {
       
            foreach (Group item in Groups)
            {
                if (item.No.ToUpper().Trim() == no.ToUpper().Trim()) return item;

            }
            return null;
        }

        public void CreateStudent(Student student, string no)
        {
            
                Group group = Find(no);
                if (group == null)
                {
                    Console.WriteLine("There is no group with this name");
                    return;
                }
                else
                {

                    if (group.Students.Count < group.Limit)
                    {
                        group.Students.Add(student);
                        Console.WriteLine($"Student successfully added {student}");
                    }
                    else
                    {
                        Console.WriteLine("Group Is Full");

                    }
                }          
          

        }

        public void DeleteStudent(string no, byte id)
        {
                Group group = Find(no);
                bool result = false;

                if (group != null)
                {
                    foreach (Student item in group.Students)
                    {
                        if (item.Id == id)
                        {
                            group.Students.Remove(item);
                            Console.WriteLine($"{item.FullName} was removed from the group");
                            result = true;
                            break;
                        }

                    }
                    if (!result) Console.WriteLine("Student Do Not Found");
                }
                else
                {
                    Console.WriteLine($"There is no group with this name:{no.ToUpper()}");
                    ShowGroup();
                }
           
        }

        public void ShowAllStudents()
        {
            if (Groups.Count > 0)
            {
                if (Student.Count == 0)
                {
                    Console.WriteLine("Not Yet Created Student");
                }
                foreach (Group item in Groups)
                {
                    foreach (Student student in item.Students)
                    {
                        Console.WriteLine($"{student} Group:{item.No}");
                    }
                }
              
            }
            else
            {
                Console.WriteLine("Not Yet Created Group");
            }
        }

        public void ShowGroup()
        {
            if (Groups.Count > 0)
            {
                foreach (Group item in Groups)
                {
                    Console.WriteLine($"{item} The number of students in the group:{item.Students.Count}");
                }
            }
            else
            {
                Console.WriteLine("No group has been created yet");
            }

        }

        public void ShowStudentsInGroup(string no)
        {
            if (Groups.Count > 0)
            {
                Group group = Find(no);
                if (group != null)
                {
                    foreach (Student item in group.Students)
                    {
                        Console.WriteLine(item + " " + group.No);
                    }
                    if (Student.Count == 0)
                    {
                        Console.WriteLine("Not Yet Created Student in This Group");
                    }
                }
                else
                {
                    Console.WriteLine($"There is no group with this name:{no.ToUpper()}");
                    ShowGroup();
                }
            }
            else
            {
                Console.WriteLine("Not Yet Craeted Group");
            }

        }

        public void UpdateGroup(string oldNo, string newNo)
        {          

                if (Find(newNo) == null)
                {
                    Group group = Find(oldNo);
                    if (group != null)
                    {
                        group.No = newNo.ToUpper().Trim();
                        Console.WriteLine($"{oldNo.ToUpper()} successfully edited {newNo.ToUpper()}");
                    }
                    else
                    {
                        Console.WriteLine($"There is no group with this name:{oldNo.ToUpper()}");
                        ShowGroup();
                    }

                }
                else
                {
                    Console.WriteLine($"There is already a group with this name:{newNo.ToUpper()}");
                }
          
        }
    }
}
