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
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var blog = new Student { Name = name };
                db.students.Add(blog);
                db.SaveChanges();

                // Display all Blogs from the database
                var query = from b in db.students
                            orderby b.Name
                            select b;

                Console.WriteLine("All blogs in the database:");
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

    
    

