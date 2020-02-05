using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    class Program
    {
        static void ExampleDelegate()
        {
            NumberAdderThresholdDelegate adder = new NumberAdderThresholdDelegate(10);
            adder.ThresholdReached += Adder_ThresholdReached;
            adder.SumModified += Adder_SumModified;
            int number;
            do
            {
                Console.WriteLine("Enter a number");
                number = int.Parse(Console.ReadLine());
                adder.Add(number);
            } while (number != 0);
        }

        static void ExampleEventHandler()
        {
            NumberAdderThresholdEventHandler adder = new NumberAdderThresholdEventHandler(10);
            adder.ThresholdReached += Adder_ThresholdReached;
            adder.SumModified += Adder_SumModified;
            int number;
            do
            {
                Console.WriteLine("Enter a number");
                number = int.Parse(Console.ReadLine());
                adder.Add(number);
            } while (number != 0);
        }

        static void Main(string[] args)
        {
            //ExampleDelegate();
            ExampleEventHandler();
        }

        private static void Adder_SumModified(object sender, int sum)
        {
            Console.WriteLine($"The sum is now {sum}");
        }

        private static void Adder_ThresholdReached(object sender, EventArgs e)
        {
            Console.WriteLine("Threshold reached");
        }

        private static void Adder_SumModified(int sum)
        {
            Console.WriteLine($"The sum is now {sum}");
        }

        private static void Adder_ThresholdReached()
        {
            Console.WriteLine("Threshold reached");
        }
    }
}
