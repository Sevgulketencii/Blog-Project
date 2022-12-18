using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Controllers
{
    [AllowAnonymous]
    public class YazarKayitController : Controller
    {
        YazarlarManager veri = new YazarlarManager(new EfYazarlarDal());
        public IActionResult YazarKayitOl()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YazarKayitOl(Yazarlar yazar)
        {
            yazar.YazarStatu = true;
            yazar.YazarHakkinda = "Boş";
            veri.ekle(yazar);
            return RedirectToAction();
        }
    }
}
