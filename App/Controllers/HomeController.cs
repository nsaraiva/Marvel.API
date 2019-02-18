using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Interface.Models;
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

            const int limit = 100;

            string publicKey = config.GetSection("MarvelComicsAPI:PublicKey").Value;

            while (personagens.Count() <= 20)
            {
                int offset = new Random().Next(0, 1400);
                string ts = DateTime.Now.Ticks.ToString();
                string hash = GerarHash(ts, publicKey,
                    config.GetSection("MarvelComicsAPI:PrivateKey").Value);
                string apiUrl = config.GetSection("MarvelComicsAPI:BaseURL").Value +
                    $"characters?limit={limit}&offset={offset}&ts={ts}&apikey={publicKey}&hash={hash}";

                var resultado = MarvelApiResult(apiUrl);

                foreach (var item in ((IEnumerable)resultado.data.results)
                    .Cast<dynamic>()
                    .Where(r => r.description != "")
                    .Where(r => r.thumbnail.path != "http://i.annihil.us/u/prod/marvel/i/mg/b/40/image_not_available"))
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
            }

            // Time 1
            Random r1 = new Random();
            int[] time1 = new int[10];
            int i = 0;

            while (i < 10)
            {
                int posicao = r1.Next(0, personagens.Count());
                if (personagens[posicao].Time == 0)
                {
                    personagens[posicao].Time = 1;
                    i++;
                }
            }

            // Time 2
            Random r2 = new Random();
            int[] time2 = new int[10];
            int j = 0;

            while (j < 10)
            {
                int posicao = r1.Next(0, personagens.Count());
                if (personagens[posicao].Time == 0)
                {
                    personagens[posicao].Time = 2;
                    j++;
                }
            }

            return View("Index", personagens.Where(p => p.Time != 0));
        }

        private dynamic MarvelApiResult(string apiUrl)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(apiUrl).Result;

                response.EnsureSuccessStatusCode();
                string conteudo = response.Content.ReadAsStringAsync().Result;
                dynamic resultado = JsonConvert.DeserializeObject(conteudo);

                return resultado;
            }
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
    }
}
