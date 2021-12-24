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
            employee.FirstName = new List<string>()
            {
                "Joe", "Alex", "RO", "Joe", "Yo", "Sam","Char", "Bed", "YO", "Kat"
            };
            employee.LastName = new List<string>()
            {
              "Roy", "Morgen", "Lang", "Dahal","La", "Gi", "Koper", "Khan", "Kumar","Rai"
            };
            employee.ID = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };
            List<string> Joe = employee.FirstName.Where(x => x == "Joe").ToList();
            List<int> moreThan5 = employee.ID.Where(X => X > 5).ToList();
            //List<Employee> employee = new List<Employee>();
            //List<string> FirstName = new List<string>();
            //List<string> LaststName = new List<string>();
             //  List<int> ID = new List<int>();

            foreach(string firstName in Joe)
            {
                Console.WriteLine(firstName);
            }
            foreach (int  id in moreThan5)
            {
                Console.WriteLine(employee.FirstName[id]);
            }

            Console.ReadLine();

        }
    }
}
