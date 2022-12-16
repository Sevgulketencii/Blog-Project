using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Controllers
{
    public class YazarLoginController : Controller
    {
        public IActionResult YazarLogin()
        {
            return View();
        }
    }
}
