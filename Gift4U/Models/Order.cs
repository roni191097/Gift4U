using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gift4U.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdSubCategory { get; set; }
        [Range(0, 50000)]
        public double Total { get; set; }
        [Required]
        public String GiftTo { get; set; }
        public String Bless { get; set; }
        public DateTime Date { get; set; }
        public DateTime ToDate { get; set; }

    }
}
