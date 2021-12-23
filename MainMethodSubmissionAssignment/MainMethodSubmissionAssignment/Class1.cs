using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment
{
    class Class1
    {
        // creatw a method that will take integer
        // AddNumber function 
        public int AddNumber(int x)
        {
            return x + 5;

        }
        // subtract the number
        public int SubtractNumber(int y)
        {
            return y - 10;
        }
        //multiply the number

        public int multiply(int z)
        {
            return z * 4;
        }
        // creatw a method that will take decimal
        public decimal divide(decimal a)
        {
            return a / 2;
        }
        // creatw a method that will take string
        public int addNum(string b)
        {
            int c = Convert.ToInt32(b);
            return c + 2;
        }
    }
}

