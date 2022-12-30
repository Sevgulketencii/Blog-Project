using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IYorumService : IGenericService<Yorum>
    {
        List<Yorum> BlogYorum(int id);
        List<Yorum> AdminYorum();
    }
}
