using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsSample
{
    class Program
    {
        public static int ComputeSum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public static void SetNumberToOne(out int x)
        {
            x = 1;
        }

        public static void IncrementNumber(ref int x)
        {
            x++;
        }

        public static int MultiplyNumber(int x, int multiplicationFactor = 1)
        {
            return x * multiplicationFactor;
        }

        static void Main(string[] args)
        {
            int number = 3;
            Console.WriteLine($"Before: {number}");
            IncrementNumber(ref number);
            Console.WriteLine($"After: {number}");

            int a;
            // this line has a compile error because 
            // you cannot use an unassigned variable
            // Console.WriteLine($"Before: {a}");
            // but you can send it as an out parameter
            SetNumberToOne(out a);
            Console.WriteLine($"After: {a}");

            int b = 4;
            Console.WriteLine($"Before: {b}");
            // you can also send an initialized argument 
            // as an out parameter
            SetNumberToOne(out b);
            Console.WriteLine($"After: {b}");

            Console.WriteLine(ComputeSum());
            Console.WriteLine(ComputeSum(1));
            Console.WriteLine(ComputeSum(1, 12));
            Console.WriteLine(ComputeSum(1, 2, 3, 4, 5, 6));

            Console.WriteLine(MultiplyNumber(3));
            Console.WriteLine(MultiplyNumber(3, 1));
            Console.WriteLine(MultiplyNumber(3, 2));
        }
    }
}
