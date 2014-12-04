using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Game
    {
        int allowedCount;
        char mask;
        string word;
        char letter;
        
        

        public Game(string word, int allowedCount, char mask) {
            this.word = word;
            this.allowedCount = allowedCount;
            this.mask = mask;
        }

        public string RevealedState{
            get{

                
                char[] letters = word.ToCharArray();
                for (int i = 0; i < letters.Length; i++)
                {
                    letters[i] = mask;
                }
                string maskedWord = new string(letters);

                if (GuessLetter(letter) == true)
                {
                    string newWord = maskedWord.Replace(mask, letter);
                    return newWord;
                }

                for (int i = allowedCount-1; i > 0; i--)
                {
                    if (GuessLetter(letter) == true)
                    {

                       newWord = newWord.Replace(mask, letter);
                        return newWord;
                    }
                    else
                    {
                        return newWord;
                    }
                }
            }
        }

        public int RemainingAttempts
        {
            get
            {
                RemainingAttempts = allowedCount;
                if (GuessLetter(letter) == false)
                    {
                        return i = i - 1;
                    }
                    else
                        return i;
            }
        }

        public bool GuessLetter(char letter)
        {
            this.letter = letter;
             return word.IndexOf(letter) != -1;

        }
    }
    

}
