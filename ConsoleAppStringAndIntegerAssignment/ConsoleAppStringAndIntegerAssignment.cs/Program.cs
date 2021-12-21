using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStringAndIntegerAssignment.cs
{
    class Program
    {
        static void Main()
        {
            // Create a List of the integer
            List<int> numbers = new List<int>{2,4,6,8,10};
            //Ask the user for number to divided each number
            Console.WriteLine("Plese put the number to divided each number");
            int user = Convert.ToInt32(Console.ReadLine());

            // A loop that iterate through each string
            // loop in try catch block
          
            try
            {
                for (int i = 0; i < numbers.Count; i++)
                {

                    int result = numbers[i] / user;
                    Console.WriteLine(result);

                }

            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divided by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            finally
            {
                Console.WriteLine("We finished the try catch");
                Console.ReadLine();
            }
        }
    }
}
