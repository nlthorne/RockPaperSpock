using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSpock
{
    public class Game
    {
        public int playerOneInput;
        public int playerTwoInput;
        public int scorePlayerOne = 0;
        public int scorePlayerTwo = 0;
        Player playerOne;
        Player playerTwo;
        public List<string> playerNames;
        public int numberOfPlayers;

        public Game()
        {
            playerOne = new Player();
            playerTwo = new Player();
            playerNames = new List<string>();
        }
        public void RunGame()
        {
            int thisRound;
            thisRound = (5 + playerOneInput - playerTwoInput) % 5;
            if (thisRound == 1 || thisRound == 3)
            {
                Console.WriteLine("{0} wins the round!", playerOne.name);
                scorePlayerOne++;
            }
            else if (thisRound == 2 || thisRound == 4)
            {
                Console.WriteLine("{0} wins the round!", playerTwo.name);
                scorePlayerTwo++;
            }
            else if (thisRound == 0)
            {
                Console.WriteLine("This round was a tie.");
            }
        }

        public int GetPlayerOneInput()
        {
            Console.WriteLine("{0} Choose:\n [1]Rock, [2]Paper, [3]Scissors, [4]Lizard or [5]Spock: ", playerOne.name);
            int tempInput = Convert.ToInt32(Console.ReadLine());
            playerOneInput = tempInput;
            return playerOneInput;

        }
        public int GetPlayerTwoInput()
        {
            if (playerTwo.name == "Computer")
            {
                GetComputerSelection();
                return playerTwoInput;
            }
            else
            {
                Console.WriteLine("{0} Choose:\n [1]Rock, [2]Paper, [3]Scissors, [4]Lizard or [5]Spock: ", playerTwo.name);
                int tempInput = Convert.ToInt32(Console.ReadLine());
                playerTwoInput = tempInput;
                return playerTwoInput;
            }

        }
        public int GetNumberOfPlayers()
        {
            Console.WriteLine("How many players? 1 or 2");
            numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;
        }
        public void SetNumberOfPlayers()
        {
            if (numberOfPlayers == 2)
            {
                for(int i = 0; i < numberOfPlayers; i++)
                {
                    CreatePlayer();
                }
                playerOne.name = playerNames[0];
                playerTwo.name = playerNames[1];

            }
            else if (numberOfPlayers == 1)
            {
                CreatePlayer();
                CreateCpu();
                playerOne.name = playerNames[0];
                playerTwo.name = playerNames[1];
            }
            else if (numberOfPlayers != 1 || numberOfPlayers != 2)
            {
                Console.WriteLine("Invalid Choice, Please Choose 1 or 2 Players.");
                GetNumberOfPlayers();
            }
        }
        public List<string> CreatePlayer()
        {
            Console.WriteLine("Please Enter Your Name:");
            string playerName = Console.ReadLine();
            playerNames.Add(playerName);
            return playerNames;
        }
        public List<string> CreateCpu()
        {
            playerNames.Add("Computer");
            return playerNames;
        }

        
        public void CheckFinalScore()
        {
            if (scorePlayerOne == 3)
            {
                Console.WriteLine("{0} Wins!! \n", playerOne.name);
            }
            else if (scorePlayerTwo == 3)
            {
                Console.WriteLine("{0} Wins!! \n", playerTwo.name);
            }
        }
        public void KeepTrackScore()
        {
            while (scorePlayerOne < 3 && scorePlayerTwo < 3)
            {
                GetPlayerOneInput();
                GetPlayerTwoInput();
                CheckFinalScore();
                RunGame();
            }
        }
        public int GetComputerSelection()
        {
            Random random = new Random();
            int randomInt;
            randomInt = random.Next(1, 6);
            return randomInt;
        }

    }
}