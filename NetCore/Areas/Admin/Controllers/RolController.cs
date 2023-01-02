using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NetCore.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class RolController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public RolController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult RolList()
        {
            var list = _roleManager.Roles.ToList();

            return View(list);
        }


        public async Task<IActionResult> RolSil(int id)
        {
            var silinen = _roleManager.Roles.Where(x => x.Id == id).FirstOrDefault();
            var result =await _roleManager.DeleteAsync(silinen);
            return RedirectToAction("RolList");
        }

        [HttpGet]
        public  IActionResult RolGuncelle(int id)
        {
            var guncellenen = _roleManager.Roles.Where(x => x.Id == id).FirstOrDefault();
            return View(guncellenen);
        }

        [HttpPost]
        public async Task<IActionResult> RolGuncelle(UpdateRoleModel p)
        {
            var guncellenen = _roleManager.Roles.Where(x => x.Id == p.RolId).FirstOrDefault();
            guncellenen.Id = p.RolId;
            guncellenen.Name = p.ModelAdi;

            var result = await _roleManager.UpdateAsync( guncellenen);
            return RedirectToAction("RolList");
        }
        [HttpGet]
        public IActionResult RolEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RolEkle(AddRoleModel p)
        {
            AppRole eklenen = new AppRole()
            {
                Name = p.RolAdi,
            };
            var result = await _roleManager.CreateAsync(eklenen);
            return RedirectToAction("RolList");
        }



        public IActionResult KullaniciRol()
        {
            var user = _userManager.Users.ToList();
            return View(user);
        }

        public async Task<IActionResult> RolDetay(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            var rol =await _userManager.GetRolesAsync(user);
            
            return View();
        }
    }

}
