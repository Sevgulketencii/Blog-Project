using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class MesajGön
    {
        public string aliciAdi { get; set; }
        public int gönderenId { get; set; }
        public string mesajAciklama { get; set; }
        public DateTime mesajTarih { get; set; }
    }
}
