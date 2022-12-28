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
    public class IdentitySignUpController : Controller
    {
    //    private readonly UserManager<AppUser> _userManager;

    //    public IdentitySignUpController(UserManager<AppUser> userManager)
    //    {
    //        _userManager = userManager;
    //    }

    //    [HttpGet]
    //    public IActionResult SıgnUp()
    //    {
    //        return View();
    //    }

    //    [HttpPost]
    //    public async Task<IActionResult> SıgnUp(UserSignUp p)
    //    {
    //        AppUser user = new AppUser()
    //        {
    //            AdSoyad = p.AdSoyad,
    //            UserName = p.KullaniciAdi,
    //            Email = p.Email,

    //        };

    //        var result = await _userManager.CreateAsync(user, p.Sifre);
    //        if (result.Succeeded)
    //        {
    //            return RedirectToAction("YazarLogin", "YazarLogin");
    //        }

    //        return View(p);
    //    }
   }
}
