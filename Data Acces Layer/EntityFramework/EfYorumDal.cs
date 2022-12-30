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
    public class EfYorumDal : GenericRepository<Yorum>, IYorumDal
    {
        Context baglan = new Context();

        public List<Yorum> AdminYorum()
        {
            return baglan.YorumDb.Include(x => x.Makale).ToList();
        }

        public List<Yorum> IdGetYorum(Expression<Func<Yorum, bool>> Filtre)
        {
            return baglan.YorumDb.Where(Filtre).ToList();
        }
    }
}
