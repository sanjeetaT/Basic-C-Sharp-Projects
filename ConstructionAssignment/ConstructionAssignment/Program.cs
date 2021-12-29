using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("Sanjeet");
            Console.WriteLine(author.Name + " + " + author.Id);
            const string name = "Alex";
            var num1 = "some text";
            Console.ReadLine();

        }
    }
}
