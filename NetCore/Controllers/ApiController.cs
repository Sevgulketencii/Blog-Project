using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Controllers
{
    public class ApiController : Controller
    {
        public async Task<IActionResult> Listele()
        {
            HttpClient client = new HttpClient();
            var responce = await client.GetAsync("https://localhost:44313/api/Yazar");
            var Json = await responce.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Class1>>(Json);
            return View(values);
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            return View();  
        }

        [HttpPost]
        public async Task<IActionResult> Ekle(Class1 yeni)
        {

            HttpClient client = new HttpClient();
            var json = JsonConvert.SerializeObject(yeni);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var responce = await client.PostAsync("https://localhost:44313/api/Yazar", content);
            if (responce.IsSuccessStatusCode)
            {
                return RedirectToAction("Listele");
            }
            return View();

        }

        [HttpGet]
        public async Task<IActionResult> Güncelle(int id)
        {

            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://localhost:44313/api/Yazar/" + id);
            if (response.IsSuccessStatusCode)
            {
                var Json = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<Class1>(Json);
                return View(values);
            }
            return RedirectToAction("Listele");
        }


        [HttpPost]
        public async Task<IActionResult> Güncelle(Class1 güncellenen)
        {
            HttpClient client = new HttpClient();
            var json = JsonConvert.SerializeObject(güncellenen);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var responce = await client.PutAsync("https://localhost:44313/api/Yazar", content);
            if (responce.IsSuccessStatusCode)
            {
                return RedirectToAction("Listele");
            }
            return View();


        }

        [HttpGet]
        public async Task<IActionResult> Sil(int id)
        {
            HttpClient client = new HttpClient();
            var responce = await client.DeleteAsync("https://localhost:44313/api/Yazar/" + id);
            if (responce.IsSuccessStatusCode)
            {
                return RedirectToAction("Listele");
            }
            return View();



            //HttpClient client = new HttpClient();
            //var responce = await client.DeleteAsync("https://localhost:44313/api/Yazar/" + id);
            //if (responce.IsSuccessStatusCode)
            //{
            //    return RedirectToAction("Listele");
            //}
            //return View();
        }
    }


    public class Class1
    {
        public int yazarId { get; set; }
        public string yazarAdi { get; set; }
    }
}
