using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndSubmitionAssignmentStep292
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a myEmployee
            // use emply class and constructor 
            // Assign first name and last  name
            Employee myEmployee = new Employee()
            {
                FirstName = " Sample ",
                LastName = " Student "
            };
            // call the sayName method from the Employee class on the myEmployee object
            myEmployee.SayName();
            

        }
    }
}
