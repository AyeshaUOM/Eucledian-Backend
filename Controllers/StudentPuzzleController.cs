using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Etudiant.Models;
using Etudiant.Attributes;
using Microsoft.EntityFrameworkCore;
using Etudiant.Classes;

namespace Etudiant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentPuzzleController : ControllerBase
    {
        public EtudiantContext Context { get; }
        public StudentPuzzleController(EtudiantContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var studentPuzzle = Context.studentPuzzles.Include(p => p.Student).Include(p => p.Puzzle);
            StudentPuzzle stpzzle = new StudentPuzzle();
            return new ObjectResult(studentPuzzle);
        }

        [HttpPost("create")]
        [ValidateModel]
        public ActionResult<int> Create([FromBody]StudentPuzzles studentPuzzle)
        {
            Context.studentPuzzles.Update(studentPuzzle);
            Context.SaveChanges();
            return studentPuzzle.Id;
        }

        [HttpGet("{id}")]
        public ActionResult<StudentPuzzles> Get(int id)
        {
            var studentPuzzle = Context.studentPuzzles.Find(id);
            return studentPuzzle;
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            StudentPuzzles studentPuzzle = (from t in Context.studentPuzzles
                                     where t.Id == id
                                     select t).Single();
            Context.studentPuzzles.Remove(studentPuzzle);
            Context.SaveChanges();
            return NoContent();
        }

    }
}