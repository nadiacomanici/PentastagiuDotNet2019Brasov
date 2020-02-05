using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample.Common
{
    public class OperationPerformer
    {
        public delegate double PerformOperation(double a, double b);

        private PerformOperation _operation;

        public OperationPerformer(PerformOperation operation)
        {
            _operation = operation;
        }

        public void Perform()
        {
            Console.WriteLine("Enter the number X");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number Y");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine($"The result of the operation is {_operation(x, y)}");
        }
    }
}
