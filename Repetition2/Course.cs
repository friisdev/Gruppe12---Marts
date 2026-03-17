using System;
using System.Collections.Generic;
using System.Text;

namespace Repetition2
{
    public class Course
    {
        public string CourseName { get; set; }
        public List<Student> Students { get; set; }
        public Course(string courseName)
        {
            CourseName = courseName;
            Students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void PrintStudents()
        {
            Console.WriteLine($"Course: {CourseName}");
            foreach (var student in Students)
            {
                student.PrintInfo();
            }

        }

        public void PrintStudentsByAge(int age)
        {
        foreach (var student in Students)
            {
                if (student.Age > age)
                {
                    student.PrintInfo();
                }
            }


        }


    }
}
