using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BlackJack
{
    class Deck
    {
        // VARIABLES
        private List<Card> cards;

        public List<Card> Cards
        {
            get { return cards; }
            set { cards = value; }
        }

        public void ShuffleDeck()
        {
            cards.Clear();

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    Card card = new Card();
                    card.Rank = (CardRank)j;
                    card.Suit = (CardSuit)i;
                    cards.Add(card);
                }
            }

            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card temp = cards[k];
                cards[k] = cards[n];
                cards[n] = temp;
            }
        }

        public Deck()
        {
            Cards = new List<Card>();
            ShuffleDeck();
        }

        public Card DrawCard(Hand hand)
        {
            if (cards.Count <= 15) ShuffleDeck();

            Card cardDrawn = cards[0];
            cards.Remove(cardDrawn);
            hand.Cards.Add(cardDrawn);
            hand.CalculateValue();

            return cardDrawn;
        }
    }
}
