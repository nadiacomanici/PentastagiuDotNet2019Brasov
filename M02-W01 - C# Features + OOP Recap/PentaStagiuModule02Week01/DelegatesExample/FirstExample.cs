using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    class FirstExample
    {
        delegate double PerformOperation(double a, double b);

        double PerformAddition(double x, double y)
        {
            return x + y;
        }

        double PerformSubtraction(double x, double y)
        {
            return x - y;
        }

        public void Run()
        {
            PerformOperation op = PerformAddition;
            double result = op(1, 2);
            Console.WriteLine(result);

            PerformOperation op1 = PerformAddition;
            PerformOperation op2 = PerformSubtraction;
            PerformOperation opComb = op1 + op2;

            double res = opComb(1, 2);
        }
    }
}
