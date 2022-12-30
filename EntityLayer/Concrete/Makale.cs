using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Makale
    {
        [Key]
        public int MakaleId { get; set; }
        public string MakaleAdi{ get; set; }
        public string MakaleBaslik{ get; set; }
        public string MakaleAciklama{ get; set; }
        public string MakaleImgUrl{ get; set; }
        public DateTime MakaleTarih{ get; set; }
        public bool MakaleStatu{ get; set; }
        public bool AdminOnay{ get; set; }
       
        public List<Yorum> Yorums { get; set; }
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
        public int Id { get; set; }
        public AppUser Yazar  { get; set; }
    }
}
