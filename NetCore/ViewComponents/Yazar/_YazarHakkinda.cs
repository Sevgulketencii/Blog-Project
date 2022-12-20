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
            var veri = list.IdGore(1);
            return View(veri);
        }
    }
}
