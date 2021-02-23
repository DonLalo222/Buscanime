using System;
using System.Net.Http;
using System.Threading.Tasks;
using Buscanime.Models;
using Newtonsoft.Json;

namespace Buscanime.Repositories
{
    public class QueryPictureRepositoryImpl : IQueryPictureRepository<QueryPicture>
    {
        //private static HttpClient client = new HttpClient();
        private static Api api = new Api();
        private readonly IHttpClientFactory _clienFactory;
        public QueryPictureRepositoryImpl(IHttpClientFactory clienFactory)
        {
            _clienFactory = clienFactory;
        }
        public async Task<QueryPicture> GetQueryPictureById(int id)
        {
            using (var client = _clienFactory.CreateClient())
            {
                var response = await client.GetAsync($"{api.GetApiPath()}/anime/{id}/pictures");
                var result = await response.Content.ReadAsStringAsync();
                QueryPicture q = JsonConvert.DeserializeObject<QueryPicture>(result);
                return q;
            }
        }
    }
}