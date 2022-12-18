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
    public class IletisimManager : IIletisimService
    {
        IIletisimDal _iletisim;
        public IletisimManager(IIletisimDal veri)
        {
            _iletisim = veri;
        }
        public void ekle(Iletisim eklenen)
        {
            _iletisim.ekle(eklenen);
        }

        public void güncelle(Iletisim güncellenen)
        {
            throw new NotImplementedException();
        }

        public Iletisim IdGore(int id)
        {
            throw new NotImplementedException();
        }

        public List<Iletisim> Listele()
        {
            throw new NotImplementedException();
        }

        public void sil(Iletisim silinen)
        {
            throw new NotImplementedException();
        }
    }
}
