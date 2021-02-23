using System;
using System.Threading.Tasks;
using Buscanime.Models;

namespace Buscanime.Repositories
{
    interface IQueryPictureRepository<QueryRepository>
    {
        Task<QueryPicture> GetQueryPictureById(int id);
    }
}