using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Mesaj
    {
        [Key]
        public int MesajId { get; set; }
        public string MesajAlici { get; set; }
        public string MesajGönderen { get; set; }
        public string MesajAciklama { get; set; }
        public DateTime MesajTarih { get; set; }
        public bool MesajStatu { get; set; }
    }
}
