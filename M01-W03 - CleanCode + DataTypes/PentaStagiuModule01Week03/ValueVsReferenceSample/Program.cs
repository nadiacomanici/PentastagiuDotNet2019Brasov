using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVsReferenceSample
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    public class Book
    {
        public string Name;
    }

    class Program
    {
        private static void VariablesSample()
        {
            // x are y are value types
            int x = 3;
            int y = x;
            x = x + 1;
            Console.WriteLine($"x={x} and y={y}");

            // Point is a struct, so it is a value type
            Point p1 = new Point(10, 20);
            Point p2 = p1;
            p1.X = 30;
            p1.Y = 40;
            Console.WriteLine($"FirstPoint: x={p1.X} and y={p1.Y}");
            Console.WriteLine($"SecondPoint: x={p2.X} and y={p2.Y}");

            // Book is a class, so it's a reference type
            Book book1 = new Book();
            book1.Name = "A tale of two cities";
            Book book2 = book1;
            book1.Name = "Great expectations";
            Console.WriteLine($"book1.Name = {book1.Name}");
            Console.WriteLine($"book2.Name = {book2.Name}");
        }

        static void IncrementNumber(int number)
        {
            number++;
        }

        private static void ValueParametersSample()
        {
            int x = 32;
            Console.WriteLine("Before: x = {0}", x);
            IncrementNumber(x);
            Console.WriteLine("After: x = {0}", x);
        }


        static void SetBookName(Book book)
        {
            book.Name = "Alice in wonderland";
        }

        private static void ReferenceParametersSample()
        {
            Book book = new Book();
            Console.WriteLine($"Before: book.Name = {book.Name}");

            SetBookName(book);
            Console.WriteLine($"After: book.Name = {book.Name}");
        }

        static void Main(string[] args)
        {
            VariablesSample();
            ValueParametersSample();
            ReferenceParametersSample();
        }
    }
}
