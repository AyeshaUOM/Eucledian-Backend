using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Etudiant.Attributes;
using Etudiant.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Etudiant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : Controller
    {
        private EtudiantContext _context;

        public ClassController(EtudiantContext context)
        {
            _context = context;
        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            var Class = _context.Classes;
            return Ok(Class);
        }

        [ValidateModel]
        [HttpPost("create")]
        public IActionResult Create(Class @class)
        {
            _context.Update(@class);
            _context.SaveChanges();
            return Ok(@class.Id);
        }

        [HttpGet("get/{id}")]
        public Class Get(int Id)
        {
            var Class = _context.Classes.Where(t => t.Id == Id).FirstOrDefault();
            return Class;
        }
    }
}