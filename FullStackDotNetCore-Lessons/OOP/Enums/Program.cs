using Enums.Enums;
using Enums.Models;
using System;
using System.Collections.Generic;

namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Difficulty> difficulties = new List<Difficulty>();
            difficulties.Add(Difficulty.Easy);
            difficulties.Add(Difficulty.Medium);
            difficulties.Add(Difficulty.Hard);

            foreach (Difficulty difficulty in difficulties)
            {
                Console.WriteLine(difficulty);
            }

            Game game = new Game();
            game.Gender = Gender.Male;
        }
    }
}
