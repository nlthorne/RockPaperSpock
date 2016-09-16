using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSpock
{
    public class Game
    {
        public int scorePlayerOne = 0;
        public int scorePlayerTwo = 0;
        Player playerOne;
        Player playerTwo;
        public int numberOfPlayers;
        //Random randomInt;

        public Game()
        {
            //randomInt = new Random();
        }

        public void RunGame()
        {
            GetNumberOfPlayers();
            CreatePlayer();
            playerOne.GetPlayerInput();
            playerTwo.GetPlayerInput();
            GetRoundResult();
            KeepTrackScore();
        }
        public void KeepTrackScore()
        {
            while (scorePlayerOne < 3 && scorePlayerTwo < 3)
            {
                playerOne.GetPlayerInput();
                playerTwo.GetPlayerInput();
                GetRoundResult();
                CheckFinalScore();
            }
        }
        public void GetRoundResult()
        {
            int thisRound;
            thisRound = (5 + playerOne.playerInput - playerTwo.playerInput) % 5;
            if (thisRound == 1 || thisRound == 3)
            {
                Console.WriteLine("{0} chose {1}, {2} chose {3}", playerOne.name, playerOne.playerInput, playerTwo.name, playerTwo.playerInput);
                Console.WriteLine("{0} wins the round!", playerOne.name);
                scorePlayerOne++;
            }
            else if (thisRound == 2 || thisRound == 4)
            {
                Console.WriteLine("{0} chose {1}, {2} chose {3}", playerOne.name, playerOne.playerInput, playerTwo.name, playerTwo.playerInput);
                Console.WriteLine("{0} wins the round!", playerTwo.name);
                scorePlayerTwo++;
            }
            else if (thisRound == 0)
            {
                Console.WriteLine("This round was a tie.");
            }
        }

        public int GetNumberOfPlayers()
        {
            Console.WriteLine("How many players? 1 or 2");
            numberOfPlayers = int.Parse(Console.ReadLine());
            if (numberOfPlayers == 1 || numberOfPlayers == 2)
            {
                return numberOfPlayers;
            }
            else 
            {
                Console.WriteLine("Invalid Choice, Please Choose 1 or 2 Players.");
                GetNumberOfPlayers();
                return numberOfPlayers;
            }
                        
        }
        public void CreatePlayer()
        {
            if (numberOfPlayers == 1)
            {
                playerOne = new Human();
                playerTwo = new Computer();
                playerOne.GetPlayerName();
                playerTwo.GetPlayerName();
            }
            else if (numberOfPlayers == 2)
            {
                playerOne = new Human();
                playerTwo = new Human();
                playerOne.GetPlayerName();
                playerTwo.GetPlayerName();
            }
        }
        public void CheckFinalScore()
        {
            if (scorePlayerOne == 3)
            {
                Console.WriteLine("{0} wins the game!! \n", playerOne.name);
            }
            else if (scorePlayerTwo == 3)
            {
                Console.WriteLine("{0} wins the game!! \n", playerTwo.name);
            }
        }
        
    }
}