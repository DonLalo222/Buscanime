using System;
using System.Net.Http;
using System.Threading.Tasks;
using Buscanime.Models;
using Buscanime.Repositories;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Buscanime.Controllers
{
    public class AnimesController : Controller
    {
        private readonly IAnimeRepository<AnimeDetail> animeRepo;
        private readonly IQueryAnimeRepository<QueryAnime> qAnimeRepo;
        private readonly IQueryPictureRepository<QueryPicture> qPictureRepo;
        private readonly IQueryVideoRepository<QueryVideo> qVideoRepo;
        private readonly IQueryCharacterStaffRepository<QueryCharacterStaff> qCharacterStaffRepo;

        private readonly IHttpClientFactory _clientFactory;

        public AnimesController(IHttpClientFactory clienFactory)
        {
            _clientFactory = clienFactory;
            animeRepo = new AnimeRepositoryImpl(_clientFactory);
            qAnimeRepo = new QueryAnimeRepositoryImpl(_clientFactory);
            qPictureRepo = new QueryPictureRepositoryImpl(_clientFactory);
            qVideoRepo = new QueryVideoRepositoryImpl(_clientFactory);
            qCharacterStaffRepo = new QueryCharacterStaffRepositoryImpl(_clientFactory);
        }

        [HttpGet]
        public async Task<IActionResult> Search([FromQuery] string query)
        {
            QueryAnime result = new QueryAnime();
            try
            {
                if (string.IsNullOrEmpty(query))
                {
                    return RedirectToAction("Index", "Home");
                }
                //
                result = await qAnimeRepo.GetQueryAnime(query.Trim());
                //
                return View(result);
                
            }
            catch (Exception)
            {
                return View("Shared/Error.cshtml");
            }

        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return RedirectToAction("Index", "Home");
            }
            //
            AnimeDetail result = await animeRepo.GetAnimeById(int.Parse(id));
            QueryPicture qp = await qPictureRepo.GetQueryPictureById(int.Parse(id));
            ViewBag.pictures = qp;
            return View(result);
        }

        [HttpGet("animes/details/{id}/promo")]
        public async Task<IActionResult> Promo(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return RedirectToAction("Index", "Home");
            }
            //
            QueryVideo qv = await qVideoRepo.GetQueryVideoById(int.Parse(id));
            ViewBag.Id = int.Parse(id);
            return View(qv);
        }

        [HttpGet("animes/details/{id}/characters")]
        public async Task<IActionResult> Characters(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return RedirectToAction("Index", "Home");
            }
            //
            QueryCharacterStaff qc = await qCharacterStaffRepo.GetQueryCharacterStaffById(int.Parse(id));
            ViewBag.Id = int.Parse(id);
            return View(qc);
        }




    }
}