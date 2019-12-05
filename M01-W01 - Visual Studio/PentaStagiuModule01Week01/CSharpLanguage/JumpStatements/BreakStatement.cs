using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLanguage.JumpStatements
{
    class BreakStatement
    {
        public static void Run()
        {
            int nr;

            nr = 2;
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

            nr = 0;
            while (nr < 5)
            {
                nr++;
                if (nr == 3)
                    break;
            }

            nr = 0;
            do
            {
                nr++;
                if (nr == 3)
                    break;
            } while (nr < 5);

            for (nr = 0; nr < 5; nr++)
            {
                if (nr == 3)
                    break;
            }

            int[] array = {1, 2, 3, 4};
            foreach (int number in array)
            {
                if (number == 3)
                    break;
            }
        }
    }
}
