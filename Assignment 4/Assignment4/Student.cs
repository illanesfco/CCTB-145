using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Student
    {
        //Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string StudentId { get; set; }
        public int CoursesTaken { get; set; }

        //Constructos
        public Student()
        {

        }

        public Student(int id, string name, string studentId)
        {
            Id = id;
            Name = name;
            StudentId = studentId;
            CoursesTaken = 0;
        }

        //Methods
        public void IncreaseCoursesTaken()
        {
            CoursesTaken++;
        }

        public void OutputStudentDetails()
        {
            Console.WriteLine("{0} (Student ID: {1}) has taken {2} course(s)", Name, StudentId, CoursesTaken);
        }

        




    }
}
