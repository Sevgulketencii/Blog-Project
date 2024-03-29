﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class YazarlarManager : IYazarlarService
    {
        IYazarlarDal _yazar;
        public YazarlarManager(IYazarlarDal veri)
        {
            _yazar = veri;

        }
        public void ekle(Yazarlar eklenen)
        {
            _yazar.ekle(eklenen);
        }

        public void güncelle(Yazarlar güncellenen)
        {
            _yazar.güncelle(güncellenen);
        }

        public Yazarlar IdGore(int id)
        {
            return _yazar.IdyeGore(id);
        }

        public List<Yazarlar> Listele()
        {
            throw new NotImplementedException();
        }

        public void sil(Yazarlar silinen)
        {
            throw new NotImplementedException();
        }

        public Yazarlar Yazar(string mail)
        {
            return _yazar.Yazar(mail);
        }

        
    }
}
