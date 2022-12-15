using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public string KategoriAciklama { get; set; }
        public bool KategoriStatu { get; set; }
    }
}
