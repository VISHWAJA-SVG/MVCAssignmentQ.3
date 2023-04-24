using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Q._3CMS.Ass.Models
{
    public class Customer
    {
        [Key]
        [Required(ErrorMessage = "CustomerId required")]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "City required")]
        public string City { get; set; }
        public int Age { get; set; }
        
        [Required(ErrorMessage = "Telephone required")]
        [Phone]
        public string Phone { get; set; }
        public int Pincode { get; set; }
    }
}