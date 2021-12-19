using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPart2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // An infinite loop and fix infinite loop
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 10);

            Console.ReadLine();

        }
    }
}
