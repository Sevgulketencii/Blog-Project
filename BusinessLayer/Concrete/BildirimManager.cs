using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BildirimManager : IBildirimService
    {
        EfBildirimDal _bildirim;
        public BildirimManager(EfBildirimDal veri)
        {
            _bildirim = veri;
        }
        public void ekle(Bildirim eklenen)
        {
            _bildirim.ekle(eklenen);
        }

        public void güncelle(Bildirim güncellenen)
        {
            _bildirim.güncelle(güncellenen);
        }

        public Bildirim IdGore(int id)
        {
            return _bildirim.IdyeGore(id);
        }

        public List<Bildirim> Listele()
        {
            return _bildirim.Listele();
        }

        public void sil(Bildirim silinen)
        {
            _bildirim.sil(silinen);
        }
    }
}
