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
    public class HakkimizdaManager : IHakkimizdaService
    {
        IHakkimizdaDal _hakkimizda;
        public HakkimizdaManager(IHakkimizdaDal veri)
        {
            _hakkimizda = veri;
        }
        public void ekle(Hakkimizda eklenen)
        {
            _hakkimizda.ekle(eklenen);
        }

        public void güncelle(Hakkimizda güncellenen)
        {
            _hakkimizda.güncelle(güncellenen);
        }

        public Hakkimizda IdGore(int id)
        {
           return _hakkimizda.IdyeGore(id);
        }

        public List<Hakkimizda> Listele()
        {
            return _hakkimizda.Listele();
        }

        public void sil(Hakkimizda silinen)
        {
            _hakkimizda.sil(silinen);
        }
    }
}
