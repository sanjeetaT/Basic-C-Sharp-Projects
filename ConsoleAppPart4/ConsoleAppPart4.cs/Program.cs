using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPart4.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cars = new List<string>{ "volvo", "BMW", "ford", "mazda" };

            Console.WriteLine("Please put the name of the cars");
            string text = Console.ReadLine();

            foreach (string car in cars)
                {
                  if(car == text)
                  {
                    Console.WriteLine(cars.IndexOf(text));
                    break;
                 }

                }
            if(cars.Contains(text) == false)
            {
                Console.WriteLine("your item is not in the list");
            }
              Console.ReadLine();

        }
    }
}
