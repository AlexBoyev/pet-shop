using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Shop
    {

        [Required(ErrorMessage = "Please enter Product ID")]
        [Key]
        [Display(Name = "Product ID")]
        public string ProID { get; set; }

        [Required(ErrorMessage = "Please enter product name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Supplier")]
        [Display(Name = "Supplier")]
        public string Supplier { get; set; }

        [Required(ErrorMessage = "Please enter price")]
        [Display(Name = "price")]
        public string Price { get; set; }

    }
}