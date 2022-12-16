using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<Table> where Table:class
    {
        List<Table> Listele();
        void ekle(Table eklenen);
        void sil(Table silinen);
        void güncelle(Table güncellenen);
        Table IdGore(int id);
    }
}
