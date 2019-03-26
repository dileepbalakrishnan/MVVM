using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService
{
    public interface IStudentDataRepository
    {
        List<Student> GetAllStudents();
        Student GetStudentByEmail(string email);
        void SaveStudent(Student student);
        void DeleteStudent(Student student);
        void UpdateStudent(Student student);
    }
}
