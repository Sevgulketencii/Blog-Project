using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.ViewComponents.Yazar
{
    public class _YazarHakkinda : ViewComponent
    {
        YazarlarManager list = new YazarlarManager(new EfYazarlarDal());
        public IViewComponentResult Invoke()
        {
            var user = User.Identity.Name;
            var kullanici = list.Yazar(user);
            var veri = list.IdGore(kullanici.YazarId);
            return View(veri);
        }
    }
}
