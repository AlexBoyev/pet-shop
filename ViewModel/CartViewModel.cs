using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.ViewModel
{
    public class CartViewModel
    {
        public UserCart CProduct { get; set; }
        public List<UserCart> CProducts { get; set; }
    }
}