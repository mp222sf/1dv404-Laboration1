using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaSiffror
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number;
            string input;

            do
            {
                Console.Write("Ange ett heltal: ");
                input = Console.ReadLine();
            } while (!uint.TryParse(input, out number));

            int countZero = 0;
            int countOdd = 0;
            int countEven = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '0')
                {
                    countZero++;
                }
                else
                {
                    if (input[i] % 2 == 0)
                    {
                        countEven++;
                    }
                    else
                    {
                        countOdd++;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Antal nollor: {0}", countZero);
            Console.WriteLine("Antal jämna tal: {0}", countEven);
            Console.WriteLine("Antal udda tal: {0}", countOdd);

        }
    }
}
