using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave5Spillekort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Made a list for the card game
            CardGame game = new CardGame();

            //Added some cards to the game
            game.AddCard(Suit.Hearts, CardNumber.Ace);
            game.AddCard(Suit.Hearts, CardNumber.Two);
            game.AddCard(Suit.Hearts, CardNumber.Three);
            game.AddCard(Suit.Hearts, CardNumber.Four);
            game.AddCard(Suit.Hearts, CardNumber.Five);
            game.AddCard(Suit.Clubs, CardNumber.Ace);
            game.AddCard(Suit.Clubs, CardNumber.Jack);
            game.AddCard(Suit.Clubs, CardNumber.Queen);
            game.AddCard(Suit.Clubs, CardNumber.King);

            //Used filter delegate to find all spades
            foreach (Card c in game.filterCardGame(FilterByKlør))
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine();

            //Used filter delegate to find all hearts
            foreach (Card c in game.filterCardGame(FilterByHjerter))
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine();

            //Used filter delegate to find all picture cards
            foreach (Card c in game.filterCardGame(FilterByBilledkort))
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine();

            //Used filter delegate to find all none picture cards
            foreach (Card c in game.filterCardGame(FilterByIkkeBilledkort))
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine();

            //Made a variable containing all picture cards by using the filter delegate
            //var billedKort = game.filterCardGame(FilterByBilledkort);
            
            //Same as above, bare med lambda
            List<Card> billedKort = game.filterCardGame(card => (int) card.Number > 9);
            //Printing the chosen cards to the console
            Console.WriteLine(String.Join(", ", billedKort));

            Console.ReadLine();
        }

        //Filter-metoder på kulør
        static public bool FilterByKlør(Card card)
        {
            return card.Suit == Suit.Clubs;
        }
        static public bool FilterByHjerter(Card card)
        {
            return card.Suit == Suit.Hearts;
        }

        //Filter-metoder på værdi
        static public bool FilterByBilledkort(Card card)
        {
            return (int) card.Number > 9 ;
        }
        static public bool FilterByIkkeBilledkort(Card card)
        {
            return (int) card.Number < 9;
        }
    }
}
