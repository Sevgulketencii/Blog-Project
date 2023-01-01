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
    public class EfMesajDal : GenericRepository<Mesaj>, IMesajDal
    {
        Context baglan = new Context();

        public List<Mesaj> GidenMesaj(Expression<Func<Mesaj, bool>> Filtre2)
        {
            return baglan.MesajDb.Include(x => x.Alici).Where(Filtre2).ToList();
        }

        public List<Mesaj> YazarMesaj(Expression<Func<Mesaj, bool>> Filtre)
        {
            return baglan.MesajDb.Include(x=>x.Gönderen).Where(Filtre).ToList();
        }

       
    }
}
