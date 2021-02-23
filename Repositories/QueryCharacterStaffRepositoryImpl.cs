using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Buscanime.Models;
using System.Collections.Generic;

namespace Buscanime.Repositories
{
    public class QueryCharacterStaffRepositoryImpl : IQueryCharacterStaffRepository<QueryCharacterStaff>
    {
        //private static HttpClient client = new HttpClient();
        private static Api api = new Api();
        private readonly IHttpClientFactory _clienFactory;
        public QueryCharacterStaffRepositoryImpl(IHttpClientFactory clienFactory)
        {
            _clienFactory = clienFactory;
        }

        public async Task<QueryCharacterStaff> GetQueryCharacterStaffById(int id)
        {
            QueryCharacterStaff q = null;
            using (var client = _clienFactory.CreateClient())
            {
                var response = await client.GetAsync($"{api.GetApiPath()}/anime/{id}/characters_staff");
                var result = await response.Content.ReadAsStringAsync();
                q = JsonConvert.DeserializeObject<QueryCharacterStaff>(result);
            }
            return q;
        }
    }
}