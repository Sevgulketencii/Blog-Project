using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMakaleDal : GenericRepository<Makale>, IMakaleDal
    {
        Context baglan = new Context();

        public List<Makale> MakaleAdmin()
        {
            return baglan.MakaleDb.Include(y=>y.Kategori).Where(x=>x.AdminOnay == true).ToList();// Burada AppUser include edilip yazar adına erişilmesi gerekiyor
        }

        public int MakaleCount()
        {
            return baglan.MakaleDb.ToList().Count();
        }

        public List<Makale> MakaleListele()
        {
            return baglan.MakaleDb.Include(x => x.Kategori).Where(y=>y.MakaleStatu==true && y.AdminOnay==true).ToList();
        }

        public List<Makale> OnayAdmin(Expression<Func<Makale, bool>> Onay)
        {
            return baglan.MakaleDb.Where(Onay).ToList();
        }

        public List<Makale> SonMakaleler()
        {
            return baglan.MakaleDb.Include(x => x.Kategori).OrderByDescending(x => x.MakaleId).Take(4).ToList();
        }

      

        public List<Makale> YazarMakale(Expression<Func<Makale, bool>> Filtre)
        {
            return baglan.MakaleDb.Where(Filtre).ToList();
        }

        public int YazarSayi(Expression<Func<Makale, bool>> FiltreSayi)
        {
            return baglan.MakaleDb.Where(FiltreSayi).Count();
        }
    }
}
