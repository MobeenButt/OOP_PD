using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHL3.BL
{
    internal class Hand
    {
        protected List<Card> cards;

        public Hand()
        {
            cards= new List<Card>();
        }
        public void Addcards(Card c)
        {

            cards.Add (c);
        }
        public void RemoveCard(Card c)
        {

            cards.Remove (c);
        }
        public void RemoveCard(int index) 
        {
            if(index>=0 && index<=cards.Count) 
            {
                cards.RemoveAt (index);
            }
        }
        public int GetcardCount()
        {
            return cards.Count;
        }
        public Card getCard(int index)
        {
            if (index >= 0 && index <= cards.Count)
            {
                return (cards[index]);
            }
            return null;
        }
        public void SortByValue()
        {
            cards=cards.OrderBy(c=>c.getValue()).ToList();
        }
        public void sortBySuit()
        {
            cards = cards.OrderBy(c => c.getSuit()).ToList();
        }
    }
}
