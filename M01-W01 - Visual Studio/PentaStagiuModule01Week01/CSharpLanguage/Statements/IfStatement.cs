﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLanguage.Statements
{
    class IfStatement
    {
        public static void Run()
        {
            Console.WriteLine("Type a number:");
            string str = Console.ReadLine();
            int nr = int.Parse(str);
            if (nr > 5)
            {
                Console.WriteLine("The number is greater than 5");
            }
            else
            {
                Console.WriteLine("The number is not greater than 5");
            }
        }
    }
}
