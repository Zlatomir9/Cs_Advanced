using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> players;

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            players = new List<Player>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public void AddPlayer(Player player) 
        {
            if (players.Count < Capacity)
            {
                players.Add(player);
            }
        }

        public bool RemovePlayer(string name) 
        {
            if (players.Any(x => x.Name == name))
            {
                Player player = players.FirstOrDefault(x => x.Name == name);
                players.Remove(player);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PromotePlayer(string name) 
        {
            if (players.FirstOrDefault(x => x.Name == name).Rank != "Member")
            {
                players.FirstOrDefault(x => x.Name == name).Rank = "Member";
            }
        }
        public void DemotePlayer(string name)
        {
            if (players.FirstOrDefault(x => x.Name == name).Rank != "Trial")
            {
                players.FirstOrDefault(x => x.Name == name).Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string @class) 
        {
            Player[] kickedPlayers = players.Where(x => x.Class == @class).ToArray();
            players.RemoveAll(x => x.Class == @class);

            return kickedPlayers;
        }

        public int Count => players.Count;

        public string Report() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");

            foreach (var player in players)
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
