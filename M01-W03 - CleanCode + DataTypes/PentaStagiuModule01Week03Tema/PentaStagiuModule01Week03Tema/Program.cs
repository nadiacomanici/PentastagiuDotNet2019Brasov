using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaStagiuModule01Week03Tema
{
    public enum Gender
    {
        Male,
        Female
    }

    class Program
    {
        private const int minAgeForRetirementMale = 65;
        private const int minAgeForRetirementFemale = 63;

        private static int ReadNumericInput(string messageToDisplay)
        {
            Console.Write(messageToDisplay);
            return int.Parse(Console.ReadLine());
        }

        private static int ComputeAge(DateTime birthDate)
        {
            return (int)((DateTime.Now - birthDate).TotalDays / 365.25);
        }

        private static DateTime ReadBirthDate()
        {
            int year = ReadNumericInput("Introduceti anul nasterii: ");
            int month = ReadNumericInput("Introduceti luna nasterii: ");
            int day = ReadNumericInput("Introduceti ziua nasterii: ");

            return new DateTime(year, month, day);
        }

        private static Gender? ReadGender()
        {
            Console.Write("Introduceti genul (M/F): ");
            char genderAsChar = Convert.ToChar(Console.ReadLine());

            Gender? gender = null;
            switch (genderAsChar)
            {
                case 'm':
                case 'M':
                    gender = Gender.Male;
                    break;
                case 'f':
                case 'F':
                    gender = Gender.Female;
                    break;
            }

            return gender;
        }

        private static string GetRetirementMessage(DateTime birthDate, int minAgeForRetirement)
        {
            int age = ComputeAge(birthDate);
            if (age > minAgeForRetirement)
            {
                return "Deja te-ai pensionat!";
            }
            else
            {
                return $"Te vei pensiona la {minAgeForRetirement} de ani";
            }
        }

        private static void DisplayRetirementMessage(Gender? gender, DateTime birthDate)
        {
            if (gender.HasValue)
            {
                switch (gender.Value)
                {
                    case Gender.Male:
                        Console.WriteLine(GetRetirementMessage(birthDate, minAgeForRetirementMale));
                        break;
                    case Gender.Female:
                        Console.WriteLine(GetRetirementMessage(birthDate, minAgeForRetirementFemale));
                        break;
                }
            }
            else
            {
                Console.WriteLine("Nu ati introdus genul corect!");
            }
        }

        static void Main(string[] args)
        {
            DateTime birthDate = ReadBirthDate();
            Gender? gender = ReadGender();
            DisplayRetirementMessage(gender, birthDate);
        }
    }
}
