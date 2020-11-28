using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Gift4U.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int IdCategory { get; set; }
        public ICollection<Order> Orderes { get; set; }
      
    }
}
