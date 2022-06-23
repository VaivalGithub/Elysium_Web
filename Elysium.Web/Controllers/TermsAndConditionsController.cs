using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elysium.Web.Controllers
{
    public class TermsAndConditionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
