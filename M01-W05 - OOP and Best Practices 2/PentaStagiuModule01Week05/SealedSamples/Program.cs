using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedSamples
{

    public class BaseClass
    {
        public virtual void DoSomething()
        {

        }
    }

    public class BaseClassWithSealedMethod : BaseClass
    {
        // a sealed method must be override too
        public sealed override void DoSomething()
        {

        }
    }

    public sealed class SealedClass
    {

    }

    // cannot derive from a sealed class
    //public class ImpossibleClass : SealedClass
    //{

    //}

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
