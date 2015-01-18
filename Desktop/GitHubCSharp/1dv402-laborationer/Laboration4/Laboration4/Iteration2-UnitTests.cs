using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4
{
    class Iteration2UnitTests
    {
        public Iteration2UnitTests()
        {
            Console.ForegroundColor = ConsoleColor.White;
            //CanNamespaceBeEmpty();
            //SameName();
            //CorrectSaved();
            //ConfirmName();
            //CorrectPublishing();
        }

        public void CanNamespaceBeEmpty()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 1                       -");
            Console.WriteLine("------------------------------------\n");

            string[][] playersToTestWith = new string[2][];
            playersToTestWith[0] = new string[2];
            playersToTestWith[0][0] = "Mattias Pavic";
            RegisterPlayers Test = new RegisterPlayers(playersToTestWith);

            string testEmptyNamespace = Test.InputPlayerName();

            if (testEmptyNamespace.Length == 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel! Namnet kan vara tomt!");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.WriteLine("Check!");
            }

            Console.WriteLine("\nTryck något för att gå vidare till nästa test.");
            Console.ReadLine();
        }

        public void SameName()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 2                       -");
            Console.WriteLine("------------------------------------\n");

            string[][] playersToTestWith = new string[2][];
            playersToTestWith[0] = new string[2];
            playersToTestWith[0][0] = "Mattias Pavic";
            RegisterPlayers Test = new RegisterPlayers(playersToTestWith);

            string testEmptyNamespace = Test.InputPlayerName();
        }

        public void CorrectSaved()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 3                       -");
            Console.WriteLine("------------------------------------\n");

            string[][] playersToTestWith = new string[1][];
            playersToTestWith[0] = new string[2];
            playersToTestWith[0][0] = "Mattias Pavic";
            RegisterPlayers Test = new RegisterPlayers(playersToTestWith);
            Test.AddToSystem("Ellen Nu");
            Console.WriteLine(Test.ToStringPlayers());
            Console.WriteLine("\nTryck något för att gå vidare till nästa test.");
            Console.ReadLine();
        }

        public void ConfirmName()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 4                       -");
            Console.WriteLine("------------------------------------\n");

            string[][] playersToTestWith = new string[1][];
            playersToTestWith[0] = new string[2];
            playersToTestWith[0][0] = "Mattias Pavic";
            RegisterPlayers Test = new RegisterPlayers(playersToTestWith);

            if (Test.AreYouSure(playersToTestWith[0][0]))
            {
                Console.WriteLine("Du har valt detta namnet.");
            }
            else
            {
                Console.WriteLine("Du har valt att skriva in ett nytt namn.");
            }

            Console.WriteLine("\nTryck något för att gå vidare till nästa test.");
            Console.ReadLine();

        }

        public void CorrectPublishing()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 5                       -");
            Console.WriteLine("------------------------------------\n");

            string[][] playersToTestWith = new string[1][];
            playersToTestWith[0] = new string[5];
            playersToTestWith[0][0] = "Mattias Pavic";
            playersToTestWith[0][1] = "Filip Quist";
            playersToTestWith[0][2] = "Måns Söderqvist";
            playersToTestWith[0][3] = "Lucas Hägg";
            playersToTestWith[0][4] = "Anton Agebjörn";
            RegisterPlayers Test = new RegisterPlayers(playersToTestWith);

            Console.WriteLine(Test.ToStringPlayers());
        }
    }
}
