namespace osu_tournament_management
{
    internal class Score
    {
        private string mod;
        private int point;
        public string Mod { get => mod; set => mod = value; }
        public int Point { get => point; set => point = value; }

        public Score(string mod, int point)
        {
            this.Mod = mod;
            this.Point = point;
        }
    }

}
