using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Controllers
{
    public class MailController : Controller
    {
        MailBülteniManager veri = new MailBülteniManager(new EfMailBülteniDal());
        
        [HttpPost]
        public IActionResult Mail(MailBülteni gelen)
        {
            veri.ekle(gelen);
            return RedirectToAction("Blog", "Blog");
        }
    }
}
