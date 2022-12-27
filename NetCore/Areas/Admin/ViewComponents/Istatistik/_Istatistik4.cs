using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Areas.Admin.ViewComponents.Istatistik
{
    public class _Istatistik4 : ViewComponent
    {
        Context baglan = new Context();
        public IViewComponentResult Invoke()
        {
            //ViewBag.adminAdi = baglan.AdminDb.Where(x => x.AdminId == 1).Select(y => y.Ad).FirstOrDefault();
            //ViewBag.adminSoyad= baglan.AdminDb.Where(x => x.AdminId == 1).Select(y => y.Soyad).FirstOrDefault();
            //ViewBag.adminHk = baglan.AdminDb.Where(x => x.AdminId == 1).Select(y => y.Hakkinda).FirstOrDefault();
            //ViewBag.adminImg = baglan.AdminDb.Where(x => x.AdminId == 1).Select(y => y.ImgUrl).FirstOrDefault();
            return View();
        }
    }
}
