using System;
using DeckClass;
using System.Collections.Generic;

namespace director
{
    class Director
    {
        void main()
        {
            Console.WriteLine("Welcome to a game of Hilo!");
            Console.WriteLine("You will be given a card, and you must guess if the next card will be higher or lower.");
            Console.WriteLine("If you guess correctly, you earn 100 points. If you guess incorrectly, you lose the 75 points.");
            Console.WriteLine("The game ends when you hit 0 points or decide to quit playing.");
            Console.WriteLine("Good luck!");
            
            Deck deck = new Deck();
            int[] shuffled_deck = deck.Shuffle();
            int card_drawn = deck.draw();
            deck.reset();
        }
        
    }
}