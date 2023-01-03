using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NetCore.Controllers
{
    [AllowAnonymous]
    public class YazarLoginController : Controller
    {
        
        SignInManager<AppUser> _signInManager;

        public YazarLoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult YazarLogin()
        {
           
            return View();
        }
      
        [HttpPost]
        public async Task<IActionResult> YazarLogin(UserSignIn p)
        {

            var result = await _signInManager.PasswordSignInAsync(p.kullaniciAdi, p.sifre, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("MakaleList", "Yazar");

            }
            ViewBag.hata = 1;
            
            return View(p);
        }


        public IActionResult YazarLogOut()
        {

            var result = _signInManager.SignOutAsync();
            if (result.IsCompletedSuccessfully)
            {
                return RedirectToAction("Blog","Blog");
            }
            return View();
        }
        //var giris = baglan.YazarlarDb.FirstOrDefault(x => x.YazarMail == yazar.YazarMail && x.YazarSifre == yazar.YazarSifre);
            //if (giris != null)
            //{
            //    HttpContext.Session.SetString("username", yazar.YazarMail);
            //    return RedirectToAction("Blog", "Blog");
            //}
            //return View();


        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
