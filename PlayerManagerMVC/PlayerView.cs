using System;
using System.Collections.Generic;
using PlayerManagerMVC.models;

namespace PlayerManagerMVC.views
{
    public class PlayerView
    {
        public void ShowMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----\n");
            Console.WriteLine("1. Insert player");
            Console.WriteLine("2. List all players");
            Console.WriteLine("3. List players with score greater than");
            Console.WriteLine("4. Sort players");
            Console.WriteLine("0. Quit\n");
            Console.Write("Your choice > ");
        }

        public Player ReadPlayer()
        {
            Console.Write("\nName: ");
            string name = Console.ReadLine();

            Console.Write("Score: ");
            int score = int.Parse(Console.ReadLine());

            return new Player(name, score);
        }

        public void ListPlayers(IEnumerable<Player> players)
        {
            Console.WriteLine("\nList of players\n---------------");
            foreach (var player in players)
            {
                Console.WriteLine($" -> {player.Name} with a score of {player.Score}");
            }
            Console.WriteLine();
        }

        public int ReadMinScore()
        {
            Console.Write("\nMinimum score player should have? ");
            return int.Parse(Console.ReadLine());
        }

        public PlayerOrder AskSortOrder()
        {
            Console.WriteLine("Player order");
            Console.WriteLine("------------");
            Console.WriteLine("1. Order by score");
            Console.WriteLine("2. Order by name");
            Console.WriteLine("3. Order by name (reverse)");
            Console.WriteLine();
            Console.Write("> ");
            return Enum.Parse<PlayerOrder>(Console.ReadLine());
        }

        public void Pause()
        {
            Console.Write("\nPress any key to continue...");
            Console.ReadKey(true);
            Console.WriteLine("\n");
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}