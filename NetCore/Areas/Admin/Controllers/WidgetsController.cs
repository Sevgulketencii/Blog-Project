using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WidgetsController : Controller
    {
        public IActionResult Widgets()
        {
            return View();
        }
    }
}
