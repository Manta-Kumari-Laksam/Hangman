using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Hangman
{
    public partial class Dashboard : Form
    {
        private Bitmap[] hangmanImages =
        {
            Properties.Resources.Hang1,
            Properties.Resources.Hang2,
            Properties.Resources.Hang3,
            Properties.Resources.Hang4,
            Properties.Resources.Hang5,
            Properties.Resources.Hang6,
            Properties.Resources.Hang7
        };
        private int wrongGuesses = 0;
        private string[] words;
        private string[] category;
        public static string guessWord;
        string copyCurrent = "";
        public static int result;
        private int guessIndex = 0;
        private char[] wrongGuessLetter = new char[6];
        private bool twoPlayers = Preload.twoPlayers;
        private static char[] wordChosenByPlayer1;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void LoadWords()
        {
            string[] readText = File.ReadAllLines("Wordfile.csv");
            char[] separator = { ',' };
            words = new string[readText.Length];
            category = new string[readText.Length];
            int index = 0;
            foreach(string s in readText)
            {
                string[] line = s.Split(separator);

                category[index] = line[0];
                words[index++] = line[1];
            }            
        }

        private void LoadWordChosenByPlayer1(char[] wordByPlayer1) 
        {
            wrongGuesses = 0;
            guessIndex = 0;
            hangmanImage.Image = hangmanImages[wrongGuesses];
            twoPlayers = false;
            hint.Text = "";
            guessWord = new string(wordByPlayer1);
            copyCurrent = "";
            for (int i = 0; i < guessWord.Length; i++)
            {
                copyCurrent += "_";
            }
            chosenWord.Text = "";            
            DisplayGuessWordDashes(copyCurrent);
            clear.Hide();
            erase.Hide();
            play.Hide();
        }
        private void SetupWordChoice()
        {
            wrongGuesses = 0;
            hangmanImage.Image = hangmanImages[wrongGuesses];
            int guessIndex = (new Random()).Next(words.Length);
            hint.Text = category[guessIndex];
            guessWord = words[guessIndex];
            //guessWord = "HOUSE";


            for(int i = 0; i < guessWord.Length; i++)
            {
                copyCurrent += "_";
            }
            DisplayGuessWordDashes(copyCurrent);
        }

        private void DisplayGuessWordDashes(string copyCurrent)
        {
            for(int i = 0; i < copyCurrent.Length; i++)
            {
                chosenWord.Text += copyCurrent.Substring(i, 1);
                chosenWord.Text += " ";
            }
        }

        private void GuessClick(object sender, EventArgs e)
        {
            Button chosenLetter = sender as Button;
            char guessLetter = chosenLetter.Text.ElementAt(0);
            char[] copyCurrentChar = copyCurrent.ToCharArray();

            if (twoPlayers == true)
            {
                if(guessIndex < 15)
                {
                    wordChosenByPlayer1[guessIndex] = guessLetter;
                    copyCurrentChar[guessIndex++] = guessLetter;
                    copyCurrent = new string(copyCurrentChar);
                    chosenWord.Text = "";
                    DisplayGuessWordDashes(copyCurrent);
                }
            }
            else
            {
                if (guessWord.Contains(guessLetter, StringComparison.OrdinalIgnoreCase))
                {
                    chosenLetter.BackColor = Color.Blue;
                    for (int i = 0; i < guessWord.Length; i++)
                    {
                        if (guessWord[i].Equals(guessLetter))
                        {
                            copyCurrentChar[i] = guessLetter;
                        }
                    }
                    copyCurrent = new string(copyCurrentChar);
                    if (guessLetter.Equals(copyCurrent) || !copyCurrent.Contains("_"))
                    {
                        result = 1;
                        Hide();
                        Result resultbox = new Result();
                        resultbox.ShowDialog();
                        Close();

                    }
                    chosenWord.Text = "";
                    DisplayGuessWordDashes(copyCurrent);
                }
                else if (wrongGuessLetter.Contains(guessLetter))
                {
                    //Do Nothing
                    //So that wrong letter does't get picked up again.
                }
                else
                {
                    wrongGuesses++;
                    wrongGuessLetter[guessIndex++] = guessLetter;
                    if (wrongGuesses < 6)
                    {
                        hangmanImage.Image = hangmanImages[wrongGuesses];
                        chosenLetter.BackColor = Color.Red;
                    }
                    else
                    {
                        hangmanImage.Image = hangmanImages[wrongGuesses];
                        chosenLetter.BackColor = Color.Red;
                        Hide();
                        result = 0;
                        Result resultbox = new Result();
                        resultbox.ShowDialog();
                        Close();
                    }
                }
            }
        }
        private void WordChosenByPlayer1()
        {
            for(int i = 0; i < wordChosenByPlayer1.Length; i++)
            {
                copyCurrent += "_";
            }
            DisplayGuessWordDashes(copyCurrent);
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            if(twoPlayers == false)
            {
                LoadWords();
                SetupWordChoice();
                clear.Hide();
                erase.Hide();
                play.Hide();
            }
            else
            {
                hint.Text = "Write a word.";
                wordChosenByPlayer1 = new char[15];
                WordChosenByPlayer1();
            }            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            char[] copyCurrentChar = copyCurrent.ToCharArray();
            if (guessIndex > 0)
            {
                copyCurrentChar[--guessIndex] = '_';
                wordChosenByPlayer1[guessIndex] = '\0';
                copyCurrent = new string(copyCurrentChar);
                chosenWord.Text = "";
                DisplayGuessWordDashes(copyCurrent);
            }
        }

        private void erase_Click(object sender, EventArgs e)
        {
            char[] copyCurrentChar = copyCurrent.ToCharArray();
            while (guessIndex > 0)
            {
                copyCurrentChar[--guessIndex] = '_';
                wordChosenByPlayer1[guessIndex] = '\0';
            }
            copyCurrent = new string(copyCurrentChar);
            chosenWord.Text = "";
            DisplayGuessWordDashes(copyCurrent);
        }

        private void play_Click(object sender, EventArgs e)
        {
            string wordSelected = new string(wordChosenByPlayer1);
            if (wordSelected.Any(x => char.IsLetter(x)))
            {
                char[] copyWordChosenByPlayer1 = new char[guessIndex];
                for(int i=0; i< guessIndex; i++)
                {
                    copyWordChosenByPlayer1[i] = wordChosenByPlayer1[i];
                }
                LoadWordChosenByPlayer1(copyWordChosenByPlayer1);
            }
        }
    }
}
