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
    public class AdminManager : IAdminService
    {
        IAdminDal _admin;
        public AdminManager(IAdminDal veri)
        {
            _admin=veri;
        }
        public void ekle(Admin eklenen)
        {
            throw new NotImplementedException();
        }

        public void güncelle(Admin güncellenen)
        {
            throw new NotImplementedException();
        }

        public Admin IdGore(int id)
        {
            return _admin.IdyeGore(id);
        }

        public List<Admin> Listele()
        {
            return _admin.Listele();
        }

        public void sil(Admin silinen)
        {
            throw new NotImplementedException();
        }
    }
}
