using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsApp
{
    public partial class Preload : Form
    {
        public static bool twoPlayers;
        public Preload()
        {
            InitializeComponent();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Dashboard playground = new Dashboard();
            playground.ShowDialog();
            //result1 = 1;
            //Result result = new Result();
            //result.ShowDialog();
            Close();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }
        private void twoPlayers_Click(object sender, EventArgs e)
        {
            Hide();
            twoPlayers = true;
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
            Close();
        }

        private void Preload_Load(object sender, EventArgs e)
        {
            twoPlayers = false;
        }
    }
}
