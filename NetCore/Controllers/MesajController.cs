using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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


        public IActionResult MesajDetay(int id)
        {
            var veri = list.IdGore(id);
            return View(veri);
        }
    }
}
