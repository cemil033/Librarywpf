using Library.Models.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.Models.Concrete
{
    public class Book : Entity
    {   
        public Book()
        {
            user = new List<User>(); 
        }
        public string Name { get; set; }
        public int Pages { get; set; }
        public string Comment { get; set; }
        public int Quantity { get; set; }
        public List<User>? user { get; set; }
    }
}
