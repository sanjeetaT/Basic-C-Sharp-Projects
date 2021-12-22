using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne.cs
{
    class Card
    {   
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }
        // get set method with property
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
