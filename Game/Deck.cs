using System;
using System.Collections.Generic;

namespace DeckClass
{
    class Deck
    {
        private List<int> deck = new List<int>();
        private int card_drawn;
        private int[] shuffled_deck;
        private int card_index = 0;
        
        public Deck()
        {
            for (int i = 1; i <= 13; i++)
            {
                deck.Add(i);
                deck.Add(i);
                deck.Add(i);
                deck.Add(i);
            }
        }
        
        public int[] Shuffle()
        {
            Random rand = new Random();
            shuffled_deck = deck.ToArray();
            for (int i = 0; i < shuffled_deck.Length; i++)
            {
                int temp = shuffled_deck[i];
                int randomIndex = rand.Next(i, shuffled_deck.Length);
                shuffled_deck[i] = shuffled_deck[randomIndex];
                shuffled_deck[randomIndex] = temp;
            }
            return shuffled_deck;
        }
        
        public int draw()
        {
            card_drawn = shuffled_deck[card_index];
            card_index++;
            return card_drawn;
        }
        
        public void reset()
        {
            card_index = 0;
        }
    }
}
