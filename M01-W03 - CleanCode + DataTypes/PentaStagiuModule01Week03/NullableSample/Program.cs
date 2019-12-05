using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // value type, not nullable, can store an integer value
            int index = 0;

            // incorrect: compile error because int is a value type
            // int anotherIndex = null;

            // correct, because int? is nullable
            // it can store either null or a value
            int? nullableIndex = null;
            nullableIndex = 2;

            if (nullableIndex.HasValue)
            {
                Console.WriteLine("NullableIndex=: " + nullableIndex.Value);
            }
            else
            {
                Console.WriteLine("NullableIndex is null");
            }

            // 'Nullable<int>' is the same as 'int?'
            Nullable<int> anotherNullableIndex = null;
        }
    }
}
