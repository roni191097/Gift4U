using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gift4U.Models
{
    public class Contact
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "חובה להזין שם פרטי")]
        [DataType(DataType.Text)]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "חובה להזין שם משפחה")]
        [DataType(DataType.Text)]
        public String LastName { get; set; }

        [Required(ErrorMessage = "חובה להזין מספר טלפון")]
        //[StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        public int Telephone { get; set; }

        [Required(ErrorMessage = "חובה להזין מייל ")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }


    }
}




