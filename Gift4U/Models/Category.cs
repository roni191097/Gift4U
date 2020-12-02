using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gift4U.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }
        public int Type { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }

    }
}
