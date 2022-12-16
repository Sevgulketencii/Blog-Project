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
    public class YazarlarManager : IYazarlarService
    {
        IYazarlarDal _yazar;
        public YazarlarManager(IYazarlarDal veri)
        {
            _yazar = veri;

        }
        public void ekle(Yazarlar eklenen)
        {
            _yazar.ekle(eklenen);
        }

        public void güncelle(Yazarlar güncellenen)
        {
            throw new NotImplementedException();
        }

        public Yazarlar IdGore(int id)
        {
            throw new NotImplementedException();
        }

        public List<Yazarlar> Listele()
        {
            throw new NotImplementedException();
        }

        public void sil(Yazarlar silinen)
        {
            throw new NotImplementedException();
        }
    }
}
