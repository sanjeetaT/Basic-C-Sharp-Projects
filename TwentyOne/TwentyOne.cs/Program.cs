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
           
            Console.WriteLine("Welcome to the Grand Hotel and Casino.Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("and how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. would you like to join a game of 21 roght now ?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivePlaying = true;
                while (player.isActivePlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing");
            }
            Console.WriteLine("Feel free to look around the casino, Bye for now.");
            Console.Read();
           // Deck deck = new Deck();
            //  Lambda
            //int count = deck.Cards.Count(x => x.Face == face.Ace);
            //int counter = 0;
            //foreach (Card card in deck.Cards)
            //{
            //    if(card.Face == Face.Ace)
            //    {
            //        counter++;
            //    }
            //}
            
            //Card card1 = new Card();
            //Card card2 = card1;
            //card1.Face = Face.Eight;
            //card2.Face = Face.King;

            //Console.WriteLine(card1.Face);
            

            //Card card = new Card();
         
            //card.Suit = Suit.Clubs;
           // int underlyingValue = Convert.ToInt32(Suit.Diamonds);
           // DaysOfTheWeek day = DayOfTheWeek.Monday;
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<Player>
            //Player player = new Player();
            //player.Name = "Jesse";
            //game = game + player;
            //game = game - player;
            //deck.deck = new Deck();
           // Deck.Shuffle(3);
            // polyMorision
            //    List<Game> games = new List<Game>();

            // TwentyOneGame game = new TwentyOneGame();
            //  game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            // games.Add(game);
            //game.ListPlayers();
            //Console.ReadLine();


            //Game game = new Game();
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            //Console.ReadLine();
            // Deck deck = new Deck();


            //List<Card> deck = new List<Card>();

            // int timesShuffled = 0;
            //deck = Shuffle(3);
            //// deck = Shuffle(deck: deck, times: 3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}

            //Console.WriteLine(deck.Cards.Count);
            //Console.WriteLine("Times shufflled: {0}");

           // Console.ReadLine();
        }
        //public enum DaysOfTheWeek
        //{
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //}
      
        
          
        }
       

    }
}
