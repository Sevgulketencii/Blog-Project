using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NetCore.Models;
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
        KullaniciManager list4 = new KullaniciManager(new EfKullaniciDal());

        UserManager<AppUser> _userManager;



        public YazarController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Yazar()
        {
           
            return View();
        }

        public async Task<IActionResult> MakaleList()
        {
            var user =await _userManager.FindByNameAsync(User.Identity.Name);
            var veri = list.YazarMakale(user.Id);
            return View(veri);
        }

        [HttpGet]
        public IActionResult MakaleEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MakaleEkle(Makale eklenen)
        {
            MakaleValidator mv = new MakaleValidator();
            ValidationResult result = mv.Validate(eklenen);
            if (result.IsValid)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                eklenen.MakaleStatu = true;
                eklenen.Id = user.Id;
                list.ekle(eklenen);
                return RedirectToAction("MakaleList");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            
            return View();
        }

        [HttpGet]
        public IActionResult MakaleSil(int id)
        {
            var sil=list.IdGore(id);
            list.sil(sil);
            return RedirectToAction("MakaleList", "Yazar");
        }

        [HttpGet]
        public IActionResult MakaleGüncelle(int id)
        {
            var veri = list.IdGore(id);
                return View(veri);
        }

        [HttpPost]
        public IActionResult MakaleGüncelle(Makale güncel)
        {
            var güncellenen = list.IdGore(güncel.MakaleId);

            güncellenen.MakaleAciklama = güncel.MakaleAciklama;
            güncellenen.MakaleBaslik = güncel.MakaleBaslik;
            güncellenen.MakaleImgUrl = güncel.MakaleImgUrl;
            güncellenen.KategoriId = güncel.KategoriId;
            
            list.güncelle(güncellenen);

            return RedirectToAction("MakaleList","Yazar");
        }

        public async Task<IActionResult> YazarBilgi()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var veri = list4.IdGore(user.Id);
            return View(veri);
        }

        [HttpPost]
        public async Task<IActionResult> YazarBilgi(UserUpdateModel p)
        {
            var user =await _userManager.FindByNameAsync(User.Identity.Name);
            user.adSoyad = p.adSoyad;
            user.Email = p.mail;
            user.ImgUrl = p.imgUrl;
            user.hakkinda = p.hakkinda;

            var result=await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("YazarBilgi", "Yazar");
            }

            return View(p);
        }


        public IActionResult Bildirimler()
        {
            var veri = list3.Listele();
            return View(veri);
        }


        
    }
}
