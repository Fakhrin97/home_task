﻿using Course_managment_application.Enum;
using Course_managment_application.Interfaces;
using Course_managment_application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course_managment_application.Services
{
    internal class CourseServices : ICourseServices
    {
        List<Group> _groups = new List<Group>();    
        public List<Group> Groups => _groups;

        public string CreateGroup(bool isonline,Categories categories)
        {
            Group group = new Group( isonline, categories);

            if (Groups.Count==0)
            {
                _groups.Add(group);
                return $"Created New Group{group.No.ToUpper().Trim()}";
            }

            foreach (Group item in Groups)
            {
                if (item.No.ToUpper().Trim() != group.No.ToUpper().Trim())
                {
                    _groups.Add(group);
                    return $"Created New Group{group.No.ToUpper().Trim()}";
                }
            }

            return "There is another group with this name";


        }
        public Group Find(string no)
        {
            foreach (Group item in Groups)
            {
                if (item.No.ToUpper().Trim()==no.ToUpper().Trim())return item;
                
            }
            return null;
        }

        public void CreateStudent(Student student,string no)
        {
            if (Groups.Count>0)
            {
                Group group= Find(no);
                if (group==null)
                {
                    Console.WriteLine("There is no group with this name");
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(student.FullName) || string.IsNullOrWhiteSpace(student.FullName))
                    {
                        Console.WriteLine("Please Enter Full Name");
                        return;
                    }
                    else
                    {
                        if (group.Students.Count<group.Limit)
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
                
            }
            else
            {
                Console.WriteLine("A student cannot be created without a group");
            }

            
        }

        public void DeleteStudent(string no , byte id)
        {
            if (Groups.Count>0)
            {


                Group group = Find(no);
                if (group != null)
                {
                    foreach (Student item in group.Students)
                    {
                        if (item.Id == id)
                        {
                            group.Students.Remove(item);
                            Console.WriteLine($"{item.FullName} was removed from the group");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Student do not found");
                        }
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
                Console.WriteLine("Not Yet Created Neither Group nor Student");
            }
        }

        public void ShowAllStudents()
        {
            if (Groups.Count>0)
            {
                foreach (Group item in Groups)
                {
                    foreach (Student student in item.Students)
                    {
                        Console.WriteLine(student);
                    }
                }
                if (Student.Count==0)
                {
                    Console.WriteLine("Not Yet Created Student");
                }
            }
            else
            {
                Console.WriteLine("Not Yet Created Group");
            }
        }

        public void ShowGroup()
        {
            if (Groups.Count>0)
            {
                foreach (Group item in Groups)
                {
                    Console.WriteLine(item); ;    
                }
            }
            else
            {
                Console.WriteLine("No group has been created yet"); 
            }
            
        }

        public void ShowStudentsInGroup(string no)
        {
            if (Groups.Count>0)
            {
                Group group = Find(no);
                if (group != null)
                {
                    foreach (Student item in group.Students)
                    {
                        Console.WriteLine(item +" "+ group.No);
                    }
                    if (Student.Count==0)
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
            if (Groups.Count>0)
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
            else
            {
                Console.WriteLine("Not Yet Craeted Group");
            }
        }
    }
}