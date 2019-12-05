using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int randomNumber = generator.Next(0, 100);

            int nrUtilizator;

            do
            {
                Console.WriteLine("Introdu un numar");
                string nrString = Console.ReadLine();
                nrUtilizator = int.Parse(nrString);

                if (nrUtilizator < randomNumber)
                {
                    Console.WriteLine("Numarul introdus este prea mic. Mai incearca");
                }

                if (nrUtilizator > randomNumber)
                {
                    Console.WriteLine("Numarul introdus este prea mare. Mai incearca");
                }

            } while (nrUtilizator != randomNumber);
            
            Console.WriteLine("Ai ghicit!");
        }
    }
}
