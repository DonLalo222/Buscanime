using System;
using System.Threading.Tasks;
using Buscanime.Models;

namespace Buscanime.Repositories
{

    interface IAnimeRepository<Anime>
    {
        Task<Anime> GetAnimeById(int id);

        // IQueryAnimeRepository 
        // IQueryPictureRepository

    }
}