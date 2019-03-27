using System;
using System.Collections.Generic;
using System.Linq;

namespace DataService
{
    public class StudentDataRespository : IStudentDataRepository
    {
        private readonly List<Student> _students;
        public StudentDataRespository()
        {
            _students = new List<Student>
            {
                new Student
                {
                    Name = "Dileep",
                    Age = 35,
                    Email = "dileep@microsoft.com",
                    Courses = new List<string>
                    {
                        "C# In Depth",
                        "Rx.Net In Action"
                    }
                },
                new Student
                {
                    Name = "Manu",
                    Age = 35,
                    Email = "manu@intel.com",
                    Courses = new List<string>
                    {
                        "C# In Depth",
                        "TPL DataFlows"
                    }
                }
            };
        }
        public List<Student> GetAllStudents()
        {
            return _students;
        }

        public Student GetStudentByEmail(string email)
        {
            return _students.FirstOrDefault(s => s.Email == email);
        }

        public void SaveStudent(Student student)
        {
            if (_students.Any(s => s.Email == student.Email))
            {
                throw new InvalidOperationException($"A student already exists with same email - {student.Email}.");
            }
            _students.Add(student);
        }

        public void DeleteStudent(Student student)
        {
            _students.Remove(student);
        }

        public void UpdateStudent(Student student)
        {
            var old = _students.FirstOrDefault(s => s.Email == student.Email);
            if (old == null)
            {
                throw new InvalidOperationException($"A student with email - {student.Email} - does not exist.");
            }
        }
    }
}