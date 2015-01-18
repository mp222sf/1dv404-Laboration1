using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4
{
    class Iteration3UnitTests
    {
        public Iteration3UnitTests()
        {
            // Fixtur till Testfall 1-4 & 6
            string[] Teams = new string[2];
            Teams[0] = "Emmaboda IS";
            Teams[1] = "Kalmar FF";
            int[][] _pointForTeams = new int[Teams.Length][];
            _pointForTeams[0] = new int[1];
            _pointForTeams[0][0] = 0;
            _pointForTeams[1] = new int[1];
            _pointForTeams[1][0] = 0;


            // Fixtur till Testfall 5
            string[] Teams5 = new string[1];
            Teams5[0] = "Emmaboda IS";
            int[][] _pointForTeams5 = new int[Teams5.Length][];
            _pointForTeams5[0] = new int[1];
            _pointForTeams5[0][0] = 7;


            // Fixtur till Testfall 7
            string[] Teams7 = new string[2];
            Teams7[0] = "Emmaboda IS";
            Teams7[1] = "Kalmar FF";
            int[][] _pointForTeams7 = new int[Teams7.Length][];
            _pointForTeams7[0] = new int[1];
            _pointForTeams7[0][0] = 6;
            _pointForTeams7[1] = new int[1];
            _pointForTeams7[1][0] = 8;



            Console.ForegroundColor = ConsoleColor.White;
            TeamEmpty(Teams, _pointForTeams);
            TeamOutOfIntervall(Teams, _pointForTeams);
            PointsNegative(Teams, _pointForTeams);
            PointsEmpty(Teams, _pointForTeams);
            VerifyPoints(Teams5, _pointForTeams5);
            CorrectSaved(Teams, _pointForTeams);
            CorrectPublishing(Teams7, _pointForTeams7);
        }

        public void TeamEmpty(string[] Teams, int[][] PointTeam)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 1                       -");
            Console.WriteLine("------------------------------------\n");

            PublishSeasonResults Test = new PublishSeasonResults(Teams, PointTeam);

            int testEmpty = Test.PickTeam();

            if (testEmpty == 0)
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

        public void TeamOutOfIntervall(string[] Teams, int[][] PointTeam)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 2                       -");
            Console.WriteLine("------------------------------------\n");

            PublishSeasonResults Test = new PublishSeasonResults(Teams, PointTeam);

            int testIntervall = Test.PickTeam();

            if (testIntervall <= 0 || testIntervall > Test.Teams.Length)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel! Valt lag är utanför intervallet");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.WriteLine("Check!");
            }

            Console.WriteLine("\nTryck något för att gå vidare till nästa test.");
            Console.ReadLine();
        }

        public void PointsNegative(string[] Teams, int[][] PointTeam)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 3                       -");
            Console.WriteLine("------------------------------------\n");

            PublishSeasonResults Test = new PublishSeasonResults(Teams, PointTeam);

            int testNegative = Test.InputTeamPoints();

            if (testNegative < 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel! Inläst poäng kan vara negativt.");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.WriteLine("Check!");
            }

            Console.WriteLine("\nTryck något för att gå vidare till nästa test.");
            Console.ReadLine();
        }

        public void PointsEmpty(string[] Teams, int[][] PointTeam)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 4                       -");
            Console.WriteLine("------------------------------------\n");

            PublishSeasonResults Test = new PublishSeasonResults(Teams, PointTeam);

            int testEmpty = Test.InputTeamPoints();

            if (testEmpty == 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel! Poängen du angav är tom.");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.WriteLine("Check!");
            }

            Console.WriteLine("\nTryck något för att gå vidare till nästa test.");
            Console.ReadLine();
        }
        public void VerifyPoints(string[] Teams, int[][] PointTeam)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 5                       -");
            Console.WriteLine("------------------------------------\n");

            PublishSeasonResults Test = new PublishSeasonResults(Teams, PointTeam);

            int test1 = Test.PickTeam();
            int test2 = Test.InputTeamPoints();
            Test.VerifyPointsForTeam();



            Console.WriteLine("\nTryck något för att gå vidare till nästa test.");
            Console.ReadLine();
        }

        public void CorrectSaved(string[] Teams, int[][] PointTeam)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 6                       -");
            Console.WriteLine("------------------------------------\n");

            PublishSeasonResults Test = new PublishSeasonResults(Teams, PointTeam);

            int test1 = Test.PickTeam();
            int test2 = Test.InputTeamPoints();
            Test.AddToSystem();

            if (Test._pointForTeams[0][0] != 0)
            {
                Console.WriteLine("Check!");
            }
            else
            {
                Console.WriteLine("Poängen sparas fel.");
            }



            Console.WriteLine("\nTryck något för att gå vidare till nästa test.");
            Console.ReadLine();
        }

        public void CorrectPublishing(string[] Teams, int[][] PointTeam)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("- Testfall 7                       -");
            Console.WriteLine("------------------------------------\n");

            PublishSeasonResults Test = new PublishSeasonResults(Teams, PointTeam);

            Console.WriteLine(Test.ToStringResults());

            Console.WriteLine("\nTryck något för att gå vidare till nästa test.");
            Console.ReadLine();
        }

    }
}
