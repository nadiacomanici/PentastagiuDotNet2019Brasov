using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    class Base { }
    class Derived : Base { }
    class MoreDerived : Derived { }

    class Program
    {
        static void ImplicitConversions()
        {
            int intValue = 123456;
            long longValue = intValue;

            Console.WriteLine("\n### ImplicitConversions ###");
            Console.WriteLine(longValue);

            Derived d = new Derived();
            Base b = d;
        }

        static void ExplicitConversions()
        {
            long longValue = 123;
            int intValue = (int)longValue; // compiler error without cast

            Console.WriteLine("\n### ExplicitConversions ###");
            Console.WriteLine(intValue);

            Base b = new Derived();
            Derived d = (Derived)b; // compiler error without cast
        }

        static void InvalidCastException()
        {
            object o = new object();
            Derived d = (Derived)o; // InvalidCastException
        }

        static void IsOperator()
        {
            Base b = new Base();

            Console.WriteLine("\n### IsOperator ###");
            Console.WriteLine(b is Base); // true
            Console.WriteLine(b is Derived); // false
        }

        static void AsOperator()
        {
            Derived d = new Derived();
            Base b = d as Base; // not null reference to derived
            MoreDerived md = d as MoreDerived; // null
        }

        static void UserDefinedConversion()
        {
            ComplexNumber cnExplicit = (ComplexNumber)1; // explicit conversion
            ComplexNumber cnImplicit = 1; // implicit conversion

            Console.WriteLine("\n### UserDefinedConversion ###");
            Console.WriteLine("Explicit: " + cnExplicit);
            Console.WriteLine("Implicit: " + cnImplicit);
        }

        static void ConvertWithHelperClasses()
        {
            int convertedPi = Convert.ToInt32(3.14);

            string base64Converted = Convert.ToBase64String(new byte[] { 0xDE, 0xAD, 0xBE, 0xEF });

            byte[] bytesFromBase64 = Convert.FromBase64String("3q2+7w==");

            byte[] bytesPi = BitConverter.GetBytes(3.14);
        }
        
        static void Main(string[] args)
        {
            ImplicitConversions();
            ExplicitConversions();
            InvalidCastException();
            IsOperator();
            AsOperator();
            UserDefinedConversion();
            ConvertWithHelperClasses();
        }
    }
}
