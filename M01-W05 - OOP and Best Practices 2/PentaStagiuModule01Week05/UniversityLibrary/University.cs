using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public class University
    {
        private IStudentsService studentsService;

        public University(IStudentsService studentsService)
        {
            this.studentsService = studentsService;
        }

        public IEnumerable<Student> GetStudents()
        {
            return studentsService.GetStudents();
        }

        public Student GetStudentById(int id)
        {
            return studentsService.GetStudentById(id);
        }

        public Student AddStudent(string firstName, string lastName, DateTime birthDate, Gender gender)
        {
            return studentsService.AddStudent(firstName, lastName, birthDate, gender);
        }

        public bool DeleteStudentById(int id)
        {
            return studentsService.DeleteStudentById(id);
        }

        public bool UpdateStudent(int id, string newFirstName, string newLastName)
        {
            return studentsService.UpdateStudent(id, newFirstName, newLastName);
        }
    }
}
