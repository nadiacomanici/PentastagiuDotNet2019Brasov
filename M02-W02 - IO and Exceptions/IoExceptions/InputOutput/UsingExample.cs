using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    class MyDisposableClass : IDisposable
    {
        public MyDisposableClass()
        {
            Console.WriteLine("Acquiring resources");
        }

        public void UseResource()
        {
            Console.WriteLine("Using resource");
        }

        public void Dispose()
        {
            Console.WriteLine("Releasing resources");
        }
    }

    class UsingExample
    {
        public void Run()
        {
            MyDisposableClass object1 = new MyDisposableClass();
            object1.UseResource();
            object1.Dispose();

            using (MyDisposableClass object2 = new MyDisposableClass())
            {
                object2.UseResource();
            }
        }
    }
}
