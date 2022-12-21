using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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

        public IActionResult Mesajlar()
        {
            var veri = list.YazarMesaj(1);
            return View(veri);
        }


        public IActionResult MesajDetay(int id)
        {
            var veri = list.IdGore(id);
            return View(veri);
        }
    }
}
