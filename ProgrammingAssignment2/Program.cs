using System;
using ConsoleCards;

namespace ProgrammingAssignment2
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 2
    /// </summary>
    class Program
    {
        /// <summary>
        /// Implements Nothing Like Blackjack functionality
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {


            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");
            Player player3 = new Player("Player 3");
            Player player4 = new Player("Player 4");


            // Add your code between this comment
            // and the comment below. You can of
            // course add more space between the
            // comments as needed

            // declare a deck variable and create a deck object
            Deck deck = new Deck();
            // DON'T SHUFFLE THE DECK

            // deal 2 cards each to 4 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            for (var i = 2; i > 0; i--)
            {
                player1.drawCard(deck.TakeTopCard());
                player2.drawCard(deck.TakeTopCard());
                player3.drawCard(deck.TakeTopCard());
                player4.drawCard(deck.TakeTopCard());
            }
            // deal 1 more card to players 2 and 3
                player2.drawCard(deck.TakeTopCard());
                player3.drawCard(deck.TakeTopCard());

            // flip all the cards over
            player1.flipCards();
            player2.flipCards();
            player3.flipCards();
            player4.flipCards();

            // print the cards for player 1
            player1.showCards();

            // print the cards for player 2
            player2.showCards();

            // print the cards for player 3
            player3.showCards();

            // print the cards for player 4
            player4.showCards();

        }
    }
}
