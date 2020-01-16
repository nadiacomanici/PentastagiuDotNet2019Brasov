using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ThrowAndCatch();
            //DifferentTypesOfExceptions();
            //FinallyBlock();

            //UserExample userExample = new UserExample();
            //userExample.Run();

            RethrowingExample rethrowingExample = new RethrowingExample();
            rethrowingExample.Run();
        }

        static void ThrowAndCatch()
        {
            try
            {
                Console.WriteLine("Before throwing");
                throw new Exception("Exception message");
                Console.WriteLine("After throwing");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught exception with the message: " + ex.Message);
            }
        }

        static void DifferentTypesOfExceptions()
        {
            try
            {
                Console.WriteLine("Before throwing");
                int a = 5;
                int b = 0;
                int c = a / b;
                Console.WriteLine("After throwing");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Caught DivideByZero exception");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Caught arithmethc exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught other exception");
            }
        }

        static void FinallyBlock()
        {
            FileStream fileStream = null;
            StreamReader streamReader = null;
            try
            {
                fileStream = new FileStream("number.txt", FileMode.Open);
                streamReader = new StreamReader(fileStream);
                string line = streamReader.ReadLine();
                int number = int.Parse(line);
                Console.WriteLine(number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Cannot parse number");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("The file was not found");
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Dispose();
                }
                if (fileStream != null)
                {
                    fileStream.Dispose();
                }
            }
        }
    }
}
