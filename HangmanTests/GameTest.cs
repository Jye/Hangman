using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HangmanTests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void NewGameShouldBeConstructedWithWordToGuessAndAllowedAttemptCountAndMaskCharacter()
        {
            Game game = new Game("Dinosaur", 5, '*');            
        }

        [TestMethod]
        public void RevealedStateShouldShowMaskCharacterForUnknownLetters()
        {
            Game game = new Game("Tree", 5, '*');
            Assert.AreEqual("****", game.RevealedState);
        }

        [TestMethod]
        public void RevealedStateShouldShowMaskCharacterForUnknownLetters2()
        {
            Game game = new Game("Tree", 5, '*');
            game.GuessLetter('e');
            Assert.AreEqual("**ee", game.RevealedState);
        }

        [TestMethod]
        public void GuessingIncorrectLetterShouldDecreaseRemainingAttempts()
        {

            Game game = new Game("Dinosaur", 5, '*');
            Assert.AreEqual(5, game.RemainingAttempts);
            Assert.IsFalse(game.GuessLetter('z'));
            Assert.AreEqual(4, game.RemainingAttempts);
        }

        [TestMethod]
        public void GuessingCorrectLetterShouldUpdateRevealedState()
        {
            Game game = new Game("Bubble", 5, '*');
            Assert.IsTrue(game.GuessLetter('b'));
            Assert.AreEqual("B*bb**", game.RevealedState);
        }

        //[TestMethod]
        //public void GuessingCorrectLetterShouldNotDecrementRemainingAttempts()
        //{
        //    Game game = new Game("Dinosaur", 5, '*');
        //    Assert.AreEqual(5, game.RemainingAttempts);
        //    Assert.IsTrue(game.GuessLetter('d'));
        //    Assert.AreEqual(5, game.RemainingAttempts);
        //}

        //[TestMethod]
        //public void GuessingWordCorrectlyShouldRevealWord()
        //{
        //    Game game = new Game("Brother", 5, '*');
        //    Assert.IsTrue(game.Guess("Brother"));
        //    Assert.AreEqual("Brother", game.RevealedState);
        //}

        //[TestMethod]
        //public void GuessingWordCorrectlyShouldScoreNumberOfLettersInWordMultipliedByRemainingAttempts()
        //{
        //    Game game = new Game("Brother", 5, '*');
        //    game.GuessLetter('b');
        //    game.GuessLetter('r');            
        //    game.Guess("Brother");
        //    Assert.AreEqual(21, game.Score);
        //}

        //[TestMethod]
        //public void RunningOutOfAttemptsShouldScoreNegativeNumberOfUnrevealedLettersMultipliedByAllowedAttempts()
        //{
        //    Game game = new Game("Brother", 5, '*');
        //    //Correct guesses
        //    game.GuessLetter('b');
        //    game.GuessLetter('r');

        //    //Incorrect guesses
        //    game.Guess("braille");
        //    game.GuessLetter('a');
        //    game.GuessLetter('u');
        //    game.GuessLetter('i');
        //    game.GuessLetter('d');            
        //    Assert.AreEqual(-25, game.Score);
        //}

        //[TestMethod]
        //public void GameIsOverWhenNoMoreRemainingAttemptsOrAllLettersAreRevealed() {
        //    Game losingGame = new Game("Brother", 3, '*');
        //    losingGame.Guess("braille");
        //    losingGame.GuessLetter('a');
        //    losingGame.GuessLetter('u');
        //    Assert.IsTrue(losingGame.IsOver);

        //    Game winningGame = new Game("Bubble", 3, '*');
        //    winningGame.Guess("bubble");
        //    Assert.IsTrue(winningGame.IsOver);
        //}
    }



    ////Auto-generated game class with no implementation
    //class Game
    //{
    //    String word;

    //    public Game(String word, int allowedAttempts, char letterMask)
    //    {
    //        this.word = word;
    //        RevealedState = String.Empty;
    //        for (int i = 0; i < word.Length; i++)
    //        {
    //            RevealedState += letterMask;
    //        }
    //        RemainingAttempts = allowedAttempts;
                
    //    }

    //    public bool GuessLetter(char guess)
    //    {
    //        char[] revealed = RevealedState.ToCharArray();
    //        Boolean foundGuessInWord = false;

    //        for (int i = 0; i < word.Length; i++)
    //        {
    //            if (word[i] == guess) {
    //                revealed[i] = guess;
    //                foundGuessInWord = true;
    //            }
    //        }
    //        if (!foundGuessInWord)
    //        {
    //            RemainingAttempts -= 1;
    //        }

    //        RevealedState = new String(revealed);

    //        return foundGuessInWord;
    //    }

    //    public int RemainingAttempts { get; set; }

    //    public String RevealedState { get; private set; }

    //    //public bool Guess(string p)
    //    //{
    //    //    throw new NotImplementedException();
    //    //}

    //    //public int Score { get; set; }
    //    //public bool IsOver { get; set; }
    //}
}
