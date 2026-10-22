using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_Class_obj_Rep.Models
{
    internal class Course
    {
        public string CourseName { get; }

        private readonly List<Student> _students = new List<Student>();



        public Course(string courseName)
        {
            CourseName = courseName;
        }



        //Create a student object outside the Course class => Aggrigation
        public void AddStudent(Student student)
        {
            _students.Add(student);
        }


        public void ShowStudents()
        {
            Console.WriteLine($"Student in {CourseName}");

            foreach (var student in _students)
            {
                Console.WriteLine($"  - {student.Name}");
            }

        }
    }
}
