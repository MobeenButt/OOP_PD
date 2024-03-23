using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeckGame.BL
{
    internal class Deck
    {
       protected List<Card> cards;
       protected int CardIndex;
        public Deck() { 
        cards = new List<Card>();
            CardIndex = 0;
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards.Add(new Card(value, suit));
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
            return cards.Count-CardIndex;
        }
        public Card DealCard()
        {
            if(CardIndex < cards.Count)
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
