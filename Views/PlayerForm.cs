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
    public partial class AddPlayerForm : Form
    {
        List<Player> players;
        public AddPlayerForm()
        {
            InitializeComponent();
        }

        internal AddPlayerForm(List<Player> players)
        {
            InitializeComponent();
            this.players = players;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                this.players.Add(new Player(textBox1.Text));
            }    
        }
    }
}
