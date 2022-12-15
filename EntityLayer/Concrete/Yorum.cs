using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Yorum
    {
        [Key]
        public int YorumId { get; set; }
        public string YorumAdi { get; set; }
        public string YorumBaslik { get; set; }
        public string YorumAciklama { get; set; }
        public string YorumStatu{ get; set; }
        public DateTime YorumTarih{ get; set; }
        public int MakaleId { get; set; }
        public Makale Makale { get; set; }
    }
}
