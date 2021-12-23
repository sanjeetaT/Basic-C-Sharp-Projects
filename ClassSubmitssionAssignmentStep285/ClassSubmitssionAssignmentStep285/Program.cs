using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmitssionAssignmentStep285
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            int result = 0;
            // ask the user put the number
            Console.WriteLine("input a number you want divided by 2");
            int a = Convert.ToInt32(Console.ReadLine());
            obj1.divided(a);
            Console.WriteLine("this is the using the out parameter");
            int number = 7;
            Console.WriteLine("result is now " + result);
            Class1.divided(number, out result);
            Console.WriteLine("result is now" + result);
            Console.ReadLine();
        }
    }
}
