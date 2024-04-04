using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.ViewModel
{
    public class PensionViewModel
    {
        public Pension userPet { get; set; }
        public List<Pension> userPets { get; set; }

    }
}