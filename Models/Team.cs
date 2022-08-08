using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu_tournament_management
{
    internal class Team
    {
        private string name;
        private List<Player> players;

        public string Name { get => name; set => name = value; }
        public List<Player> Players { get => players; set => players = value; }

        public Team(string name)
        {
            Name = name;
            Players = new List<Player>();
        }

        public void AddPlayer(string name) { Players.Add(new Player(name)); }
    }
}
