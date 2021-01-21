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
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace AppDaw2021.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        private readonly proiectDawContext _context;

        public AuthController(IUserService userService, proiectDawContext context)
        {
            this._userService = userService;
            this._context = context;
        }

        
        [HttpGet("users")]
        [AllowAnonymous]
        public IActionResult GetAll()
        {
            var response = _userService.GetAll();
            return Ok(response);
        }

        [Microsoft.AspNetCore.Authorization.Authorize]
        [HttpGet("login/{idUser}")]
        public ActionResult<User> GetUserById(string idUser)
        {
            return Ok(_userService.GetById(idUser));
        }
        
    }

}
