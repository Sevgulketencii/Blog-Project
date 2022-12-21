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
    public class EfYazarlarDal : GenericRepository<Yazarlar>, IYazarlarDal
    {
        Context baglan = new Context();

        public Yazarlar Yazar(string mail)
        {
            return baglan.YazarlarDb.FirstOrDefault(x=>x.YazarMail==mail);
        }

        public List<Yazarlar> YazarBlog(Expression<Func<Yazarlar, bool>> Filtre)
        {
            return baglan.YazarlarDb.Include(x => x.Makales).Where(Filtre).ToList();
        }


       
    }
}
