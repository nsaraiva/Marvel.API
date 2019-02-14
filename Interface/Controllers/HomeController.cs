using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Interface.Models;
using Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System.Collections;

namespace Interface.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index([FromServices]IConfiguration config)
        {
            List<Personagem> personagens = new List<Personagem>();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                string ts = DateTime.Now.Ticks.ToString();
                string publicKey = config.GetSection("MarvelComicsAPI:PublicKey").Value;
                string hash = GerarHash(ts, publicKey,
                    config.GetSection("MarvelComicsAPI:PrivateKey").Value);

                //HttpResponseMessage response = client.GetAsync(
                //    config.GetSection("MarvelComicsAPI:BaseURL").Value +
                //    $"characters?ts={ts}&apikey={publicKey}&hash={hash}&" +
                //    $"name={Uri.EscapeUriString("Captain America")}").Result;

                HttpResponseMessage response = client.GetAsync(
                config.GetSection("MarvelComicsAPI:BaseURL").Value +
                $"characters?limit=100&ts={ts}&apikey={publicKey}&hash={hash}").Result;

                response.EnsureSuccessStatusCode();
                string conteudo = response.Content.ReadAsStringAsync().Result;

                dynamic resultado = JsonConvert.DeserializeObject(conteudo);

                foreach(var item in ((IEnumerable)resultado.data.results)
                    .Cast<dynamic>()
                    .Where(d => d.description != ""))
                {
                    personagens.Add(new Personagem
                    {
                        Id = item.id,
                        Nome = item.name,
                        Descricao = item.description,
                        Imagem = item.thumbnail.path + "." + item.thumbnail.extension,
                        Hqs = item.comics.available
                    });
                }

                //// Time 1
                //Random r1 = new Random();
                //int[] time1 = new int[10];
                //for (int i = 0; i < 10; i++)
                //{
                //    time1[i] = r1.Next(0, resultado.data.results.Count());
                //}

                //// Time 2
                //Random r2 = new Random();
                //int[] time2 = new int[10];
                //for (int i = 0; i < 10; i++)
                //{
                //    time2[i] = r2.Next(0, resultado.data.results.Count());
                //}
            }

                return View("Index", personagens);
        }

        private string GerarHash(string ts, string publicKey, string privateKey)
        {
            byte[] bytes =
                System.Text.Encoding.UTF8.GetBytes(ts + privateKey + publicKey);
            var gerador = MD5.Create();
            byte[] bytesHash = gerador.ComputeHash(bytes);
            return BitConverter.ToString(bytesHash)
                .ToLower().Replace("-", String.Empty);
        }



        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
