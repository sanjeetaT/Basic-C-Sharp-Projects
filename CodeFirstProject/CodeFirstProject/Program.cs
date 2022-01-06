using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeFirstProject
{
    class Program
    {
        static void Main()
        {
            using (var db = new StudentContext())
            {
                // Create and save a new Blog
                Console.Write("Enter a name for a new Student: ");
                var name = Console.ReadLine();

                var student = new Student { Name = name };
                db.Students.Add(student);
                db.SaveChanges();

                // Display all Studentss from the database
                var query = from b in db.Students
                            orderby b.Name
                            select b;

                Console.WriteLine("All Students in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
           
        






    }
    
}

    
    

