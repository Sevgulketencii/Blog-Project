﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.ViewComponents.Yazar
{
    public class _YazarBildirim : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}