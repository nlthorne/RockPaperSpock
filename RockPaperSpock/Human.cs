﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSpock
{
    public class Human : Player
    {

        public Human()
        {

        }
        public override string GetPlayerName()
        {
            Console.WriteLine("Please Enter Your Name:");
            name = Console.ReadLine();
            return name;
        }

        public override int GetPlayerInput()
        {
            Console.WriteLine("{0} Choose:\n [1]Rock, [2]Paper, [3]Scissors, [4]Lizard or [5]Spock: ", name);
            int tempInput = Convert.ToInt32(Console.ReadLine());
            playerInput = tempInput;
            return playerInput;
        }
    }
    

}
