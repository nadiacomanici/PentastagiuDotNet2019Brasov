using System;
using UniversityLibrary;

namespace UniversityConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student nadia = new Student(1, "Nadia", "Comanici", new DateTime(1986, 01, 24), Gender.Female);
            Student radu = new Student(2, "Radu", "Popescu", new DateTime(1990, 10, 13), Gender.Male);

            Teacher teacher = new Teacher("Dr.", "Maria", "Georgescu", new DateTime(1972, 02, 29), Gender.Female);

        }
    }
}
