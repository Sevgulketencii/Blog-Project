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

namespace NetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminMesaj : Controller
    {
        UserManager<AppUser> _userManager;
        MesajManager mesajlar = new MesajManager(new EfMesajDal());
        public AdminMesaj(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> GelenMesaj()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var gelenMesaj = mesajlar.YazarMesaj(user.Id);
           
            return View(gelenMesaj);
        }


        public async Task<IActionResult> GidenMesaj()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var gidenMesaj = mesajlar.YazarGidenMesaj(user.Id);
            return View(gidenMesaj);
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
            var gonderen = await _userManager.FindByNameAsync(User.Identity.Name);
            if (alici != null)
            {
                Mesaj yeni = new Mesaj()
                {
                    MesajAlici = alici.Id,
                    MesajGönderen = gonderen.Id,
                    MesajAciklama = p.mesajAciklama,
                    MesajTarih = DateTime.Now,
                    MesajStatu = true
                };
                mesajlar.ekle(yeni);
                return RedirectToAction("GidenMesaj");
            }
            ViewBag.hata = 1;
            return View(p);
            
        }
    }
}
