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
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "חובה להזין שם לחנות")]
        [StringLength(30, ErrorMessage = "ארוך מידי, עד 30 תווים בבקשה")]
        public String Name { get; set; }

        public Category Category { get; set; }

        //add desc
        [StringLength(2000, ErrorMessage = "עד 2000 תווים בבקשה")]
        public String Description { get; set; }
        
        public string ImageUrl { get; set; }

        public ICollection<Order> Orders { get; set; }

        public List<StoreSale> StoreSales { get; set; }

    }
}
