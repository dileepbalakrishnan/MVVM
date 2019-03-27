using System.Collections.Generic;

namespace DataService
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public List<string> Courses { get; set; }
    }
}
