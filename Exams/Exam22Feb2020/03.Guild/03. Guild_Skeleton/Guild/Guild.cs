using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.roster = new List<Player>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => roster.Count;

        public void AddPlayer(Player player)
        {
            if (Capacity > roster.Count)
            {
                roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            Player playerToBeRemoved = roster.FirstOrDefault(p => p.Name == name);

            if (playerToBeRemoved != null)
            {
                roster.Remove(playerToBeRemoved);
                return true;
            }

            return false;
        }

        public void PromotePlayer(string name)
        {
            Player playerToBePromoted = roster.FirstOrDefault(p => p.Name == name);

            if (playerToBePromoted.Rank != "Member")
            {
                playerToBePromoted.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            Player playerToBeDemoted = roster.FirstOrDefault(p => p.Name == name);

            if (playerToBeDemoted.Rank != "Trial")
            {
                playerToBeDemoted.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string clas)
        {
            Player[] players = roster.Where(p => p.Class == clas).ToArray();
            roster = roster.Where(p => p.Class != clas).ToList();
            return players;
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Players in the guild: {this.Name}");
            foreach (var player in roster)
            {
                result.AppendLine(player.ToString());
            }

            return result.ToString().TrimEnd();
        }
    }
}
