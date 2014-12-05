using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace HangmanWinForms
{
    public partial class MainForm : Form
    {
        Game currentGame;
        String[] nouns = File.ReadAllLines("nouns.txt");
        Random rnd = new Random();
        readonly int MAX_GUESSES = 5;
        readonly char MASK_CHAR = '*';
            
        public MainForm()
        {
            InitializeComponent();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {            
            var word = nouns[rnd.Next(nouns.Length)];
            currentGame = new Game(word, MAX_GUESSES, MASK_CHAR);
            SyncFrom(currentGame);
        }

        private void SyncFrom(Game currentGame)
        {
            remainingGuessesLabel.Text = currentGame.RemainingAttempts;
            revealedLabel.Text = currentGame.RevealedState;
            if (currentGame.IsOver)
            {
                scoreLabel.Text = currentGame.Score;
            }
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            var guess = guessTextBox.Text;
            if (guess.Length == 1)
            {
                currentGame.GuessLetter(guess[0]);
            }
            else if (guess.Length > 1)
            {
                currentGame.Guess(guess);
            }
            guessTextBox.Text = String.Empty;
            SyncFrom(currentGame);
        }

    }
}
