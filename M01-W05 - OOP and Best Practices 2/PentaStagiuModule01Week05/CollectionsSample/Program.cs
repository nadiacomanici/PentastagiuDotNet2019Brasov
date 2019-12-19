using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsSample
{
    class Program
    {
        public void DisplayNumbersUntilZero(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (number == 0)
                {
                    return;
                }
                Console.WriteLine(number);
            }
        }

        public double ComputeAverage(List<int> numbers)
        {
            if (numbers != null && numbers.Count > 0)
            {
                double sum = 0;
                foreach (int number in numbers)
                {
                    sum += number;
                }
                return sum / numbers.Count;
            }
            // If we don't write this line, we will 
            // get a compile error that:
            //not all code paths return a value
            return 0;
        }

        // If we don't declare the method as static
        // we will get a compile time error because
        // Main method is static and can call only other
        // static methods
        public static void DisplayNumbers(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public class Book
        {
            public string Name { get; private set; }
            public Book(string name)
            {
                this.Name = name;
            }

            // if we don't override the 'ToString()' method
            // the Console.WriteLine call will display
            // the full qualified name of the class
            // instead of something specific to the instance
            public override string ToString()
            {
                return this.Name;
            }
        }

        static void Main(string[] args)
        {
            // declare and assign collection
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            DisplayNumbers(numbers);

            // declare a fixed size collection and assign values afterwards
            int[] integers = new int[3];
            integers[0] = 10;
            integers[1] = 11;
            integers[2] = 12;
            DisplayNumbers(integers);

            // declare and create a dynamic-size collection
            List<int> genericList = new List<int>();
            // add as many items as you want
            genericList.Add(1);
            genericList.Add(13);
            genericList.Add(21);
            genericList.Add(33);
            // get the number of items in the list
            int genericListCount = genericList.Count;
            // remove item at specified index
            genericList.RemoveAt(1);
            // remove specified item 
            genericList.Remove(21);
            // remove all items
            genericList.Clear();

            List<object> allKindsOfObjects = new List<object>();
            allKindsOfObjects.Add(1);
            allKindsOfObjects.Add(2.34);
            allKindsOfObjects.Add("String here");
            allKindsOfObjects.Add(new Book("Ion"));
            foreach (object obj in allKindsOfObjects)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
