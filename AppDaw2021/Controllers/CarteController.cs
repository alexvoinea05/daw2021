using AppDaw2021.Entities;
using AppDaw2021.IServices;
using AppDaw2021.Helpers;
using AppDaw2021.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDaw2021.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class CarteController : ControllerBase
        {
            private readonly ICarteService _carteService;

            private readonly proiectDawContext _context;

            public CarteController(ICarteService carteService, proiectDawContext context)
            {
                this._carteService = carteService;
                this._context = context;
            }

            [HttpGet("categorie/{id}")]
            public IActionResult GetAllByIdCategorie(string id)
            {
                var response = _carteService.GetByCategorie(id);
                return Ok(response);
            }

            [HttpGet("unitara/{id}")]
            public IActionResult GetCarteById(string id)
            {
                var response = _carteService.GetByCarteId(id);
                return Ok(response);
            }
            
            [HttpGet]
            public IActionResult GetAllCarti()
            {
            var response = _carteService.GetAll();
            return Ok(response);
            }

            [HttpGet("unit/{nume}")]
            public IActionResult GetCarteByNume(string nume)
            {
            var response = _carteService.GetByNume(nume);
            return Ok(response);
            }

        }
    }