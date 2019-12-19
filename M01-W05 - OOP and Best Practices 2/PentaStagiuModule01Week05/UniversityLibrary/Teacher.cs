using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public class Teacher : Person
    {
        // default value is null
        public string ScientificTitle { get; private set; }

        public override string FullName
        {
            get
            {
                return $"{ScientificTitle} {FirstName} {LastName}";
            }
        }

        public Teacher(string scientificTitle, string firstName, string lastName, DateTime birthDate, Gender gender)
            : base(firstName, lastName, birthDate, gender)
        {
            this.ScientificTitle = scientificTitle;
        }
    }
}
