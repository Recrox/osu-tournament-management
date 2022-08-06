using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu_tournament_management
{
    public partial class Form1 : Form
    {
        private List<Team> Teams;
        public Form1()
        {
            InitializeComponent();

            Teams = new List<Team>();
            testListBoxs();
            

        }

        private void testListBoxs()
        {
            //models
            for (int i = 0; i < 3; i++)
            {
                Teams.Add(new Team("Team num " + i));
                for (int j = 0; j < 3; j++)
                {
                    Teams[i].AddPlayer("Joueur num " + j + " "+i);
                    for (int k = 0; k < 10; k++)
                    {
                        Teams[i].Players[j].AddScore("NM" + k+" "+j+" "+i, k * 100000);
                    } 
                }

            }
            //views
            foreach (Team team in Teams)
            {
                listBoxTeam.Items.Add(team.Name);
            }

            listBoxTeam_SelectedIndexChanged(null, null);
            listBoxPlayer_SelectedIndexChanged(null, null);
        }

        
        private Team getTeamSelected()
        {
            return Teams.ElementAt(listBoxTeam.SelectedIndex);
        }
        private Player getPlayerSelected()
        {
            return getTeamSelected().Players.ElementAt(listBoxPlayer.SelectedIndex);
        }

        private void listBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxTeam.SelectedItem != null)
            {
                listBoxPlayer.Items.Clear();
                foreach (Player player in getTeamSelected().Players)
                {
                    listBoxPlayer.Items.Add(player.Name);
                }
            }
    
        }

        private void listBoxPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxTeam.SelectedItem != null)
            {
                listBoxScore.Items.Clear();
                foreach (Score score in getPlayerSelected().Scores)
                {
                    listBoxScore.Items.Add(score.Mod + " " + score.Point);
                }
            }
            
        }

        private void AddTeam_Click(object sender, EventArgs e)
        {
            
        }

        private void AddPlayer_Click(object sender, EventArgs e)
        {

        }
        private void AddScore_Click(object sender, EventArgs e)
        {

        }
    }
}
