using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.ViewComponents.Mail
{
    public class _MailBülteni:ViewComponent
    {
        MailBülteniManager veri = new MailBülteniManager(new EfMailBülteniDal());
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
