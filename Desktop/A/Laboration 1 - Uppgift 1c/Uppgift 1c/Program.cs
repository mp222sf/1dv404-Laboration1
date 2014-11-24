using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1c
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                int largestNumber = int.MinValue;
                int secondLargestNumber = int.MinValue;

                string input;
                int number;

                for (int i = 0; i < 10; i++)
                {
                    
                    Console.Write("Skriv in tal {0}: ", (i + 1));
                    do
                    {
                        input = Console.ReadLine();
                    }
                    while (!int.TryParse(input, out number));

                    if (number > largestNumber)
                    {
                        secondLargestNumber = largestNumber;
                        largestNumber = number;
                    }
                    else
                    {
                        if (number > secondLargestNumber)
                        {
                            secondLargestNumber = number;
                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Näststörsta talet är: {0}", secondLargestNumber);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nKlicka på valfri knapp för att fortsätta - ESC avslutar.");
                Console.ResetColor();
                
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            
                

            
            
        }
    }
}
