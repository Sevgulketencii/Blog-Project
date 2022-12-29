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
    public class _YazarHakkinda : ViewComponent
    {
        YazarlarManager list = new YazarlarManager(new EfYazarlarDal());
        UserManager<AppUser> _usermanager;

        public _YazarHakkinda(UserManager<AppUser> usermanager)
        {
            _usermanager = usermanager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _usermanager.FindByNameAsync(User.Identity.Name);         
            return View(user);
        }
    }
}
