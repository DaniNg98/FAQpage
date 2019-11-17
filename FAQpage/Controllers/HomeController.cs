﻿using System;
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
        public IActionResult LagSpormal(SendtInnSpm sporsmal)
        {
            if (ModelState.IsValid)
            {
                SendtInnSpm nySporsmal = new SendtInnSpm
                {
                    Navn = sporsmal.Navn,
                    Email = sporsmal.Email,
                    Tema = sporsmal.Tema,
                    Sporsmal = sporsmal.Sporsmal
                };

                _sporsmalOgSvarRepository.LeggTilSporsmal(nySporsmal);
                return RedirectToAction("InnsendtSpm", new { id = nySporsmal.SId });
            }
            return View();
        }

        public ViewResult InnsendtSpm()
        {
            return View();
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
