using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BlogYayın : Controller
    {
        MakaleManager veri = new MakaleManager(new EfMakaleDal());
        
        public IActionResult Talepler()
        {
            var list = veri.AdminOnay();
            return View(list);
        }

        public IActionResult OnayTrue(int id)
        {
            
            var makale = veri.IdGore(id);
            makale.AdminOnay = true;
            veri.güncelle(makale);
            return RedirectToAction("Talepler");
        }

        public IActionResult OnayFalse(int id)
        {

            var makale = veri.IdGore(id);
            veri.sil(makale);
            return RedirectToAction("Talepler");
        }


    }
}
