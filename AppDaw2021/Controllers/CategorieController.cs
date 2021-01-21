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
         public class CategorieController : ControllerBase
        {
            private readonly ICategorieService _categorieService;

            private readonly proiectDawContext _context;

            public CategorieController(ICategorieService categorieService, proiectDawContext context)
            {
                this._categorieService = categorieService;
                this._context = context;
            }

            [HttpGet]
            public IEnumerable<Categorie> GetAllCategories()
            {
                var response = _categorieService.GetAll();
                return _context.Categories.ToList();
            }

            [HttpGet("nume/{nume}")]
            public IActionResult GetByNume(string nume)
            {
                var response = _categorieService.GetByNume(nume);
                return Ok(response);
            }

            [HttpGet("id/{id}")]
            public IActionResult GetById(string id)
            {
                var response = _categorieService.GetById(id);
                return Ok(response);
            }

        }
}