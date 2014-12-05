using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Game
    {
        String word;
        int allowedAttempts;
        char letterMask;

        public Game(String word, int allowedAttempts, char letterMask)
        {
            this.word = word;
            this.allowedAttempts = allowedAttempts;
            this.letterMask = letterMask;
            RevealedState = String.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                RevealedState += letterMask;
            }
            RemainingAttempts = allowedAttempts;

        }

        public bool GuessLetter(char guess)
        {
            char[] revealed = RevealedState.ToCharArray();
            Boolean foundGuessInWord = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (char.ToUpperInvariant(word[i]) == char.ToUpperInvariant(guess))
                {
                    revealed[i] = word[i];
                    foundGuessInWord = true;
                }
            }
            if (!foundGuessInWord)
            {
                RemainingAttempts -= 1;
                if (RemainingAttempts == 0)
                {
                    int unrevealedCount = 0;
                    for (int i = 0; i < revealed.Length; i++)
                    {                     
                        if (revealed[i] == letterMask)
                        {
                             unrevealedCount = unrevealedCount + 1;
                        }
                    }

                    Score = -unrevealedCount * allowedAttempts;
                }
            }

            RevealedState = new string(revealed);

            return foundGuessInWord;
        }

        public int RemainingAttempts { get; set; }

        public String RevealedState { get; private set; }

        public bool Guess(string guessWord)
        {
            char[] revealed = RevealedState.ToCharArray();
            if (string.Equals(guessWord, word, StringComparison.CurrentCultureIgnoreCase))
            {
                RevealedState = word;
                Score = word.Length * RemainingAttempts;
                return true;
            }
            else
            {
                RemainingAttempts -= 1;
                if (RemainingAttempts == 0)
                {
                    int unrevealedCount = 0;
                    for (int i = 0; i < revealed.Length; i++)
                    {
                        if (revealed[i] == letterMask)
                        {
                            unrevealedCount = unrevealedCount + 1;
                        }
                    }

                    Score = -unrevealedCount * allowedAttempts;
                }
                return false;
            }

            
        }

        public int Score { get; private set; }


        public bool IsOver { get; set; }
    }       
}
