using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Controllers
{
    public class HakkindaController : Controller
    {
        HakkimizdaManager list = new HakkimizdaManager(new EfHakkimizdaDal());
       
        public IActionResult Hakkinda()
        {
            var veri = list.Listele();
            return View(veri);
        }
    }
}
