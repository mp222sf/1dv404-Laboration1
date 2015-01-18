using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4
{
    class RegisterTeams
    {
        public string _teamName;
        public string[] _teams = new string[2];

        public RegisterTeams(string[] testTeams)
        {
            _teams = testTeams;

            //Console.ForegroundColor = ConsoleColor.White;
            //_teams[0] = "Hej";
            //_teamName = InputTeamName();
            //AddToSystem(_teamName);
            //Console.WriteLine(ToString());
        }

        // Läser in lagnamn.
        public string InputTeamName()
        {
            string teamName;
            do
            {
                Console.Write("Skriv in lagnamn: ");
                teamName = Console.ReadLine();
                
            } while ((AreYouSure(teamName) == false) || (VerifyTeamName(teamName) == false));
            return teamName;
            
        }

        // Kontrollerar så att inte namnet är upptaget.
        public bool VerifyTeamName(string checkName)
        {
            for (int i = 0; i < _teams.Length; i++)
            {
                if (_teams[i] == checkName)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Namnet är upptaget.\n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    return false;
                }
            }
                return true;
        }

        // Lägger till namnet i systemet.
        public void AddToSystem(string teamName)
        {
            _teams[1] = teamName;
        }

        // Frågar användaren om hen vill registrera det inmatade namnet.
        public bool AreYouSure(string chosenName)
        {
            
            Console.WriteLine("Vill du registrera laget '{0}'?", chosenName);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Ja - skriv in '1'.");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Nej - skriv in annat tecken.");
            Console.BackgroundColor = ConsoleColor.Black;
            string YesOrNo = Console.ReadLine();
            bool choice = false;

            if (YesOrNo == "1")
            {
                choice = true;
            }

            return choice;
        }

        // Skriver ut sträng med alla anmälda lag.
        public override string ToString()
        {
            string publish = "";

            for (int i = 0; i < _teams.Length; i++)
            {
                publish += "- " + _teams[i] + "\n";
            }
               
            return String.Format("\n[LAG ANMÄLDA]\n{0}", publish);
        }
    }
}
