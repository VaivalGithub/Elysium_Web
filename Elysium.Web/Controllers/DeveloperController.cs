﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elysium.Web.Controllers
{
    public class DeveloperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
