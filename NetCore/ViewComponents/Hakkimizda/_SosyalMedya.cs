using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Views.Shared.Components.Hakkimizda
{
    public class _SosyalMedya : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
