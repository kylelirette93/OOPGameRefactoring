using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Static entry point to the game class.
            // Initialize and start game.
            Game game = new Game();
            game.StartGame();
        }
    }
}
