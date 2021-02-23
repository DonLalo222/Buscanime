using System;
using System.Net.Http;
using System.Threading.Tasks;
using Buscanime.Models;
using Newtonsoft.Json;

namespace Buscanime.Repositories
{
    public class QueryVideoRepositoryImpl : IQueryVideoRepository<QueryVideo>
    {
        //private static HttpClient client = new HttpClient();
        private static Api api = new Api();
        private readonly IHttpClientFactory _clienFactory;
        public QueryVideoRepositoryImpl(IHttpClientFactory clienFactory)
        {
            _clienFactory = clienFactory;
        }
        public async Task<QueryVideo> GetQueryVideoById(int id)
        {
            QueryVideo q = null;
            using (var client = _clienFactory.CreateClient())
            {
                var response = await client.GetAsync($"{api.GetApiPath()}/anime/{id}/videos");
                var result = await response.Content.ReadAsStringAsync();
                q = JsonConvert.DeserializeObject<QueryVideo>(result);
            }
            return q;
        }
    }
}