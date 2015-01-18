using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4
{
    class Iteration3IntegrationsTests
    {
        public Iteration3IntegrationsTests()
        {
            // Fixtur till Testfall 1 & 3
            string[] Teams = new string[2];
            Teams[0] = "Emmaboda IS";
            Teams[1] = "Kalmar FF";
            int[][] _pointForTeams = new int[Teams.Length][];
            _pointForTeams[0] = new int[1];
            _pointForTeams[0][0] = 0;
            _pointForTeams[1] = new int[1];
            _pointForTeams[1][0] = 0;

            // Fixtur till Testfall 2
            string[] Teams2 = new string[2];
            Teams2[0] = "Emmaboda IS";
            Teams2[1] = "Kalmar FF";
            int[][] _pointForTeams2 = new int[Teams2.Length][];
            _pointForTeams2[0] = new int[1];
            _pointForTeams2[0][0] = 0;
            _pointForTeams2[1] = new int[1];
            _pointForTeams2[1][0] = 7;

            // Fixtur till Testfall 4
            string[] Teams4 = new string[2];
            Teams4[0] = "Emmaboda IS";
            Teams4[1] = "Kalmar FF";
            int[][] _pointForTeams4 = new int[Teams4.Length][];
            _pointForTeams4[0] = new int[1];
            _pointForTeams4[0][0] = 10;
            _pointForTeams4[1] = new int[1];
            _pointForTeams4[1][0] = 0;


            Console.ForegroundColor = ConsoleColor.White;
            //InputTeamAndPoints(Teams, _pointForTeams);
            //InputTeamAndPointsVerify(Teams2, _pointForTeams2);
            //InputTeamAndPointsAddToSystem(Teams, _pointForTeams);
            AddToSystemPublish(Teams4, _pointForTeams4);
        }

        public void InputTeamAndPoints(string[] Teams, int[][] PointTeam)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 1                       -");
            Console.WriteLine("------------------------------------\n");

            PublishSeasonResults Test = new PublishSeasonResults(Teams, PointTeam);

            int test = Test.PickTeam();
            int test2 = Test.InputTeamPoints();

            Console.WriteLine("Lag valt: {0}\nPoäng: {1}", Teams[Test._pickedTeam - 1], Test._teamPoint);
            Console.WriteLine("\nTryck något för att gå vidare till nästa test.");
            Console.ReadLine();
        }

        public void InputTeamAndPointsVerify(string[] Teams, int[][] PointTeam)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 2                       -");
            Console.WriteLine("------------------------------------\n");

            PublishSeasonResults Test = new PublishSeasonResults(Teams, PointTeam);

            int test = Test.PickTeam();
            int test2 = Test.InputTeamPoints();
            Test.VerifyPointsForTeam();

            Console.WriteLine("Lag valt: {0}\nPoäng: {1}", Teams[Test._pickedTeam - 1], Test._teamPoint);
            Console.WriteLine("\nTryck något för att gå vidare till nästa test.");
            Console.ReadLine();
        }

        public void InputTeamAndPointsAddToSystem(string[] Teams, int[][] PointTeam)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 3                       -");
            Console.WriteLine("------------------------------------\n");

            PublishSeasonResults Test = new PublishSeasonResults(Teams, PointTeam);

            int test = Test.PickTeam();
            int test2 = Test.InputTeamPoints();
            Test.AddToSystem();

            Console.WriteLine("Lag valt: {0}\nPoäng: {1}", Teams[Test._pickedTeam - 1], Test._pointForTeams[Test._pickedTeam - 1][0]);

            if (Test._pointForTeams[Test._pickedTeam - 1][0] == 10)
            {
                Console.WriteLine("Check! Lagt in i systemet korrekt.");
            }
            else
            {
                Console.WriteLine("Fel! Lagt in i systemet fel.");
            }
            Console.WriteLine("\nTryck något för att gå vidare till nästa test.");
            Console.ReadLine();
        }

        public void AddToSystemPublish(string[] Teams, int[][] PointTeam)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 4                       -");
            Console.WriteLine("------------------------------------\n");

            PublishSeasonResults Test = new PublishSeasonResults(Teams, PointTeam);

            Test._pickedTeam = 2;
            Test._teamPoint = 9;
            Test.AddToSystem();
            

            if (Test._pointForTeams[Test._pickedTeam - 1][0] == 9)
            {
                Console.WriteLine("Check! Lagt in i systemet korrekt.");
            }
            else
            {
                Console.WriteLine("Fel! Lagt in i systemet fel.");
            }

            Console.WriteLine(Test.ToStringResults());
            Console.WriteLine("\nTryck något för att gå vidare till nästa test.");
            Console.ReadLine();
        }

    }
}
