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
        private int Id { get; set; }
        private string Name { get; set; }
        private string StudentId { get; set; }
        private int CoursesTaken { get; set; }

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
