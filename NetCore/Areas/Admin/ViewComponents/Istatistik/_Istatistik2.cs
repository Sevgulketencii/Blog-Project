using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Areas.Admin.ViewComponents.Istatistik
{
    public class _Istatistik2 : ViewComponent
    {
        Context baglan = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.sonBlog = baglan.MakaleDb.OrderByDescending(x => x.MakaleId).Select(x => x.MakaleAdi).Take(1).FirstOrDefault(); 
            return View();
        }
    }
}
