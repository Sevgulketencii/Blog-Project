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
        YazarlarManager list2 = new YazarlarManager(new EfYazarlarDal());
        BildirimManager list3 = new BildirimManager(new EfBildirimDal());
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
            eklenen.MakaleStatu = true;
            eklenen.YazarId = 1;
            
            list.ekle(eklenen);
            return RedirectToAction("MakaleList", "Yazar");
        }


        public IActionResult Sil(int id)
        {
            var sil=list.IdGore(id);
            list.sil(sil);
            return RedirectToAction("MakaleList", "Yazar");
        }

        
        public IActionResult Güncelle(int id)
        {
            var veri = list.IdGore(id);

            return View(veri);
        }

        [HttpPost]
        public IActionResult Güncelle(Makale güncel)
        {
            güncel.MakaleId = 7;
            güncel.MakaleAdi = güncel.MakaleBaslik;
            güncel.MakaleTarih =DateTime.Parse(DateTime.Now.ToShortDateString());
            güncel.YazarId = 1;
            list.güncelle(güncel);

            return RedirectToAction("MakaleList","Yazar");
        }

        public IActionResult YazarBilgi()
        {
            var veri = list2.IdGore(1);
            return View(veri);
        }

        [HttpPost]
        public IActionResult YazarBilgi(Yazarlar güncel)
        {
            güncel.YazarId = 1;
            güncel.YazarStatu = true;
            list2.güncelle(güncel);
            return RedirectToAction("YazarBilgi", "Yazar");
        }


        public IActionResult Bildirimler()
        {
            var veri = list3.Listele();
            return View(veri);
        }
    }
}
