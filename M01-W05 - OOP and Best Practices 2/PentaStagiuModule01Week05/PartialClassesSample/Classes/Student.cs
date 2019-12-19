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
        public string FirstName { get; private set; }

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
