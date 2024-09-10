using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave5Spillekort
{
    internal class CardGame
    {
        List<Card> cards;

        public CardGame()
        {
            cards = new List<Card>(); 
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }
        public void AddCard(Suit suit, CardNumber number)
        {
            cards.Add(new Card(suit, number));
        }
        //Method that takes a delegate (that takes a card and returns a bool) as parameter
        //and returns filtered cards in a list
        public List<Card> filterCardGame(FilterCardDelegate filter) 
        {
            var filteredCards = new List<Card>();

            foreach (Card card in cards)
            {
                if (filter(card))
                {
                    filteredCards.Add(card);
                }
            }

            return filteredCards;
        }
    }
}
