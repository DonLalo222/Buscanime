using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Buscanime.Models;
using Buscanime.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Buscanime.Controllers
{
    public class CharactersController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly ICharacterDetailRepository<CharacterDetail> characterDetailRepository;

        public CharactersController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
            characterDetailRepository = new CharacterDetailRepositoryImpl(_clientFactory);
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            int number = 0;
            CharacterDetail characterDetail = null;
            //List<Picture> picturesCharacter = null;
            //CharacterDetailVM model = null;
            //
            if (string.IsNullOrEmpty(id))
            {
                return RedirectToAction("Index", "Home");
            }

            bool success = Int32.TryParse(id, out number);
            //
            if (success)
            {
                characterDetail = await characterDetailRepository.GetCharacterDetailById(number);
                //picturesCharacter = await characterDetailRepository.GetAllPicturesCharactersById(number);
                // http://api.jikan.moe/v3/person/6730 object person with details
                // https://api.jikan.moe/v3/character/2009 get object data Character
                //model = new CharacterDetailVM();
               //model.characterDetail = characterDetail;
                //model.pictures = picturesCharacter;
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            //
            return View(characterDetail);
        }
    }
}