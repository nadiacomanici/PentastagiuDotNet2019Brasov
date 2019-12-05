using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLanguage.Statements
{
    class SwitchStatement
    {
        public static void Run()
        {
            Console.WriteLine("Type a number:");
            string str = Console.ReadLine();
            int nr = int.Parse(str);
            switch (nr)
            {
                case 1:
                    Console.WriteLine("The number is 1");
                    break;
                case 2:
                    Console.WriteLine("The number is 2");
                    break;
                default:
                    Console.WriteLine("The number is not in the list");
                    break;
            }
        }
    }
}
