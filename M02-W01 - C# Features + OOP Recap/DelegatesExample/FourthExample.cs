using DelegatesExample.Common;
using System;

namespace DelegatesExample
{
    class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine($"To console: {message}");
        }

        public void LogToFile(string message)
        {
            Console.WriteLine($"To file: {message}");
        }
    }

    class FourthExample
    {
        public void Run()
        {
            Logger logger = new Logger();
            FileCopier.Printer printerConsole = logger.LogToConsole;
            FileCopier.Printer printerFile = logger.LogToFile;

            FileCopier.Printer printerCombined = printerConsole + printerFile;

            FileCopier copier = new FileCopier();
            copier.StartCopying(printerCombined, null);
        }
    }
}
