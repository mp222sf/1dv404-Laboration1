using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4
{
    class Iteration1UnitTests
    {
        public Iteration1UnitTests()
        {
            Console.ForegroundColor = ConsoleColor.White;
            CanNamespaceBeEmpty();
            SameName();
            CorrectSaved();
            ConfirmName();
            CorrectPublishing();
        }
        public void CanNamespaceBeEmpty()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 1                       -");
            Console.WriteLine("------------------------------------\n");


            string[] teamsToTestWith = new string[2];
            teamsToTestWith[0] = "Emmaboda IS";
            RegisterTeams Test = new RegisterTeams(teamsToTestWith);
            string testEmptyNamespace = Test.InputTeamName();

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

            string[] teamsToTestWith = new string[2];
            teamsToTestWith[0] = "Emmaboda IS";
            RegisterTeams Test = new RegisterTeams(teamsToTestWith);
            string testEmptyNamespace = Test.InputTeamName();
        }

        public void CorrectSaved()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 3                       -");
            Console.WriteLine("------------------------------------\n");

            string[] teamsToTestWith = new string[2];
            teamsToTestWith[0] = "Emmaboda IS";
            RegisterTeams Test = new RegisterTeams(teamsToTestWith);
            Test.AddToSystem("Oskarshamns AIK");
            Console.WriteLine(Test.ToString());
            Console.WriteLine("\nTryck något för att gå vidare till nästa test.");
            Console.ReadLine();
        }

        public void ConfirmName()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 4                       -");
            Console.WriteLine("------------------------------------\n");

            string[] teamsToTestWith = new string[2];
            teamsToTestWith[0] = "Emmaboda IS";
            teamsToTestWith[1] = "Oskarshamns AIK";
            RegisterTeams Test = new RegisterTeams(teamsToTestWith);

            if (Test.AreYouSure(teamsToTestWith[1]))
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

            string[] teamsToTestWith = new string[5];
            teamsToTestWith[0] = "Emmaboda IS";
            teamsToTestWith[1] = "Oskarshamns AIK";
            teamsToTestWith[2] = "Kalmar FF";
            teamsToTestWith[3] = "IFK Berga";
            teamsToTestWith[4] = "Lindsdals IF";
            RegisterTeams Test = new RegisterTeams(teamsToTestWith);

            Console.WriteLine(Test.ToString());
        }
    }
}
