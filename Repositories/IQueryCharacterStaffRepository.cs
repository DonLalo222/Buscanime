using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Buscanime.Models;

namespace Buscanime.Repositories
{
    interface IQueryCharacterStaffRepository<QueryCharacterStaff>
    {
        Task<QueryCharacterStaff> GetQueryCharacterStaffById(int id);
        
    }
}