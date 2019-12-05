using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLanguage.Topics
{
    class Constants
    {
        public static void Run()
        {
            const int y = 6;
            //y = 5; // Compile error
            Console.WriteLine("The value of y is {0}", y);
        }
    }
}
