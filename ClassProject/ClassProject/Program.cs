using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask the user what number they want to do math operation
            Console.WriteLine("Please inter the number");
            int x = Convert.ToInt32(Console.ReadLine());
            // call each method in turn passing the user input
            Class1 obj1 = new Class1();
            Console.WriteLine(obj1.AddNumber(x));
            Console.WriteLine(obj1.SubtractNumber(x));
            Console.WriteLine(obj1.multiply(x));


            Console.ReadLine();

        }
    }
}
