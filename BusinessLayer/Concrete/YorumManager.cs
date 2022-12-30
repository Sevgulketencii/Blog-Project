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

        public List<Yorum> AdminYorum()
        {
            return _yorum.AdminYorum();

        }

        public List<Yorum> BlogYorum(int id)
        {
           return _yorum.IdGetYorum(x => x.MakaleId == id && x.YorumStatu==true);
        }

        public void ekle(Yorum eklenen)
        {
            _yorum.ekle(eklenen);
        }

        public void güncelle(Yorum güncellenen)
        {
            _yorum.güncelle(güncellenen);
        }

        public Yorum IdGore(int id)
        {
            return _yorum.IdyeGore(id);
        }

        public List<Yorum> Listele()
        {
           return _yorum.Listele();
        }

        public void sil(Yorum silinen)
        {
            throw new NotImplementedException();
        }
    }
}
