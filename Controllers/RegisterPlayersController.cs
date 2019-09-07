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
    public class RegisterPlayersController : ControllerBase
    {
        public EtudiantContext Context { get; }
        public RegisterPlayersController(EtudiantContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var player = Context.tournamentPlayers;
            return new ObjectResult(player);
        }

        [HttpPost("create")]
        [ValidateModel]
        public ActionResult<int> Create(int studentId, int tournamentId)
        {
            TournamentPlayers p = new TournamentPlayers();
            p.PlayerId = studentId;
            p.TournamentId = tournamentId;
            p.Id = 0;
            Context.tournamentPlayers.Update(p);
            Context.SaveChanges();
            return p.Id;
        }

    }
}