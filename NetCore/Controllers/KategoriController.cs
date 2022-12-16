using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Controllers
{
    public class KategoriController : Controller
    {
        KategoriManager veri = new KategoriManager(new EfKategoriDal());
        public IActionResult Kategori()
        {
            var list = veri.Listele();
            return View(list);
        }
    }
}
