using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmissionStep281
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            // ask the user put the number
            Console.WriteLine("input a number");
            int a = Convert.ToInt32(Console.ReadLine());
            // ask the user put the another  number
            Console.WriteLine("input another number");
            int b = Convert.ToInt32(Console.ReadLine());

           // passing two numbers
            obj1.addNumber(a,b);
            Console.ReadLine();
            // passing in by parameter's name
            obj1.addNumber(a: 7, b: 4);

            Console.ReadLine();
        }
    }
}
