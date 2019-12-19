using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public class StudentsService : IStudentsService
    {
        // code as in previous slides
        private List<Student> students;
        private static int nextId = 1;

        public StudentsService()
        {
            this.students = new List<Student>();
            AddStudent("Vasile", "Popescu", new DateTime(1990, 03, 02), Gender.Male);
            AddStudent("Maria", "Ionescu", new DateTime(1988, 02, 24), Gender.Female);
            AddStudent("Ionel", "Georgescu", new DateTime(1991, 11, 13), Gender.Male);
        }

        public Student AddStudent(string firstName, string lastName, DateTime birthDate, Gender gender)
        {
            Student student = new Student(nextId++, firstName, lastName, birthDate, gender);
            this.students.Add(student);
            return student;
        }

        public List<Student> GetStudents()
        {
            return this.students;
        }

        public Student GetStudentById(int id)
        {
            foreach (Student student in this.students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }

        public bool DeleteStudentById(int id)
        {
            Student student = GetStudentById(id);
            if (student != null)
            {
                students.Remove(student);
                return true;
            }
            return false;
        }

        public bool UpdateStudent(int id, string newFirstName, string newLastName)
        {
            Student student = GetStudentById(id);
            if (student != null)
            {
                student.FirstName = newFirstName;
                student.LastName = newLastName;
                return true;
            }
            return false;
        }
    }
}
