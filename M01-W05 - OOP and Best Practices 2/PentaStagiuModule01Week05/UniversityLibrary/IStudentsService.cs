using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public interface IStudentsService
    {
        Student AddStudent(string firstName, string lastName, DateTime birthDate, Gender gender);
        List<Student> GetStudents();
        Student GetStudentById(int id);
        bool DeleteStudentById(int id);
        bool UpdateStudent(int id, string newFirstName, string newLastName);
    }


}
