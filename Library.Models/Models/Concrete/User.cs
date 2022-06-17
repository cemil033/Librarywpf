using Library.Models.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.Models.Concrete
{
    public class User:Entity
    {       
        public User()
        {
            books = new List<Book>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Book>? books { get; set; }
    }
}
