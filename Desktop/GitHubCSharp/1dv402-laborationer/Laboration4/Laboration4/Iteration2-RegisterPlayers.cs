using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4
{
    class RegisterPlayers
    {
        public string _playerName;
        public string[][] _playersInTeams = new string[4][];



        public RegisterPlayers(string[][] TestPlayersInTeams)
        {

            _playersInTeams = TestPlayersInTeams;

            //_playerName = InputPlayerName();
            //AddToSystem(_playerName);
            //Console.WriteLine(ToStringPlayers());

            
        }

        public string InputPlayerName()
        {
            string playerName;
            do
            {

                do 
                {
                    Console.Write("Skriv in ett spelarnamn: ");
                    playerName = Console.ReadLine();

                    if (playerName.Length < 1)
                    {
                        Console.WriteLine("Fel! Namnet du angav är tomt.");
                    }
                } while (playerName.Length < 1);
                

            } while ((AreYouSure(playerName) == false) || (VerifyTeamName(playerName) == false));
            return playerName;
        }

        public bool VerifyTeamName(string checkName)
        {
            for (int i = 0; i < _playersInTeams[0].Length; i++)
            {

                if (_playersInTeams[0][i] == checkName)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Det finns redan en spelare med det namnet.\n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    return false;
                }
            }
            return true;
        }

        public bool AreYouSure(string chosenName)
        {

            Console.WriteLine("Vill du registrera spelaren '{0}'?", chosenName);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ja - tryck 1. | Nej - tryck valfri knapp.");
            Console.BackgroundColor = ConsoleColor.Black;
            string YesOrNo = Console.ReadLine();
            bool choice = false;

            if (YesOrNo == "1")
            {
                choice = true;
            }

            return choice;
        }

        public void AddToSystem(string playerName)
        {
            _playersInTeams[0][1] = playerName;
        }

        public string ToStringPlayers()
        {
            string publish = "";

            for (int i = 0; i < _playersInTeams.Length; i++)
            {
                publish += "Lag" + (i + 1) + ":\n";

                for (int j = 0; j < _playersInTeams[i].Length; j++)
                {
                    publish += "- " + _playersInTeams[i][j] + "\n";
                }
                publish += "\n";
                    
            }

            return String.Format("\n[Spelare anmälda]\n{0}", publish);
        }
    }
}
