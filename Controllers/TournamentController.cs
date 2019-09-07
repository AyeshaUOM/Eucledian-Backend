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
    public class TournamentController : ControllerBase
    {
        public EtudiantContext Context { get; }
        public TournamentController(EtudiantContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var tournament = Context.tournament;
            return new ObjectResult(tournament);
        }

        [HttpPost("create")]
        [ValidateModel]
        public ActionResult<int> Create([FromBody]Tournament tournament)
        {
            Context.tournament.Update(tournament);
            Context.SaveChanges();
            return tournament.Id;
        }

        [HttpGet("{id}")]
        public ActionResult<Tournament> Get(int id)
        {
            var tournament = Context.tournament.Find(id);
            return tournament;
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Tournament tournament = (from t in Context.tournament
                                     where t.Id == id
                                     select t).Single();
            Context.tournament.Remove(tournament);
            Context.SaveChanges();
            return NoContent();
        }
    }
}