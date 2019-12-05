using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLanguage.JumpStatements
{
    class GotoAndReturnStatement
    {
        public static void Run()
        {
            Console.WriteLine("Do you agree to the terms and conditions? Y/N");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                goto agreed;
            }
            else
            {
                goto didNotAgree;
            }

            agreed:
            Console.WriteLine("You agreed");
            return;

            didNotAgree:
            Console.WriteLine("You did not agree");
        }
    }
}
