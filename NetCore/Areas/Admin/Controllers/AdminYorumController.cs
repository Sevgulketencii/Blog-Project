using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminYorumController : Controller
    {
        YorumManager yorum = new YorumManager(new EfYorumDal());
        public IActionResult YorumList()
        {
            var list = yorum.AdminYorum();
            return View(list);
        }

        public IActionResult StatuTrue(int id)
        {
            var p = yorum.IdGore(id);
            p.YorumStatu = true;
            yorum.güncelle(p);
            return RedirectToAction("YorumList");
        }

        public IActionResult StatuFalse(int id)
        {
            var p = yorum.IdGore(id);
            p.YorumStatu = false;
            yorum.güncelle(p);
            return RedirectToAction("YorumList");
        }
    }
}
