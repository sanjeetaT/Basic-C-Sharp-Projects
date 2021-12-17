using System;
using System.Collections.Generic;


namespace Array.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);

            Console.WriteLine(intList[0]);
            Console.ReadLine();

            //  // Array
            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;
            //// Faster way to write
            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };
            //// even more faster way
            //int []numArray2 = {5, 2, 10, 200, 5000, 600, 2300};

            //Console.WriteLine(numArray2[3]);
            //Console.ReadLine();
        }
    }
}
