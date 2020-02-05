using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregationPrincipleBad
{
    interface IMultifunctionalMachine
    {
        void Print();
        void Scan();
        void Copy();
    }

    class MultifunctionalMachine : IMultifunctionalMachine
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

    class MultifunctionalMachineWithoutScanning : IMultifunctionalMachine
    {
        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public void Scan()
        {
            throw new NotImplementedException();
        }

        public void Copy()
        {
            Console.WriteLine("Copying...");
        }
    }

    class Example
    {
        static void MakeScan(IMultifunctionalMachine machine)
        {
            machine.Scan();
        }
    }
}
