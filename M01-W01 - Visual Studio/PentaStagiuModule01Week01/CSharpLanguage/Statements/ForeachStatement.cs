using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLanguage.Statements
{
    class ForeachStatement
    {
        public static void Run()
        {
            int[] array = { 1, 2, 3, 4 };
            foreach (int number in array)
            {
                Console.WriteLine(number + 1);
            }
        }
    }
}
