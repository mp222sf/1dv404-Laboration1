using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4
{
    

    class PublishSeasonResults
    {
        public int _teamPoint;
        public int _pickedTeam;
        public string[] Teams;
        public int[][] _pointForTeams;

        public PublishSeasonResults(string[] inputTeams, int[][] inputPointsTeam)
        {
            // Till fixtur
            Teams = inputTeams;
            _pointForTeams = inputPointsTeam;
            
            

            //_pickedTeam = PickTeam();
            //_teamPoint = InputTeamPoints();
            //VerifyPointsForTeam();
            //AddToSystem();
            //Console.WriteLine(ToStringResults());
            
            
        }

        public int InputTeamPoints()
        {
            int teamPoint;
            bool inputOK;

            do
            {
                string input;
                inputOK = false;
                Console.Write("\nSkriv in poäng: ");
                input = Console.ReadLine();

                teamPoint = 0;
                if (input.Length > 0)
                {
                    inputOK = true;
                    teamPoint = int.Parse(input);
                    _teamPoint = teamPoint;
                }

                if (!inputOK)
                {
                    Console.WriteLine("Fel! Poängen du angav är tomt.");
                    
                }

            } while (!inputOK);
            return teamPoint;
            
        }

        public int PickTeam()
        {
            int pickedTeam;
            bool inputOK;

            do {
                string CW = "";
                inputOK = false;
                for (int i = 0; i < Teams.Length; i++)
                {
                    CW += (i + 1) + ". " + Teams[i] + "\n";
                }

                Console.Write("{0}\nVälj lag: ", CW);

                string input = Console.ReadLine();

                pickedTeam = 0;
                if (input.Length > 0)
                {
                    inputOK = true;
                    pickedTeam = int.Parse(input);
                    _pickedTeam = pickedTeam;
                }

                if (!inputOK)
                {
                    Console.WriteLine("Fel! Namnet du angav är tomt.");
                }

            } while (inputOK == false);
            

            return pickedTeam;
        }

        public void AddToSystem()
        {
            _pointForTeams[_pickedTeam - 1][0] = _teamPoint;
        }

        public void VerifyPointsForTeam()
        {
            if (_pointForTeams[_pickedTeam - 1][0] != 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Det finns redan poäng registrerat för detta lag.\n");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        public string ToStringResults()
        {
            string publish = "[Resultat]\n";

            for (int i = 0; i < _pointForTeams.Length; i++)
            {
                string points = "";
                if (_pointForTeams[i][0] == 0)
                {
                    points = "Inget poäng registrerat";
                }
                else
                {
                    points = String.Format("{0}", _pointForTeams[i][0]);
                }

                publish += Teams[i] + ": " + points + "\n";
            }

            return publish;
        }
    }
}
