using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Gift4U.Models
{
    public class StoreSale
    {
        [Key]
        public int Id { get; set; }
        

        public int StoreID { get; set; }

        public Stores Store { get; set; }

        
        public int SaleId { get; set; }

        public Sale Sale { get; set; }
    }
}
