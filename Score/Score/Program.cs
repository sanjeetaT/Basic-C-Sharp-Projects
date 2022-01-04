﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleaese enter in your first name.");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back (uName).Today is (date).";
            Console.WriteLine(msg);

            string path = @"C:\Users\Dridh\OneDrive\Documents\GitHub\Basic-C-Sharp-Projects\Score\Score.txt";
            string[] lines System.IO.File.ReadLines(path);
            double tScore = 0.0;
            Console.WriteLine("\nStudent Score: \n");
            foreach (string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student score. \tAverage score: " + avgScore);
            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
