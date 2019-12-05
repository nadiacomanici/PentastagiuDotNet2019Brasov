using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLanguage.Statements
{
    class WhileStatement
    {
        public static void Run()
        {
            int a = 30;
            int b = 7;
            int x = 0;
            while (a > 0)
            {
                a = a - b;
                x++;
            }
            Console.WriteLine("b can be subtracted from a {0} times", x);
        }
    }
}
