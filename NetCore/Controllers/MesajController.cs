using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Controllers
{
    public class MesajController : Controller
    {
        MesajManager list = new MesajManager(new EfMesajDal());
        UserManager<AppUser> _userManager;
        
        public MesajController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Mesajlar()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var veri = list.YazarMesaj(user.Id);
            return View(veri);
        }

        [HttpGet]
        public IActionResult MesajGonder()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MesajGonder(MesajGön p)
        {
            var alici = await _userManager.FindByNameAsync(p.aliciAdi);
            var gönderen = await _userManager.FindByNameAsync(User.Identity.Name);
            if (alici != null)
            {
                Mesaj mesaj = new Mesaj()
                {
                    MesajAlici = alici.Id,
                    MesajGönderen = gönderen.Id,
                    MesajAciklama = p.mesajAciklama,
                    MesajTarih = p.mesajTarih,
                };

                list.ekle(mesaj);
                return RedirectToAction("Mesajlar");
            }
            ViewBag.hata = 1;
            return View(p);
        }

        public IActionResult MesajDetay(int id)
        {
            var veri = list.MesajDetay(id);
            veri.MesajStatu = true; // Bildirimlere gelen mesaj adeti statü'ye göre çağırılması için ayrı bir metod oluşturulacak
            list.güncelle(veri);
            return View(veri);
        }
    }
}
