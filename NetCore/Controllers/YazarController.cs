using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Controllers
{
    public class YazarController : Controller
    {
        public IActionResult Yazar()
        {
            return View();
        }
    }
}
