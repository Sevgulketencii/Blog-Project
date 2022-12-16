using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<Table> : IGenericDal<Table> where Table : class
    {
        Context baglan = new Context();
        
        public void ekle(Table eklenen)
        {
            baglan.Set<Table>().Add(eklenen);
            baglan.SaveChanges();
        }

        public void güncelle(Table güncellenen)
        {
            baglan.Set<Table>().Update(güncellenen);
            baglan.SaveChanges();
        }

        public Table IdyeGore(int id)
        {
            return baglan.Set<Table>().Find(id);
        }

        public List<Table> Listele()
        {
            return baglan.Set<Table>().ToList();
        }

        public void sil(Table silinen)
        {
            baglan.Set<Table>().Remove(silinen);
            baglan.SaveChanges();
        }
    }
}
