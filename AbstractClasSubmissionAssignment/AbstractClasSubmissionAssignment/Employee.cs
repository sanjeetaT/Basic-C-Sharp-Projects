using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasSubmissionAssignment
{
    class Employee : Person
    {
        // Emplement the SayName method inside the Employee
        public override void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);

            Console.ReadLine();
        }
    }
}

