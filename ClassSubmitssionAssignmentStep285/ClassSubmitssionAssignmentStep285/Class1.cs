using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmitssionAssignmentStep285
{
    class Class1
    {
        // create the void method that output an integer
        //  Have a method divided the data passed to it by 2
        public void divided(int a)
        {
            int result = a / 2;
            Console.WriteLine("Here is " + a + " / 2  = " + result);


        }

        public static void divided( int num1, out int result )
        {
            result = num1;
        }

    }
}
