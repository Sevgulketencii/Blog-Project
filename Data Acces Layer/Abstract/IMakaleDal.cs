using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IMakaleDal: IGenericDal<Makale>
    {
        List<Makale> MakaleListele();
        List<Makale> YazarMakale(Expression<Func<Makale, bool>> Filtre);
        List<Makale> SonMakaleler();
        int MakaleCount();
        int YazarSayi(Expression<Func<Makale,bool>>FiltreSayi);
    }
}
