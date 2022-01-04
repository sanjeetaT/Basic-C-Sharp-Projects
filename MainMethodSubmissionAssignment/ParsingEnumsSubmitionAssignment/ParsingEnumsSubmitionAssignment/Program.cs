using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsSubmitionAssignment
{
    class Program
    {
        // Create the enum for day of the week
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        };
        static void Main(string[] args)
        {
            // wrap up with try catch
            try
            {
                // promt the user to put the current day
                Console.WriteLine("Enter a day of the Week");
                string input = Console.ReadLine();
                WeekDays day = (WeekDays)Enum.Parse(typeof(WeekDays), input);
                Console.WriteLine("Today is " + day);
            }
            catch(Exception)
            {
                Console.WriteLine("Sorry invalid input");
            }
            Console.ReadLine();



        }
    }
}
