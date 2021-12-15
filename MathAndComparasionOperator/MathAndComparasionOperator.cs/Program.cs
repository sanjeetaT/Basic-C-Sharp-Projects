using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparasionOperator.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            // print Anonyous
            Console.WriteLine("Anonyous Income Comparison Program");

            // Person 1
            Console.WriteLine("Person 1");
            float hourlyRate = float.Parse(Console.ReadLine());
            Console.WriteLine(" hourlyRate:" + hourlyRate);

            float hoursWorked = float.Parse(Console.ReadLine());
            Console.WriteLine(" total hourse are :" + hoursWorked);
            Console.ReadLine();

            // Person 2
            Console.WriteLine("Person 2");
            float hourlyRateA = float.Parse(Console.ReadLine());
            Console.WriteLine(" hourlyRate:" + hourlyRateA);

            float hoursWorkedA = float.Parse(Console.ReadLine());
            Console.WriteLine(" total hourse are :" + hoursWorkedA);

            //  Annual Salary Person 1
            Console.WriteLine("Annual Salary person1");
            float AnnualRateA = hourlyRate * hoursWorked * 52;
            Console.WriteLine(" total Rates are :" + AnnualRateA);

            //  Annual Salary Person 2
            Console.WriteLine("Annual Salary Person2");
            float AnnualRateB = hourlyRateA * hoursWorkedA * 52;
            Console.WriteLine(" total Rates are :" + AnnualRateB);

            //comperision
            Console.WriteLine("Does person1 make more money than Person2?");
            bool isMakeMoreMoney = AnnualRateA > AnnualRateB;
            Console.WriteLine(isMakeMoreMoney);
            Console.ReadLine();


       
   


        }
    }
}
