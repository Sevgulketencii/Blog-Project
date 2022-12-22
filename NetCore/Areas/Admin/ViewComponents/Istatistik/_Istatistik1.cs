using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Areas.Admin.ViewComponents.Istatistik1
{
    public class _Istatistik1 : ViewComponent
    {
        Context baglan = new Context();
        public IViewComponentResult Invoke()
        {

            ViewBag.blgSayi = baglan.MakaleDb.Count();
            ViewBag.glnMsj = baglan.IletisimDb.Count();
            ViewBag.glnYrm = baglan.YorumDb.Count();
            
            return View();
        }
    }
}
