using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Etudiant.Attributes;
using Etudiant.Dto;
using Etudiant.Models;
using Microsoft.AspNetCore.Mvc;

namespace Etudiant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private EtudiantContext _context;

        public UsersController(EtudiantContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto loginDto)
        {
            // TODO: Encrypt password
            var user = _context.Users
                .Where(t =>
                    t.Email == loginDto.Username &&
                    t.Password == loginDto.Password &&
                    t.BranchId == loginDto.BranchId
                 )
                 .FirstOrDefault();

            // TODO: Generate JWT
            string Jwt = null;
            if (user != null)
            {
                Jwt = "JWT";
            }

            return new ObjectResult(new UserDto()
            {
                JWT = Jwt,
                UserID = user?.Id,
                BranchId = user?.BranchId,
                UserRole = user?.Role.ToString(),
            });

        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            var users = _context.Users;
            return new ObjectResult(users);
        }

        [HttpGet("get/{id}")]
        public IActionResult Get(int id)
        {
            // TODO: Admin Previlage Check
            var user = _context.Users.Find(id);
            return new ObjectResult(user);
        }


        [HttpPost("create")]
        [ValidateModel]
        public IActionResult Create(User user)
        {
            // TODO: Encrypt password
            _context.Update(user);
            _context.SaveChanges();

            return new ObjectResult(user.Id);
        }
    }
}