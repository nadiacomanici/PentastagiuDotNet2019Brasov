using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregationPrincipleGood
{
    interface IPrinter
    {
        void Print();
    }

    interface IScanner
    {
        void Scan();
    }

    interface ICopier
    {
        void Copy();
    }

    class MultifunctionalMachine : IPrinter, ICopier, IScanner
    {
        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning...");
        }

        public void Copy()
        {
            Console.WriteLine("Copying...");
        }
    }

    class MultifunctionalMachineWithoutScanning : IPrinter, ICopier
    {
        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public void Copy()
        {
            Console.WriteLine("Copying...");
        }
    }

    class Example
    {
        static void MakeScan(IScanner scanner)
        {
            scanner.Scan();
        }
    }
}
