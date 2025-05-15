using System;
using System.Collections.Generic;
using PlayerManagerMVC.models;
using PlayerManagerMVC.views;

namespace PlayerManagerMVC.controllers
{
    public class PlayerController
    {
        private readonly List<Player> playerList;
        private readonly PlayerView view;
        private readonly IComparer<Player> compareByName;
        private readonly IComparer<Player> compareByNameReverse;

        public PlayerController()
        {
            view = new PlayerView();
            compareByName = new CompareByName(true);
            compareByNameReverse = new CompareByName(false);

            playerList = new List<Player>()
            {
                new Player("Best player ever", 100),
                new Player("An even better player", 500)
            };
        }

        public void Run()
        {
            string option;
            do
            {
                view.ShowMenu();
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        InsertPlayer();
                        break;
                    case "2":
                        view.ListPlayers(playerList);
                        break;
                    case "3":
                        ListPlayersWithScoreGreaterThan();
                        break;
                    case "4":
                        SortPlayers();
                        break;
                    case "0":
                        view.ShowMessage("Bye!");
                        break;
                    default:
                        view.ShowMessage("\n>>> Unknown option! <<<\n");
                        break;
                }

                view.Pause();
            } while (option != "0");
        }

        private void InsertPlayer()
        {
            var newPlayer = view.ReadPlayer();
            playerList.Add(newPlayer);
        }

        private void ListPlayersWithScoreGreaterThan()
        {
            int minScore = view.ReadMinScore();
            var filtered = GetPlayersWithScoreGreaterThan(minScore);
            view.ListPlayers(filtered);
        }

        private IEnumerable<Player> GetPlayersWithScoreGreaterThan(int minScore)
        {
            foreach (var player in playerList)
            {
                if (player.Score > minScore)
                    yield return player;
            }
        }

        private void SortPlayers()
        {
            PlayerOrder order = view.AskSortOrder();
            switch (order)
            {
                case PlayerOrder.ByScore:
                    playerList.Sort();
                    break;
                case PlayerOrder.ByName:
                    playerList.Sort(compareByName);
                    break;
                case PlayerOrder.ByNameReverse:
                    playerList.Sort(compareByNameReverse);
                    break;
                default:
                    view.ShowMessage("\n>>> Unknown player order! <<<\n");
                    break;
            }
        }
    }
}