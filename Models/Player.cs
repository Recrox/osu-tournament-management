using System.Collections.Generic;

namespace osu_tournament_management
{
    internal class Player
    {
        private string name;

        public string Name { get => name; set => name = value; }
        internal List<Score> Scores { get => scores; set => scores = value; }

        private List<Score> scores;

        public Player(string name)
        {
            this.Name = name;
            Scores = new List<Score>();
        }

        public void AddScore(string mod,int point) { Scores.Add(new Score(mod,point));}
    }

}
