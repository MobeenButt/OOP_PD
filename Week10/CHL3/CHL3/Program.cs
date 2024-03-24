using CHL3.BL;
using System;

namespace CHL3
{
    internal class Program
    {
        static Deck deck = new Deck();

        static void Main(string[] args)
        {
            deck.Shuffle();
            BlackJackHand player = new BlackJackHand();
            BlackJackHand dealer = new BlackJackHand();

            player.AddCard(deck.DealCard());
            dealer.AddCard(deck.DealCard());
            player.AddCard(deck.DealCard());
            dealer.AddCard(deck.DealCard());

            if (player.GetBlackJackValue() == 21)
            {
                Console.WriteLine("Player Wins!!!");
                goto end;
            }

            while (true)
            {
                Console.WriteLine("Player Turn");
                Console.WriteLine($"Current Hand Value: {player.GetBlackJackValue()}");
                Console.Write("Hit(0) or Stand(1): ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                {
                    player.AddCard(deck.DealCard());
                    if (player.GetBlackJackValue() > 21)
                    {
                        Console.WriteLine("Player Bust");
                        Console.WriteLine("Dealer Wins!!!");
                        goto end;
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Dealer Turn");
            while (dealer.GetBlackJackValue() < 17)
            {
                dealer.AddCard(deck.DealCard());
                if (dealer.GetBlackJackValue() > 21)
                {
                    Console.WriteLine("Dealer Bust");
                    Console.WriteLine("Player Wins!!!");
                    goto end;
                }
            }

            if (dealer.GetBlackJackValue() > player.GetBlackJackValue())
            {
                Console.WriteLine("Dealer Wins!!!");
            }
            else if (dealer.GetBlackJackValue() == player.GetBlackJackValue())
            {
                Console.WriteLine("Draw");
            }
            else
            {
                Console.WriteLine("Player Wins!!!");
            }

        end:
            Console.ReadKey();
        }
    }
}
