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
    public partial class AddTeamForm : Form
    {
        private List<Team> teams;

        public AddTeamForm()
        {
            InitializeComponent();
        }

        internal AddTeamForm(List<Team> teams)
        {
            InitializeComponent();
            this.teams = teams;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                this.teams.Add(new Team(textBox1.Text));
            }
        }
    }
}
