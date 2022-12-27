using BlogApi.DataAccesLayer;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class YazarController : ControllerBase
    {
        Context baglan = new Context();
       
        [HttpGet]
        public IActionResult Listele()
        {
            var list = baglan.yazarDb.ToList();
            return Ok(list);
        }


        [HttpDelete("{id}")]
        public IActionResult Sil(int id)
        {
            var silinen = baglan.yazarDb.Find(id);
            if (silinen != null)
            {
                baglan.Remove(silinen);
                baglan.SaveChanges();
                return Ok();
            }
            return NotFound();
        }

     
        [HttpPost]
        public IActionResult Ekle(Yazarlar p)
        {
            baglan.yazarDb.Add(p);
            baglan.SaveChanges();
            return Ok();
        }

     
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var yazar = baglan.yazarDb.Find(id);
            if (yazar != null)
            {
                return Ok(yazar);
            }
            return NotFound();
        }

      
        [HttpPut]
        public IActionResult Güncelle(Yazarlar p)
        {
            var yazar = baglan.yazarDb.Find(p.YazarId);
            if (yazar != null)
            {
                yazar.YazarAdi = p.YazarAdi;
                baglan.SaveChanges();
                return Ok(yazar);
            }
            return NotFound();
        }
    }
}
