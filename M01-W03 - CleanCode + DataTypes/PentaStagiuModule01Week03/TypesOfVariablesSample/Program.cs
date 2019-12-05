using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfVariablesSample
{
    public class Program
    {
        private static void IntegralSamples()
        {
            byte byteNumber = 255;
            sbyte sByteNumber = 127;
            short shortNumber = 32767;
            ushort uShortNumber = 65535;
            int intNumber = 123;
            uint uIntNumber = 4294967290;
            long longNumber = 4294967296;
            ulong uLongNumber = 9223372036854775808;
        }

        private static void CharSamples()
        {
            // Character literal
            char character = 'A';

            // Hexadecimal
            char charAsHexazecimal = '\x0041';

            // Cast from integral type
            char charFromIntCast = (char)65;

            // Unicode
            char charInUnicode = '\u0041';

            Console.WriteLine(character + charAsHexazecimal + charFromIntCast + charInUnicode);
            Console.WriteLine(character + " " + charAsHexazecimal + " "
                                + charFromIntCast + " " + charInUnicode);

            int intValueOfCharacter = (int)character;

        }

        private static void FloatingPointSamples()
        {
            // correct
            float floatValueWithSuffix = 3.5F;
            // incorrect
            //float floatValue = 3.5;

            // correct
            double doubleValue = 3;
            double doubleNumber = 3D;

            // correct
            decimal decimalValueWithSuffix = 300.5m;
            // incorrect
            //decimal decimalValue = 300.5;
        }

        private static void BoolSamples()
        {
            // correct
            bool canVote = true;
            bool hasGraduated = false;

            // incorrect
            //bool isAdult = 1;
            //bool isMale = 0;

            // correct
            if (canVote)
            {
                Console.WriteLine("I can vote");
            }

            if (!hasGraduated)
            {
                Console.WriteLine("Still in school");
            }

            if (hasGraduated == false)
            {
                Console.WriteLine("Still in school");
            }
        }

        static void Main(string[] args)
        {
            IntegralSamples();
            CharSamples();
            FloatingPointSamples();
            BoolSamples();
        }
    }
}
