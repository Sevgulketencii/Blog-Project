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
    public class YorumController : Controller
    {

        YorumManager list = new YorumManager(new EfYorumDal());
        
        [HttpPost]
        public IActionResult Yorumlar(Yorum yorum)
        {
            list.ekle(yorum);
            return RedirectToAction("Blog","Blog");
        }
    }
}
