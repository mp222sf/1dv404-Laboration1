using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM1
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Kör funktionerna.
            //Run();

            //// Testkör enhetstesterna.
            //Test.TestRun();

            //// Testkör Integrationstesterna
            //TestIntegration.TestRun();
        }

        public static void Run()
        {
            // InputAmountOfReferees
            string amountOfReferees = InputAmountOfReferees();

            // Create Array
            double[] arrayPoints = CreateArray(1);

            // InputPoints
            string Points = InputPoints();

            // AddToArray
            arrayPoints = AddToArray(arrayPoints, 0, 1);

            // ArraySort
            arrayPoints = ArraySort(arrayPoints);

            // AvaragePoint
            double avaragePoints = AvaragePoints(2, arrayPoints);

            // Show
            toString(avaragePoints);
        }

        // Läser in antal domare.
        public static string InputAmountOfReferees()
        {
            string input;
           
            Console.Write("Skriv in antal domare: ");
            input = Console.ReadLine();
            
            return input;
        }

        // Läser in poäng.
        public static string InputPoints()
        {
                string input;
                
                Console.Write("Skriv in poäng: ");
                input = Console.ReadLine();

            return input;
        }

        // Skapar array med antal domare.
        public static double[] CreateArray(int referees)
        {
            double[] createArray = new double[referees];
            return createArray;
        }

        // Lägger in poäng i array.
        public static double[] AddToArray(double[] arrayAdd, int id, double value)
        {
            arrayAdd[id] = value;

            return arrayAdd;
        }

        // Sorterar en array.
        public static double[] ArraySort(double[] arrayForSort)
        {
            
            Array.Sort(arrayForSort);
            return arrayForSort;
        }

        // Räknar ut medelvärde av poäng.
        public static double AvaragePoints(int amountOfReferees, double[] arrayPoints)
        {
            double totalPoints = 0;
            double avaragePoints = 0;

            if (amountOfReferees > 2)
            {
                for (int i = 1; i < amountOfReferees - 1; i++)
                {
                    totalPoints += arrayPoints[i];
                }

                avaragePoints = totalPoints / (amountOfReferees - 2);
            }
            else
            {
                for (int i = 0; i < amountOfReferees; i++)
                {
                    totalPoints += arrayPoints[i];
                }

                avaragePoints = totalPoints / amountOfReferees;
            }

            return avaragePoints;
        }

        // Presenterar medelpoänget.
        public static void toString(double avaragePoints)
        {
            Console.WriteLine("Medelpoäng: {0}", avaragePoints);
        }
    }
}
