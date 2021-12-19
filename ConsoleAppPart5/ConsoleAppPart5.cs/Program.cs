using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPart5.cs
{
    class Program
    {
        static void Main()
        { 
        // A list of strings that has at least two identical strings in the list
         List<string> names = new List<string> { "Roy", "Jey", "Alex", "Jey","Sam"};
            Console.WriteLine("Please put the names of the list");
            string text = Console.ReadLine();
          // create loop iterates through the list
            for(int i = 0; i < names.Count; i++ )
            {
                if (names[i] == text)
                {
                    Console.WriteLine(i);
                    
                }

            }
            if (names.Contains(text) == false)
            {
                Console.WriteLine("your name is not in the list");
            }
            Console.ReadLine();


        }
    }
}
