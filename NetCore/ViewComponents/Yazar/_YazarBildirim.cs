using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.ViewComponents.Yazar
{
    public class _YazarBildirim : ViewComponent
    {
        BildirimManager list = new BildirimManager(new EfBildirimDal());
       
        public IViewComponentResult Invoke()
        {
            var veri = list.Listele();
            return View(veri);
        }
    }
}
