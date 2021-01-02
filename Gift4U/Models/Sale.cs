using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gift4U.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "You must input a Sale name")]
        [StringLength(30, ErrorMessage = "You cannot have a name longer than 30 characters")]
        public string Name { get; set; }

        [Range(0, 100)]
        public int Percentage { get; set; }

        public List<StoreSale> StoreSales { get; set; }

    }
}
