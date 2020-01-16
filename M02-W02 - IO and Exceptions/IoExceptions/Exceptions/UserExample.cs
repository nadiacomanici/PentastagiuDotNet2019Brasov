using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class UserExample
    {
        private List<string> _students = new List<string> { "Ovidiu", "Nadia", "Ionut" };
        private string _loggedInUser;

        public void Run()
        {
            Console.WriteLine("Username:");
            _loggedInUser = Console.ReadLine();
            Console.WriteLine("Logged in as {0}", _loggedInUser);

            int choice = 0;
            do
            {
                try
                {                    
                    PrintMenu();
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        PrintStudents();
                    }
                    else if (choice == 2)
                    {
                        DeleteStudents();
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid number");
                }
                catch(UserUnauthorizedException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (choice != 3);
        }

        private void PrintStudents()
        {
            foreach(string student in _students)
            {
                Console.WriteLine(student);
            }
        }

        private void DeleteStudents()
        {
            if (_loggedInUser == "admin")
            {
                _students.Clear();
            }
            else
            {
                throw new UserUnauthorizedException(_loggedInUser);
            }
        }

        private void PrintMenu()
        {
            Console.WriteLine("1. View students");
            Console.WriteLine("2. Delete students");
            Console.WriteLine("3. Exit");
        }
    }
}
