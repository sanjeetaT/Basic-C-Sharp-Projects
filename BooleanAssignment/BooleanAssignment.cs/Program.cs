using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {    
            //  your Age
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your age is:" + age);
           
            // Have you ever have DUI
            Console.WriteLine("Have you ever have DUI");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(" Have you ever have dui?:" + dui);
           

            // How many speeding tickets do you have?
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" tickets are:" + tickets);
           

            // rules of the Application
            bool application = (age > 15 && !dui && tickets <= 3);
            Console.WriteLine("application is approved?");
            Console.WriteLine(application);
            Console.ReadLine();


        }
    }
}
