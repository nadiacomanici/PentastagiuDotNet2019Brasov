using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSample
{
    public abstract class MultiplicationBaseClass
    {
        public abstract int MultiplyNumber(int x);
    }

    public class ThreeTimesMultiplication : MultiplicationBaseClass
    {
        public override int MultiplyNumber(int x)
        {
            return 3 * x;
        }
    }

    public class NoMultiplication : MultiplicationBaseClass
    {
        public override int MultiplyNumber(int x)
        {
            return x;
        }
    }

    public class TenTimesMultiplication : MultiplicationBaseClass
    {
        public override int MultiplyNumber(int x)
        {
            return 10 * x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<MultiplicationBaseClass> multiplications = new List<MultiplicationBaseClass>();
            // compile time error because you cannot create an abstract class instance
            // multiplications.Add(new MultiplicationBaseClass());
            multiplications.Add(new ThreeTimesMultiplication());
            multiplications.Add(new NoMultiplication());
            multiplications.Add(new TenTimesMultiplication());

            int x = 3;
            foreach (MultiplicationBaseClass multiplication in multiplications)
            {
                Console.WriteLine(multiplication.MultiplyNumber(x));
            }
        }
    }
}
