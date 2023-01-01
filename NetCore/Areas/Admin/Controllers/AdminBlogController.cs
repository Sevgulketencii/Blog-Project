using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBlogController : Controller
    {
        MakaleManager blog = new MakaleManager(new EfMakaleDal());

      

        public IActionResult Bloglar()
        {
            var list = blog.MakaleAdmin();
            return View(list);
        }

        public IActionResult StatuFalse(int id)
        {
            var guncellenen=blog.IdGore(id);
            guncellenen.MakaleStatu = false;
            blog.güncelle(guncellenen);

            return RedirectToAction("Bloglar");
        }

        public IActionResult StatuTrue(int id)
        {
            var guncellenen = blog.IdGore(id);
            guncellenen.MakaleStatu = true;
            blog.güncelle(guncellenen);

            return RedirectToAction("Bloglar");
        }

    }
}
