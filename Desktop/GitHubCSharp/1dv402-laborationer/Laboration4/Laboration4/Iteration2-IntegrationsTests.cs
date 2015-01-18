using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4
{
    class Iteration2IntegrationsTests
    {
        public Iteration2IntegrationsTests()
        {
            Console.ForegroundColor = ConsoleColor.White;
            //InputNameVerify();
            //InputNameCorrectSaved();
            //InputNameConfirmName();
            AddToSystemPublish();
        }

        public void InputNameVerify()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 1                       -");
            Console.WriteLine("------------------------------------\n");

            string[][] playersToTestWith = new string[1][];
            playersToTestWith[0] = new string[2];
            playersToTestWith[0][0] = "Mattias Pavic";
            RegisterPlayers Test = new RegisterPlayers(playersToTestWith);

            string inputName = Test.InputPlayerName();

            if (inputName.Length > 1)
            {
                Console.WriteLine("Check! Namnet har verifierats.");
            }

            Console.WriteLine("\nTryck något för att gå vidare till nästa test.");
            Console.ReadLine();
        }

        public void InputNameCorrectSaved()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 2                       -");
            Console.WriteLine("------------------------------------\n");


            string[][] playersToTestWith = new string[1][];
            playersToTestWith[0] = new string[2];
            playersToTestWith[0][0] = "Mattias Pavic";
            RegisterPlayers Test = new RegisterPlayers(playersToTestWith);
            string inputName = Test.InputPlayerName();

            Test.AddToSystem(inputName);
            Console.WriteLine(Test.ToStringPlayers());
            Console.WriteLine("\nTryck något för att gå vidare till nästa test.");
            Console.ReadLine();
        }

        public void InputNameConfirmName()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 3                       -");
            Console.WriteLine("------------------------------------\n");


            string[][] playersToTestWith = new string[1][];
            playersToTestWith[0] = new string[2];
            playersToTestWith[0][0] = "Mattias Pavic";
            RegisterPlayers Test = new RegisterPlayers(playersToTestWith);
            string inputName = Test.InputPlayerName();

            if (inputName.Length > 1)
            {
                Console.WriteLine("Check! Bekräftelsesidan fungerar.");
            }

            Console.WriteLine("\nTryck något för att gå vidare till nästa test.");
            Console.ReadLine();
        }

        public void AddToSystemPublish()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 4                       -");
            Console.WriteLine("------------------------------------\n");


            string[][] playersToTestWith = new string[1][];
            playersToTestWith[0] = new string[4];
            playersToTestWith[0][0] = "Mattias Pavic";
            playersToTestWith[0][2] = "Frank Lampard";
            playersToTestWith[0][3] = "Lionel Messi";
            RegisterPlayers Test = new RegisterPlayers(playersToTestWith);
            Test.AddToSystem("Cristiano Ronaldo");
            Console.WriteLine(Test.ToStringPlayers());

            Console.WriteLine("\nTryck något för att gå vidare till nästa test.");
            Console.ReadLine();
        }
    }
}
