using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hakkimizda
    {
        [Key]
        public int HakkimizdaId { get; set; }
        public string HakkimizdaBaslik { get; set; }
        public string HakkimizdaAciklama { get; set; }
        public string HakkimizdaImgUrl1 { get; set; }
        public string HakkimizdaImgUrl2 { get; set; }
        public string HakkimizdaStatus { get; set; }
        public string HakkimizdaMap{ get; set; }
    }
}
