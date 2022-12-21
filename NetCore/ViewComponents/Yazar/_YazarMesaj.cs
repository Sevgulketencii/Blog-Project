
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.ViewComponents.Yazar
{
    public class _YazarMesaj : ViewComponent
    {
        MesajManager veri = new MesajManager(new EfMesajDal());
        
        public IViewComponentResult Invoke()
        {
            var list = veri.YazarMesaj(1);
           
            return View(list);
        }
    }
}
