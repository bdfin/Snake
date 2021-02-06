using Snake.Common;
using Snake.Data;
using Snake.Models;
using System;
using System.Linq;

namespace Snake
{
    public class Game
    {
        public Player Player { get; set; }

        public void Initialise()
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Welcome to Snake!");

            string inputName = string.Empty;

            while (string.IsNullOrWhiteSpace(inputName))
            {
                Console.WriteLine("Please enter your name:");

                inputName = Console.ReadLine();
            }

            Console.Clear();

            using (var dataContext = new DataContext())
            {
                Player = dataContext.Players.FirstOrDefault(p => p.Name.ToLower() == inputName.ToLower());

                if (Player is null)
                {
                    Player = new Player()
                    {
                        Id = Guid.NewGuid(),
                        Name = inputName
                    };

                    dataContext.Players.Add(Player);
                    dataContext.SaveChanges();

                    Console.WriteLine($"Hi {Player.Name}!");
                }
                else
                {
                    Console.WriteLine($"Welcome back {Player.Name}!");
                }
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Stats:");
            Console.WriteLine($"High Score: {Player.HighScore}");
            Console.WriteLine($"Total Games: {Player.GameCount}");

            CommonMessages.Continue();
        }
    }
}
