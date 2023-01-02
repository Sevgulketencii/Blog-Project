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
    public class MesajManager : IMesajService
    {
        IMesajDal _mesaj;
        public MesajManager(IMesajDal veri)
        {
            _mesaj = veri;
        }
        public void ekle(Mesaj eklenen)
        {
            _mesaj.ekle(eklenen);
        }

        public void güncelle(Mesaj güncellenen)
        {
            throw new NotImplementedException();
        }

        public Mesaj IdGore(int id)
        {
            return _mesaj.IdyeGore(id);
        }

        public List<Mesaj> Listele()
        {
            throw new NotImplementedException();
        }

        public void sil(Mesaj silinen)
        {
            throw new NotImplementedException();
        }

        public List<Mesaj> YazarGidenMesaj(int id)
        {
            return _mesaj.GidenMesaj(x => x.Gönderen.Id == id);
        }

        public List<Mesaj> YazarMesaj(int alici)
        {
            return _mesaj.YazarMesaj(x => x.MesajAlici == alici);
        }

    }
}
