using System;
using System.Media;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Result : Form
    {
        private SoundPlayer soundPlayer;
        public Result()
        {
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
           int result = Dashboard.result;
           if(result == 1)
            {
                resultPictureBox.Image = Properties.Resources._3596_win_result_2;
                soundPlayer = new SoundPlayer(Properties.Resources.Applause);
                soundPlayer.Play();
                resultWord.Text = Dashboard.guessWord;
                resultWord.ForeColor = System.Drawing.Color.Green;
                resultText.Text = "Congratulation! You won.";
            }
            else
            {
                resultPictureBox.Image = Properties.Resources._11864_crying;
                soundPlayer = new SoundPlayer(Properties.Resources.Sad);
                soundPlayer.Play();
                resultWord.Text = Dashboard.guessWord;
                resultWord.ForeColor = System.Drawing.Color.DarkRed;
                resultText.Text = "You failed! Try again.";
            }
        }

        private void play_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
            Close();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

        private void goHomeBtn_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            Hide();
            Preload preload = new Preload();
            preload.ShowDialog();
            Close();
        }
    }
}
