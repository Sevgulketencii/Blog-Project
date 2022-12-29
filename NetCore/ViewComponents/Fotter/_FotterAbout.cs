using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.ViewComponents.Fotter
{
    public class _FotterAbout : ViewComponent
    {
        HakkimizdaManager list = new HakkimizdaManager(new EfHakkimizdaDal());
        public IViewComponentResult Invoke()
        {
            var veri = list.Listele().Select(y=>y.HakkimizdaAciklama).FirstOrDefault();
            return View();
        }
    }
}
