using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsSubmitionAssignment
{
    class Program
    {
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

            try
            {
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
