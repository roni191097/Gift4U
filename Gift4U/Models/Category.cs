using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gift4U.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "חובה להזין שם קטגוריה")]
        [StringLength(30, ErrorMessage = "ארוך מידי, עד 30 תווים בבקשה")]
        public String Name { get; set; }

        [Required]
        public String ImageUrl { get; set; }

        public ICollection<Stores> Stores { get; set; }
       
        /*kkkk*/
    }
}
