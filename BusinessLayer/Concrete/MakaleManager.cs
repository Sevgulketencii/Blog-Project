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
    
    public class MakaleManager : IMakaleService
    {
        IMakaleDal _makale;

        public MakaleManager(IMakaleDal veri)
        {
            _makale = veri;
        }
        public void ekle(Makale eklenen)
        {
            _makale.ekle(eklenen);
        }

        public void güncelle(Makale güncellenen)
        {
            _makale.güncelle(güncellenen);
        }

        public Makale IdGore(int id)
        {
            return _makale.IdyeGore(id);
        }

        public List<Makale> Listele()
        {
            return _makale.Listele();
        }

        public int MakaleCount()
        {
            return _makale.MakaleCount();
        }

        public List<Makale> MakaleListele()
        {
            return _makale.MakaleListele();
        }

        public void sil(Makale silinen)
        {
             _makale.sil(silinen);
        }

        public List<Makale> SonMakaleler()
        {
            return _makale.SonMakaleler();
        }

        

        public List<Makale> YazarMakale(int id)
        {
            return _makale.YazarMakale(x => x.Id == id);
        }

        public int YazarMakCount(int id)
        {
            return _makale.YazarSayi(x => x.Id == id);
        }
    }
}
