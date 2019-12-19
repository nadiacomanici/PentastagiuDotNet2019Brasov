using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassesSample
{
    // must specify partial before class
    // and namespace must match for both partial classes
    public partial class Student
    {
        public string LastName { get; private set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ion", "Vasile");
            Console.WriteLine($"{student.FirstName} {student.LastName}");
        }
    }
}
