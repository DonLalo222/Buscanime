using System;
using System.Net.Http;
using System.Threading.Tasks;
using Buscanime.Models;
using Newtonsoft.Json;

namespace Buscanime.Repositories
{
    public class VoiceActorRepositoryImpl : IVoiceActorRepository<VoiceActorDetail>
    {
        //private static Api api = new Api();
        private readonly IHttpClientFactory _clientFactory;
        public VoiceActorRepositoryImpl(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<VoiceActorDetail> GetVoiceActorDetailById(int id)
        {
            VoiceActorDetail va = null;
            using (var client = _clientFactory.CreateClient("jikan"))
            {
                var response = await client.GetAsync($"person/{id}");
                var result = await response.Content.ReadAsStringAsync();
                va = JsonConvert.DeserializeObject<VoiceActorDetail>(result);
            }
            //
            return va;
        }

    }
}