using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*FirstExample fe = new FirstExample();
            fe.Run();
            */
            SecondExample se = new SecondExample();
            se.Run();
            Console.WriteLine("");
            /*ThirdExample te = new ThirdExample();
            te.Run();*/

            /*FourthExample fe = new FourthExample();
            fe.Run();*/
        }
    }
}
