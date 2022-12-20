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
            throw new NotImplementedException();
        }

        public void güncelle(Mesaj güncellenen)
        {
            throw new NotImplementedException();
        }

        public Mesaj IdGore(int id)
        {
            throw new NotImplementedException();
        }

        public List<Mesaj> Listele()
        {
            throw new NotImplementedException();
        }

        public void sil(Mesaj silinen)
        {
            throw new NotImplementedException();
        }

        public List<Mesaj> YazarMesaj(string mail)
        {
            return _mesaj.YazarMesaj(x => x.MesajAlici == mail);
        }
    }
}
