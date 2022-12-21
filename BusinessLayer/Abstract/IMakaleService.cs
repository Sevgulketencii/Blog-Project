using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMakaleService : IGenericService<Makale>
    {
        List<Makale> MakaleListele();
        List<Makale> YazarMakale(int id);
        List<Makale> SonMakaleler();
        int MakaleCount();
        int YazarMakCount(int id);
        
    }
}
