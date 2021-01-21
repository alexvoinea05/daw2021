using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppDaw2021.Entities;
using AppDaw2021.IServices;
using AppDaw2021.Helpers;
using AppDaw2021.Models;
using Microsoft.AspNetCore.Http;


namespace AppDaw2021.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;

        private readonly proiectDawContext _context;

        private readonly ITokenService _tokenService;
       public AccountController(proiectDawContext context, IUserService userService, ITokenService tokenService)
        {
            _context = context;
            _userService = userService;
            _tokenService = tokenService;
        }

        [HttpPost("register/user")]
        public ActionResult<AuthenticationResponse> Register(RegisterRq registerRq)
        {
            if(UserExists(registerRq.username))
            {
                return BadRequest("Username is taken");
            }
            if(idExists(registerRq.idUser))
            {
                return BadRequest("IdUser is taken");
            }
            var userReg = new User
            {
                Email = registerRq.email,
                Username = registerRq.username.ToLower(),
                Parola = registerRq.password,
                Nume = registerRq.nume,
                Prenume = registerRq.prenume,
                IdUser = registerRq.idUser
                
            };

            _context.Users.Add(userReg);
            _context.SaveChanges();
            return new AuthenticationResponse
            {
                Username = userReg.Username,
                Id = userReg.IdUser,
                Token = _tokenService.CreateToken(userReg)
            };
            
        }

        [HttpPost("login/user")]
        public ActionResult<AuthenticationResponse> Login(AuthenticationRequest authenticationRequest)
        {
            var userReg = _context.Users.SingleOrDefault(x => x.Username == authenticationRequest.Username && x.Parola ==authenticationRequest.Password);

            if (userReg == null) return Unauthorized("Invalid credentials");

            return new AuthenticationResponse
            {
                Username = userReg.Username,
                Id = userReg.IdUser,
                Token = _tokenService.CreateToken(userReg)
            };

        }


        private bool UserExists(string username)
        {
            return _context.Users.Any(x => x.Username == username.ToLower());
        }

        private bool idExists(string idUser)
        {
            return _context.Users.Any(x => x.IdUser == idUser);
        }
    }
}
