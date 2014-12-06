
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Game
    {
        public String Word { get; private set; }
        int allowedAttempts;
        char letterMask;
        char[] revealed;

        public Game(String word, int allowedAttempts, char letterMask)
        {
            this.Word = word;
            this.allowedAttempts = allowedAttempts;
            this.letterMask = letterMask;
            RemainingAttempts = allowedAttempts;
            //RevealedState = String.Empty.PadLeft(word.Length, letterMask);
            revealed = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                revealed[i] = letterMask;
            }


        }


        public bool GuessLetter(char guess)
        {

            Boolean foundGuessInWord = false;
            for (int i = 0; i < Word.Length; i++)
            {
                if (char.ToUpperInvariant(Word[i]) == char.ToUpperInvariant(guess))
                {
                    revealed[i] = Word[i];
                    foundGuessInWord = true;
                }
            }

            if (!foundGuessInWord)
            {
                RemainingAttempts -= 1;
                
            }

           

            return foundGuessInWord;
        }

        public int RemainingAttempts { get; set; }

        public String RevealedState { 
            get
            { 
                //return revealed.ToString();--doesn't work
                return new string (revealed);
            }
        }

        public bool Guess(string guessWord)
        {
            if (string.Equals(guessWord, Word, StringComparison.CurrentCultureIgnoreCase))
            {
                revealed = Word.ToCharArray();

                return true;
            }
            else
            {
                RemainingAttempts -= 1;
               
                return false;
            }


        }

        public int Score
        {
            get
            {
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

                    return -unrevealedCount * allowedAttempts;
                }
                else if (RevealedState == Word)
                {
                    return Word.Length * RemainingAttempts;
                }
                else
                {
                    return 0;
                }
            }
        }


        public bool IsOver
        {
            get
            {
                return ((RemainingAttempts == 0) || (RevealedState == Word));
            }
        }
    }
}
