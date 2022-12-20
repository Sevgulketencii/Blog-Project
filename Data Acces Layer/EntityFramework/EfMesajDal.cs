using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
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
        public List<Mesaj> YazarMesaj(Expression<Func<Mesaj, bool>> Filtre)
        {
            return baglan.MesajDb.Where(Filtre).ToList();
        }
    }
}
