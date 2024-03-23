using CardDeckGame.BL;
using System;

namespace CardDeckGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HIGH-LOW Card Game!");
            Deck deck = new Deck();
            deck.Shuffle();

            Card currentCard = deck.DealCard();

            Console.WriteLine("First Card is: " + currentCard.toString());
            int score = 0;

            while (true)
            {
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();

                Console.Write("Predict Higher (h) or Lower (l) or Quit (q): ");
                string input = Console.ReadLine().ToLower();

                if (input == "q")
                {
                    break;
                }

                // Deal the next card
                Card nextCard = deck.DealCard();

                if (nextCard == null)
                {
                    Console.WriteLine("No more cards left in the deck.");
                    break;
                }

                Console.WriteLine("Next card is: " + nextCard);

                // Determine if prediction is correct
                bool predictionCorrect = false;

                if (input == "h")
                {
                    predictionCorrect = nextCard.getValue() > currentCard.getValue();
                }
                else if (input == "l")
                {
                    predictionCorrect = nextCard.getValue() < currentCard.getValue();
                }

                if (predictionCorrect)
                {
                    Console.WriteLine("Correct prediction!");
                    score++;
                    currentCard = nextCard;
                }
                else
                {
                    Console.WriteLine("Incorrect prediction. Game over!");
                    break;
                }
            }

            // Display final score
            Console.WriteLine("Your score: " + score);
        }
    }
}
