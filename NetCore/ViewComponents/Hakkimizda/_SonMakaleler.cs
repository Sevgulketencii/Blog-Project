using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.ViewComponents.Hakkimizda
{
    public class _SonMakaleler : ViewComponent
    {
        MakaleManager list = new MakaleManager(new EfMakaleDal());
        public IViewComponentResult Invoke()
        {
            var veri = list.SonMakaleler();
            return View(veri);
        }
    }
}
