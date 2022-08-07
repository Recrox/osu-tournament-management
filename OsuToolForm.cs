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
    public partial class OsuToolForm : Form
    {
        private List<Team> Teams;
        public OsuToolForm()
        {
            InitializeComponent();

            Teams = new List<Team>();
            //FillModel();
            ShowTeams();

        }

        private void FillModel()
        {
            for (int i = 0; i < 3; i++)
            {
                Teams.Add(new Team("Team num " + i));
                for (int j = 0; j < 3; j++)
                {
                    Teams[i].AddPlayer("Joueur num " + j + " " + i);
                    for (int k = 0; k < 5; k++)
                    {
                        Teams[i].Players[j].AddScore("NM" + k + " |", k * 100000);
                    }
                }
            }       
        }

        private void ShowTeams()
        {
            listBoxTeam.Items.Clear();
            listBoxPlayer.Items.Clear();
            listBoxScore.Items.Clear();

            foreach (Team team in Teams)
            {
                listBoxTeam.Items.Add(team.Name);
            }
        }

        private Team getTeamSelected()
        {
            return Teams.ElementAt(listBoxTeam.SelectedIndex);
        }
        private Player getPlayerSelected()
        {
            return getTeamSelected().Players.ElementAt(listBoxPlayer.SelectedIndex);
        }
        public void AddTeam_Click(object sender, EventArgs e)
        {
            new AddTeamForm(this.Teams).Show();
        }

        private void AddPlayer_Click(object sender, EventArgs e)
        {
            if(listBoxTeam.SelectedItem != null)
                new AddPlayerForm(getTeamSelected().Players).Show();
        }
        private void AddScore_Click(object sender, EventArgs e)
        {
            if (listBoxPlayer.SelectedItem != null)
                new AddScoreForm(getPlayerSelected().Scores).Show();
        }

        private void listBoxTeam_SelectedValueChanged(object sender, EventArgs e)
        {
            showPlayerOfTheTeamSelect();
        }

        private void showPlayerOfTheTeamSelect()
        {
            if (listBoxTeam.SelectedItem != null)
            {
                listBoxPlayer.Items.Clear();
                listBoxScore.Items.Clear();
                foreach (Player player in getTeamSelected().Players)
                {
                    listBoxPlayer.Items.Add(player.Name);
                }
            }
        }

        private void listBoxPlayer_SelectedValueChanged(object sender, EventArgs e)
        {
            showScoreOfThePlayerSelect();
        }

        private void showScoreOfThePlayerSelect()
        {
            if (listBoxPlayer.SelectedItem != null)
            {
                listBoxScore.Items.Clear();
                foreach (Score score in getPlayerSelected().Scores)
                {
                    listBoxScore.Items.Add(score.Mod + " " + score.Point);
                }
            }
        }

        private void DeleteTeam_Click(object sender, EventArgs e)
        {
            if (listBoxTeam.SelectedItem != null)
            {
                this.Teams.RemoveAt(listBoxTeam.SelectedIndex);
                ShowTeams();
            }
        }

        private void DeletePlayer_Click(object sender, EventArgs e)
        {
            if (listBoxPlayer.SelectedItem != null)
            {
                getTeamSelected().Players.RemoveAt(listBoxPlayer.SelectedIndex);
                showPlayerOfTheTeamSelect();
            }
        }

        private void DeleteScore_Click(object sender, EventArgs e)
        {
            if (listBoxScore.SelectedItem != null)
            {
                getPlayerSelected().Scores.RemoveAt(listBoxScore.SelectedIndex);
                showScoreOfThePlayerSelect();
            }       
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ShowTeams();
        }
    }
}
