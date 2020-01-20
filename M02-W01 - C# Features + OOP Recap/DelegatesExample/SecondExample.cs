using DelegatesExample.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    class SecondExample
    {
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
            OperationPerformer.PerformOperation opAdd = PerformAddition;
            OperationPerformer.PerformOperation opSub = PerformSubtraction;

            OperationPerformer perfAdd = new OperationPerformer(opAdd);
            perfAdd.Perform();
            /*OperationPerformer perfAddWithMethod = new OperationPerformer(PerformAddition);
            perfAddWithMethod.Perform();

            OperationPerformer perfSub = new OperationPerformer(opSub);
            perfSub.Perform();
            OperationPerformer perfSubWithMethod = new OperationPerformer(PerformSubtraction);
            perfSubWithMethod.Perform();*/
        }
    }
}
