﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne.cs
{
    public class Player
    {
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            balance = beginningBalance; name;
            Name = name;
        }
        public List <Card> Hand { get; set; }
        public int Balance{ get; set; }
        public string Name{ get; set; }
        public bool isActivePlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)
        {
            if(Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
            }
        }

        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }

    }
}
