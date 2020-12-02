using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Gift4U.Models
{
    public class SubCategory
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must input a SubCategory name")]
        [StringLength(30, ErrorMessage = "You cannot have a name longer than 30 characters")]

        public String Name { get; set; }

        public int IdCategory { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<Order> Orderes { get; set; }

        public ICollection<SubCategorySale> Sales { get; set; }

    }
}
