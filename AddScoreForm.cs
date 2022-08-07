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
    public partial class AddScoreForm : Form
    {
        List<Score> scores;
        public AddScoreForm()
        {
            InitializeComponent();
        }

        internal AddScoreForm(List<Score> scores)
        {
            InitializeComponent();
            this.scores = scores;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int nb;
            if (textBox1.Text != "" && int.TryParse(textBox2.Text,out nb))
            {
                this.scores.Add(new Score(textBox1.Text,Int32.Parse(textBox2.Text)));
            }
        }
    }
}
