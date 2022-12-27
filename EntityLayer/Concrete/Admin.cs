using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string AdminKullaniciAdi{ get; set; }
        public string AdminSifre{ get; set; }
        public string Ad{ get; set; }
        public string Soyad{ get; set; }
        public string ImgUrl{ get; set; }
        public string Hakkinda{ get; set; }
        public string Rol{ get; set; }
    }
}
