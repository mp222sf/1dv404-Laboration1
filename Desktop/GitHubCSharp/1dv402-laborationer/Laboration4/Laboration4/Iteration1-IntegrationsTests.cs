using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4
{
    class Iteration1IntegrationsTests
    {
        public Iteration1IntegrationsTests()
        {
            Console.ForegroundColor = ConsoleColor.White;
            //InputNameVerify();
            //InputNameCorrectSaved();
            //InputNameConfirmName();
            //AddToSystemPublish();
        }
        public void InputNameVerify()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 1                       -");
            Console.WriteLine("------------------------------------\n");


            string[] teamsToTestWith = new string[2];
            teamsToTestWith[0] = "Emmaboda IS";
            RegisterTeams Test = new RegisterTeams(teamsToTestWith);
            string inputName = Test.InputTeamName();

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


            string[] teamsToTestWith = new string[2];
            teamsToTestWith[0] = "Emmaboda IS";
            RegisterTeams Test = new RegisterTeams(teamsToTestWith);
            string inputName = Test.InputTeamName();

            Test.AddToSystem(inputName);
            Console.WriteLine(Test.ToString());
            Console.WriteLine("\nTryck något för att gå vidare till nästa test.");
            Console.ReadLine();
        }

        public void InputNameConfirmName()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 3                       -");
            Console.WriteLine("------------------------------------\n");


            string[] teamsToTestWith = new string[2];
            teamsToTestWith[0] = "Emmaboda IS";
            RegisterTeams Test = new RegisterTeams(teamsToTestWith);
            string inputName = Test.InputTeamName();

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


            string[] teamsToTestWith = new string[4];
            teamsToTestWith[0] = "Emmaboda IS";
            teamsToTestWith[2] = "Oskarshamns AIK";
            teamsToTestWith[3] = "IFK Berga";
            
            RegisterTeams Test = new RegisterTeams(teamsToTestWith);
            Test.AddToSystem("Lindsdals IF");
            Console.WriteLine(Test.ToString());

            Console.WriteLine("\nTryck något för att gå vidare till nästa test.");
            Console.ReadLine();
        }


    }
}
