using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using FAQpage.Data;
using Microsoft.Data.SqlClient;
using FAQpage.Models;
using FAQpage.ViewModels;

namespace FAQpage.Controllers
{
    public class HomeController : Controller
    {

        private readonly ISporsmalOgSvarRepository _sporsmalOgSvarRepository;

        public HomeController(ISporsmalOgSvarRepository sporsmalOgSvarRepository)
        {
            _sporsmalOgSvarRepository = sporsmalOgSvarRepository;
        }

        public ViewResult Index()
        {
            var model = _sporsmalOgSvarRepository.GetAlleSporsmal();
            return View(model);
        }

        public ViewResult AlleSporsmal()
        {
            var model = _sporsmalOgSvarRepository.GetAlleSporsmal();
            return View(model);
        }

        [HttpGet]
        public ViewResult LagSporsmal()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult LagSporsmal(SendtInnSpm sendtInnSpm)
        {
            if (ModelState.IsValid)
            {
                SendtInnSpm nySporsmal = new SendtInnSpm
                {
                    Navn = sendtInnSpm.Navn,
                    Email = sendtInnSpm.Email,
                    Tema = sendtInnSpm.Tema,
                    Sporsmal = sendtInnSpm.Sporsmal
                };

                _sporsmalOgSvarRepository.LeggTilSporsmal(nySporsmal);
                return RedirectToAction("InnsendtSpm", new { id = nySporsmal.SId });
            }
            return View();
        }

        public ViewResult InnsendtSpm()
        {
            var model = _sporsmalOgSvarRepository.GetAlleNySporsmal();
            return View(model);
        }
        

        /*
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                SporsmalOgSvar = _sporsmalOgSvarRepository.GetSporsmalOgSvar(id??1)
            };
          
            return View(homeDetailsViewModel);
        }
        */

    }
}
