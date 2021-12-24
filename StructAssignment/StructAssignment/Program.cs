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
            Number number;
            number.Amount = 100.5m;//
            Console.WriteLine("decimal:" + number.Amount);
            Console.ReadLine();
        }
         
    }
}
