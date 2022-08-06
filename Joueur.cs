namespace osu_tournament_management
{
    internal class Joueur
    {
        private string name { get; set; }
        private Score[] scores { get; set; }

        public Joueur(string name)
        {
            this.name = name;
        }
    }

}
