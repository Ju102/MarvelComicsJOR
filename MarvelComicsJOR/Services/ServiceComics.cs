using MarvelComicsJOR.Models;
using Newtonsoft.Json;
using System.Net;

namespace MarvelComicsJOR.Services
{
    public class ServiceComics
    {
        public async Task<ComicsList> GetListaComicsAsync(string query)
        {
            WebClient client = new WebClient();

            client.Headers["content-type"] = "application/json";
            string url = $"https://marvel.emreparker.com/v1/search/issues?q={query}&limit=5";
            string data = await client.DownloadStringTaskAsync(url);

            ComicsList lista = JsonConvert.DeserializeObject<ComicsList>(data);
            return lista;
        }
    }
}
