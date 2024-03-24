using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHL3.BL
{
    internal class BlackJackHand : Hand
    {
       public List<Card> Cards = new List<Card>();  
        public void AddCard(Card card)
        {
            Cards.Add(card);
        }
    


    public int GetBlackJackValue()
        {
            int value = 0;

            foreach (var card in cards)
            {
                int cardValue = card.getValue();

                if (cardValue != 1)
                {
                    if (cardValue > 10)
                    {
                        value += 10;
                    }
                    else
                    {
                        value += cardValue;
                    }
                }
            }

            foreach (var card in cards)
            {
                if (card.getValue() == 1)
                {
                    if (value + 11 <= 21)
                    {
                        value += 11;
                    }
                    else
                    {
                        value += 1;
                    }
                }
            }

            return value;
        }
    }
}

