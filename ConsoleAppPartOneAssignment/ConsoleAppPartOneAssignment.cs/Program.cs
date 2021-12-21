using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPartOneAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Create one dimensional Array of string
            string[] names = { "Ale", "Bed", "Cali", "Joy", "Alex" };
            //Ask the user input some text
            Console.WriteLine("Plese put the some test");
            string userText = Console.ReadLine();

            // A loop that iterate through each string
            for(int i = 0; i < names.Length; i++)
            {
                //names[i] = names[i] + userText;
                names[i] += " " + userText;
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
        }      
    }
}
