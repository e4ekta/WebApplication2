﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public House[] MyHouses;
    }
}