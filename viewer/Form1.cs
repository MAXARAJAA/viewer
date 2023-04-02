using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static viewer.SeasonObserver;

namespace viewer
{
    public partial class Form1 : Form
    {
        private Season season;

        public Form1()
        {
            InitializeComponent();
            season = new Season();
            season.RegisterObserver(new TreeObserver(pictureBox1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            season.SetSeason(SeasonType.Spring);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            season.SetSeason(SeasonType.Summer);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            season.SetSeason(SeasonType.Autumn);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            season.SetSeason(SeasonType.Winter);
        }
    }
}
