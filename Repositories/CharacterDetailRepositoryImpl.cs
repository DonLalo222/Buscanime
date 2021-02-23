using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Buscanime.Models;
using Newtonsoft.Json;

namespace Buscanime.Repositories
{
    public class CharacterDetailRepositoryImpl : ICharacterDetailRepository<CharacterDetail>
    {
        //private static HttpClient client = new HttpClient();
        private static Api api = new Api();
        private readonly IHttpClientFactory _clientFactory;

        public CharacterDetailRepositoryImpl(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<List<Picture>> GetAllPicturesCharactersById(int id)
        {
            List<Picture> list = null;

            using (var client = _clientFactory.CreateClient())
            {
                var response = await client.GetAsync($"{api.GetApiPath()}/character/{id}/pictures");
                var result = await response.Content.ReadAsStringAsync();
                QueryPicture q = JsonConvert.DeserializeObject<QueryPicture>(result);
                list = (List<Picture>)q.pictures;
                //
            }
            //
            return list;
        }

        public async Task<CharacterDetail> GetCharacterDetailById(int id)
        {
            CharacterDetail characterDetail = null;
            //
            using (var client = _clientFactory.CreateClient())
            {
                var response = await client.GetAsync($"{api.GetApiPath()}/character/{id}");
                var result = await response.Content.ReadAsStringAsync();
                characterDetail = JsonConvert.DeserializeObject<CharacterDetail>(result);
            }
            //
            return characterDetail;
        }

    }
}