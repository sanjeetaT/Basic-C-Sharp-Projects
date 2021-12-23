using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            //Game game = new Game();
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            //Console.ReadLine();
            // Deck deck = new Deck();


            //List<Card> deck = new List<Card>();

            // int timesShuffled = 0;
            deck = Shuffle(3);
            // deck = Shuffle(deck: deck, times: 3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shufflled: {0}");

            Console.ReadLine();
        }
      
        
          
        }
       

    }
}
