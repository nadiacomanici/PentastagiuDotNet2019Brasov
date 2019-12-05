using System;
using System.Collections.Generic;

namespace MeaningfulNames_End
{
    class Program
    {
        //public static double ComputeAverage(List<int> numbers)
        //{
        //    return numbers.Count == 0 ? 0 : numbers.Average();
        //}

        public static double ComputeAverage(List<int> numbers)
        {
            double sum = 0;
            int howManyNumbers = 0;

            foreach (int number in numbers)
            {
                sum += number;
                howManyNumbers++;
            }

            if (howManyNumbers == 0)
            {
                return 0;
            }
            else
            {
                return sum / howManyNumbers;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ComputeAverage(new List<int>()));
            Console.WriteLine(ComputeAverage(new List<int> { 1, 2, 3, 4, 5 }));
            Console.WriteLine(ComputeAverage(new List<int> { 10, -2, -13, 4, 9 }));
        }
    }
}
