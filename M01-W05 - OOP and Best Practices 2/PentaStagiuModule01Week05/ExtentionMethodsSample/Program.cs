using System;
using ExtentionMethodsSample.Helpers;

namespace ExtentionMethodsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "   ";
            Console.WriteLine(str.IsEmpty());
        }
    }
}
