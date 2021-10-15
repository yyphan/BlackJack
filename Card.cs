using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public enum CardRank
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eigth = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    public enum CardSuit
    {
        Hearts = 1,
        Spades = 2,
        Clubs = 3,
        Diamonds = 4
    }

    class Card
    {
        // VARIABLES
        private CardRank cardRank;
        private CardSuit cardSuit;

        public Card()
        {
            cardRank = 0;
            cardSuit = 0;
        }

        public CardRank Rank
        {
            get { return cardRank; }
            set { cardRank = value; }
        }

        public CardSuit Suit
        {
            get { return cardSuit; }
            set { cardSuit = value; }
        }

        public override string ToString()
        {
            return cardRank.ToString() + " of " + cardSuit.ToString();
        }
    }
}
