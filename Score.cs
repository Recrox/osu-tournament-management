namespace osu_tournament_management
{
    internal class Score
    {
        private string mod { get; set; }
        private int point { get; set; }

        public Score(string mod, int point)
        {
            this.mod = mod;
            this.point = point;
        }
    }

}
