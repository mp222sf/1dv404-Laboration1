using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            string inputPalindrom;
            string newPalindrom = "";

            Console.Write("Skriv in en textrad: ");
            inputPalindrom = Console.ReadLine();
            inputPalindrom = inputPalindrom.ToLower();

            for (int i = (inputPalindrom.Length-1); i >= 0; i--)
            {
                newPalindrom += inputPalindrom[i];
            }

            Console.WriteLine("\n\n-----------------------");
            Console.WriteLine("Exempel 1:");
            Console.WriteLine("-----------------------");
            if (inputPalindrom == newPalindrom)
            {
                Console.WriteLine("Är en palindrom!");
            }
            else
            {
                Console.WriteLine("Är inte en palindrom!");
            }


            Console.WriteLine("\n\n-----------------------");
            Console.WriteLine("Exempel 2:");
            Console.WriteLine("-----------------------");

            bool isPalindrom = false;

            for (int i = 0; i <= (inputPalindrom.Length-(1+i)); i++)
            {
                if (inputPalindrom[i] != (inputPalindrom[inputPalindrom.Length-(1+i)]))
                {
                    isPalindrom = false;
                    break;
                }
                else
                {
                    isPalindrom = true;
                }
                
            }

            if (isPalindrom)
            {
                
                Console.WriteLine("Är också en palindrom!");
            }
            else
            {
                Console.WriteLine("Är ej palindrom!");
            }

        }
    }
}
