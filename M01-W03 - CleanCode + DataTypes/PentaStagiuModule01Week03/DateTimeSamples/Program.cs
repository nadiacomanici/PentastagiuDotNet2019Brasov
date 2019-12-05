using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("dd/MM/yyyy"));

            DateTime birthDate = new DateTime(1086, 01, 24, 06, 31, 50);
            DateTime aYearAgo = now.AddYears(1);

            TimeSpan diff = now - birthDate;
            Console.WriteLine($"Time elapsed in days:{diff.TotalDays}");
            Console.WriteLine($"Time elapsed in minutes:{diff.TotalMinutes}");
            Console.WriteLine($"Time elapsed: {diff.Days} days and {diff.Minutes} and {diff.Seconds} and {diff.Milliseconds}");
        }
    }
}
