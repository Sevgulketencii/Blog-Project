using EntityLayer.Concrete;
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
    [AllowAnonymous]
    public class YazarSıgnUp : Controller
    {
        UserManager<AppUser> _userManager;

        public YazarSıgnUp(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult SıgnUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SıgnUp(UserSignUp yeniKullanici)
        {
            AppUser user = new AppUser()
            {
                adSoyad=yeniKullanici.adSoyad,
                Email=yeniKullanici.mail,
                ImgUrl=yeniKullanici.imgUrl,
                UserName=yeniKullanici.kullaniciAd,
            };
            var result = await _userManager.CreateAsync(user, yeniKullanici.sifre);
            if (result.Succeeded)
            {
                return RedirectToAction("YazarLogin", "YazarLogin");

            }
            return View();
        }

    }
}
