using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.ViewComponents.Yazar
{
    public class _YazarNavbar : ViewComponent
    {
        YazarlarManager list = new YazarlarManager(new EfYazarlarDal());
        public IViewComponentResult Invoke()
        {
            var user = User.Identity.Name;
            var userid = list.Yazar(user);
            ViewBag.kullaniciId = userid.YazarAdi;
            ViewBag.kullaniciId2 = userid.YazarAdi;
            return View();

        }
    }
}
