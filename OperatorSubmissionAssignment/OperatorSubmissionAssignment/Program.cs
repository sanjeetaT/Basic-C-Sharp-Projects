using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)

        {
            // overload operator and check employee object are same
            Employee employee1 = new Employee(){ ID = 1 };
            Employee employee2 = new Employee(){ ID = 1 };
            Console.WriteLine(employee1 == employee2);
            Console.ReadLine();
        }
    }
}
