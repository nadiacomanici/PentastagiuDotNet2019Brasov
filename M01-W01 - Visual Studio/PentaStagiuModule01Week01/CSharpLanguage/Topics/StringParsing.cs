using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLanguage.Topics
{
    class StringParsing
    {
        public static void Run()
        {
            Console.WriteLine("Type a number:");
            string str = Console.ReadLine();
            int nr = int.Parse(str);
            Console.WriteLine("The number after that is {0}", nr + 1);
        }
    }
}
