using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class  struct Card
    {   
        
        // get set method with property
        public Suit Suit { get; set; }
        public string Face { get; set; }

        public override string ToString()
        {

            return string.Format("{0} of {1}", Face, Suit);

        }
        
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spedes
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten

    };
}
