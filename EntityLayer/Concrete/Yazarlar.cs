using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Yazarlar
    {
        [Key]
        public int YazarId { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public string YazarMail { get; set; }
        public string YazarSifre { get; set; }
        public string YazarHakkinda { get; set; }
        public string YazarImgUrl { get; set; }
        public bool YazarStatu { get; set; }
        public List<Makale> Makales;
        public virtual ICollection<Mesaj> Alıcı { get; set; }
        public virtual ICollection<Mesaj> Gonderen { get; set; }
    }
}
