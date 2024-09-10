using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave5Spillekort
{
    //Enum used to list the suits
    enum Suit
    {
        Hearts,
        Diamonds,
        Spades,
        Clubs
    }
    //Enum used to list the numbers
    enum CardNumber
    {
        Ace,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
    //Delegate for a filter
    delegate bool FilterCardDelegate(Card card);
    internal class Card
    {
        public Card(Suit suit, CardNumber number) 
        {
            Suit = suit;
            Number = number;
        }

        public Suit Suit {  get; set; }
        public CardNumber Number { get; set; }

        public override string ToString()
        {
            return Suit + " " + Number;
        }
    }
}
