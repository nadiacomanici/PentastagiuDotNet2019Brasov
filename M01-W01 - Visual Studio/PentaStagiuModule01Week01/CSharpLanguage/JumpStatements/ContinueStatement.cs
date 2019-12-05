using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLanguage.JumpStatements
{
    class ContinueStatement
    {
        public static void Run()
        {
            int nr;

            nr = 0;
            while (nr < 5)
            {
                nr++;
                if (nr == 3)
                    continue;
                Console.WriteLine("nr={0}", nr);
            }
            Console.WriteLine();

            nr = 0;
            do
            {
                nr++;
                if (nr == 3)
                    continue;
                Console.WriteLine("nr={0}", nr);
            } while (nr < 5);

            Console.WriteLine();

            for (nr = 0; nr < 5; nr++)
            {
                if (nr == 3)
                    continue;
                Console.WriteLine("nr={0}", nr);
            }

            Console.WriteLine();

            int[] array = { 1, 2, 3, 4 };
            foreach (int number in array)
            {
                if (number == 3)
                    continue;
                Console.WriteLine("number={0}", number);
            }
        }
    }
}
