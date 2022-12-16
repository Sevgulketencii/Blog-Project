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
        public List<Makale> MakaleListele()
        {
            return baglan.MakaleDb.Include(x => x.Kategori).ToList();
        }

        public List<Makale> YazarMakale(Expression<Func<Makale, bool>> Filtre)
        {
            return baglan.MakaleDb.Where(Filtre).ToList();
        }
    }
}
