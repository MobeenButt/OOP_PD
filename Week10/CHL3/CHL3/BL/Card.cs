namespace CHL3.BL
{
    internal class Card
    {

        private int value;
        private int suit;
        public Card(int value, int suit)
        {
            this.value = value;
            this.suit = suit;
        }
        public int getValue()
        {
            return value;
        }
        public int getSuit()
        {
            return suit;
        }
        public string GetSuitAsString()
        {
            if (suit== 1)
                return "Clubs";
            else if (suit== 2)
                return "Diamonds";
            else if (suit== 3)
                return "Spades";
            else if (suit== 4)
                return "Hearts";
            return " ";
        }
        public string GetValueAsString()
        {
            if (value == 1)
                return "Ace";
            else if (value == 11)
                return "Jack";
            else if (value == 12)
                return "Queen";
            else if (value == 13)
                return "King";
            return value.ToString();
        }
        public string To_String()
        {
            return GetValueAsString() + " of " + GetSuitAsString();
        }
    }
}
