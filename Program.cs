using Snake.Common;
using Snake.Data;
using Snake.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            var scoreBoard = new ScoreBoard();
            scoreBoard.Draw();

            CommonMessages.Continue();

            var game = new Game();
            game.Initialise();
        }
    }
}
