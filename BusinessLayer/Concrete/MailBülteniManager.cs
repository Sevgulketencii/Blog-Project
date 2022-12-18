using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MailBülteniManager : IMailBülteniService
    {
        IMailBülteniDal _mail;

        public MailBülteniManager(IMailBülteniDal veri)
        {
            _mail = veri;
        }
        public void ekle(MailBülteni eklenen)
        {
            _mail.ekle(eklenen);
        }

        public void güncelle(MailBülteni güncellenen)
        {
            throw new NotImplementedException();
        }

        public MailBülteni IdGore(int id)
        {
            throw new NotImplementedException();
        }

        public List<MailBülteni> Listele()
        {
            throw new NotImplementedException();
        }

        public void sil(MailBülteni silinen)
        {
            throw new NotImplementedException();
        }
    }
}
