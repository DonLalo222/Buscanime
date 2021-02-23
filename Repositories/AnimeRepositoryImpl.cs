using System.Net.Http;
using System.Threading.Tasks;
using Buscanime.Models;
using Newtonsoft.Json;

namespace Buscanime.Repositories
{
    public class AnimeRepositoryImpl : IAnimeRepository<AnimeDetail>
    {
        //private static HttpClient client = new HttpClient();
        private static Api api = new Api();
        private readonly IHttpClientFactory _clienFactory;
        public AnimeRepositoryImpl(IHttpClientFactory clienFactory)
        {
            _clienFactory = clienFactory;
        }
        public async Task<AnimeDetail> GetAnimeById(int id)
        {
            var client = _clienFactory.CreateClient();
            var response = await client.GetAsync($"{api.GetApiPath()}/anime/{id}");
            var result = await response.Content.ReadAsStringAsync();
            AnimeDetail q = JsonConvert.DeserializeObject<AnimeDetail>(result);
            return q;
        }
    }
}