using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Areas.Admin.ViewComponents.BildirimMesaj
{
    public class _BildirimMesaj: ViewComponent
    {
        MakaleManager list = new MakaleManager(new EfMakaleDal());
        MesajManager list2 = new MesajManager(new EfMesajDal());
        UserManager<AppUser> _userManager;

        public _BildirimMesaj(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user =await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.msjCount = list2.YazarMesaj(user.Id).Count();
            TempData["TalepCount"] = list.AdminOnay().Count();
            ViewBag.New = 0;
            if (list.AdminOnay().Count() != 0)
            {
                ViewBag.New = 1;
            }
            return View();
        }
    }
}
