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
    public class EfYorumDal : GenericRepository<Yorum>, IYorumDal
    {
        Context baglan = new Context();
       

        public List<Yorum> BlogYorum(Expression<Func<Yorum, bool>> Filter)
        {
            return baglan.YorumDb.Where(Filter).ToList();
        }
    }
}
