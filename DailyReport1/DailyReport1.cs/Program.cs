using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport1.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Teach Academy");
            Console.ReadLine();
            Console.WriteLine("Daily Reports");
            Console.ReadLine();
            // A
            // what is your name?
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("your name is:" + yourName);
            Console.ReadLine();
            // B
            // What course are you on?
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("your course is:" + yourCourse);
            Console.ReadLine();
            // C
            // What is the page number?
            Console.WriteLine("What is the page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your page number is:" + pageNumber);
            Console.ReadLine();
            // D
            //Do you need help with anything? Please answer true or false
            Console.WriteLine("Do you need help with anything? Please answer true or false");
            bool help = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(" you need help :" + help);
            Console.ReadLine();
            //E
            // Is there any positive feedback you'd like to provide? Please be specific
            Console.WriteLine("Is there any positive feedback you'd like to provide? Please be specific");
            string reason = Console.ReadLine();
            Console.WriteLine(" experience :" + reason);
            Console.ReadLine();
            // F
            // How many hours did you study today?
            Console.WriteLine("How many hours did you study today?");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" total hourse are :" + hours);
            Console.ReadLine();

            Console.WriteLine("Have a good day");
            Console.ReadLine();

        }

    }
}
