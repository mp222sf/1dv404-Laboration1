using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM1
{
    class Test
    {
        public static void TestRun()
        {
            Console.ForegroundColor = ConsoleColor.White;

            // Testfall 1
            TestRefereesLessThanZero();

            // Testfall 2
            TestRefereesOtherThanInteger();

            // Testfall 3
            TestInputPointsOtherThanDouble();

            // Testfall 4
            TestInputPointsNegative();

            // Testfall 5
            TestInputBigNumbers();

            // Testfall 6 - TestSortArray
            // Skapar en array med poäng från 7 domare.
            double[] testArrayToSort = new double[7];
            testArrayToSort[0] = 7;
            testArrayToSort[1] = 9;
            testArrayToSort[2] = 33;
            testArrayToSort[3] = 1;
            testArrayToSort[4] = 21;
            testArrayToSort[5] = 65;
            testArrayToSort[6] = 93;
            TestSortArray(testArrayToSort);

            // Testfall 7 - TestAvaragePointsThreeOrMoreReferees
            // Skapar en array.
            double[] testArray = new double[5];
            testArray[0] = 1;
            testArray[1] = 21;
            testArray[2] = 33;
            testArray[3] = 65;
            testArray[4] = 93;
            TestAvaragePointsThreeOrMoreReferees(testArray);

            // Testfall 8 - TestAvaragePointsTwoOrLessReferees
            // Skapar en array.
            double[] testArray2 = new double[2];
            testArray2[0] = 21;
            testArray2[1] = 93;
            TestAvaragePointsTwoOrLessReferees(testArray2);
        }

        // Testmetod som testar om inläsning av antal domare kan vara mindre än 0.
        public static void TestRefereesLessThanZero()
        {
            Console.WriteLine(" ---------------------------------------- ");
            Console.WriteLine("|     Antal domare - Mindre än noll?     |");
            Console.WriteLine(" ---------------------------------------- ");

            // Läser in ett värde av antal domare.
            string testZero = Program.InputAmountOfReferees();
            int integerValue;

            integerValue = int.Parse(testZero);

            // Kontrollerar om inmatade värdet är mindre än 0.
            if (integerValue < 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel! '{0}' är mindre än 0.", testZero);
                Console.BackgroundColor = ConsoleColor.Black;
                
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Check!");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        // Testmettod som testar om inläsning av antal domare kan vara annat än ett positivt heltal.
        public static void TestRefereesOtherThanInteger()
        {
            Console.WriteLine(" ---------------------------------------- ");
            Console.WriteLine("|    Antal domare - Annat än heltal?     |");
            Console.WriteLine(" ---------------------------------------- ");

            // Läser in ett värde av antal domare.
            string testZero = Program.InputAmountOfReferees();
            int integerValue;

            if (!int.TryParse(testZero, out integerValue))
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
        }

        // Testmetod som testar om ett inläst poäng kan vara av annan typ än "double".
        public static void TestInputPointsOtherThanDouble()
        {
            Console.WriteLine(" ---------------------------------------- ");
            Console.WriteLine("|   Poänginläsning - Annat än double?    |");
            Console.WriteLine(" ---------------------------------------- ");

            // Läser in ett poäng från 1 domare.
            string testInput = Program.InputPoints();
            double doubleValue;

            if (!double.TryParse(testInput, out doubleValue))
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel! '{0}' är inte ett flyttal.", testInput);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Check!");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        // Testmetod som testar om inläsning av poäng kan vara negativt.
        public static void TestInputPointsNegative()
        {
            Console.WriteLine(" ---------------------------------------- ");
            Console.WriteLine("|       Poänginläsning - Negativt?       |");
            Console.WriteLine(" ---------------------------------------- ");

            // Läser in ett poäng från 1 domare.
            string testInput = Program.InputPoints();
            double doubleValue;

            doubleValue = double.Parse(testInput);

            if (doubleValue < 0)
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

        // Testmetod som testar om inläst poäng kan vara större än 2.500.000.
        public static void TestInputBigNumbers()
        {
            Console.WriteLine(" ---------------------------------------- ");
            Console.WriteLine("|      Poänginläsning - Stora tal?       |");
            Console.WriteLine(" ---------------------------------------- ");

            // Läser in ett poäng från 1 domare.
            string testInput = Program.InputPoints();
            double doubleValue;

            doubleValue = double.Parse(testInput);

            if (doubleValue < 2500000)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel! '{0}' är mindre än testvärdet 2500000.", testInput);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Check!");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        // Testmetod som testar om inlästa poäng sorteras rätt i en array.
        public static void TestSortArray(double[] testArrayToSort)
        {
            Console.WriteLine(" ---------------------------------------- ");
            Console.WriteLine("|         Sortera array korrekt?         |");
            Console.WriteLine(" ---------------------------------------- ");

            // Sorterar arrayen.
            double[] testSortedArray = Program.ArraySort(testArrayToSort);

            bool IsCorrect = true;

            // Kontrollerar om varje element i array större än nästa element i arrayen. Är så fallet är sorteringen fel till den metoden.
            for (int i = 0; i < testArrayToSort.Length - 1; i++)
            {
                if (testArrayToSort[i] > testArrayToSort[i+1])
                {
                    IsCorrect = false;
                    break;
                }
                else
                {
                    IsCorrect = true;
                }
            }

            // Presenterar testresultatet.
            string ArrayToString = "[" + testArrayToSort[0] + ", " + testArrayToSort[1] + ", " + testArrayToSort[2] + ", " + testArrayToSort[3] + ", " + testArrayToSort[4] + ", " + testArrayToSort[5] + ", " + testArrayToSort[6] + "]";
            Console.WriteLine("Testarray:          {0}\nFörväntat resultat: [1, 7, 9, 21, 33, 65, 93]\n", ArrayToString);

            if (IsCorrect)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Check! Sorteringen är rätt.\n");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("FEL! Sorteringen är fel.\n");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        // Testmetod som testar om medelvärdet räknas ut korrekt från 3 eller fler domare.
        public static void TestAvaragePointsThreeOrMoreReferees(double[] testArray)
        {
            Console.WriteLine(" ---------------------------------------- ");
            Console.WriteLine("|       Medelpoäng - Med 5 domare.       |");
            Console.WriteLine(" ---------------------------------------- ");

            

            // Kör uträkningsmetod med 5 domare och array [1, 21, 33, 65, 93]
            double testAvaragePointsThreeReferees = Program.AvaragePoints(5, testArray);

            // Presenterar testresultatet
            Console.WriteLine("Medelvärdet:        {0}\nFörväntat resultat: 39.666...667\n", testAvaragePointsThreeReferees);

            // Presenterar om resultatet är rätt/fel.
            if (testAvaragePointsThreeReferees != (21.0+33.0+65.0)/3)
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

        // Testmetod som testar om medelvärdet räknas ut korrekt från 2 eller färre domare.
        public static void TestAvaragePointsTwoOrLessReferees(double [] testArray2)
        {
            Console.WriteLine(" ---------------------------------------- ");
            Console.WriteLine("|       Medelpoäng - Med 2 domare.       |");
            Console.WriteLine(" ---------------------------------------- ");

            // Kör uträkningsmetod med 3 domare och array [21, 93]
            double testAvaragePointsTwoReferees = Program.AvaragePoints(2, testArray2);

            // Presenterar testresultatet
            Console.WriteLine("Medelvärdet:        {0}\nFörväntat resultat: 57\n", testAvaragePointsTwoReferees);

            // Presenterar om resultatet är rätt/fel.
            if (testAvaragePointsTwoReferees != (21.0 + 93.0) / 2)
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
