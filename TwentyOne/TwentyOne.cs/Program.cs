using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";
            //Guid identifier = Guid.NewGuid();


            //var newDictionary  = new Dictionary <String, string>();
            //var newPlayer = new Player("Sanjeeta"); 
            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);
            //TimeSpan TimeAtGraduation = yearOfGraduation - yearOfBirth;
           // string text = File.ReadAllText(@"C:\Users\Sanjeeta\Logs\log.txt");
           // string text = "Here is some text.";
            //File.WriteAllText(@"C:\Users\Sanjeeta\Logs\log.txt", text);


            Console.WriteLine("Welcome to the Grand Hotel and Casino.Let's start by telling me your name.", casinoName);
            
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadException();
                foreach(var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

            bool validAnswer = false;
            int bank = 0;
            while(!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimal.");
            }

            //Console.WriteLine("and how much money did you bring today?");
            //int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. would you like to join a game of 21 roght now ?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Dridh\OneDrive\Documents\GitHub\Basic-C-Sharp-Projects\TwentyOne\TwentyOne.cs\logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                    
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivePlaying = true;
                while (player.isActivePlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithExceptions(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred. Please contact your System Administrator.");
                        UpdateDbWithExceptions(ex);
                        Console.ReadLine();
                        return;
                    }


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
        private static void UpdateDbWithExceptions(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                  Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                  TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                (@ExceptionType, @ExceptionMessage, @TimeStamp)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }



        }
         private static List<ExceptionEntity> ReadException()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                  Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                  TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);

                }
                connection.Close();
            }
            return Exceptions;

        }
        
          
        }
       

    }

