using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    class Hand
    {
        // CONSTANTS
        private const int StartingCardCount = 2;

        // VARIABLES
        private List<Card> cards;
        private int currentSum = 0;

        public List<Card> Cards
        {
            get { return cards; }
        }

        public int CurrentSum
        {
            get { return currentSum; }
        }

        public Hand(Deck deck)
        {
            cards = new List<Card>();
            for (int i = 0; i < StartingCardCount; i++)
            {
                deck.DrawCard(this);
            }
        }

        public void CalculateValue()
        {
            int aceCount = 0;
            currentSum = 0;

            // Count everything except for Ace
            foreach(Card card in cards)
            {
                if (card.Rank == CardRank.Ace)
                {
                    aceCount++;
                }
                else if (card.Rank == CardRank.Jack || card.Rank == CardRank.Queen || card.Rank == CardRank.King)
                {
                    currentSum += 10;
                }
                else
                {
                    currentSum += (int)card.Rank;
                }
            }

            // Count Ace based on current sum
            for (int i = 0; i < aceCount; i++)
            {
                if (currentSum < 11)
                {
                    currentSum += 11;
                }
                else
                {
                    currentSum += 1;
                }
            }
        }
    }
}
