using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativ_Mjukvareutveckling_Uppgift_1a
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Mata in en textrad: ");
            string input = Console.ReadLine();

            int countBigA = 0;
            int countLittleA = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'A')
                {
                    countBigA++;
                }
                
                if (input[i] == 'a')
                {
                    countLittleA++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Antalet 'A': {0}", countBigA);
            Console.WriteLine("Antalet 'a': {0}", countLittleA);

        }
    }
}
