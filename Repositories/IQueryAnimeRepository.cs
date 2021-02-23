using System;
using System.Threading.Tasks;

namespace Buscanime.Repositories
{
    interface IQueryAnimeRepository<QueryAnime>
    {
        Task<QueryAnime> GetQueryAnime(string query);
    }
}