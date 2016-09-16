using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSpock
{
    public class Computer : Player
    {
        Random randomInt;
        public Computer()
        {
            randomInt = new Random();
        }
        

        public override string GetPlayerName()
        {
            name = "Computer";
            return name;
        }
        public override int GetPlayerInput()
        {
            Random random = new Random();
            int randomInt;
            randomInt = random.Next(1, 6);
            playerInput = randomInt;
            return playerInput;
        }


    }
    
}
