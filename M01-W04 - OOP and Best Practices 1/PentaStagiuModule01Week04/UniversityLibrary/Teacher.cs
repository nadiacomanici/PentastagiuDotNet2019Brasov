using System;

namespace UniversityLibrary
{
    public class Teacher : Person
    {
        // default value is null
        public string ScientificTitle { get; private set; }

        public Teacher(string scientificTitle, string firstName, string lastName, DateTime birthDate, Gender gender)
            : base(firstName, lastName, birthDate, gender)
        {
            this.ScientificTitle = scientificTitle;
        }
    }
}
