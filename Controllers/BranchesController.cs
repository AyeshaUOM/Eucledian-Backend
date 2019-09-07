using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Etudiant.Attributes;
using Etudiant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Etudiant.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BranchesController : Controller
    {
        private EtudiantContext _context;

        public BranchesController(EtudiantContext context)
        {
            _context = context;
        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            var branches = _context.Branches;
            return Ok(branches);
        }

        [ValidateModel]
        [HttpPost("create")]
        public IActionResult Create(Branch branch)
        {
            _context.Update(branch);
            _context.SaveChanges();
            return Ok(branch.Id);
        }

        [HttpGet("get/{id}")]
        public Branch Get(int Id)
        {
            var Branch = _context.Branches.Where(t => t.Id == Id).FirstOrDefault();
            return Branch;
        }
    }
}