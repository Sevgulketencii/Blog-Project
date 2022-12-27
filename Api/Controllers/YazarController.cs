using Api.DataAccesLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YazarController : ControllerBase
    {
        Context baglan = new Context();
        [HttpGet]
        public IActionResult YazarList()
        {
            var list = baglan.yazarDb.ToList();
            return Ok(list);
        }

    
        [HttpPost]
        public IActionResult Ekle(Yazar eklenen)
        {  
            baglan.yazarDb.Add(eklenen);
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


        [HttpDelete("{id}")]
        public IActionResult Sil(int id)
        {   
            var sil = baglan.yazarDb.Find(id);
            if (sil != null)
            {
                baglan.Remove(sil);
                baglan.SaveChanges();
                return Ok();
            }
            
            return NotFound();
        }

        [HttpPut]
        public IActionResult Güncelle(Yazar güncellenen)
        {
            var güncelle = baglan.yazarDb.Find(güncellenen.YazarId);
            güncelle.YazarAdi = güncellenen.YazarAdi;
            baglan.SaveChanges();
            return Ok();
        }

       
    }
}
