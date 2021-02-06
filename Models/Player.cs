using System;

namespace Snake.Models
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int HighScore { get; set; }
        public int GameCount { get; set; }
    }
}
