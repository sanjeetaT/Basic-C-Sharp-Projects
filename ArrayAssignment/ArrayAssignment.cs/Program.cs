using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment.cs
{
    class Program
    {
        static void Main()
        {
            // Create one dimensional Array of string
            string[] name = { "Ale", "Bed", "Cali", "Joy", "Alex" };
            //Ask the user to select an index
            Console.WriteLine("Plese put the number between 0 to 4");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(name[userNumber]);

            // Create one dimensional Array of integer
            int[] list = { 1, 2, 3, 4, 6, 9 };
            //Ask the user to select an index
            Console.WriteLine("Plese put the number between 0 to 5");
            int userNumber2 = Convert.ToInt32(Console.ReadLine());
            // 
             if(userNumber2 >= 0 && userNumber2 <= 5)
            {
                Console.WriteLine(list[userNumber2]);
            }
            else
            {
                Console.WriteLine("Please pick the number between 0 to 5");
            }
              
          


             // create a list string 
            List<string> stringList = new List<string>();
            stringList.Add("Hello");
            stringList.Add("World");
            stringList.Add("LMS");
            //Ask the user to select the string
            Console.WriteLine("Please choose the number between 0 to 2");
            int userNumber3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringList[userNumber3]);
            
            Console.ReadLine();
        }
    }
}
