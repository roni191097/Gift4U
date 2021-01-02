using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Gift4U.Models
{
    public class Stores
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must input a Store name")]
        [StringLength(30, ErrorMessage = "You cannot have a name longer than 30 characters")]
        public String Name { get; set; }

        public Category Category { get; set; }

        //add desc
        [StringLength(2000, ErrorMessage = "You cannot have a name longer than 2000 characters")]
        public String Description { get; set; }
        
        public string ImageUrl { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<StoreSale> Sales { get; set; }

    }
}
