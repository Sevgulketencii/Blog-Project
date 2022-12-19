using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        Context baglan = new Context();
        
        public IActionResult YazarLogin()
        {
            return View();
        }
      
        [HttpPost]
        public async Task<IActionResult> YazarLogin(Yazarlar yazar)
        {
            var giris = baglan.YazarlarDb.FirstOrDefault(x => x.YazarMail == yazar.YazarMail && x.YazarSifre == yazar.YazarSifre);
            if (giris != null)
            {
                ViewBag.kullanici = giris.YazarId;
                var claims = new List<Claim>
                {
                   new Claim(ClaimTypes.Name,yazar.YazarMail)
                };
                var useridenty = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal princal = new ClaimsPrincipal(useridenty);
                await HttpContext.SignInAsync(princal);
                return RedirectToAction("Yazar", "Yazar");
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
    }
}
