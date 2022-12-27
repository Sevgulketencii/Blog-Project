using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminYazarController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> YazarList()
        {
            var client = new HttpClient();
            var responce = await client.GetAsync("https://localhost:44382/api/Yazar");
            var json = await responce.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<YazarClass>>(json);

            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> Sil(int id)
        {
            var client = new HttpClient();
            var responce = await client.DeleteAsync("https://localhost:44382/api/Yazar/" + id);
            if (responce.IsSuccessStatusCode)
            {
                return RedirectToAction("YazarList");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Güncelle(int id)
        {
            var client = new HttpClient();
            var responce = await client.GetAsync("https://localhost:44382/api/Yazar/" + id);
            var json = await responce.Content.ReadAsStringAsync();
            var value = JsonConvert.DeserializeObject<YazarClass>(json);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> Güncelle(YazarClass p)
        {
            var client = new HttpClient();
            var Json = JsonConvert.SerializeObject(p);
            var content = new StringContent(Json, Encoding.UTF8, "application/json");
            var responce = await client.PutAsync("https://localhost:44382/api/Yazar", content);
            if (responce.IsSuccessStatusCode)
            {
                return RedirectToAction("YazarList");

            }
            return View(p);
        }

        [HttpGet]
        public async Task<IActionResult> Ekle()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Ekle(YazarClass p)
        {
            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(p);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var responce = await client.PostAsync("https://localhost:44382/api/Yazar", content);
            if (responce.IsSuccessStatusCode)
            {
                return RedirectToAction("YazarList");
            }
            return View();
        }



    }



    public class YazarClass
    {

        public int YazarId { get; set; }
        public string YazarAdi { get; set; }

    }

}
