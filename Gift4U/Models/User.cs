using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gift4U.Models
{
    public class User
    {

        public int Id { get; set; }
        [Required]
        public String UserName { get; set; }
        [Required]
        [StringLength(8)]
        public String Password { get; set; }
        [Required]
        public String FirstName { get; set; }
        [Required]
        public String LastName { get; set; }
        [Required]
        public int Type { get; set; }
        [Required]
        [StringLength(10)]
        public int Telephone { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
