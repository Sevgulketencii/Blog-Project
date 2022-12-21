using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IYazarlarDal:IGenericDal<Yazarlar>
    {
        List<Yazarlar> YazarBlog(Expression<Func<Yazarlar, bool>> Filtre);
        Yazarlar Yazar(string mail);
    }
}
