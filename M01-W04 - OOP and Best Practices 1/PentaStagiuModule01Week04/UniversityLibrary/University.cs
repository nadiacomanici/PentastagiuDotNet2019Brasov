using System.Collections.Generic;

namespace UniversityLibrary
{
    public class University
    {
        private List<Student> students;
        private List<Teacher> teachers;

        public University()
        {
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }
    }
}
