using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.ViewModel
{
    public class UserViewModel
    {
        public User Auser { get; set; }
        public List<User> Ausers{ get; set; }
    }
}