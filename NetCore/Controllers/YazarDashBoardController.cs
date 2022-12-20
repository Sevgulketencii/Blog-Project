using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Controllers
{
    public class YazarDashBoardController : Controller
    {
        MakaleManager list = new MakaleManager(new EfMakaleDal());
        KategoriManager list2 = new KategoriManager(new EfKategoriDal());
     
        public IActionResult DashBoard()
        {
            ViewBag.veri1 = list.MakaleCount();
            ViewBag.veri2 = list.YazarMakCount(1);
            ViewBag.veri3 = list2.KategoriCount();
            return View();
        }
    }
}
