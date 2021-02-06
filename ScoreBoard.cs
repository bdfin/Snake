using Snake.Data;
using Snake.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    public class ScoreBoard
    {
        private readonly int width = 35;

        public void Draw()
        {
            Console.Clear();

            Console.SetCursorPosition((width / 3), 0);
            Console.WriteLine("--- High Scores ---");

            for (int i = 0; i <= (width + 2); i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("-");
            }

            for (int i = 0; i <= (width + 2); i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("-");
            }

            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Name");

            Console.SetCursorPosition(12, 4);
            Console.WriteLine("Top Score");

            Console.SetCursorPosition(26, 4);
            Console.WriteLine("Games Played");

            var players = GetPlayers();
            int line = 6;

            for (int i = 0; i < players.Count; i++)
            {
                Console.SetCursorPosition(2, line);
                Console.WriteLine(players[i].Name);

                Console.SetCursorPosition(12, line);
                Console.WriteLine(players[i].HighScore);

                Console.SetCursorPosition(26, line);
                Console.WriteLine(players[i].GameCount);

                line++;
            }

        }

        public static List<Player> GetPlayers()
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Players.ToList();
            }
        }
    }
}
