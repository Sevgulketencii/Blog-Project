using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IYorumDal: IGenericDal<Yorum>
    {
        List<Yorum> IdGetYorum(Expression<Func<Yorum, bool>> Filtre);
    }
}
