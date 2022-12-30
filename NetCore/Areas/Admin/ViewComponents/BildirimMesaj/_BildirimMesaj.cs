using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Areas.Admin.ViewComponents.BildirimMesaj
{
    public class _BildirimMesaj: ViewComponent
    {
        MakaleManager list = new MakaleManager(new EfMakaleDal());
        public IViewComponentResult Invoke()
        {
            
            TempData["TalepCount"] = list.AdminOnay().Count();
            ViewBag.New = 0;
            if (list.AdminOnay().Count() != 0)
            {
                ViewBag.New = 1;
            }
            return View();
        }
    }
}
