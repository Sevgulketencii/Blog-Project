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
    public class IdentityKayit : Controller
    {

        //public IdentityKayit(UserManager<AppUser> userManager)
        //{
        //    _userManager = userManager;
        //}

        //[HttpGet]
        //public IActionResult KayitOl()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> KayitOl(UserSignUp p)
        //{
        //    AppUser user = new AppUser()
        //    {
        //        Ad = p.ad,
        //        Soyad = p.soyad,
        //        Email = p.mail,

        //    };

        //    var result = await _userManager.CreateAsync(user, p.sifre);
        //    if (result.Succeeded)
        //    {
        //        return RedirectToAction("YazarLogin", "YazarLogin");
        //    }

        //    return View(p);
        //}
    }
}
