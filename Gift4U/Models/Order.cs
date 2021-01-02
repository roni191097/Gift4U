using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gift4U.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public User User { get; set; }

        public Stores store { get; set; }

        [Range(0, 50000)]
        public double Total { get; set; }

        [Required]
        public String GiftTo { get; set; }

        [DataType(DataType.Text)]
        public String Bless { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ToDate { get; set; }

    }
}
