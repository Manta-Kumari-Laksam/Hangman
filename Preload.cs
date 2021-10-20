using System;
using System.Windows.Forms;

namespace Hangman
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
