using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gift4U.Models
{
    public class SubCategorySale
    {
        public int SubCategoryID { get; set; }

        public SubCategory subCategory { get; set; }

        public int SaleId { get; set; }

        public Sale Sale { get; set; }
    }
}
