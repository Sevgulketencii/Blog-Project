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
    public class YorumManager : IYorumService
    {
        IYorumDal _yorum;
        public YorumManager(IYorumDal veri)
        {
            _yorum = veri;
        }

        public List<Yorum> BlogYorum(int id)
        {
            return _yorum.BlogYorum(x => x.MakaleId == id).ToList();
        }

        public void ekle(Yorum eklenen)
        {
            _yorum.ekle(eklenen);
        }

        public void güncelle(Yorum güncellenen)
        {
            throw new NotImplementedException();
        }

        public Yorum IdGore(int id)
        {
            throw new NotImplementedException();
        }

        public List<Yorum> Listele()
        {
            throw new NotImplementedException();
        }

        public void sil(Yorum silinen)
        {
            throw new NotImplementedException();
        }
    }
}
