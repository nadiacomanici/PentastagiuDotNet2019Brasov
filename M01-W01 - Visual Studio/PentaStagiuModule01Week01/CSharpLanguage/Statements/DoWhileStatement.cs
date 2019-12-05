using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLanguage.Statements
{
    class DoWhileStatement
    {
        public static void Run()
        {
            int x = 0;
            do
            {
                Console.WriteLine("Enter a negative number");
                string str = Console.ReadLine();
                x = int.Parse(str);
            } while (x >= 0);
            Console.WriteLine("You entered the number {0}", x);
        }
    }
}
