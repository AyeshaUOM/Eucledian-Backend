using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Etudiant.Models;
using Etudiant.Attributes;

namespace Etudiant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PuzzleController : ControllerBase
    {
        public EtudiantContext Context { get; }
        public PuzzleController(EtudiantContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var puzzle = Context.puzzles;
            return new ObjectResult(puzzle);
        }

        [HttpPost("create")]
        [ValidateModel]
        public ActionResult<int> Create([FromBody]Puzzle puzzle)
        {
            Context.puzzles.Update(puzzle);
            Context.SaveChanges();
            return puzzle.Id;
        }

        [HttpGet("{id}")]
        public ActionResult<Puzzle> Get(int id)
        {
            var puzzle = Context.puzzles.Find(id);
            return puzzle;
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Puzzle puzzle = (from t in Context.puzzles
                                     where t.Id == id
                                     select t).Single();
            Context.puzzles.Remove(puzzle);
            Context.SaveChanges();
            return NoContent();
        }
    }
}