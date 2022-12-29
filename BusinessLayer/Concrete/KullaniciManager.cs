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
    public class KullaniciManager : IKullaniciService
    {
        IKullaniciDal _kullanici;
        public KullaniciManager(IKullaniciDal veri)
        {
            _kullanici = veri;
        }
        public void ekle(AppUser eklenen)
        {
            throw new NotImplementedException();
        }

        public void güncelle(AppUser güncellenen)
        {
            throw new NotImplementedException();
        }

        public AppUser IdGore(int id)
        {
            return _kullanici.IdyeGore(id);
        }

        public List<AppUser> Listele()
        {
            throw new NotImplementedException();
        }

        public void sil(AppUser silinen)
        {
            throw new NotImplementedException();
        }
    }
}
