using DelegatesExample.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    class ConsolePrinter
    {
        private ConsoleColor color;
        public ConsolePrinter(ConsoleColor color)
        {
            this.color = color;
        }
        public void Print(string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }

    class ThirdExample
    {
        public void Run()
        {
            ConsolePrinter successPrinter = new ConsolePrinter(ConsoleColor.Green);
            ConsolePrinter errorPrinter = new ConsolePrinter(ConsoleColor.Red);

            FileCopier copier = new FileCopier();
            FileCopier.Printer printerSuccess = successPrinter.Print;
            FileCopier.Printer printerError = errorPrinter.Print;

            copier.StartCopying(printerSuccess, printerError);
        }
    }
}
