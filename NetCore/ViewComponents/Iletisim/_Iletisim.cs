using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.ViewComponents.Iletisim
{
    public class _Iletisim : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
