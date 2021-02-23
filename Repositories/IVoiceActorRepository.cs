using System;
using System.Threading.Tasks;

namespace Buscanime.Repositories
{
    interface IVoiceActorRepository<VoiceActorDetail>
    {
        Task<VoiceActorDetail> GetVoiceActorDetailById(int id);
    }
}
