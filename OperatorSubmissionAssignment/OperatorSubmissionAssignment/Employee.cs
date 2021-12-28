using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorSubmissionAssignment
{
    class Employee
    {
        // person class property
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int ID { get; set;}
        // ==  bool operator
        public static bool operator == (Employee emp1, Employee emp2)
        {
            return emp1.ID == emp2.ID;
        }
        public static bool operator != (Employee emp1, Employee emp2)
        {
            return emp1.ID != emp2.ID;
        }
    }
}
