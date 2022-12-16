using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.ViewComponents.YazarMakale
{
    public class _YazarMakale: ViewComponent
    {
        MakaleManager list = new MakaleManager(new EfMakaleDal());
        public IViewComponentResult Invoke()
        {
            var veri = list.YazarMakale(ViewBag.id);

            return View(veri);
        }
    }
}
