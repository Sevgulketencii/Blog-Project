
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.ViewComponents.Yazar
{
    public class _YazarMesaj : ViewComponent
    {
        MesajManager veri = new MesajManager(new EfMesajDal());
        UserManager<AppUser> _user;

        public _YazarMesaj(UserManager<AppUser> user)
        {
            _user = user;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _user.FindByNameAsync(User.Identity.Name);
            var list = veri.YazarMesaj(user.Id);
            if (list == null)
            {
                ViewBag.count = 0;
            }
            ViewBag.count = list.Count();
            return View(list);
        }
    }
}
