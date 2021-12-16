using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;
            do
            {
               
                    switch (number)
                    {
                        case 62:
                            Console.WriteLine("you guessed 62. Try again");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 29:
                            Console.WriteLine("you guessed 29. Try again");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 55:
                            Console.WriteLine("you guessed 55. Try again");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 12:
                            Console.WriteLine("you guessed number 12. That is correct");
                            break;
                        default:
                            Console.WriteLine("you are wrong");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }

                while (!isGuessed);
               
            //while (!isGuessed)
            //{
            //    switch (number)
            //    {
            //        case 62:
            //            Console.WriteLine("you guessed 62. Try again");
            //            Console.WriteLine("Guess a number?");
            //             number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 29:
            //            Console.WriteLine("you guessed 29. Try again");
            //            Console.WriteLine("Guess a number?");
            //             number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 55:
            //            Console.WriteLine("you guessed 55. Try again");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 12:
            //            Console.WriteLine("you guessed number 12. That is correct");
            //          break;
            //        default:
            //            Console.WriteLine("you are wrong");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}
            //switch (number)
            //{
            //    case 62:
            //        Console.WriteLine("you guessed 62. Try again");
            //        break;
            //    case 29:
            //        Console.WriteLine("you guessed 29. Try again");
            //        break;
            //    case 55:
            //        Console.WriteLine("you guessed 55. Try again");
            //        break;
            //    case 12:
            //        Console.WriteLine("you guessed number 12. That is correct");
            //        break;
            //    default:
            //        Console.WriteLine("you are wrong");
            //        break;
            //}
            
        
            
        }
       
         
            
    }

}