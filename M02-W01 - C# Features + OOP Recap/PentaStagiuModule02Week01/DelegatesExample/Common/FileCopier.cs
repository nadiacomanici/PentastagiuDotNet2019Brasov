using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample.Common
{
    public class FileCopier
    {
        public delegate void Printer(string message);

        private Random _rnd = new Random();

        public void StartCopying(Printer printSuccess, Printer printError)
        {
            for (int i = 0; i < 20; i++)
            {
                bool success = _rnd.Next(100) % 2 == 0;
                if (success)
                {
                    if (printSuccess != null)
                    {
                        printSuccess($"File {i} was copied");
                    }
                }
                else
                {
                    if (printError != null)
                    {
                        printError($"File {i} could not be copied");
                    }
                }
            }
        }
    }
}
