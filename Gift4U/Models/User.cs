using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gift4U.Models
{
    public class User
    {
        
        public int Id { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Type { get; set; }
        public int Telephone { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
