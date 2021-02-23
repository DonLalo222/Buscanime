using System;
using System.Net.Http;
using System.Threading.Tasks;
using Buscanime.Models;
using Newtonsoft.Json;

namespace Buscanime.Repositories
{
    public class QueryAnimeRepositoryImpl : IQueryAnimeRepository<QueryAnime>
    {
        //private static HttpClient client = new HttpClient();
        //private static Api api = new Api();
        private readonly IHttpClientFactory _clienFactory;
        public QueryAnimeRepositoryImpl(IHttpClientFactory clienFactory)
        {
            _clienFactory = clienFactory;
        }
        public async Task<QueryAnime> GetQueryAnime(string query)
        {
            using (var client = _clienFactory.CreateClient("jikan"))
            {
                var response = await client.GetAsync($"search/anime?q={query}&page=1");
                var result = await response.Content.ReadAsStringAsync();
                QueryAnime q = JsonConvert.DeserializeObject<QueryAnime>(result);
                return q;
            }
        }
    }
}