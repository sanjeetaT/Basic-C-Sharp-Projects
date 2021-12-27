using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            // List of ten employee first name
            employee.FirstName = new List<string>()

            {
                "Joe", "Alex", "RO", "Joe", "Yo", "Sam","Char", "Bed", "YO", "Kat"
            };
            // List of ten employee last name
            employee.LastName = new List<string>()
            {
              "Roy", "Morgen", "Lang", "Dahal","La", "Gi", "Koper", "Khan", "Kumar","Rai"
            };
            // List of ten employee id
            employee.ID = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };
            // lanbda express to figure out first name is Joe
            List<string> Joe = employee.FirstName.Where(x => x == "Joe").ToList();
            // labda express to figure out number is greather than 5
            List<int> moreThan5 = employee.ID.Where(X => X > 5).ToList();
          
             //  foreach loop to using the at least we have same name of two employee
            foreach(string firstName in Joe)
            {
                Console.WriteLine(firstName);
            }
            // foreach loop to figure out the number greather than 5
            foreach (int  id in moreThan5)
            {
                Console.WriteLine(employee.FirstName[id]);
            }

            Console.ReadLine();

        }
    }
}
