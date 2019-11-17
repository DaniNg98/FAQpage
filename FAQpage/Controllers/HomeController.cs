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

namespace FAQpage.Controllers
{
    public class HomeController : Controller
    {

        private readonly ISporsmalOgSvarRepository _sporsmalOgSvarRepository;

        public HomeController(ISporsmalOgSvarRepository sporsmalOgSvarRepository)
        {
            _sporsmalOgSvarRepository = sporsmalOgSvarRepository;
        }

        // Henter alle spørsmal fra databasen
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

        // Legger inn et nytt spørsmål i databasen og den automatisk en ny ID
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

        // Henter alle innsendte spørsmal fra databasen
        public ViewResult InnsendtSpm()
        {
            var model = _sporsmalOgSvarRepository.GetAlleNySporsmal();
            return View(model);
        }

        // Oppdaterer ratingen til spørsmålene
        public IActionResult EndreRating(int id, string rating)
        {
            _sporsmalOgSvarRepository.EndreRating(id,rating);
            return RedirectToAction("AlleSporsmal");
        }
       

    }
}
