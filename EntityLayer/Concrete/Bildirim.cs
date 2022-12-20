using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Bildirim
    {
        [Key]
        public int BildirimId { get; set; }
        public string BildirimTürü { get; set; }
        public string BildirimImg { get; set; }
        public string BildirimAciklama { get; set; }
        public DateTime BildirimTarih{ get; set; }
        public bool BildirimStatu{ get; set; }
    }
}
