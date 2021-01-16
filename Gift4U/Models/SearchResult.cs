using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gift4U.Models
{
    public class SearchResult
    {
        public List<Stores> Stores { get; set; }
        public List<Category> Categories { get; set; }

        public SearchResult()
        {
            Stores = new List<Stores>();
            Categories = new List<Category>();
        }
    }
}
