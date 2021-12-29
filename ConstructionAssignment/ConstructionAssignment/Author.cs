using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionAssignment
{
   public class Author
    {
       public string Name { get; set; }
        public int Id { get; set; }

       public Author(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
        // chain constructor
        public Author(string name) : this(name, 1)
        {

        }
        

    }
}
