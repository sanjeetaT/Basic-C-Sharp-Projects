using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndSubmitionAssignmentStep292
{
    class Person
    {
        // person class property
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // sayName function 
        public void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName  + " " + this.LastName);
            
            Console.ReadLine();
        }
    }
}
