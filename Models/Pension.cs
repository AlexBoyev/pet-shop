using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Pension
    {
        [Required(ErrorMessage = "Please enter your pet name")]
        [Display(Name = "Pet name")]
        public string PetName { get; set; }

        [Required(ErrorMessage = "Please enter pet ID.")]
        [Key]
        [Display(Name = "pet ID")]
        public string PetID { get; set; }

        [Required(ErrorMessage = "Please enter your duration in days.")]
        [Display(Name = "Days")]
        public string Days { get; set; }

        [Display(Name = "Price")]
        public string Price { get; set; }

        [Display(Name = "UserLogin")]
        public string UserLogin { get; set; }

    }
}