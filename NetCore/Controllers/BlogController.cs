using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Controllers
{
    
    [AllowAnonymous]
    public class BlogController : Controller
    {
        MakaleManager veri = new MakaleManager(new EfMakaleDal());

        public IActionResult Blog()
        {
            var list = veri.MakaleListele();
            return View(list);
        }

        public IActionResult BlogDetay(int id)
        {
            ViewBag.id = id;
            
            var list = veri.IdGore(id);
            ViewBag.yid = list.Id;
            return View(list);
        }
    }
}
