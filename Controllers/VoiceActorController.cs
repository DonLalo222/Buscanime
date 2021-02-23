using System;
using System.Net.Http;
using System.Threading.Tasks;
using Buscanime.Models;
using Buscanime.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Buscanime.Controllers
{
    public class VoiceActorController : Controller
    {
        private readonly IVoiceActorRepository<VoiceActorDetail> voiceActorRepository;
        private readonly IHttpClientFactory _clientFactory;

        public VoiceActorController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
            voiceActorRepository = new VoiceActorRepositoryImpl(_clientFactory);
        }

        [HttpGet("voice-actor/details/{id}")]
        public async Task<IActionResult> Details(string id)
        {
            Int32 number = 0;
            VoiceActorDetail voiceActorDetail = null;
            if (string.IsNullOrEmpty(id))
            {
                return RedirectToAction("Index", "Home");
            }

            bool success = Int32.TryParse(id, out number);
            //
            if (success)
            {
                voiceActorDetail = await voiceActorRepository.GetVoiceActorDetailById(number);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            //
            return View(voiceActorDetail);
        }
    }
}