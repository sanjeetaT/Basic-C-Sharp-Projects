using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPart6.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the list of string that has at least two identical string in the list
            List<string> vowels = new List<string> { "a", "e", "i", "o", "u", "a" };
            List<string> vowelsCopy = new List<string> ();

            foreach (string vowel in vowels)
            {
             foreach(string vowelCopy in vowelsCopy)
                {
                    if(vowel == vowelCopy)
                    {
                        Console.WriteLine(vowel + " has Appeared Before");
                    }
                }
                vowelsCopy.Add(vowel);

            }
            Console.ReadLine();
        }
    }
}
