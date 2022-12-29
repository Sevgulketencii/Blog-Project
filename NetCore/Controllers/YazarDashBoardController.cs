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
    public class YazarDashBoardController : Controller
    {
        MakaleManager list = new MakaleManager(new EfMakaleDal());
        KategoriManager list2 = new KategoriManager(new EfKategoriDal());
        

        UserManager<AppUser> _userManager;

        public YazarDashBoardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> DashBoard()
        {
            var user =await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.veri1 = list.MakaleCount();
            ViewBag.veri2 = list.YazarMakCount(user.Id);
            ViewBag.veri3 = list2.KategoriCount();
            return View();
        }
    }
}
