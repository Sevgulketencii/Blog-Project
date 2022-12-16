using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.ViewComponents.Yorum
{
    public class _YorumListe : ViewComponent
    {
        YorumManager list = new YorumManager(new EfYorumDal());
       
        public IViewComponentResult Invoke()
        {
            var veri = list.BlogYorum(ViewBag.id);
            return View(veri);
        }
    }
}
