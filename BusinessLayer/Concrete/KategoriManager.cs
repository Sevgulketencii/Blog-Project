using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class KategoriManager : IKategoriService
    {
        IKategoriDal _kategori;

        public KategoriManager(IKategoriDal veri)
        {
            _kategori = veri;
        }
        public void ekle(Kategori eklenen)
        {
            _kategori.ekle(eklenen);
        }

        public void güncelle(Kategori güncellenen)
        {
            _kategori.güncelle(güncellenen);
        }

        public Kategori IdGore(int id)
        {
            return _kategori.IdyeGore(id);
        }

        public int KategoriCount()
        {
            return _kategori.KategoriCount();
        }

        public List<Kategori> Listele()
        {
            return _kategori.Listele();
        }

        public void sil(Kategori silinen)
        {
            _kategori.sil(silinen);
        }
    }
}
