using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        // create a structure number with the number
        struct Number
        {
            public decimal Amount;
            
        };
        static void Main(string[] args)
        {
            Number number;// create an object
            number.Amount = 100.5m;// Assign the Amount
            // print the Amount to the console
            Console.WriteLine("decimal:" + number.Amount);
            Console.ReadLine();
        }
         
    }
}
