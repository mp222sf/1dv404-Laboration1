using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM1
{
    class TestIntegration
    {
        public static void TestRun()
        {
            Console.ForegroundColor = ConsoleColor.White;

            // Testfall 1
            InputRefereesPoints();

            // Testfall 2
            InputRefereesCreateArray();

            // Testfall 3
            InputPointsInArray(2);

            // Testfall 4
            double[] testArray = new double[2];
            testArray[0] = 8.0;
            testArray[1] = 7.4;
            SortArrayAvaragePoint(testArray);

        }

        public static void InputRefereesPoints()
        {
            Console.WriteLine("\n\n ---------------------------------------- ");
            Console.WriteLine("|               Testfall 1               |");
            Console.WriteLine(" ---------------------------------------- ");

            // Läser in ett värde av antal domare.
            string testZero = Program.InputAmountOfReferees();
            int integerRefereesValue;

            integerRefereesValue = int.Parse(testZero);

            // Kontrollerar om inmatade värdet är mindre än 0.
            if (integerRefereesValue < 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel! '{0}' är mindre än 0.", testZero);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (!int.TryParse(testZero, out integerRefereesValue))
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel! '{0}' är inte ett heltal.", testZero);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Check!");
                Console.BackgroundColor = ConsoleColor.Black;
            }

            // Läser in ett poäng från 1 domare.
            for (int i = 0; i < integerRefereesValue; i++)
            {
                string testInput = Program.InputPoints();
                double doubleValue;

                if (!double.TryParse(testInput, out doubleValue))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel! '{0}' är inte ett flyttal.", testInput);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else if (doubleValue < 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel! '{0}' är mindre än 0.", testInput);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Check!");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }

        }
        public static void InputRefereesCreateArray()
        {
            Console.WriteLine("\n\n ---------------------------------------- ");
            Console.WriteLine("|               Testfall 2               |");
            Console.WriteLine(" ---------------------------------------- ");

            // Läser in ett värde av antal domare.
            string testZero = Program.InputAmountOfReferees();
            int integerRefereesValue;

            integerRefereesValue = int.Parse(testZero);

            // Kontrollerar om inmatade värdet är mindre än 0.
            if (integerRefereesValue < 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel! '{0}' är mindre än 0.", testZero);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (!int.TryParse(testZero, out integerRefereesValue))
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel! '{0}' är inte ett heltal.", testZero);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Check!");
                Console.BackgroundColor = ConsoleColor.Black;
            }

           

            double[] testArray = Program.CreateArray(integerRefereesValue);

            if (testArray.Length > 0)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Check! Array är skapad");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel! Array har inte skapats.");
                Console.BackgroundColor = ConsoleColor.Black;
            }


        }

        public static void InputPointsInArray(int integerRefereesValue)
        {
            Console.WriteLine("\n\n ---------------------------------------- ");
            Console.WriteLine("|               Testfall 3               |");
            Console.WriteLine(" ---------------------------------------- ");

            // Läser in ett poäng från 1 domare.
            for (int i = 0; i < integerRefereesValue; i++)
            {
                string testInput = Program.InputPoints();
                double doubleValue;

                // Testar.
                if (!double.TryParse(testInput, out doubleValue))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel! '{0}' är inte ett flyttal.", testInput);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                }
                else if (doubleValue < 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel! '{0}' är mindre än 0.", testInput);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Check!");
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                // Skapar array.
                double[] testArray = new double[integerRefereesValue];

                // Lägger in poäng i array
                testArray = Program.AddToArray(testArray, i, doubleValue);
                
                // Testar
                if (doubleValue == testArray[i])
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Check! Läggs in i array korrekt.\nInläst poäng: {0}\nVärde i array: {1}", doubleValue, testArray[i]);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel! Läggs in i array fel.");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                
            }

        }
        public static void SortArrayAvaragePoint(double[] testArray)
        {
            Console.WriteLine("\n\n ---------------------------------------- ");
            Console.WriteLine("|               Testfall 4               |");
            Console.WriteLine(" ---------------------------------------- ");
            
            // Sorterar array
            double[] copyArray = testArray;
            testArray = Program.ArraySort(testArray);
            
            bool IsCorrect = true;

            // Kontrollerar om varje element i array större än nästa element i arrayen. Är så fallet är sorteringen fel till den metoden.
            for (int i = 0; i < testArray.Length - 1; i++)
            {
                if (testArray[i] > testArray[i + 1])
                {
                    IsCorrect = false;
                    break;
                }
                else
                {
                    IsCorrect = true;
                }
            }

            if (IsCorrect)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Check! Arrayen är rätt sorterad.");
                Console.Write("Vår array:      [");
                for (int i = 0; i < copyArray.Length; i++)
                {
                    if (i + 1 != copyArray.Length)
                    {
                        Console.Write("{0}, ", copyArray[i]);
                    }
                    else
                    {
                        Console.Write("{0}", copyArray[i]);
                    }
                    
                }
                Console.Write("]\nSorterad array: [");
                for (int i = 0; i < testArray.Length; i++)
                {
                    if (i + 1 != testArray.Length)
                    {
                        Console.Write("{0}, ", testArray[i]);
                    }
                    else
                    {
                        Console.Write("{0}", testArray[i]);
                    }
                }
                Console.WriteLine("]");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel! Arrayen är felsorterad.");
                Console.BackgroundColor = ConsoleColor.Black;
            }


            // Kör uträkningsmetod med 3 domare och array [21, 93]
            double testAvaragePointsTwoReferees = Program.AvaragePoints(testArray.Length, testArray);

            // Presenterar testresultatet
            Console.WriteLine("\n\nMedelvärdet:        {0}\nFörväntat resultat: 7,7\n", testAvaragePointsTwoReferees);

            // Presenterar om resultatet är rätt/fel.
            if (testAvaragePointsTwoReferees != (8.0 + 7.4) / 2)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("FEL! Uträkningen är fel.\n");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Check! Uträkningen fungerar rätt.\n");
                Console.BackgroundColor = ConsoleColor.Black;
            }

        }

    }
}
