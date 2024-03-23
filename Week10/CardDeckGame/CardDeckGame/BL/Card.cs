namespace CardDeckGame.BL
{
    internal class Card
    {
        protected int value;
        protected int suit;
        public Card(int value, int suit)
        {
            this.value = value;
            this.suit = suit;
        }
        public string getSuitAsString()
        {
            string suitstring = "";
            if (suit == 1)
            {
                suitstring = "Clubs";
            }
            else if (suit == 2)
            {
                suitstring = "Diamonds";
            }
            else if (suit == 3)
            {
                suitstring = "Spades";
            }
            else if (suit == 4)
            {
                suitstring = "Hearts";
            }
            else
            {
                suitstring = suit.ToString();
            }
            return suitstring;
        }

        public string getValueAsString()
        {
            string valuestring = "";
            if (value == 1)
            {
                valuestring = "Ace";
            }
            else if (value == 11)
            {
                valuestring = "Jack";
            }
            else if (value == 12)
            {
                valuestring = "Queen";
            }
            else if (value == 13)
            {
                valuestring = "King";
            }
            else
            {
                valuestring = value.ToString();   // 2-10 values
            }
            return valuestring;
        }
        public string toString()
        {
            return getValueAsString() + " of " + getSuitAsString();
        }
        public int getSuit()
        {
            return suit;
        }
        public int getValue()
        {
            return value;
        }

    }
}
