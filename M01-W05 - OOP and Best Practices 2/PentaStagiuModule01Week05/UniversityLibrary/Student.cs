using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public class Student : Person
    {
        // default value is 0
        public int Id { get; private set; }

        // default value is null
        private List<int> marks;

        public Student(int id, string firstName, string lastName, DateTime birthDate, Gender gender)
            : base(firstName, lastName, birthDate, gender)
        {
            this.Id = id;
            this.marks = new List<int>();
        }
    }
}
