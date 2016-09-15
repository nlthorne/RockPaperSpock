using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSpock
{
    public class Player
    {
        //public string playerOne;
        //public string playerTwo;
        public int numberOfPlayers;
        public string name;
        Random randomInt = new Random();
        public int playerOneInput;
        public int playerTwoInput;



        public Player()
        {

        }
        public int GetComputerSelection()
        {
            Random random = new Random();
            int randomInt;
            randomInt = random.Next(1, 6);
            playerTwoInput = randomInt;
            return playerTwoInput;
        }

    }
}
