using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLanguage.Topics
{
    class GenerateRandomNumber
    {
        public static void Run()
        {
            Random rng = new Random();
            int r = rng.Next(1, 100);
            Console.WriteLine(r);
        }
    }
}
