using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmissionAssignment
{
    class Employee: Person, IQuittable
    {
        // property
        public int ID { get; set; }
        // method
        public void Quit(string name)
        {
            Console.WriteLine(name + " Quit");
        }
    }
}
