using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UserCart
    {

        [Required(ErrorMessage = "Please enter Product ID")]
        [Display(Name = "Product ID")]
        public string ProID { get; set; }

        [Required(ErrorMessage = "Please enter RowIndex")]
        [Key]
        [Display(Name = "RowIndex")]
        public int RowIndex { get; set; }

        [Required(ErrorMessage = "Please enter product name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "UserLogin")]
        public string UserLogin { get; set; }

        [Required(ErrorMessage = "Please enter Quantity")]
        [Display(Name = "Quantity")]
        public string Quantity { get; set; }

        [Required(ErrorMessage = "Please enter price")]
        [Display(Name = "Price")]
        public string Price { get; set; }

    }
}