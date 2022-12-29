using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        public string adSoyad { get; set; }
        public string hakkinda { get; set; }
        public string ImgUrl { get; set; }
        public string yazarStatu { get; set; }
        public virtual ICollection<Makale> Makales { get; set; }
        public virtual ICollection<Mesaj> Alıcı { get; set; }
        public virtual ICollection<Mesaj> Gonderen { get; set; }
    
    
    }






}
