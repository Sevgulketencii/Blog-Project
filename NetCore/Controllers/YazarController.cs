using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Controllers
{


    public class YazarController : Controller
    {
        MakaleManager list = new MakaleManager(new EfMakaleDal());
        public IActionResult Yazar()
        {
            return View();
        }

        public IActionResult MakaleList()
        {
            //ViewBag.kullanici; loginde alınıyor
            var veri = list.YazarMakale(1);
            return View(veri);
        }

        [HttpGet]
        public IActionResult MakaleEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MakaleEkle(Makale eklenen)
        {
            list.ekle(eklenen);
            return RedirectToAction("MakaleList", "Yazar");
        }
    }
}
