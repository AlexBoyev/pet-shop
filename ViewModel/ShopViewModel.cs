﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.ViewModel
{
    public class ShopViewModel
    {
     
            public Shop Product { get; set; }
            public List<Shop> Products { get; set; }
        
    }
}