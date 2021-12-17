using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said,\\Hello\", Jesse,\n Hello an a new line. \n \t Hello on a tab. ";
            //string fileName = @"C:\\Users\\Jesse";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;
            //name = name.ToUpper();
            //name = name.ToLower();
            //Console.WriteLine(trueOrFalse);
            //Console.ReadLine();

            string name = "Jesse";
            name = "Joe";
            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Jesse");

            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
