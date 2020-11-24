using System;
using System.Collections.Generic;
using ConsoleCards;

namespace ProgrammingAssignment2
{
    public class Player
    {
        public string Name { get; set;}
        public List<Card> CurrentHand { get; set; }

        // instantiates a player with given name
        public Player(string name)
        {
            Name = name;
            CurrentHand = new List<Card>();
        }
        //adds the card to the player's CurrentHand
        public void drawCard(Card card)
        {
            CurrentHand.Add(card);
        }
        // flips all of the cards in the player's CurrentHand over
        public void flipCards()
        {
            foreach (Card card in CurrentHand)
            {
                card.FlipOver();
            }
        }
        // prints the cards rank and suit to the console
        public void showCards()
        {
            Console.WriteLine($"{Name} has: ");
            foreach(Card card in CurrentHand)
            {
                Console.WriteLine($"{card.Rank} of {card.Suit}");
            }
        }
    }
}
