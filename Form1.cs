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

            for (int i = 0; i < 3; i++)
            {
                Teams.Add(new Team("Team num " + i));
                for (int j = 0; j < 3; j++)
                {
                    Teams[i].AddPlayer("Joueur num " + j);
                    for (int k = 0; k < 10; k++)
                    {
                        Teams[i].Players[j].AddScore("NM" + k, k * 100000);
                    }
                }
                
            }
        }

        private void AddTeam_Click(object sender, EventArgs e)
        {
            foreach (Team team in Teams)
            {
                listBoxTeam.Items.Add(team.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if(listBox1.SelectedIndex != null)
            foreach (Player player in getTeamSelected().Players)
            {
                listBoxPlayer.Items.Add(player.Name);
            }
        }

        private Team getTeamSelected()
        {
            return Teams.ElementAt(listBoxTeam.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Score score in getPlayerSelected().Scores)
            {
                listBoxScore.Items.Add(score.Mod + " " + score.Point);
            }
        }

        private Player getPlayerSelected()
        {
            return getTeamSelected().Players.ElementAt(listBoxPlayer.SelectedIndex);
        }
    }
}
