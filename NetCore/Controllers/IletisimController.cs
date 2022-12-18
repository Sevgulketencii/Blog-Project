using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Controllers
{
    public class IletisimController : Controller
    {
        IletisimManager veri = new IletisimManager(new EfIletisimDal());
        public IActionResult Iletisim()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Iletisim(Iletisim yeni)
        {
            veri.ekle(yeni);
            return RedirectToAction("Iletisim", "Iletisim");
        }
    }
}
