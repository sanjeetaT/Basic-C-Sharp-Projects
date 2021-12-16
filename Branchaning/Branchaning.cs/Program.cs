using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branchaning.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome pacage
             
            Console.WriteLine("Welcome to the Package Express. Please follow the instructor bellow");

            // Packege weight
            Console.WriteLine("Please inter the packege weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Packege wight is:" + weight);

            if (weight > 50)
            {
                Console.WriteLine("Packege is too heavy to be shipped via package Express. Havea a good day");
            }
            else
            {


                // Packege height
                Console.WriteLine("Please inter the packege height");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Packege height is:" + height);

                // Packege length
                Console.WriteLine("Please inter the packege length");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Packege height is:" + length);

                // Packege width
                Console.WriteLine("Please inter the packege width");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Packege width is:" + width);

                int dimensions = length + height + width;
                if (dimensions > 50)

                {
                    Console.WriteLine("Packege is too big to be shipped via package Express");
                }
                else
                {
                    int price = length * height * width * weight / 100;
                    Console.WriteLine(price);
   
                }
            }
            Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //int favNum = Convert.ToInt32(Console.ReadLine());
            //string result = favNum == 12 ? "you have an awesome favorite number." : "you do not have an awesome favorite number.";
            //Console.WriteLine(result);
            //Console.ReadLine();


        }
    }
}