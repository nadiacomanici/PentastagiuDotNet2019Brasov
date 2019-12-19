using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityLibrary;

namespace UniversityConsoleApp
{
    class Program
    {
        private static University university;

        private static void DisplayMenu()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Display all students");
            Console.WriteLine("2 - Add a new student");
            Console.WriteLine("3 - Get a student by id");
            Console.WriteLine("4 - Delete a student by id");
            Console.WriteLine("5 - Update a student");
            Console.WriteLine("6 - Exit");
        }

        private static void DisplayStudent(Student student)
        {
            Console.WriteLine("{0} {1} (id={2}) - {3} - {4}",
                student.FirstName, student.LastName, student.Id, student.Gender, student.BirthDate);
        }

        private static void DisplayAllStudents()
        {
            Console.WriteLine("All students:");
            foreach (Student student in university.GetStudents())
            {
                DisplayStudent(student);
            }
        }

        private static Student ReadStudent()
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter gender (m/f): ");
            string genderLetter = Console.ReadLine().ToLower().Trim();
            Gender gender = Gender.Male;
            switch (genderLetter)
            {
                case "m":
                    gender = Gender.Male;
                    break;
                case "f":
                    gender = Gender.Female;
                    break;
                default:
                    throw new ArgumentException("Invalid value for gender");
            }

            Console.Write("Enter year of birth (yyyy): ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Enter month of birth (1-12): ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter day of birth (1-31): ");
            int day = int.Parse(Console.ReadLine());

            return university.AddStudent(firstName, lastName, new DateTime(year, month, day), gender);
        }

        private static void DeleteStudentById()
        {
            Console.Write("Delete student by id: ");
            int id = int.Parse(Console.ReadLine());
            bool wasStudentDeleted = university.DeleteStudentById(id);
            if (wasStudentDeleted)
            {
                Console.WriteLine("Student was deleted");
            }
            else
            {
                Console.WriteLine("No student with that id");
            }
        }

        private static void SearchStudentById()
        {
            Console.Write("Search student by id: ");
            int id = int.Parse(Console.ReadLine());
            Student foundStudent = university.GetStudentById(id);
            if (foundStudent != null)
            {
                DisplayStudent(foundStudent);
            }
            else
            {
                Console.WriteLine("No student with that id");
            }
        }

        static void Main(string[] args)
        {
            university = new University(new StudentsService());
            university.AddStudent("Nadia", "Comanici", new DateTime(1986, 01, 24), Gender.Female);
            university.AddStudent("Radu", "Popescu", new DateTime(1990, 10, 13), Gender.Male);

            while (true)
            {
                DisplayMenu();

                Console.Write("Your option is: ");
                int option = 0;
                int.TryParse(Console.ReadLine(), out option);

                Console.WriteLine();

                switch (option)
                {
                    case 1:
                        DisplayAllStudents();
                        break;
                    case 2:
                        ReadStudent();
                        break;
                    case 3:
                        SearchStudentById();
                        break;
                    case 4:
                        DeleteStudentById();
                        break;
                    case 5:
                        UpdateStudentById();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again!");
                        break;
                }

                Console.WriteLine();
            }
        }

        private static void UpdateStudentById()
        {
            Console.Write("Update student by id: ");
            int id = int.Parse(Console.ReadLine());

            Student foundStudent = university.GetStudentById(id);
            if (foundStudent != null)
            {
                Console.Write("Enter new first name: ");
                string newFirstName = Console.ReadLine();

                Console.Write("Enter new last name: ");
                string newLastName = Console.ReadLine();

                bool wasStudentUpdated = university.UpdateStudent(id, newFirstName, newLastName);
                if (wasStudentUpdated)
                {
                    Console.WriteLine("Student was updated");
                }
                else
                {
                    Console.WriteLine("Student could not be updated");
                }
            }
            else
            {
                Console.WriteLine("No student with that id");
            }
        }
    }
}
