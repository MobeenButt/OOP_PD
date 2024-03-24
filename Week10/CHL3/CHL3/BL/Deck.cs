using System;
using System.Collections.Generic;

namespace CHL3.BL
{
    internal class Deck
    {
        private List<Card> cards;
        private int CardIndex;
        public Deck()
        {
            cards = new List<Card>();
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    Card c = new Card(i, j);
                    cards.Add(c);
                }
            }
        }
        public void Shuffle()
        {
            Random rnd = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Card temp = cards[k];
                cards[k] = cards[n];
                cards[n] = temp;
            }
            CardIndex = 0; // Reset CardIndex after shuffling
        }
        public int CardsLeft()
        {
            return cards.Count - CardIndex;
        }
        public Card DealCard()
        {
            if (CardIndex < cards.Count)
            {
                return cards[CardIndex++];
            }
            else
            {
                return null;
            }
        }
    }

}

