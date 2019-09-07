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
    public class StudentClassController : Controller
    {

        private EtudiantContext _context;

        public StudentClassController(EtudiantContext context)
        {
            _context = context;
        }

        [ValidateModel]
        [HttpPost("create")]
        public IActionResult Create(StudentClass studentClass)
        {

            _context.Update(studentClass);
            _context.SaveChanges();
            return Ok(studentClass.Id);
        }

    }
}