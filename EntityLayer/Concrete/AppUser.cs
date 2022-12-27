using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Memleket { get; set; }
        public string ImgUrl { get; set; }
    }
}
