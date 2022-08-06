using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu_tournament_management
{
    internal class Team
    {
        private string Name { get; set; }
        private Joueur[] Joueurs { get; set; }
       
        public Team(string name, Joueur[] joueurs)
        {
            Name = name;
        }
    }
}
