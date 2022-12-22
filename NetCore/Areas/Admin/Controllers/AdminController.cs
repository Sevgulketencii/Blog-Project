using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        KategoriManager kategoriList = new KategoriManager(new EfKategoriDal());
        
        public IActionResult Kategori()
        {
            var veri = kategoriList.Listele();
            return View(veri);
        }

        [HttpGet]
        public IActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KategoriEkle(Kategori eklenen)
        {
            eklenen.KategoriStatu = true;
            kategoriList.ekle(eklenen);
            return RedirectToAction("Kategori");
        }

        public IActionResult Pasif(int id)
        {
            var pasif=kategoriList.IdGore(id);
            pasif.KategoriStatu = false;
            kategoriList.güncelle(pasif);
            return RedirectToAction("Kategori");
        }

        public IActionResult Aktif(int id)
        {
            var aktif = kategoriList.IdGore(id);
            aktif.KategoriStatu = true;
            kategoriList.güncelle(aktif);
            return RedirectToAction("Kategori");
        }
    }
}
