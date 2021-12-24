using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // use the polymorphism to create an object
            IQuittable myIQuittable = new Employee();
            myIQuittable.Quit("Joy");
            Console.ReadLine();
          

        }
    }
}
