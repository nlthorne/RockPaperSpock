using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.GetNumberOfPlayers();
            game.SetNumberOfPlayers();
            game.GetPlayerOneInput();
            game.GetPlayerTwoInput();
            game.RunGame();
            game.KeepTrackScore();
            Console.Read();


        }
    }
}
