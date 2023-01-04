using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IMesajDal:IGenericDal<Mesaj>
    {
        List<Mesaj> YazarMesaj(Expression<Func<Mesaj,bool>>Filtre);
        List<Mesaj> GidenMesaj(Expression<Func<Mesaj, bool>> Filtre2);
        Mesaj MesajDetay(int id);
    }
}
