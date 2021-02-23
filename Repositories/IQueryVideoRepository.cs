using System;
using System.Threading.Tasks;

namespace Buscanime.Repositories
{
    interface IQueryVideoRepository<QueryVideo>
    {
        Task<QueryVideo> GetQueryVideoById(int id);
    }
}