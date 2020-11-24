using System;
using System.Collections.Generic;
using ConsoleCards;
namespace ProgrammingAssignment2
{
    public class Player
    {
        public string Name { get; set;}
        public List<Card> CurrentHand { get; set; }

        public Player(string name)
        {
            Name = name;
            CurrentHand = new List<Card>();
        }
        public void drawCard(Card card)
        {
            CurrentHand.Add(card);
        }
        public void flipCards()
        {
            foreach (Card card in CurrentHand)
            {
                card.FlipOver();
            }
        }
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
