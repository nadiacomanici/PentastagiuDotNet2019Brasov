using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLanguage.Topics
{
    class InputOutput
    {
        public static void Run()
        {
            string input;
            Console.WriteLine("Enter some text:");
            input = Console.ReadLine();
            Console.WriteLine("The text you entered is {0}", input);
        }
    }
}
