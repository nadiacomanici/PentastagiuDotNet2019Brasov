using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Person
    {
        public virtual string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        // ToString() is virtual in object class
        // and every class in C# derives from object
        public override string ToString()
        {
            return FullName;
        }

        public const int MinimumAgeForId = 14;
        public static int MinimumAgeForVoting = 18;
        public readonly int MinimumAgeForRetirement;

        // default value is null
        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    firstName = value;
                }
            }
        }
        public string LastName { get; set; }

        // default value is 1/1/0001 12:00:00 AM
        public DateTime BirthDate { get; private set; }

        // default value is first enum value
        public Gender Gender { get; private set; }

        /// <summary>
        /// Computed property to determine the age of a person
        /// </summary>
        public double Age
        {
            get
            {
                return (DateTime.Now - this.BirthDate).TotalDays / 365.2425;
            }
        }

        public bool CanVote
        {
            get
            {
                return this.Age > MinimumAgeForVoting;
            }
        }

        public Person() : this("John", "Doe", DateTime.Now, Gender.Male)
        {

        }

        public Person(string firstName, string lastName, DateTime birthDate, Gender gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Gender = gender;
            this.MinimumAgeForRetirement = gender == Gender.Male ? 65 : 63;
        }
    }
}