using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Buscanime.Models;

namespace Buscanime.Repositories
{
    interface ICharacterDetailRepository<CharacterDetail>
    {
        Task<CharacterDetail> GetCharacterDetailById(int id);
        Task<List<Picture>> GetAllPicturesCharactersById(int id);
    }
}