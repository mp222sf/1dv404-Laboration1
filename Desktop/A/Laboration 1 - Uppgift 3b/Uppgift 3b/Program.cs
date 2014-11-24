using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine(" Skapa ett nytt Fraction-objekt. Test av konstruktorn.");
            Console.WriteLine("--------------------------------------------------------\n");

            int input_numerator;
            Console.Write("Skriv in en täljare: ");
            while (!int.TryParse(Console.ReadLine(), out input_numerator) && input_numerator >= 0)
            {

            }
            int input_denominator;
            Console.Write("Skriv in en nämnare: ");
            while (!int.TryParse(Console.ReadLine(), out input_denominator) && input_denominator >= 0)
            {

            }

            Fraction Test1 = new Fraction(input_numerator, input_denominator);
           

            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine(" Test om metoderna getNumerator och getDenominator fungerar.");
            Console.WriteLine("--------------------------------------------------------\n");

            Console.WriteLine("Täljaren är: {0}", Test1.getNumerator);
            Console.WriteLine("Nämnaren är: {0}", Test1.getDenominator);

            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine(" Kontrollera om bråktalet är negativt med isNegative.");
            Console.WriteLine("--------------------------------------------------------\n");

            if (Test1.isNegative())
            {
                Console.WriteLine("Bråktalet är negativt.");
            }
            else
            {
                Console.WriteLine("Bråktalet är inte negativt.");
            }
            

            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine(" Addera två bråk med metoden Add.");
            Console.WriteLine("--------------------------------------------------------\n");

            Console.WriteLine("Adderar ditt bråktal med bråktalet 3/1.");
            Console.WriteLine(Test1.Add(3, 1));
            


            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine(" Multiplicera två bråk med metoden Multiply");
            Console.WriteLine("--------------------------------------------------------\n");

            Console.WriteLine("Multiplicerar ditt bråktal med bråktalet 3/10.");
            Console.WriteLine(Test1.Multiply(3, 10));

            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine(" Jämför två Fraction-objekt med metoden isEqualTo");
            Console.WriteLine("--------------------------------------------------------\n");

            Fraction test2 = new Fraction(1, 10);
            Console.WriteLine("Jämför om ditt bråktal är lika stort som 1/10.\n");

            if (Test1.IsEqualTo(test2))
            {
                Console.WriteLine("Bråktalen är lika stora.");
            }
            else
            {
                Console.WriteLine("Bråktalen är inte lika stora.");
            }
            



            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine(" Skriv ut en sträng med bråktalet.");
            Console.WriteLine("--------------------------------------------------------\n");

            Console.WriteLine(Test1.ToString());
        }
    }
}
