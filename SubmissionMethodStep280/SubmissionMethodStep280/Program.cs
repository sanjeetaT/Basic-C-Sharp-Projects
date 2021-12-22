using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmissionMethodStep280
{
    class Program
    {
        static void Main(string[] args)
        {
            // call each method in turn passing the user input
            Class1 obj1 = new Class1();
            // ask the user what number they want to do math operation
            Console.WriteLine("Please enter one or two numbers one at a time");

            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a seond number of you wise");
            try
            {
                int y = Convert.ToInt32(Console.ReadLine());
                int result = obj1.AddNumber(x, y);
                Console.WriteLine(x + " + " + y + " = " + result);
            }
            catch
            {
                int result = obj1.AddNumber(x);
                Console.WriteLine(x + " + " + " 0 " + " = " + result);

            }
            Console.ReadLine();
        }
    }
}
